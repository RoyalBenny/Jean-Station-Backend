using JeanStationModels;
using System.Collections.Generic;

namespace DAL
{
    public interface IOfferRepository
    {
        Offer AddOffer(Offer offer);
        bool DeleteOffer(string id);
        List<Offer> GetAllOffers();
    }
}