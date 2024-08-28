using EntityMVC.Api;
using Microsoft.AspNetCore.Mvc;

namespace EntityMVC.Controllers
{
    public class FeriadoController : BaseController
    {
        public async Task<IActionResult> Index()
        {
            List<ApiNagerDateResponse> listaFeriados = new List<ApiNagerDateResponse>();
            try
            {
                int ano = DateTime.Now.Year;                
                listaFeriados = await ApiNagerDate.GetFeriados(ano) ?? new List<ApiNagerDateResponse>();
                ViewBag.Ano = ano;
            }
            catch (Exception ex)
            {
                ViewBag.MensagemDeErro = ex.Message;
            }
            return View(listaFeriados);
        }
    }
}