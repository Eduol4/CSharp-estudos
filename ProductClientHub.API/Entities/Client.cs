namespace ProductClientHub.API.Entities
{
    public class Client
    {
        public Guid id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
    }
}
