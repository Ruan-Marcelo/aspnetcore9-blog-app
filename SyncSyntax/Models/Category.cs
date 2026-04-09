using System.ComponentModel.DataAnnotations;

namespace SyncSyntax.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O Nome da Categoria é obrigatorio")]
        [MaxLength(100, ErrorMessage = "A Categoria não pode ser execeder 200 caracteres")]
        public string Name { get; set; }

        public string? Description { get; set; }
    }
}
