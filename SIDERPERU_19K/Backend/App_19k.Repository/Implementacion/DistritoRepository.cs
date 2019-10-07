using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using App_19k.Domain;
using App_19k.Repository.Context;

namespace App_19k.Repository.Implementacion
{
    public class DistritoRepository : IDistritoRepository
    {
        private ApplicationDbContext context;

        public DistritoRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public Distrito Get(int id)
        {
            var result = new Distrito();
            try
            {
                result = context.Distritos.Single(x => x.DistritoId == id);
            }

            catch (System.Exception)
            {

                throw;
            }
            return result;
        }

        public IEnumerable<Distrito> GetAll()
        {

            var result = new List<Distrito>();
            try
            {
                result = context.Distritos.ToList();
            }

            catch (System.Exception)
            {

                throw;
            }
            return result;
        }

        public bool Save(Distrito entity)
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

        public bool Update(Distrito entity)
        {
            try
            {
                var DistritoOriginal = context.Distritos.Single(
                    x => x.DistritoId == entity.DistritoId
                );

                DistritoOriginal.DistritoId = entity.DistritoId;
                DistritoOriginal.NDistrito = entity.NDistrito;
                DistritoOriginal.ProvinciaId = entity.ProvinciaId;
                context.Update(DistritoOriginal);
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