using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NoticiasApi.Model
{
	public class Noticia
	{
		[Key]
		public int NoticiaID { get; set; }
		
		public String Titulo { get; set; }
		public String Descripcion { get; set; }
		public String Contenido { get; set; }
		public DateTime Fecha { get; set; }
		[ForeignKey("AutorID")]
		public int AutorID { get; set; }
		
		public  Autor Autor { get; set; }
	}
}
