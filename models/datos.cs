namespace Examen_Tercer_Parcial.models
{
    public class datos
    {
        public int Id { get; set; } 
        public int? Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Direccion { get; set; } = null!;
        public string Telefono { get; set; } = null!;

        public DateTime FechaCreacion { get; set; }

    }
}
