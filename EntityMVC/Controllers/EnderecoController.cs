using EntityMVC.Api;
using Microsoft.AspNetCore.Mvc;

namespace EntityMVC.Controllers
{
    public class EnderecoController : BaseController
    {
        public async Task<IActionResult> Index()
        {
            ApiConsultaCepResponse endereco = new ApiConsultaCepResponse();
            
            try
            {
                string cep = "60130240";
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