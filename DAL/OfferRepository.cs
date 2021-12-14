using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using JeanStationModels;

namespace DAL
{
    public class OfferRepository : IOfferRepository
    {
        private readonly JeanStationDbContext _context;
        public OfferRepository(JeanStationDbContext con)
        {
            _context = con;
        }

        public List<Offer> GetAllOffers()
        {
            return _context.Offers.ToList();
        }

        public Offer AddOffer(Offer offer)
        {
            _context.Offers.Add(offer);
            _context.SaveChanges();
            return offer;

        }

        public bool DeleteOffer(string id)
        {
            var offer = _context.Offers.FirstOrDefault(x => x.Id == id);
            if (offer == null) return false;
            _context.Offers.Remove(offer);
            _context.SaveChanges();
            return true;

        }
    }
}
