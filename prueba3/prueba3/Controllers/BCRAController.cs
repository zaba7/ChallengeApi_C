using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using prueba3.Modelos;
using prueba3.Modelos.Dto;

namespace prueba3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BCRAController : ControllerBase
    {
        [HttpGet] //VERBO
        [ProducesResponseType(StatusCodes.Status200OK)]

        public ActionResult<IEnumerable<Datos>> GetDatos() //conActioR se define el tipo de retorno
        {
            return Ok(DatosStore.datos_list);
        }

        [HttpPatch("id:int")]
        ///documentar codigo de estado
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public IActionResult UpdatePartialDatos(int id, JsonPatchDocument<Datos> patchDto)
        {
            if (patchDto == null || id == 0)//validaciones
            {
                return BadRequest();
            }
            var mi_dato = DatosStore.datos_list.FirstOrDefault(v => v.id == id);
            patchDto.ApplyTo(mi_dato);

            return NoContent();
        }
    }
}
