using System;
using System.Collections.Generic;
using System.Text;

namespace ChaldeaCommon.Models
{
    class Servant
    {
        public string Name { get; set; }
        public IEnumerable<Goal> Goals { get; set; }

        public Servant()
        {
            Goals = new List<Goal>();
        }
    }
}
