using Avaliacao.API.Application.Interfaces;
using Avaliacao.API.Controllers.Shared;
using Avaliacao.API.Domain.Entities;
using Avaliacao.API.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Avaliacao.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : Controller
    {
        private readonly ILogger<ClienteController> _logger;
        private IClienteService _clienteService;

        public ClienteController(ILogger<ClienteController> logger, IClienteService clienteService)
        {
            _logger = logger;
            _clienteService = clienteService;
        }

        [HttpPost("")]
        [ProducesResponseType(typeof(ApiResult<Guid>), StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status422UnprocessableEntity)]
        public async Task<IActionResult> Cadastrar([FromBody] ClienteViewModel cliente)
        {
            try
            {
                _clienteService.Cadastrar(cliente);
                 return Ok(ApiResult.Ok(cliente));
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return UnprocessableEntity(ApiResult.Fail("Não foi possível cadastrar, favor comunicar administrador do sistema."));
            }
        }

        [HttpPut("")]
        [ProducesResponseType(typeof(ApiResult<Guid>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status422UnprocessableEntity)]
        public async Task<IActionResult> Editar([FromBody] ClienteViewModel cliente)
        {
            try
            {
                _clienteService.Editar(cliente);
                return Ok(ApiResult.Ok());
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return UnprocessableEntity(ApiResult.Fail("Não foi possível alterar os dados, favor comunicar administrador do sistema."));
            }
        }



        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(ApiResult<Guid>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status422UnprocessableEntity)]
        public async Task<IActionResult> Excluir(int id)
        {
            try
            {
                _clienteService.Excluir(id);
                return Ok(ApiResult.Ok());
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return UnprocessableEntity(ApiResult.Fail("Não foi possível realizar a exclusão, favor comunicar administrador do sistema."));
            }
        }

        [HttpGet("")]
        [ProducesResponseType(typeof(ApiResult<string>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status422UnprocessableEntity)]
        public async Task<IActionResult> Listar()
        {
            try
            {
                var lista = _clienteService.Listar();
                return Ok(ApiResult.Ok(lista));
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return UnprocessableEntity(ApiResult.Fail("Não foi possível listar os dados, favor comunicar administrador do sistema."));
            }
        }
    }
}
