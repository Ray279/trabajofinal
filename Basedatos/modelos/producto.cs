using System;
using System.Collections.Generic;
using System.Text;

namespace Basedatos.modelos
{
    public class producto
    {
        public int id_Producto { get; set; }
        public string Nombre_Producto { get; set; }
        public string Marca_Producto { get; set; }
        public string Categoria_Producto { get; set; }
        public string Precio_Producto { get; set; }
        public string Stock_Producto { get; set; }
    }
}
