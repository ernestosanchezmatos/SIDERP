using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using App_19k.Domain;
using App_19k.Repository.Context;
using App_19k.Repository.ViewModel;

namespace App_19k.Repository.Implementacion
{
    public class ProyectoRepository : IProyectoRepository
    {
        private ApplicationDbContext context;

        public ProyectoRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public Proyecto Get(int id)
        {
            var result = new Proyecto();
            try
            {
                result = context.Proyectos.Single(x => x.ProyectoId == id);
            }

            catch (System.Exception)
            {

                throw;
            }
            return result;
        }

        public IEnumerable<Proyecto> GetAll()
        {

            var result = new List<Proyecto>();
            try
            {
                result = context.Proyectos.ToList();
            }

            catch (System.Exception)
            {

                throw;
            }
            return result;
        }

        public bool Save(Proyecto entity)
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

        public bool Update(Proyecto entity)
        {
            try
            {
                var ProyectoOriginal = context.Proyectos.Single(
                    x => x.ProyectoId == entity.ProyectoId
                );

                ProyectoOriginal.ProyectoId = entity.ProyectoId;
                ProyectoOriginal.NProyecto = entity.NProyecto;
                ProyectoOriginal.DistritoId = entity.DistritoId;
                ProyectoOriginal.VendedorId = entity.VendedorId;
                ProyectoOriginal.NumArea = entity.NumArea;
                ProyectoOriginal.TTipoInversion = entity.TTipoInversion;
                ProyectoOriginal.TDireccion = entity.TDireccion;
                ProyectoOriginal.TEstatusProyecto = entity.TEstatusProyecto;
                ProyectoOriginal.NumLicencia = entity.NumLicencia;
                ProyectoOriginal.DInicioSuministro = entity.DInicioSuministro;
                ProyectoOriginal.NumTiempoSuministro = entity.NumTiempoSuministro;
                ProyectoOriginal.DFechaFinalObra = entity.DFechaFinalObra;
                ProyectoOriginal.TMarcaProveedorActual = entity.TMarcaProveedorActual;
                ProyectoOriginal.TTipoSolicitud = entity.TTipoSolicitud;
                ProyectoOriginal.MPrecioSolicitado = entity.MPrecioSolicitado;
                ProyectoOriginal.NConstructora = entity.NConstructora;
                ProyectoOriginal.TRucConstructora = entity.TRucConstructora;
                ProyectoOriginal.TActividadEconomicaEmpresa = entity.TActividadEconomicaEmpresa; 
                

                context.Update(ProyectoOriginal);
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

        public IEnumerable<LstaProyecto> LstaProyectos()
        {
            var lstaProyectos = from p in context.Proyectos
                                join v in context.Vendedores
                                on p.VendedorId equals v.VendedorId
                                join u in context.Usuarios
                                on v.VendedorId equals u.UsuarioId
                                join d in context.Distribuidores
                                on v.DistribuidorId equals d.DistribuidorId
                                select new {p.ProyectoId,d.DistribuidorId,v.VendedorId, p.NProyecto, p.TDireccion, u.NUsuario, d.NDistribuidor, p.TEstatusProyecto, p.NConstructora};

            var lstaProyectosRepo = new List<LstaProyecto>();

            foreach (var campo in lstaProyectos)
            {
                var objProyecto = new LstaProyecto();
                objProyecto.ProyectoId= campo.ProyectoId;
                objProyecto.DistribuidorId = campo.DistribuidorId;
                objProyecto.VendedorId= campo.VendedorId;           
                objProyecto.NProyecto = campo.NProyecto;
                objProyecto.TDireccion = campo.TDireccion;
                objProyecto.NVendedor = campo.NUsuario;
                objProyecto.NDistribuidor = campo.NDistribuidor;
                objProyecto.TEstatusProyecto = campo.TEstatusProyecto;
                objProyecto.NConstructora = campo.NConstructora;
                lstaProyectosRepo.Add(objProyecto);
            }
            return lstaProyectosRepo;


        }

        public DetalleProyecto DetalleXProyecto(int id)
        {
            var lstaProyectos = from p in context.Proyectos
                                join v in context.Vendedores
                                on p.VendedorId equals v.VendedorId
                                join u in context.Usuarios
                                on v.VendedorId equals u.UsuarioId
                                join d in context.Distribuidores
                                on v.DistribuidorId equals d.DistribuidorId
                                join distrito in context.Distritos
                                on p.DistritoId equals distrito.DistritoId
                                where p.ProyectoId==id
                                select new{
                                    p.ProyectoId,
                                    p.NProyecto,
                                    d.DistribuidorId,
                                    d.NDistribuidor,
                                    distrito.DistritoId,
                                    distrito.NDistrito,
                                    v.VendedorId,
                                    u.NUsuario,
                                    p.NumArea,
                                    p.TTipoInversion,
                                    p.TEstatusProyecto,
                                    p.TDireccion,
                                    p.NumLicencia,
                                    p.DInicioSuministro,
                                    p.NumTiempoSuministro,
                                    p.DFechaFinalObra,
                                    p.TMarcaProveedorActual,
                                    p.TTipoSolicitud,
                                    p.MPrecioSolicitado,
                                    p.NConstructora,
                                    p.TRucConstructora,
                                    p.TActividadEconomicaEmpresa,
                                };
            var detalleProyecto = new DetalleProyecto();

            detalleProyecto.ProyectoId = lstaProyectos.First().ProyectoId;
            detalleProyecto.NProyecto = lstaProyectos.First().NProyecto;
            detalleProyecto.DistribuidorId = lstaProyectos.First().DistribuidorId;
            detalleProyecto.NDistribuidor = lstaProyectos.First().NDistribuidor;
            detalleProyecto.DistritoId = lstaProyectos.First().DistritoId;
            detalleProyecto.NDistrito = lstaProyectos.First().NDistrito;
            detalleProyecto.VendedorId = lstaProyectos.First().VendedorId;
            detalleProyecto.NVendedor = lstaProyectos.First().NUsuario;
            detalleProyecto.NumArea = lstaProyectos.First().NumArea;
            detalleProyecto.TTipoInversion = lstaProyectos.First().TTipoInversion;
            detalleProyecto.TEstatusProyecto = lstaProyectos.First().TEstatusProyecto;
            detalleProyecto.TDireccion = lstaProyectos.First().TDireccion;
            detalleProyecto.NumLicencia = lstaProyectos.First().NumLicencia;
            detalleProyecto.DInicioSuministro = lstaProyectos.First().DInicioSuministro;
            detalleProyecto.NumTiempoSuministro = lstaProyectos.First().NumTiempoSuministro;
            detalleProyecto.DFechaFinalObra = lstaProyectos.First().DFechaFinalObra;
            detalleProyecto.TMarcaProveedorActual = lstaProyectos.First().TMarcaProveedorActual;

            detalleProyecto.TTipoSolicitud = lstaProyectos.First().TTipoSolicitud;
            detalleProyecto.MPrecioSolicitado = lstaProyectos.First().MPrecioSolicitado;
            detalleProyecto.NConstructora = lstaProyectos.First().NConstructora;
            detalleProyecto.TRucConstructora = lstaProyectos.First().TRucConstructora;
            detalleProyecto.TActividadEconomicaEmpresa = lstaProyectos.First().TActividadEconomicaEmpresa;


            return detalleProyecto; 
        }
    }
}