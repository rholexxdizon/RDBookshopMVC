namespace RDBookshopMVC.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //One-to-many relationship: one Category can have many Books.
        public List<Book> Books { get; set; }
    }
}
