using ChaldeaCommon.Models;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace JsonDataServices
{
    public sealed class EventDataService : BaseJsonDataService<EventData>
    {
        /// <summary>
        /// Initializes a new instace of the GameDataService
        /// That is bound to a specific file for I/O
        /// </summary>
        /// <param name="fileLocation">The path to the file</param>
        /// <exception cref="FileNotFoundException" />
        /// <exception cref="ArgumentException" />
        public EventDataService(string fileLocation) : base(fileLocation) { }

        public override async Task<EventData> RetrieveData()
        {
            var data = await base.RetrieveData();

            foreach (var currencyWithoutShop in data.Currencies.Where(x => x.Shop == null))
            {
                currencyWithoutShop.Shop = new List<EventCurrencyShopItem>();
            }

            foreach (var currencyWithoutDrops in data.Currencies.Where(x => x.CurrencyDropInstance == null))
            {
                currencyWithoutDrops.CurrencyDropInstance = new List<int>();
            }

            return data;
        }
    }
}