using Microsoft.AspNetCore.Mvc;
using deliveryfast.Models;
namespace deliveryfast.Controllers
{
    public class CadastroController : Controller
    {
        [HttpPost]       
           public IActionResult Formulario(Cadastro novoCadastro)
           {
               CadastroBancoDados user = new CadastroBancoDados();
               user.Insert(novoCadastro);
               ViewBag.Mensagem = "Obrigado pela Compra e Aguarde Nossa Entrega!";
               return View();
           }

    }
}