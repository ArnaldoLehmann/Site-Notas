using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;

namespace Site_Aele.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        [BindProperty]
        public float Nota1 { get; set; } // Propriedade vinculada ao formulário

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            // Lógica para requisição GET (se necessário)
        }

        public void OnPost()
        {
            // Lógica para processar o envio do formulário
            Console.WriteLine($"Nota recebida: {Nota1}");
        }
    }
}
