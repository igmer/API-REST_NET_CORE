using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NoticiasApi.Model
{
    public class Autor
    {
        [Key]
        public int AutorID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
    }
}
