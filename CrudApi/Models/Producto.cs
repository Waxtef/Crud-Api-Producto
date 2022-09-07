using System.ComponentModel.DataAnnotations;

namespace CrudApi.Models
{
    public class Producto
    {
        [Key]
        public int id_Producto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; } 
        public decimal porcentaje_impuesto { get; set; }   

    }
}
