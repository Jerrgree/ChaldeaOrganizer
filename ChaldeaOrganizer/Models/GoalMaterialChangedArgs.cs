using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChaldeaOrganizer.Models
{
    public class GoalMaterialChangedArgs : MaterialQuantityChangedArgs
    {
        public string GoalName { get; set; }
    }
}