using System;
using System.Collections.Generic;
using System.Text;

namespace Basedatos.modelos
{
    public class usuarios
    {
        public int id_User { get; set; }
        public string UserName { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Contraseña { get; set; }
    }
}
