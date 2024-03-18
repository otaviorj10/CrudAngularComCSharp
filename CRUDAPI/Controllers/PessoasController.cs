using CRUDAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRUDAPI.Controllers
{

    [ApiController]
    [Route("api/[Controller]")]
    public class PessoasController : ControllerBase
    {
        private readonly Contexto _contexto;

        public PessoasController(Contexto contexto)
        {
            _contexto = contexto;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pessoa>>> GetAsync()
        {
            return await _contexto.Pessoas.ToListAsync();
        }


        [HttpGet("{PessoalId}")]
        public async Task<ActionResult<Pessoa>> GetPessoaById(int PessoalId)
        {
            Pessoa pessoa = await _contexto.Pessoas.FindAsync(PessoalId);

            if (pessoa == null)
                return NotFound();

            return pessoa;
        }


        [HttpPost]
        public async Task<ActionResult<Pessoa>> SavePessoas(Pessoa pessoa)
        {
            await _contexto.Pessoas.AddAsync(pessoa);
            await _contexto.SaveChangesAsync();

            return Ok();

        }


        [HttpPut]
        public async Task<ActionResult> UpdatePessoa(Pessoa pessoa)
        {
            _contexto.Pessoas.Update(pessoa);
            await _contexto.SaveChangesAsync();

            return Ok();
        }


        [HttpDelete("{PessoalId}")]
        public async Task<ActionResult> DeletePessoa(int pessoaId)
        {
            Pessoa pessoa = await _contexto.Pessoas.FindAsync(pessoaId);

            if (pessoa == null)
                return NotFound();

            _contexto.Pessoas.Remove(pessoa);
            await _contexto.SaveChangesAsync();
            return Ok();
        }

    }

}


