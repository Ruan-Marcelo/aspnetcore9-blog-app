using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SyncSyntax.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O Titulo é Obrigatorio")]
        [MaxLength(400, ErrorMessage = "O Titulo não pode ser execeder 200 caracteres")]
        public string Title { get; set; }

        [Required(ErrorMessage = "O Conteudo é Obrigatorio")]
        public string Content { get; set; }

        [Required(ErrorMessage = "O Autor é Obrigatorio")]
        [MaxLength(400, ErrorMessage = "O Nome do autor não pode ser execeder 200 caracteres")]
        public string Author { get; set; }

        public string FeatureImagePath { get; set; }

        [DataType(DataType.Date)] 
        public DateTime PublishedDate { get; set; } = DateTime.Now;

        [ForeignKey("Category")]
        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public ICollection<Comment> Comments { get; set; }
    }
}
