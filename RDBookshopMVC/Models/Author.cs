namespace RDBookshopMVC.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Biography { get; set; }

        //One-to-many relationship: one author can write many books
        public List<Book> Books { get; set; }
    }
}
