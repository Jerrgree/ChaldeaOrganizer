using System;
using System.Collections.Generic;
using System.Text;

namespace ChaldeaCommon.Models
{
    public class Servant
    {
        public string Name { get; set; }
        public List<Goal> Goals { get; set; }

        public Servant()
        {
            Goals = new List<Goal>();
        }
    }
}
