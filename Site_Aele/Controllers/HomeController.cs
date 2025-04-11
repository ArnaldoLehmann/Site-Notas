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

        float nota1 = model.Nota1; // Processa a nota válida.
        float nota2 = model.Nota2;
        float notaPim = model.NotaPim;
        float media = (float)(nota1 * 0.4) + (float)(nota2 * 0.4) + (float)(notaPim * 0.2);

        TempData["Media"] = media;
        return RedirectToAction("success");
    }

    public IActionResult Index()
    {
        NotaModels model = new NotaModels();
        return View(model);
    }


}