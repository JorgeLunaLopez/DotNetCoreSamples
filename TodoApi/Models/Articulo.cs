namespace TodoApi.Models
{
    public class Articulo
    {
        public long ID { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public int Stock { get; set; }
        public string Foto { get; set; }
    }
}