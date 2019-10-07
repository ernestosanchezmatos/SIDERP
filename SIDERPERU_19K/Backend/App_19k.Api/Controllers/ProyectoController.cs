﻿using System;
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
    public class ProyectoController : ControllerBase
    {

        private IProyectoService ProyectoService;

        public ProyectoController(IProyectoService ProyectoService)
        {
            this.ProyectoService = ProyectoService;
        }
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            return Ok(
                ProyectoService.DetalleXProyecto(id)
            );
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(
                ProyectoService.LstaProyectos()
            );
        }

        [HttpPost]
        public ActionResult Post([FromBody] Proyecto Proyecto)
        {
            return Ok(
                ProyectoService.Save(Proyecto)
            );
        }

        [HttpPut]
        public ActionResult Put([FromBody] Proyecto Proyecto)
        {
            return Ok(
                ProyectoService.Update(Proyecto)
            );
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok(
                ProyectoService.Delete(id)
            );
        }

    }
}