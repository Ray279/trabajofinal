using System;
using System.Data.SqlClient;
using Basedatos.modelos;
using System.Data;
using Basedatos;


namespace Capadenegocio
{
    public class mantenimientoProducto
    {
        private repositorioProducto Repost;

        public mantenimientoProducto(SqlConnection sqlConnection)
        {
            Repost = new repositorioProducto(sqlConnection);
        }

        public bool Agregar(producto productos)
        {
            return Repost.Agregar(productos);

        }

        public bool Eliminar(int iD)
        {
            return Repost.Eliminar(iD);
        }

        public DataTable Listar()
        {
            return Repost.Listar();
        }

        public bool Actualizar(producto productos)
        {
            return Repost.Actualizar(productos);
        }

        public producto producto(int id)
        {
            return Repost.EnlistarPorid(id);
        }
    }
}
