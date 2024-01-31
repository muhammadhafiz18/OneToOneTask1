namespace OneToOneTask1.models
{
    public class Author
    {
        public int AuthorID { get; set; }
        public string AuthorName { get; set; }
        public DateTime AuthorAge { get; set; }
        public string AuthorAddress { get; set; }
        public Biography Biography { get; set; }
    }
}

