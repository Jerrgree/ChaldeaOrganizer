using System;
using System.Collections.Generic;
using System.Text;

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
