using System.Collections.Generic;

namespace ChaldeaCommon.Models
{
    public class EventData
    {
        public List<EventCurrency> Currencies { get; set; }

        public EventData()
        {
            Currencies = new List<EventCurrency>();
        }
    }
}