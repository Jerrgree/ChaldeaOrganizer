using System.Collections.Generic;
using System.Linq;
using System;

namespace ChaldeaCommon.Models
{
    public class EventCurrency
    {
        public string Name { get; }
        public string Color { get; }
        public bool HasShop { get; }

        public List<EventCurrencyShopItem> Shop { get; set; }

        public List<int> CurrencyDropInstance { get; set; }

        public EventCurrency(string name, string color, bool hasShop)
        {
            Name = name;
            Color = color;
            HasShop = hasShop;
        }

        public int AmountNeeded => (Shop == null || Shop.Count == 0) ? 0 : Shop.Sum(x => x.Total);

        public int AmountOwned { get; set; }

        public int DropAverage => (CurrencyDropInstance == null || CurrencyDropInstance.Count == 0) ? 0 : (int)Math.Floor(CurrencyDropInstance.Average());
    }
}