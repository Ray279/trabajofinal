using System;
using System.Collections.Generic;
using System.Text;
using Basedatos;
using Basedatos.modelos;
using System.Data;
using System.Data.SqlClient;

namespace Capadenegocio
{
   public class mantenimientoUsuario
    {
        private repositorioUsuario Repost;

        public mantenimientoUsuario(SqlConnection sqlConnection)
        {
            Repost = new repositorioUsuario(sqlConnection);
        }

        public bool Agregar(usuarios usuario)
        {
            return Repost.Agregar(usuario);

        }

        public bool Eliminar(int iD)
        {
            return Repost.Eliminar(iD);
        }

        public DataTable Listar()
        {
            return Repost.Listar();
        }

        public bool Actualizar(usuarios usuario)
        {
            return Repost.Actualizar(usuario);

        }

        public bool Leer(String nombredeusuario)
        {
            return Repost.Leer(nombredeusuario);
        }

        public usuarios usuarios(string nombreusuario)
        {
            return Repost.EnlistarPorUsuario(nombreusuario);
        }

        public usuarios Listarporid(int id)
        {
            return Repost.EnlistarPorid(id);
        }

    }
}
