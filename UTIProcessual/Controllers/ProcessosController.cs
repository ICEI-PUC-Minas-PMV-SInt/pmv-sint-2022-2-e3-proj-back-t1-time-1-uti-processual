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


        [HttpGet]
        public async Task <IActionResult> View(Guid id)
        {
            var verProcesso = await dbContext.CadastroProcessos.FirstOrDefaultAsync(x => x.Id == id);

            if (verProcesso != null)
            {
                var viewModel = new EditarProcessoViewModel()
                {
                    Id = verProcesso.Id,
                    NumeroProcessoPenal = verProcesso.NumeroProcessoPenal,
                    TipoPenal = verProcesso.TipoPenal,
                    LocalDoCrime = verProcesso.LocalDoCrime,
                    DataDoCrime = verProcesso.DataDoCrime,
                    NumeroPCNET = verProcesso.NumeroPCNET,
                    NumeroREDS = verProcesso.NumeroREDS,
                    NumInqueritoPolicial = verProcesso.NumInqueritoPolicial,

                    NomeReu = verProcesso.NomeReu,
                    FiliacaoReu = verProcesso.FiliacaoReu,
                    DataNascReu = verProcesso.DataNascReu,
                    NaturalidadeReu = verProcesso.NaturalidadeReu,
                    EnderecoReu = verProcesso.EnderecoReu,
                    TelefoneReu = verProcesso.TelefoneReu,

                    Advogado = verProcesso.Advogado,
                    OABAdvogado = verProcesso.OABAdvogado,
                    DefensoriaPublica = verProcesso.DefensoriaPublica
                };

                return await Task.Run(() => View("View", viewModel));
            }

            return RedirectToAction("View");
        }

        [HttpPost]
        public async Task<IActionResult> View(EditarProcessoViewModel model)
        {
            var verProcesso = await dbContext.CadastroProcessos.FindAsync(model.Id);

            if (verProcesso != null)
            {
                verProcesso.Id = model.Id;
                verProcesso.NumeroProcessoPenal = model.NumeroProcessoPenal;
                verProcesso.TipoPenal = model.TipoPenal;
                verProcesso.LocalDoCrime = model.LocalDoCrime;
                verProcesso.DataDoCrime = model.DataDoCrime;
                verProcesso.NumeroPCNET = model.NumeroPCNET;
                verProcesso.NumeroREDS = model.NumeroREDS;
                verProcesso.NumInqueritoPolicial = model.NumInqueritoPolicial;

                verProcesso.NomeReu = model.NomeReu;
                verProcesso.FiliacaoReu = model.FiliacaoReu;
                verProcesso.DataNascReu = model.DataNascReu;
                verProcesso.NaturalidadeReu = model.NaturalidadeReu;
                verProcesso.EnderecoReu = model.EnderecoReu;
                verProcesso.TelefoneReu = model.TelefoneReu;

                verProcesso.Advogado = model.Advogado;
                verProcesso.OABAdvogado = model.OABAdvogado;
                verProcesso.DefensoriaPublica = model.DefensoriaPublica;

                await dbContext.SaveChangesAsync();

                return RedirectToAction("ListarProcessos");
            }

            return RedirectToAction("ListarProcessos");
        }

    }
}
