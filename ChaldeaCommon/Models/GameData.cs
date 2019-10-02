using System;
using System.Collections.Generic;
using System.Text;

namespace ChaldeaCommon.Models
{
    public class GameData
    {
        /// <summary>
        /// A list of owned items and their quantity
        /// </summary>
        public Dictionary<string, int> Inventory { get; set; }
        /// <summary>
        /// A list of owned servants
        /// </summary>
        public List<Servant> Servants { get; set; }

        public GameData()
        {
            Inventory = new Dictionary<string, int>();
            Servants = new List<Servant>();
        }
    }
}
