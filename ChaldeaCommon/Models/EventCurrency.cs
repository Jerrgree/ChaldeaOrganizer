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

        public int AmountRemaining => Math.Max(AmountNeeded - AmountOwned, 0);

        // Hardcode for now, make variable as a future enhancement
        public int ApPerRun => 40;

        public int RunsNeeded => (AmountRemaining > 0 && DropAverage > 0) ? (int)Math.Ceiling((decimal)AmountRemaining / DropAverage) : 0;

        private int? _amountOwned;

        public int AmountOwned
        {
            get
            {
                return _amountOwned.GetValueOrDefault();
            }
            set
            {
                // Have a null check to avoid adding an instance on initalization
                if (_amountOwned.HasValue && _amountOwned.Value < value)
                {
                    CurrencyDropInstance.Add(value - _amountOwned.Value);
                }

                _amountOwned = value;
            }
        }

        public int DropAverage => (CurrencyDropInstance == null || CurrencyDropInstance.Count == 0) ? 0 : (int)Math.Floor(CurrencyDropInstance.Average());
    }
}