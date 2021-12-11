using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using Basedatos.modelos;
using System.Data;

namespace Basedatos
{
    public class repositorioUsuario
    {
        private SqlConnection conexion;
        public repositorioUsuario(SqlConnection sqlConnection)
        {
            conexion = sqlConnection;
        }
        public bool Agregar(usuarios usuario)
        {
            SqlCommand command = new SqlCommand("insert into Usuarios(UserName,Nombre,Apellido,Telefono,Email,Contraseña)values(@UserName,@Nombre,@Apellido,@Telefono,@Email,@Contraseña)", conexion);
            command.Parameters.AddWithValue("@UserName", usuario.UserName);
            command.Parameters.AddWithValue("@Nombre", usuario.Nombre);
            command.Parameters.AddWithValue("@Apellido", usuario.Apellido);
            command.Parameters.AddWithValue("@Telefono", usuario.Telefono);
            command.Parameters.AddWithValue("@Email", usuario.Email);
            command.Parameters.AddWithValue("@Contraseña", usuario.Contraseña);


            
            return Ejecutar_DML(command);
        }

        public bool Eliminar(int ID)
        {
            SqlCommand sqlCommand = new SqlCommand("delete Usuarios where id_User = @id_User", conexion);

            sqlCommand.Parameters.AddWithValue("@id_User", ID);

            return Ejecutar_DML(sqlCommand);
        }

        public DataTable Listar()
        {
            SqlDataAdapter sqlData = new SqlDataAdapter("Select *from Usuarios", conexion);
            return ObtenerDatos(sqlData);
        }

        public bool Actualizar(usuarios usuario)
        {
            SqlCommand command = new SqlCommand("update Usuarios set UserName=@UserName,Nombre=@Nombre,Apellido=@Apellido,Telefono=@Telefono,Email=@Email,Contraseña=@Contraseña where id_User=@id", conexion);
            command.Parameters.AddWithValue("@UserName", usuario.UserName);
            command.Parameters.AddWithValue("@Nombre", usuario.Nombre);
            command.Parameters.AddWithValue("@Apellido", usuario.Apellido);
            command.Parameters.AddWithValue("@Telefono", usuario.Telefono);
            command.Parameters.AddWithValue("@Email", usuario.Email);
            command.Parameters.AddWithValue("@Contraseña", usuario.Contraseña);
            command.Parameters.AddWithValue("@id", usuario.id_User);

            return Ejecutar_DML(command);
        }

        public bool Leer(string nombreUsuario)
        {
            try
            {
                int Exists = 0;

                conexion.Open();

                SqlCommand command = new SqlCommand("select count(UserName) from Usuarios where UserName = @UserName", conexion);

                command.Parameters.AddWithValue("@UserName", nombreUsuario);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Exists = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                }

                reader.Close();
                reader.Dispose();

                conexion.Close();

                if (Exists >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception e)
            {
                conexion.Close();

                return false;
            }
        }

        public usuarios EnlistarPorUsuario(string nombreUsuario)
        {
            try
            {
                conexion.Open();

                usuarios usuarios = new usuarios();

                SqlCommand sqlCommand = new SqlCommand("select * from Usuarios where UserName = @UserName", conexion);

                sqlCommand.Parameters.AddWithValue("@UserName", nombreUsuario);

                SqlDataReader dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    usuarios.id_User = dataReader.IsDBNull(0) ? 0 : dataReader.GetInt32(0);
                    usuarios.Nombre = dataReader.IsDBNull(1) ? "NULL" : dataReader.GetString(1);
                    usuarios.Apellido = dataReader.IsDBNull(2) ? "NULL" : dataReader.GetString(2);
                    usuarios.Email = dataReader.IsDBNull(3) ? "NULL" : dataReader.GetString(3);
                    usuarios.UserName = dataReader.IsDBNull(4) ? "NULL" : dataReader.GetString(4);
                    usuarios.Contraseña = dataReader.IsDBNull(5) ? "NULL" : dataReader.GetString(5);
                    
                }

                dataReader.Close();
                dataReader.Dispose();

                conexion.Close();

                return usuarios;
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public usuarios EnlistarPorid(int id)
        {
            try
            {
                conexion.Open();

                usuarios usuarios = new usuarios();

                SqlCommand sqlCommand = new SqlCommand("select * from Usuarios where id_User = @id", conexion);

                sqlCommand.Parameters.AddWithValue("@id", id);

                SqlDataReader dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    usuarios.id_User = dataReader.IsDBNull(0) ? 0 : dataReader.GetInt32(0);
                    usuarios.Nombre = dataReader.IsDBNull(1) ? "NULL" : dataReader.GetString(1);
                    usuarios.Apellido = dataReader.IsDBNull(2) ? "NULL" : dataReader.GetString(2);
                    usuarios.Email = dataReader.IsDBNull(3) ? "NULL" : dataReader.GetString(3);
                    usuarios.UserName = dataReader.IsDBNull(4) ? "NULL" : dataReader.GetString(4);
                    usuarios.Contraseña = dataReader.IsDBNull(5) ? "NULL" : dataReader.GetString(5);

                }

                dataReader.Close();
                dataReader.Dispose();

                conexion.Close();

                return usuarios;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public bool Ejecutar_DML(SqlCommand query)
        {
            try
            {
                conexion.Open();

                query.ExecuteNonQuery();

                conexion.Close();

                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        private DataTable ObtenerDatos(SqlDataAdapter sqlData)
        {
            try
            {
                DataTable data = new DataTable();
                conexion.Open();
                sqlData.Fill(data);
                conexion.Close();
                return data;
            }
            catch
            {
                return null;
            }
        }
    }
}
