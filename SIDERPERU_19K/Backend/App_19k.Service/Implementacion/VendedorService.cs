using System;
using System.Collections.Generic;
using System.Text;
using App_19k.Domain;
using App_19k.Repository;
using App_19k.Repository.Implementacion;
namespace App_19k.Service.Implementacion
{
    public class VendedorService : IVendedorService
    {

        private IVendedorRepository VendedorRepository;

        public VendedorService(IVendedorRepository VendedorRepository)
        {
            this.VendedorRepository = VendedorRepository;
        }    

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Vendedor Get(int id)
        {
            return VendedorRepository.Get(id);
        }

     

        public IEnumerable<Vendedor> GetAll()
        {
            return VendedorRepository.GetAll();
        }

        public bool Save(Vendedor entity)
        {
            return VendedorRepository.Save(entity);
        }    

        public bool Update(Vendedor entity)
        {
            throw new NotImplementedException();
        }

       
    }
}
