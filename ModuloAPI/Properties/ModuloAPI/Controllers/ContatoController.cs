using Microsoft.AspNetCore.Mvc;
using ModuloAPI.Context;
using ModuloAPI.Entities;

namespace ModuloAPI.Controllers
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
            var contato = _context.Contatos.Find(id);
            if (contato == null)
            {
                return NotFound();
            }
            return Ok(contato);
        }
        [HttpGet("ObterPorNome")]
        public IActionResult ObterPorNome(string nome) 
        {
            var contatos = _context.Contatos.Where(x => x.Nome.Contains(nome));
            return Ok(contatos);
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, Contato contato) 
        {
            var contatoDB = _context.Contatos.Find(id);
            if (contatoDB == null) 
                return NotFound();

            contatoDB.Nome = contato.Nome;
            contatoDB.Telefone = contato.Telefone; 
            contatoDB.Ativo = contato.Ativo;

            _context.Contatos.Update(contatoDB);
            _context.SaveChanges();
            return Ok(contato);
        }
        [HttpDelete("{id}")]
        public IActionResult Deletar(int id) 
        {
            var contatoDB = _context.Contatos.Find(id);
            if (contatoDB == null)
                return NotFound();
            _context.Contatos.Remove(contatoDB);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
