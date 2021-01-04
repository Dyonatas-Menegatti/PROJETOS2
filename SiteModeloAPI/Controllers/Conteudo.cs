using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SiteModeloAPI.Data;
using SiteModeloAPI.Model;

namespace SiteModeloAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConteudoController : ControllerBase
    {
        public DataContext Context { get; }

        public ConteudoController(DataContext context)
        {
            this.Context = context;

        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var results = await Context.Parametros.ToListAsync();

                return Ok(results);
            }
            catch (System.Exception)
            {
                
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Falha no Banco de Dados");
                
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var results = await Context.Parametros.FirstOrDefaultAsync(x => x.PessoaId == id);

                return Ok(results);
            }
            catch (System.Exception)
            {
                
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Falha no Banco de Dados");
                
            }

        }
    }
}