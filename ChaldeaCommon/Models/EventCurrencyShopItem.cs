namespace ChaldeaCommon.Models
{
    public class EventCurrencyShopItem
    {
        public string Item { get; set; }
        public int Quantity { get; set; }
        public int Cost { get; set; }

        public int Total => Quantity * Cost;
    }
}