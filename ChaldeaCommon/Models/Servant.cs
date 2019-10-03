using System;
using System.Collections.Generic;
using System.Text;
using ChaldeaCommon.Enums;

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
