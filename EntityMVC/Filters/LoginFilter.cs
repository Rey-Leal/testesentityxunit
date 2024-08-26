using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace EntityMVC.Filters
{
    public class UsuarioLogadoFilter : ActionFilterAttribute
    {
        // Filtro que valida login e redireciona se necessário
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var controller = context.Controller as Controller;
            if (controller != null)
            {
                bool usuarioLogado = controller.HttpContext.Session.GetString("usuarioLogadoID") != null;

                // Valida se Action é de Login para evitar loop infinito do Filter
                var acaoDaChamada = context.ActionDescriptor.DisplayName;
                bool acaoDeLogin = acaoDaChamada.Contains("Login");

                // Redireciona para Home.Login se o usuário não estiver logado e Action não for de Login
                if (!usuarioLogado && !acaoDeLogin)
                {
                    context.Result = new RedirectToActionResult("Login", "Home", null);
                }
                // Action Login
                else
                {
                    // Variavel para controle do menu de acessos
                    // LoginFilter >> _Layout >> _Navbar
                    controller.ViewBag.UsuarioLogado = usuarioLogado;
                }
            }
            base.OnActionExecuting(context);
        }
    }
}
