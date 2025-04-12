using HotLapping.Models;
using Microsoft.AspNetCore.Mvc;

namespace HotLapping.Controllers
{
    public class CircuitoController : Controller
    {
        public IActionResult Index()
        {
            new Circuito
            {
                CircuitoID = 0,
                Nome = "Interlagos",
                Pais = "Brasil",
                Cidade = "São Paulo",
                Tamanho = "4,309",
                NumeroCurvas = "15",
                Recorde = "Teste",
                RecordePiloto = "Teste",
                RecordeCarro = "Teste",
                Imagem = "string.Empty"
            };
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

    }
}
