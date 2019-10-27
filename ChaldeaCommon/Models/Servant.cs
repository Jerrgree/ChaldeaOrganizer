using ChaldeaCommon.Enums;
using System.Collections.Generic;

namespace ChaldeaCommon.Models
{
    public class Servant
    {
        public string Name { get; set; }
        public List<Goal> Goals { get; set; }
        public ServantClass? Class { get; set; }

        public Servant()
        {
            Goals = new List<Goal>();
        }
    }
}