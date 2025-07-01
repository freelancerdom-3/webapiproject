using ENT.BL.Common;
using ENT.BL.User;
using ENT.Model.Common;
using ENT.Model.EntityFramework;
using ENT.Model.Otp;
using ENT.Model.Users;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;


namespace ENT.BL.Otp
{
    public class Otp : IOtp
    {
        private readonly MyDBContext _context;
        //This is for jwt token generation
        private readonly IUser _user;

        public Otp(MyDBContext context, IUser userService)
        {
            _context = context;
            _user = userService;
        }

        //Generate OTP object
        private OtpModel GenerateOtpObject(string mobileNumber)
        {
            //add logic to create random 6 digit code -- 123456
            Random random = new Random();
            OtpModel otpObject = new OtpModel();
            otpObject.OTP = random.Next(100000, 1000000);
            otpObject.MobileNumber = mobileNumber;
            
            // add expiration time = current time + 5 mins
            otpObject.ExpiryTime = DateTime.Now.AddMinutes(5);
            otpObject.IsUsed = false;
            
            return otpObject;
        }

        public async Task<APIResponseModel> GenerateOtpForAdmin(string mobileNumber)
        {
            APIResponseModel response = new APIResponseModel();
            try
            {
                
                using (var connection = _context)
                {
                    bool userExists = await connection.TblUsers.AnyAsync(x => x.MobileNumber == mobileNumber);
                    if (userExists == false)
                    {
                        //Add new user
                        UserModel newUser = new UserModel() { MobileNumber = mobileNumber, UserTypeId = 1};
                        await _user.Add(newUser);
                    }
                    OtpModel otpObject = GenerateOtpObject(mobileNumber);
                    response.Data = otpObject;
                    response.Message = "OTP Generated successfully";
                    response.statusCode = 200;

                    await connection.TblOtp.AddAsync(otpObject);
                    await connection.SaveChangesAsync();
                }
                return response;
            }
            catch (Exception ex)
            {
                response.Data = false;
                response.statusCode = 400;
                response.Message = ex.Message;
            }
            return response;
        }

        public async Task<APIResponseModel> GenerateOtpForEndUser(string mobileNumber)
        {
            APIResponseModel response = new APIResponseModel();
            try
            {
                using (var connection = _context)
                {
                    bool userExists = await connection.TblUsers.AnyAsync(x => x.MobileNumber == mobileNumber);
                    if (userExists == false)
                    {
                        //Add new user
                        UserModel newUser = new UserModel() { MobileNumber = mobileNumber, UserTypeId = 2 };
                        await _user.Add(newUser);
                    }
                    OtpModel otpObject = GenerateOtpObject(mobileNumber);
                    response.Data = otpObject;
                    response.Message = "OTP Generated successfully";
                    response.statusCode = 200;

                    await connection.TblOtp.AddAsync(otpObject);
                    await connection.SaveChangesAsync();
                }
                return response;
            }
            catch (Exception ex)
            {
                response.Data = false;
                response.statusCode = 400;
                response.Message = ex.Message;
            }
            return response;
        }

        public async Task<APIResponseModel> GenerateOtpForServiceProvider(string mobileNumber)
        {
            APIResponseModel response = new APIResponseModel();
            try
            {
                OtpModel otpObject = GenerateOtpObject(mobileNumber);
                using (var connection = _context)
                {
                    bool userExists = await connection.TblUsers.AnyAsync(x => x.MobileNumber == mobileNumber);
                    if (userExists == false)
                    {
                        //Add new user
                        UserModel newUser = new UserModel() { MobileNumber = mobileNumber, UserTypeId = 3 };
                        await _user.Add(newUser);
                    }
                    await connection.TblOtp.AddAsync(otpObject);
                    await connection.SaveChangesAsync();
                }
                response.Data = otpObject;
                response.Message = "OTP Generated successfully";
                response.statusCode = 200;
                return response;
            }
            catch (Exception ex)
            {
                response.Data = false;
                response.statusCode = 400;
                response.Message = ex.Message;
            }
            return response;
        }

        

        public async Task<APIResponseModel> Verify(int Otp, string mobileNumber) //123456, 9033342003
        {
            APIResponseModel response = new APIResponseModel();
            try
            {
                using (var connection = _context)
                {
                   

                    //mobile number does not exists
                    OtpModel otpObject = await connection.TblOtp.Where(x => x.MobileNumber == mobileNumber).OrderByDescending(x => x.ExpiryTime).FirstAsync();

                    if(otpObject.OTP == Otp)
                    {
                        if(otpObject.OTP == Otp && otpObject.ExpiryTime > DateTime.Now)
                        {
                            if(otpObject.OTP == Otp && otpObject.IsUsed == false)
                            {
                                //Update otp flag to true
                                otpObject.IsUsed = true;
                                await connection.SaveChangesAsync();
                                response.Message = "OTP verified";
                                response.statusCode=200;
                                //Generate token if OTP is verified
                                //Get exisiting user
                                UserModel? existingUser = await connection.TblUsers.FirstOrDefaultAsync(x => x.MobileNumber.Equals(mobileNumber));
                                
                                //Generate token
                                string token = GenerateJSONWebToken(existingUser);
                                response.Data = new
                                {
                                    JwtToken = token,
                                    userId = existingUser?.UserId,
                                    mobileNumber = existingUser?.MobileNumber,
                                    userTypeId = existingUser?.UserTypeId
                                };
                            }
                            else
                            {
                                response.Message = "OTP is used";
                                response.statusCode = 403;
                            }
                        }
                        else
                        {
                            response.Message = "OTP expired";
                            response.statusCode = 403;
                        }
                    }
                    else
                    {
                        response.Message = "Mobile number or OTP invalid";
                        response.statusCode = 403;
                    }
                }      
            }
            catch (Exception ex)
            {
                response.Data = false;
                response.statusCode = 400;
                response.Message = ex.Message;
            }
            return response;
        }

        public string GenerateJSONWebToken(UserModel? objUser)
        {
            try
            {
                var claims = new[]
                {
                    //new Claim(JwtRegisteredClaimNames.Sub, JwtSettings.subject),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                    new Claim("UserId", objUser.UserId.ToString()),
                    new Claim("MobileNumber", objUser.MobileNumber.ToString()),
                    new Claim("UserTypeId", objUser.UserTypeId.ToString())
                    //new Claim("ExpiryTime", DateTime.Now.AddMinutes(JwtSettings.expiryMinutes).ToString())
                };
                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JwtSettings.jwtKey));
                var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                var token = new JwtSecurityToken(
                        JwtSettings.issuer,
                        JwtSettings.audience,
                        claims,
                        //expires : DateTime.Now.AddSeconds(20),
                        expires: DateTime.Now.AddMinutes(JwtSettings.expiryMinutes),
                        signingCredentials: signIn
                    );
                string tokenValue = new JwtSecurityTokenHandler().WriteToken(token);
                return tokenValue;
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }
    }   
}
