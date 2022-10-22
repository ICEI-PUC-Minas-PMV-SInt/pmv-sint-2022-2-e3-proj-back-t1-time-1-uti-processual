using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;
using UTIProcessual.Data;
using UTIProcessual.Models;
using UTIProcessual.Models.Cadastro;

namespace UTIProcessual.Controllers
{
    public class ProcessosController : Controller
    {
        private readonly MVCDbContext dbContext;
        public ProcessosController(MVCDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> ListarProcessos()
        {
            var listarProcessos = await dbContext.CadastroProcessos.ToListAsync();
            return View(listarProcessos);
        }


        [HttpGet]
        public IActionResult Adicionar()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Adicionar(NovoProcessoViewModel dadosNovoProcessoRequest)
        {
            var processos = new NovoProcesso()
            {
                Id = Guid.NewGuid(),
                NumeroProcessoPenal = dadosNovoProcessoRequest.NumeroProcessoPenal,
                TipoPenal = dadosNovoProcessoRequest.TipoPenal,
                LocalDoCrime = dadosNovoProcessoRequest.LocalDoCrime,
                DataDoCrime = dadosNovoProcessoRequest.DataDoCrime,
                NumeroPCNET = dadosNovoProcessoRequest.NumeroPCNET,
                NumeroREDS = dadosNovoProcessoRequest.NumeroREDS,
                NumInqueritoPolicial = dadosNovoProcessoRequest.NumInqueritoPolicial,

                NomeReu = dadosNovoProcessoRequest.NomeReu,
                FiliacaoReu = dadosNovoProcessoRequest.FiliacaoReu,
                DataNascReu = dadosNovoProcessoRequest.DataNascReu,
                NaturalidadeReu = dadosNovoProcessoRequest.NaturalidadeReu,
                EnderecoReu = dadosNovoProcessoRequest.EnderecoReu,
                TelefoneReu = dadosNovoProcessoRequest.TelefoneReu,

                Advogado = dadosNovoProcessoRequest.Advogado,
                OABAdvogado = dadosNovoProcessoRequest.OABAdvogado,
                DefensoriaPublica = dadosNovoProcessoRequest.DefensoriaPublica
            };

            await dbContext.CadastroProcessos.AddAsync(processos);
            await dbContext.SaveChangesAsync();
            return RedirectToAction("ListarProcessos");
        }
    }
}
