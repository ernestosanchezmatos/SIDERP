namespace App_19k.Domain
{
    public class DetalleSuministro
    {
        public int DetalleSuministroId { get; set; }
        public int SuministroId { get; set; }
        public Suministro Suministro;
        public int ProyectoId { get; set; }
        public Proyecto Proyecto { get; set; }
        public int NumCantidad { get; set; }
        public string   TTipoCantidad { get; set; }
    }
}