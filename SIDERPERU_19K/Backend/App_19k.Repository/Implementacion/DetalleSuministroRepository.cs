using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using App_19k.Domain;
using App_19k.Repository.Context;

namespace App_19k.Repository.Implementacion
{
    public class DetalleSuministroRepository : IDetalleSuministroRepository
    {
        private ApplicationDbContext context;

        public DetalleSuministroRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public DetalleSuministro Get(int id)
        {
            var result = new DetalleSuministro();
            try
            {
                result = context.DetalleSuministros.Single(x => x.DetalleSuministroId == id);
            }

            catch (System.Exception)
            {

                throw;
            }
            return result;
        }

        public IEnumerable<DetalleSuministro> GetAll()
        {

            var result = new List<DetalleSuministro>();
            try
            {
                result = context.DetalleSuministros.ToList();
            }

            catch (System.Exception)
            {

                throw;
            }
            return result;
        }

        public bool Save(DetalleSuministro entity)
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

        public bool Update(DetalleSuministro entity)
        {
            try
            {
                var DetalleSuministroOriginal = context.DetalleSuministros.Single(
                    x => x.DetalleSuministroId == entity.DetalleSuministroId
                );

                DetalleSuministroOriginal.DetalleSuministroId = entity.DetalleSuministroId;
                DetalleSuministroOriginal.NumCantidad = entity.NumCantidad;
                DetalleSuministroOriginal.ProyectoId= entity.ProyectoId;
                DetalleSuministroOriginal.SuministroId= entity.SuministroId;
                DetalleSuministroOriginal.TTipoCantidad= entity.TTipoCantidad;
                
                context.Update(DetalleSuministroOriginal);
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