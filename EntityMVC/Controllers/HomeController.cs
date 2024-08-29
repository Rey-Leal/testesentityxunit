using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using EntityMVC.Api;
using EntityMVC.Data;
using EntityMVC.Models;

namespace EntityMVC.Controllers
{
    public class HomeController : BaseController
    {
        private readonly Context _context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(Context context, ILogger<HomeController> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            try
            {
                // Imagens randomicas das APIs Picsum e DogCeo                        
                ViewBag.Imagem1 = await ApiPicsum.GetPicsumImage();
                ViewBag.Imagem2 = await ApiDogCeo.GetDogImage();
                ViewBag.Imagem3 = await ApiPicsum.GetPicsumImage();
            }
            catch (Exception ex)
            {
                ViewBag.MensagemDeErro = ex.Message;
            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        // Post Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Usuario usuario)
        {
            if (usuario.Email != null && usuario.Senha != null)
            {
                try
                {
                    // Validação
                    var validaLogin = _context.Usuario.Where(a => a.Email.Equals(usuario.Email) && a.Senha.Equals(usuario.Senha)).FirstOrDefault();
                    if (validaLogin != null)
                    {
                        HttpContext.Session.SetString("usuarioLogadoID", validaLogin.Id.ToString());
                        HttpContext.Session.SetString("nomeUsuarioLogado", validaLogin.Email);
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        HttpContext.Session.Remove("usuarioLogadoID");
                        HttpContext.Session.Remove("nomeUsuarioLogado");
                        ViewBag.MensagemDeErro = "Email ou senha inválidos!";
                    }
                }
                catch (Exception ex)
                {
                    ViewBag.MensagemDeErro = ex.Message;
                }
            }
            return View(usuario);
        }

        // Post Logoff
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Logoff(Usuario usuario)
        {
            try
            {
                HttpContext.Session.Remove("usuarioLogadoID");
                HttpContext.Session.Remove("nomeUsuarioLogado");
            }

            catch (Exception ex)
            {
                ViewBag.MensagemDeErro = ex.Message;
            }
            return RedirectToAction("Login");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
