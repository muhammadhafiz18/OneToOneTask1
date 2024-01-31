namespace OneToOneTask1.models
{
    public class Biography
    {
        public int BiographyID { get; set; }
        public int AuthorID { get; set; }
        public string BiographyItself { get; set; }
        public Author Author { get; set; }
    }
}
