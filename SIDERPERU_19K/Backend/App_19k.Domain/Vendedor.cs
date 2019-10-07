namespace App_19k.Domain
{
    public class Vendedor
    {                   
        public int VendedorId { get; set; }
        public Usuario VendedorNavigation { get; set; }
        public string TDni { get; set; }    
        public int DistribuidorId { get; set; }
        public Distribuidor Distribuidor { get; set; }
        public string TEstado { get; set; }
    }
}