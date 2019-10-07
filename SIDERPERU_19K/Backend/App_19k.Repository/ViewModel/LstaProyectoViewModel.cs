using System;

namespace App_19k.Repository.ViewModel
{
    public class LstaProyecto
    {
        public int ProyectoId { get; set; }
        public int VendedorId { get; set; }      
        public int DistribuidorId { get; set; }
        
        public string NProyecto { get; set; }
        public string TDireccion { get; set; }
        public string NVendedor { get; set; }     
        public string NDistribuidor { get; set; }              
        public string TEstatusProyecto { get; set; }
        public string NConstructora { get; set; }

    }
}