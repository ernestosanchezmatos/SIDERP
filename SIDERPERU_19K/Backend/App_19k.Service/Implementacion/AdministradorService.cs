using System;
using System.Collections.Generic;
using System.Text;
using App_19k.Domain;
using App_19k.Repository;
using App_19k.Repository.Implementacion;
namespace App_19k.Service.Implementacion
{
    public class AdministradorService : IAdministradorService
    {

        private IAdministradorRepository AdministradorRepository;

        public AdministradorService(IAdministradorRepository AdministradorRepository)
        {
            this.AdministradorRepository = AdministradorRepository;
        }    

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Administrador Get(int id)
        {
            return AdministradorRepository.Get(id);
        }

     

        public IEnumerable<Administrador> GetAll()
        {
            return AdministradorRepository.GetAll();
        }

        public bool Save(Administrador entity)
        {
            return AdministradorRepository.Save(entity);
        }    

        public bool Update(Administrador entity)
        {
            throw new NotImplementedException();
        }

       
    }
}
