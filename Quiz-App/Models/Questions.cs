using System.ComponentModel.DataAnnotations;

namespace Quiz_App.Models
{
    public class Questions
    {

        [Key]
        public int Id_Question { get; set; }
        public string? Question_text { get; set; }
        public string? Option1 { get; set; }
        public string? Option2 { get; set; }
        public string? Option3 { get; set; }
        public int Correct_Answer { get; set; }
        public int Difficulty { get; set; }
        public int Score { get; set; }

       
    }
}
