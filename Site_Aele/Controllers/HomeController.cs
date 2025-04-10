using Microsoft.AspNetCore.Mvc;
using Site_Aele;

public class HomeController : Controller
{
    [HttpGet]
    public IActionResult Submit()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Submit(NotaModels model)
    {
        if (!ModelState.IsValid)
        {
            return View(model); // Retorna os erros de validação à View.
        }

        float nota = model.Nota1; // Processa a nota válida.
        return RedirectToAction("Success");
    }

    public IActionResult Success()
    {
        return View(); // Mostra uma página de sucesso após o envio.
    }
}