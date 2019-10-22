using System.Collections.Generic;

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
    }
}