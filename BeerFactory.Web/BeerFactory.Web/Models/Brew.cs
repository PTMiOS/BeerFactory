namespace BeerFactory.Web.Models
{
    public class Brew
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int RecipeId { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
