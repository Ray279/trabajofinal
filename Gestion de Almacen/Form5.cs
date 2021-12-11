using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Basedatos.modelos;
using Capadenegocio;



namespace Gestion_de_Almacen
{
    public partial class Form5 : Form
    {
        private int id;
        private producto producto= new producto();
  
        private mantenimientoProducto mantenimientoProducto;
        public Form5()
        {
            InitializeComponent();
            SqlConnection conexion = new SqlConnection("server=DESKTOP-5G0QSH9 ;database=Almacen_de_productos; INTEGRATED SECURITY=true");
            mantenimientoProducto= new mantenimientoProducto(conexion);
        }

        private void btncerrarsesion_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {  
            if (id >= 0)
            {
                
                txtNombreProducto.Text = producto.Nombre_Producto;
                txtMarcaProducto.Text = producto.Marca_Producto;
                txtCategoria.Text = producto.Categoria_Producto;
                txtPrecioProducto.Text = producto.Precio_Producto;
                txtStockProducto.Text = producto.Stock_Producto;
                mantenimientoProducto.Agregar(producto);

                MessageBox.Show("Se ah agregado corretacmente");

                dataGridView1.Refresh();
            }
            
           

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = mantenimientoProducto.Listar();
            
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            mantenimientoProducto.Eliminar(id);
            MessageBox.Show("Se ah eliminado corretacmente");
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());


               
                txtNombreProducto.Text = producto.Nombre_Producto;
                txtMarcaProducto.Text = producto.Marca_Producto;
                txtCategoria.Text = producto.Categoria_Producto;
                txtPrecioProducto.Text = producto.Precio_Producto;
                txtStockProducto.Text = producto.Stock_Producto;
                producto = mantenimientoProducto.producto(id);

                MessageBox.Show("Se ah actualizado corretacmente");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombreProducto.Text = "";
            txtMarcaProducto.Text ="";
            txtCategoria.Text = "";
            txtPrecioProducto.Text = "";
            txtStockProducto.Text = "";
        }
    }
}
