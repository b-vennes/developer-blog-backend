namespace Blog.Backend.Dtos
{
    public class PublishContentDto
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public bool Hidden { get; set; }
    }
}