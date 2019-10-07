using System;
using System.Collections.Generic;
using System.Text;
using App_19k.Domain;
using App_19k.Repository.ViewModel;
namespace App_19k.Repository.Implementacion
{
    public interface IProyectoRepository : ICrudRepository<Proyecto>
    {
        IEnumerable<LstaProyecto> LstaProyectos();
        DetalleProyecto DetalleXProyecto(int id);
    }
}