using System.ComponentModel.DataAnnotations;

namespace SyncSyntax.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O Nome de Usuario é Obrigatorio")]
        [MaxLength(100, ErrorMessage = "O Nome de Usuario não pode ser execeder 200 caracteres")]
        public string UserName { get; set; }

        [DataType(DataType.Date)]
        public DateTime CommentDate { get; set; }

        [Required]
        public string Content { get; set; }
    }
}
