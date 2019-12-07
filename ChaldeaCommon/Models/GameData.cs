using ChaldeaCommon.Enums;
using System.Collections.Generic;

namespace ChaldeaCommon.Models
{
    public class GameData
    {
        /// <summary>
        /// A list of owned items and their quantity
        /// </summary>
        public Dictionary<Material, int> Inventory { get; set; }

        /// <summary>
        /// A list of owned servants
        /// </summary>
        public List<Servant> Servants { get; set; }

        public GameData()
        {
            Inventory = new Dictionary<Material, int>();
            Servants = new List<Servant>();
        }
    }
}