using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boleteria.Classes
{
    class Boletos
    {
        [Required(ErrorMessage = "El Nombre Es Obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El Correo Es Obligatorio")]
        public string? Correo { get; set; }

        [Required(ErrorMessage = "El Numero Telefonico  Es Obligatorio")]
        [MinLength(10, ErrorMessage = "El Numero Telefonico Debe Ser A 10 Digitos")]
        [MaxLength(10, ErrorMessage = "El Numero Telefonico Debe Ser A 10 Digitos")]
        public string Numero { get; set; }

        public string Asiento { get; set; }

    }
}
