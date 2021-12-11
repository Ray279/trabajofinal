using System;
using System.Data.SqlClient;
using Basedatos.modelos;
using System.Data;

namespace Basedatos
{
    public class repositorioProducto
    {
        private SqlConnection conexion;
        public repositorioProducto(SqlConnection sqlConnection)
        {
            conexion = sqlConnection;
        }
        public bool Agregar(producto productos)
        {
            SqlCommand command = new SqlCommand("insert into Productos(Nombre_Producto,Marca_Producto,Categoria_Producto,Precio_Producto,Stock_Producto) values(@Nombre_Producto,@Marca_Producto,@Categoria_Producto,@Precio_Producto,@Stock_Producto) ", conexion);
            command.Parameters.AddWithValue("@Nombre_Producto", productos.Nombre_Producto);
            command.Parameters.AddWithValue("@Marca_Producto", productos.Marca_Producto);
            command.Parameters.AddWithValue("@Categoria_Producto", productos.Categoria_Producto);
            command.Parameters.AddWithValue("@Precio_Producto", productos.Precio_Producto);
            command.Parameters.AddWithValue("@Stock_Producto", productos.Stock_Producto);


            return Ejecutar_DML(command);
        }
        public bool Eliminar(int ID)
        {
            SqlCommand sqlCommand = new SqlCommand("delete Productos where id_Producto = @id_Producto", conexion);

            sqlCommand.Parameters.AddWithValue("@id_Producto", ID);

            return Ejecutar_DML(sqlCommand);
        }

        public DataTable Listar()
        {
            SqlDataAdapter sqlData = new SqlDataAdapter("Select *from Productos_del_Almacen", conexion);
            return ObtenerDatos(sqlData);
        }


        public bool Actualizar(producto productos)
        {
            SqlCommand command = new SqlCommand("update Productos set Nombre_Producto=@Nombre_Producto,Marca_Producto=@Marca_Producto,Categoria_Producto=,Precio_Producto=@Precio_Producto,Stock_Producto=@Stock_Producto where id_Producto=@id ", conexion);
            command.Parameters.AddWithValue("@Nombre_Producto", productos.Nombre_Producto);
            command.Parameters.AddWithValue("@Marca_Producto", productos.Marca_Producto);
            command.Parameters.AddWithValue("@Categoria_Producto", productos.Categoria_Producto);
            command.Parameters.AddWithValue("@Precio_Producto", productos.Precio_Producto);
            command.Parameters.AddWithValue("@Stock_Producto", productos.Stock_Producto);
            command.Parameters.AddWithValue("@id", productos.id_Producto);

            return Ejecutar_DML(command);
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
            catch
            {
                return false;
            }
        }
        public producto EnlistarPorid(int id)
        {
            try
            {
                conexion.Open();

                producto producto = new producto();

                SqlCommand sqlCommand = new SqlCommand("select * from Productos_del_Almacen where id_Producto = @id", conexion);

                sqlCommand.Parameters.AddWithValue("@id", id);

                SqlDataReader dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    producto.id_Producto = dataReader.IsDBNull(0) ? 0 : dataReader.GetInt32(0);
                    producto.Nombre_Producto = dataReader.IsDBNull(1) ? "NULL" : dataReader.GetString(1);
                    producto.Marca_Producto = dataReader.IsDBNull(2) ? "NULL" : dataReader.GetString(2);
                    producto.Categoria_Producto = dataReader.IsDBNull(3) ? "NULL" : dataReader.GetString(3);
                    producto.Precio_Producto = dataReader.IsDBNull(4) ? "NULL" : dataReader.GetString(4);
                    producto.Stock_Producto = dataReader.IsDBNull(5) ? "NULL" : dataReader.GetString(5);
                    

                }

                dataReader.Close();
                dataReader.Dispose();

                conexion.Close();

                return producto;
            }
            catch (Exception e)
            {
                return null;
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
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
}
