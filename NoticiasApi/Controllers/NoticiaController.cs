using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NoticiasApi.Model;
using NoticiasApi.Services;

namespace NoticiasApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NoticiaController : ControllerBase
    {
        private readonly NoticiaService _noticiaService;
        public NoticiaController(NoticiaService noticiaService)
        {
            _noticiaService = noticiaService;
        }
        [HttpGet]
        [Route("obtener")]
        public IActionResult Obtener()
        {
            var result = _noticiaService.obtener();
            return Ok(result);
        }

        [HttpPost]
        [Route("agregar")]
        public IActionResult Agregar([FromBody] Noticia noticia)
        {
            var result = _noticiaService.AgregarNoticia(noticia);
            if (result)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpPut]
        [Route("editar")]
        public IActionResult Editar([FromBody] Noticia noticia)
        {
            var result = _noticiaService.EditarNoticia(noticia);
            if (result)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpDelete]
        [Route("eliminar/{IdNoticia}")]
        public IActionResult Eliminar(int IdNoticia)
        {
            var result = _noticiaService.EliminarNoticia(IdNoticia);
            if (result)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
    }
}