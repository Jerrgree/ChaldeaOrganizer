using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChaldeaOrganizer.Models
{
    public class ServantGoalMaterialChangeArgs : GoalMaterialChangedArgs
    {
        public int ServantId { get; set; }
    }
}