namespace LetsHungry.API.DTOs
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool IsActive { get; set; }
        public int ProductCategoryId { get; set; }
        public int RestaurantId { get; set; }
    }
}
