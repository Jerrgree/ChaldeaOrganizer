using System.Collections.Generic;
using System.Linq;
using System;

namespace ChaldeaCommon.Models
{
    public class EventCurrency
    {
        public string Name { get; }
        public string Color { get; }
        public bool IsLotteryCurrency { get; set; }
        public bool IsShopCurrency { get; set; }

        public List<EventCurrencyShop> Shop { get; set; }

        public List<int> CurrencyDropInstance { get; set; }

        public EventCurrency(string name, string color)
        {
            Name = name;
            Color = color;
        }

        public int Amount => (Shop?.Count == 0) ? 0 : Shop.Sum(x => x.Quantity * x.Cost);

        public int DropAverage => (CurrencyDropInstance?.Count == 0) ? 0 : (int)Math.Floor(CurrencyDropInstance.Average());
    }
}