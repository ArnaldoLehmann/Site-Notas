

using System.ComponentModel.DataAnnotations;
namespace Site_Aele
{
    public class NotaModels
    {
        [Required] // Validação para garantir que o campo seja obrigatório.
        [Range(0, 10, ErrorMessage = "A nota deve estar entre 0 e 10.")]
        public float Nota1 { get; set; }

        [Required] // Validação para a segunda nota.
        [Range(0, 10, ErrorMessage = "A nota deve estar entre 0 e 10.")]
        public float Nota2 { get; set; }

        
        [Range(0, 10, ErrorMessage = "A nota deve estar entre 0 e 10.")]
        public float NotaPim { get; set; }
    }
}
