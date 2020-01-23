namespace DevBlog.DatabaseModels
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public byte[] TokenHash { get; set; }
        public byte[] TokenSalt { get; set; }
    }
}