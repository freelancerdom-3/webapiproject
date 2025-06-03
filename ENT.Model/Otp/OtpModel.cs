using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ENT.Model.Otp
{
    public class OtpModel
    {
        [Key]
        public int OTPId { get; set; }
        public string MobileNumber { get; set; }
        public int OTP {  get; set; }
        public DateTime ExpiryTime { get; set; }
        public bool IsUsed {  get; set; }
      
    }
}
