using GameSimulation.Abstract;
using GameSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSimulation.Concretes
{
    public class OfferManager : IOfferService
    {
        void IOfferService.AddOffer(Offer offer)
        {
            Console.WriteLine(offer.OfferName + "Offer Added");
        }

        void IOfferService.DeleteOffer(Offer offer)
        {
            Console.WriteLine(offer.OfferId + "   offer Deleted");
        }

        void IOfferService.UpdateOffer(Offer offer)
        {
            Console.WriteLine(offer.OfferRate + " ... offer Updated");
        }
    }
}
