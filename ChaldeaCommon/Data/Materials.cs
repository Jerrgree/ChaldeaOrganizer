using ChaldeaCommon.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ChaldeaCommon.Data
{
    public class Materials
    {
        public static IEnumerable<Material> GetMaterials()
        {
            return ((IEnumerable<Material>)Enum.GetValues(typeof(Material))).Where(x => x != Material.Unkown);
        }
    }
}