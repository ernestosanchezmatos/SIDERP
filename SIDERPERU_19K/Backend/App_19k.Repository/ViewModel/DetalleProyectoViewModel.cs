using App_19k.Domain;
using System;

namespace App_19k.Repository.ViewModel
{
    public class DetalleProyecto
    {
        public int ProyectoId { get; set; }
        public string NProyecto { get; set; }
        public int DistribuidorId { get; set; }
        public string NDistribuidor { get; set; }
        public int DistritoId { get; set; }     
        public string NDistrito { get; set; }
        public int VendedorId { get; set; }
        public string NVendedor { get; set; }
        public decimal NumArea { get; set; }
        public string TTipoInversion { get; set; }
        public string TEstatusProyecto { get; set; }
        public string TDireccion { get; set; }
        public long NumLicencia { get; set; }
        public DateTime DInicioSuministro { get; set; }
        public int NumTiempoSuministro { get; set; }
        public DateTime DFechaFinalObra { get; set; }
        public string TMarcaProveedorActual { get; set; }
        public string TTipoSolicitud { get; set; }
        public decimal MPrecioSolicitado { get; set; }
        public string NConstructora { get; set; }
        public string TRucConstructora { get; set; }
        public string TActividadEconomicaEmpresa { get; set; }

    }
}