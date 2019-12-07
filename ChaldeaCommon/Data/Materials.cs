using ChaldeaCommon.Enums;
using System;
using System.Collections.Generic;

namespace ChaldeaCommon.Data
{
    public class Materials
    {
        public static IEnumerable<Material> GetMaterials()
        {
            return (IEnumerable<Material>)Enum.GetValues(typeof(Material));
        }
    }
}