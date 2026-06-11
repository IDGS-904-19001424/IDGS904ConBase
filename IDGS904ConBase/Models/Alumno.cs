using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IDGS904ConBase.Models
{
    public class Alumno
    {

        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public String Nombre { get; set; }
        
        [StringLength(100)]
        public String Apaterno { get; set; }
        
        [StringLength(100)]

        public String Amaterno { get; set; }

        public int Edad { get; set; }
        public String Correo { get; set; }

    }
}