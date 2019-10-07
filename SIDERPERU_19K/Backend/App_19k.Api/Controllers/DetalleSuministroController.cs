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
    public class DetalleSuministroController : ControllerBase
    {

        private IDetalleSuministroService DetalleSuministroService;

        public DetalleSuministroController(IDetalleSuministroService DetalleSuministroService)
        {
            this.DetalleSuministroService = DetalleSuministroService;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(
                DetalleSuministroService.GetAll()
            );
        }

        [HttpPost]
        public ActionResult Post([FromBody] DetalleSuministro DetalleSuministro)
        {
            return Ok(
                DetalleSuministroService.Save(DetalleSuministro)
            );
        }

        [HttpPut]
        public ActionResult Put([FromBody] DetalleSuministro DetalleSuministro)
        {
            return Ok(
                DetalleSuministroService.Update(DetalleSuministro)
            );
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok(
                DetalleSuministroService.Delete(id)
            );
        }

    }
}