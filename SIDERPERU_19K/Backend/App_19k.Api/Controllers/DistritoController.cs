using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using App_19k.Service;
using App_19k.Service.Implementacion;
using App_19k.Domain;

namespace App_19k.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DistritoController : ControllerBase
    {

        private IDistritoService DistritoService;

        public DistritoController(IDistritoService DistritoService)
        {
            this.DistritoService = DistritoService;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(
                DistritoService.GetAll()
            );
        }

        [HttpPost]
        public ActionResult Post([FromBody] Distrito Distrito)
        {
            return Ok(
                DistritoService.Save(Distrito)
            );
        }

        [HttpPut]
        public ActionResult Put([FromBody] Distrito Distrito)
        {
            return Ok(
                DistritoService.Update(Distrito)
            );
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok(
                DistritoService.Delete(id)
            );
        }

    }
}