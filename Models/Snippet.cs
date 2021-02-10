using System.ComponentModel.DataAnnotations;

namespace WikiSnippets.Models{
    public class Snippet{
        [Key]
        public int Id { get; set; }

        [Required]
        public string HowTo { get; set; }

        [Required]
        public string Line { get; set; }

        [Required]
        public string Platform { get; set; }
    }
}