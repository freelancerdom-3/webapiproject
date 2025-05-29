using ENT.BL.Offer;
using ENT.Model.Common;
using ENT.Model.EntityFramework;
using ENT.Model.Offer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT.BL.Offers
{
    public class Offer : IOffer
    {

        private readonly MyDBContext _context;
        public Offer(MyDBContext context)
        {
            _context = context;

        }
        public async Task<APIResponseModel> Add(OfferModel objOffer)
        {

            APIResponseModel response = new APIResponseModel();
            try
            {
                using (var connection = _context)
                {
                    await connection.TblOffers.AddAsync(objOffer);
                    await connection.SaveChangesAsync();
                }
                response.Data = true;
                response.statusCode = 200;
                return response;
            }
            catch (Exception ex)
            {
                response.Data = false;
                response.statusCode = 400;
                response.Message = ex.Message;
                return response;
            }
        }

        public async Task<APIResponseModel> GetById(int OfferId)
        {
            APIResponseModel response = new APIResponseModel();
            try
            {
                using(MyDBContext connection = _context)
                {
                    bool offerExists = await connection.TblOffers.AnyAsync(x => x.OfferId == OfferId);

                    if (offerExists)
                    {
                        response.statusCode = 200;
                        response.Data = await connection.TblOffers.Where(x => x.OfferId == OfferId).FirstAsync();
                    }
                    else
                    {
                        response.statusCode = 200;
                        response.Message = "Offer not found.";
                        response.Data = false;

                    }
                }
            }
            catch (Exception ex)
            {
                response.Data = false;
                response.statusCode = 500;
                response.Message = ex.Message;
            }

            return response;
        }


        public async Task<APIResponseModel> Delete(int OfferId)
        {
            APIResponseModel response = new APIResponseModel();
            try
            {
                using (var conn = _context)
                {
                    var Offer = await _context.TblOffers.FirstOrDefaultAsync(x => x.OfferId == OfferId);
                    if (Offer != null)
                    {
                        _context.TblOffers.Remove(Offer);
                        await _context.SaveChangesAsync();

                        response.statusCode = 200;
                        response.Message = "Offer Deleted SuccesFullay";

                    }
                    else
                    {
                        response.Data = false;
                        response.statusCode = 204;
                        response.Message = "Offer Not Found";

                    }

                }
                return response;
            }
            catch (Exception ex)
            {
                response.Data = false;
                response.statusCode = 400;
                response.Message = ex.Message;
                return response;
            }
        }

        public async Task<APIResponseModel> GetAll()
        {
            APIResponseModel response = new APIResponseModel();
            try
            {
                using(MyDBContext connection = _context)
                {
                    response.Data = await connection.TblOffers.ToListAsync();
                    response.statusCode = 200;
                }
                return response;
            }
            catch(Exception ex)
            {
                response.Data = false;
                response.statusCode = 400;
                response.Message = ex.Message;
                return response;
            }

        }



        public async Task<APIResponseModel> Update(OfferModel Offer)
        {
            APIResponseModel response = new APIResponseModel();
            try
            {
                using (MyDBContext connection = _context)
                {
                    bool offerExists = await connection.TblOffers.AnyAsync(x => x.OfferId == Offer.OfferId);
                    if (offerExists)
                    {

                        connection.TblOffers.Update(Offer);
                        await connection.SaveChangesAsync();
                        response.statusCode = 200;
                        response.Message = "Offer Update SuccessFullay";
                    }
                    else
                    {
                        response.statusCode = 400;
                        response.Message = "Offer Not Found";
                    }

                }
                return response;

            }
            catch (Exception ex)
            {
                response.Data = false;
                response.statusCode = 500;
                response.Message = ex.Message;
                return response;
                throw;
            }

        }
    }
}

