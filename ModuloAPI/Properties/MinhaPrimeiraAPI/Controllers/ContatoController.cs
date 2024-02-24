using Microsoft.AspNetCore.Mvc;
using MinhaPrimeiraAPI.Context;
using MinhaPrimeiraAPI.Entities;

namespace MinhaPrimeiraAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContatoController : ControllerBase
    {
        private readonly AgendaContext _context;
        public ContatoController(AgendaContext context) 
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Create(Contato contato)
        {
            _context.Add(contato);
            _context.SaveChanges();
            return Ok(contato);
        }

        [HttpGet("{id}")]
        public IActionResult ObterPorId(int id)
        {
            var contato = _context.Contato.Find(id);

            if (contato == null) 
            {
                return NotFound();
            }
            return Ok(contato);
        }

        [HttpPost("{id}/{contato}")]
        public IActionResult Atualizar(int id, Contato contato) 
        {
            var contatoDB = _context.Contatos.Find(id);

            if (contatoDB == null)
            {
                return NotFound();
            }
            contatoDB.Nome = contato.Nome;
            contatoDB.Telefone = contato.Telefone;
            contatoDB.Ativo = contato.Ativo;

            _context.Contatos
        }
    }
}
