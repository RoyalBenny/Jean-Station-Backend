using JeanStationModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public interface IOfferService
    {
        Offer AddOffer(Offer offer);
        bool DeleteOffer(string id);
        List<Offer> GetAllOffers();
    }
}
