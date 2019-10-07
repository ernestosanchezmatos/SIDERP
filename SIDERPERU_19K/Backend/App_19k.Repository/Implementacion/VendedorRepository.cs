using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using App_19k.Domain;
using App_19k.Repository.Context;

namespace App_19k.Repository.Implementacion
{
    public class VendedorRepository : IVendedorRepository
    {
        private ApplicationDbContext context;

        public VendedorRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public Vendedor Get(int id)
        {
            var result = new Vendedor();
            try
            {
                result = context.Vendedores.Single(x => x.VendedorId == id);
            }

            catch (System.Exception)
            {

                throw;
            }
            return result;
        }

        public IEnumerable<Vendedor> GetAll()
        {

            var result = new List<Vendedor>();
            try
            {
                result = context.Vendedores.ToList();
            }

            catch (System.Exception)
            {

                throw;
            }
            return result;
        }

        public bool Save(Vendedor entity)
        {
            try
            {
                context.Add(entity);
                context.SaveChanges();
            }
            catch (System.Exception)
            {

                return false;
            }
            return true;
        }

        public bool Update(Vendedor entity)
        {
            try
            {
                var VendedorOriginal = context.Vendedores.Single(
                    x => x.VendedorId == entity.VendedorId
                );

                VendedorOriginal.VendedorId = entity.VendedorId;
                VendedorOriginal.VendedorNavigation.NUsuario = entity.VendedorNavigation.NUsuario;
                VendedorOriginal.TDni = entity.TDni;
                VendedorOriginal.TEstado = entity.TEstado;          
                VendedorOriginal.DistribuidorId = entity.DistribuidorId;

                context.Update(VendedorOriginal);
                context.SaveChanges();
            }
            catch (System.Exception)
            {
                return false;
            }
            return true;
        }

        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}