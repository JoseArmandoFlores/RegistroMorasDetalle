using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RegistroMorasConDetalle.BLL;
using RegistroMorasConDetalle.Models;

namespace PrestamosAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrestamosController : ControllerBase
    {
        // GET: api/Prestamos
        [HttpGet]
        public ActionResult<IEnumerable<Prestamos>> Get()
        {
            return PrestamosBLL.GetPretamo();
        }

        // GET: api/Prestamos/2
        [HttpGet("{id}")]
        public ActionResult<Prestamos> Get(int id)
        {
            return PrestamosBLL.Buscar(id);
        }

        // POST: api/Prestamos
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Prestamos/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
