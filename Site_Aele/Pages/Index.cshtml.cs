using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;

namespace Site_Aele.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        [BindProperty]
        public float Nota1 { get; set; } // Propriedade vinculada ao formul�rio

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            // L�gica para requisi��o GET (se necess�rio)
        }

        public void OnPost()
        {
            // L�gica para processar o envio do formul�rio
            Console.WriteLine($"Nota recebida: {Nota1}");
        }
    }
}
