namespace TakeawayTitans.Dto
{
    public class UserCreateDto
    {
        public string Name { get; set; } = "";
        public string Email { get; set; } = "";
        public string Password { get; set; } = "";  // You’ll eventually want to hash this
    }
}
