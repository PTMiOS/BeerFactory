namespace BeerFactory.Web.Models
{
    public class BrewBottle
    {
        public int Id { get; set; }
        public int BottleId { get; set; }
        public int BrewId { get; set; }
        public DateTime FillDate { get; set; }
        public BrewBottleState State { get; set; }
    }
}
