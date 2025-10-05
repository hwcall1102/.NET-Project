namespace TakeawayTitans.Dto
{
    public class MenuItemDto
    {
        public int Id { get; set; }           // PK
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public decimal Price { get; set; }
        public string? ImageUrl { get; set; }
    }
}
