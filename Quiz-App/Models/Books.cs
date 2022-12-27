using System.ComponentModel.DataAnnotations;

namespace Quiz_App.Models
{
    public class Books
    {
        [Key]
        public int Id_Book { get; set; }
        public string? Title { get; set; }
        public string? Author { get; set; }
        public string? Price { get; set; }
        public string? Photo { get; set; }
        
    }
}
