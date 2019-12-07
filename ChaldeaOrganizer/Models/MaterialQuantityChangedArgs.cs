using ChaldeaCommon.Enums;

namespace ChaldeaOrganizer.Models
{
    public class MaterialQuantityChangedArgs
    {
        public Material Material { get; set; }

        public int Quantity { get; set; }
    }
}