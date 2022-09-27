namespace users.Models
{
    public class users
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public string Email { get; set; }
        public int ? phone { get; set; }
        public bool IsComplete { get; set; }
    }
}