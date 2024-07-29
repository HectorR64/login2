namespace injeccion.Models
{
    public class UserResponse
    {
        public User user { get; set; }
        public string token { get; set; }
        public bool is_valid { get; set; } = true;
        public string message { get; set; }
    }

    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public DateTime? emailVerifiedAt
        { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt
        {
            get; set;
        }

    }
}
