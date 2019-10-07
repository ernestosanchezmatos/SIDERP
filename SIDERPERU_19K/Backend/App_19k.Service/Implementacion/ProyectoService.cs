using System;
using System.Collections.Generic;
using System.Text;
using App_19k.Domain;
using App_19k.Repository;
using App_19k.Repository.Implementacion;
using App_19k.Repository.ViewModel;
namespace App_19k.Service.Implementacion
{
    public class ProyectoService : IProyectoService
    {

        private IProyectoRepository ProyectoRepository;

        public ProyectoService(IProyectoRepository ProyectoRepository)
        {
            this.ProyectoRepository = ProyectoRepository;
        }    

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public DetalleProyecto DetalleXProyecto(int id)
        {
            return ProyectoRepository.DetalleXProyecto(id);
        }

        public Proyecto Get(int id)
        {
            return ProyectoRepository.Get(id);
        }

     

        public IEnumerable<Proyecto> GetAll()
        {
            return ProyectoRepository.GetAll();
        }

        public IEnumerable<LstaProyecto> LstaProyectos()
        {
            return ProyectoRepository.LstaProyectos();
        }

        public bool Save(Proyecto entity)
        {
            return ProyectoRepository.Save(entity);
        }    

        public bool Update(Proyecto entity)
        {
            throw new NotImplementedException();
        }

   
    }
}
