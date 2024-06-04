using System.ComponentModel.DataAnnotations;


namespace Ap1_P1_LiamellCruz.Models
{
    public class Articulos
    {
        [Key]

        public int ArticulosId{ get; set; }
		[Required(ErrorMessage = "Campo Obligatorio")]

		public string Descripcion { get; set;}
		[Required(ErrorMessage = "Campo Obligatorio")]

		public decimal Costo { get; set;}
		[Required(ErrorMessage = "Campo Obligatorio")]

		public decimal Ganancia { get; set;}
		[Required(ErrorMessage = "Campo Obligatorio")]

		public decimal Precio { get; set; }
		

	}
}
