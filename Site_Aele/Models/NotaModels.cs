using System.ComponentModel.DataAnnotations;
namespace Site_Aele
{
    public class NotaModels
    {
        [Range(0, 10, ErrorMessage = "Por favor, insira um valor entre 0 e 10.")]
        public float Nota1 { get; set; }
    
}
}
