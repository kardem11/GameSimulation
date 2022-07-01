using GameSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSimulation.Abstract
{
    internal interface IOfferService
    {
        public void AddOffer(Offer offer);
        public void UpdateOffer(Offer offer);
        public void DeleteOffer(Offer offer);
    }
}
