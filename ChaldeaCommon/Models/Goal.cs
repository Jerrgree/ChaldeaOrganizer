using ChaldeaCommon.Enums;
using System.Collections.Generic;

namespace ChaldeaCommon.Models
{
    public class Goal
    {
        /// <summary>
        /// A list of items and their quantity
        /// </summary>
        public Dictionary<Material, int> Materials { get; set; }

        /// <summary>
        /// A unique label for the goal
        /// </summary>
        public string Name { get; set; }
    }
}