using Microsoft.AspNetCore.Mvc;
using Desafio.API.Models;
using Desafio.Domain.Services; // Adicione esta referência

namespace Desafio.API.Controllers
{
    [ApiController]
    [Route("[controller]")]  
    public class InvestigacaoController : ControllerBase
    {
        private readonly InvestigacaoService _service;
             
        public InvestigacaoController()
        {
            _service = new InvestigacaoService();
        }

        [HttpPost("suspeito")] 
        public IActionResult VerificarSuspeito([FromBody] CarteiraRequest request)
        {
            if (request == null || request.Notas == null)
            {
                return BadRequest(new { Mensagem = "O array de notas é obrigatório." });
            }
                        
            bool eOSuspeito = _service.PodeTerRoubado(request.Notas);

            if (eOSuspeito)
            {
                return Ok(new
                {
                    Resultado = true,
                    Mensagem = "Suspeito! Esta carteira possui duas notas que somam 150 fulampos."
                });
            }
            else
            {
                return Ok(new
                {
                    Resultado = false,
                    Mensagem = "Suspeito inocentado. Nenhuma combinação de duas notas soma 150 fulampos."
                });
            }
        }
    }
}