using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
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


        double nota1 = model.Nota1; // Processa a nota válida.
        double nota2 = model.Nota2;
        double? notaPim = model.NotaPim;
        double mediaProvas = (float)(nota1 * 0.4) + (float)(nota2 * 0.4);


        
        if (notaPim == null)//Testa se ainda nao tem nota do pim para mostrar para o usuario quanto falta para ele através da nota do pim, se nao tiver, entra no bloc
        {
            if (mediaProvas >= 7){//Se a media das provas ja for maior ou igual a 7, ja diz que ele passou
                TempData["mediaProvasAprovado"] = mediaProvas;
                return View(model);
            }
            else {//Caso o contrario calcula quanto falta da nota do pim para passar
                double pimFaltante = (7 - mediaProvas) / 0.2;

                if (pimFaltante > 2){//Testa se com a nota faltante do pim ja está reprovado, se sim altera os valores da temp data
                    TempData["mediaProvasReprovado"] = mediaProvas;
                    TempData["pimFaltanteReprovado"] = pimFaltante;
                    return View(model);
                }
                else{//Se nao, adiciona os valores para apresentar como possivel ser aprovado

                    TempData["mediaProvasPossivel"] = mediaProvas;
                    TempData["pimFaltantePossivel"] = pimFaltante;
                    return View(model);
                }
            }
        }
        else//Caso tenha a nota do pim, calcula a media final no bloco abaixo
        {
            double mediaFinal = ((double)mediaProvas + ((notaPim ?? 0.0) * 0.2));
            
            if(mediaFinal >= 7){//Se a media final for mair que 7 armazena a nota na "mediaFinalaprovado"
                TempData["mediaFinalAprovado"] = mediaFinal;
                return View(model);
            }
            else//Caso o contrario, armazena na temp data "mediaFinalreprovado"
            {
                TempData["mediaFinalReprovado"] = mediaFinal;
            }
            
        }
    }
            public IActionResult Index()
            {
                NotaModels model = new NotaModels();
                return View(model);
            }


        
        if (notaPim == null)//Testa se ainda nao tem nota do pim para mostrar para o usuario quanto falta para ele através da nota do pim, se nao tiver, entra no bloc
        {
            if (mediaProvas >= 7){//Se a media das provas ja for maior ou igual a 7, ja diz que ele passou
                TempData["mediaProvasAprovado"] = mediaProvas;
                return View(model);
            }
            else {//Caso o contrario calcula quanto falta da nota do pim para passar
                double pimFaltante = (7 - mediaProvas) / 0.2;

                if (pimFaltante > 2){//Testa se com a nota faltante do pim ja está reprovado, se sim altera os valores da temp data
                    TempData["mediaProvasReprovado"] = mediaProvas;
                    TempData["pimFaltanteReprovado"] = pimFaltante;
                    return View(model);
                }
                else{//Se nao, adiciona os valores para apresentar como possivel ser aprovado

                    TempData["mediaProvasPossivel"] = mediaProvas;
                    TempData["pimFaltantePossivel"] = pimFaltante;
                    return View(model);
                }
            }
        }
        else//Caso tenha a nota do pim, calcula a media final no bloco abaixo
        {
            double mediaFinal = ((double)mediaProvas + ((notaPim ?? 0.0) * 0.2));
            
            if(mediaFinal >= 7){//Se a media final for mair que 7 armazena a nota na "mediaFinalaprovado"
                TempData["mediaFinalAprovado"] = mediaFinal;
                return View(model);
            }
            else//Caso o contrario, armazena na temp data "mediaFinalreprovado"
            {
                TempData["mediaFinalReprovado"] = mediaFinal;
            }
            
        }
    }



            public IActionResult Index()
            {
                NotaModels model = new NotaModels();
                return View(model);
            }



}