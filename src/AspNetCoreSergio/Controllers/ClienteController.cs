using AspNetCoreSergio.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace AspNetCoreSergio.Controllers
{
    public class ClienteController : Controller
    {
        private readonly ICliente _Icliente;
        public ClienteController(ICliente Icliente)
        {
            _Icliente = Icliente;
        }
       
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }
}
