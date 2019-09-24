using System;
using System.Collections.Generic;
using System.Text;

namespace ChaldeaCommon.Models
{
    public class Goal
    {
        /// <summary>
        /// A list of items and their quantity
        /// </summary>
        public Dictionary<string, int> Materials { get; set; }
        /// <summary>
        /// A unique label for the goal
        /// </summary>
        public string Name { get; set; }
    }
}
