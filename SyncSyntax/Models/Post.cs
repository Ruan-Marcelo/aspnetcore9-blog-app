using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
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
        [MaxLength(100, ErrorMessage = "O Nome do autor não pode ser execeder 100 caracteres")]
        public string Author { get; set; }

        [ValidateNever]
        public string FeatureImagePath { get; set; }

        [DataType(DataType.Date)] 
        public DateTime PublishedDate { get; set; } = DateTime.Now;

        [ForeignKey("Category")]

        [DisplayName("Category")]
        public int CategoryId { get; set; }

        [ValidateNever]
        public Category Category { get; set; }

    }
}
