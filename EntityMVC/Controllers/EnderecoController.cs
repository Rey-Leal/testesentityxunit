using EntityMVC.Api;
using Microsoft.AspNetCore.Mvc;

namespace EntityMVC.Controllers
{
    public class EnderecoController : BaseController
    {
        public async Task<IActionResult> Index()
        {
            string cep = "60130240";
            Endereco endereco = await ApiConsultaCep.GetEndereco(cep);            
                        
            return View(endereco);
        }
    }
}