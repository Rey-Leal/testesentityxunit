using EntityMVC.Api;
using EntityMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace EntityMVC.Controllers
{
    public class EnderecoController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ConsultarCep(string cep)
        {
            ApiConsultaCepResponse endereco = new ApiConsultaCepResponse();

            try
            {
                endereco = await ApiConsultaCep.GetEndereco(cep) ?? new ApiConsultaCepResponse();
            }
            catch (Exception ex)
            {
                ViewBag.MensagemDeErro = ex.Message;
            }
            return View(endereco);
        }
    }
}