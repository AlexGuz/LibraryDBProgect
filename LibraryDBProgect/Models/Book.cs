namespace LibraryDBProgect
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int ReleaseDate { get; set; }
        public BookGenre Genre { get; set; }
        public int AutorId { get; set; }
        public Autor Autor { get; set; }
        public int? ClientId { get; set; }
        public Client Client { get; set; }        
    }
}