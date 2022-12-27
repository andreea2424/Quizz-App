using System.ComponentModel.DataAnnotations;

namespace Quiz_App.Models
{
    public class User
    {
        [Key]
        public int Id_User { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Email { get; set; }
       
        public string? Password { get; set; }

        public int Score { get; set; }

        public int Total_Score { get; set; }
    }
}
