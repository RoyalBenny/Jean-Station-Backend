using JeanStationModels;
using System;
using System.Collections.Generic;
using System.Text;
using DAL;

namespace Services
{
    public class OfferServices : IOfferService
    {
        private readonly IOfferRepository _repo;
        public OfferServices(IOfferRepository repo)
        {
            _repo = repo;
        }
        public Offer AddOffer(Offer offer)
        {
            try
            {
                return _repo.AddOffer(offer);
            }catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool DeleteOffer(string id)
        {
            try {
                return _repo.DeleteOffer(id);
            }
            catch (Exception ex)
            { return false; }
        }

        public List<Offer> GetAllOffers()
        {
            try
            {
                return _repo.GetAllOffers();
            }catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
