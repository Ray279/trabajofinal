using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Capadenegocio;
using System.Data.SqlClient;
using Basedatos.modelos; 

namespace Gestion_de_Almacen
{
    public partial class Form4 : Form
    {
        private int id;
        private usuarios usuarios=new usuarios();
        
            private mantenimientoUsuario mantenimientouser;
        public Form4()
        {
            InitializeComponent();
            SqlConnection conexion = new SqlConnection("server=DESKTOP-5G0QSH9 ;database=Almacen_de_productos; INTEGRATED SECURITY=true");

            mantenimientouser = new mantenimientoUsuario(conexion);

        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ah cerrado sesion correctamente", "Notificacion");
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            dgvusuarios.DataSource = mantenimientouser.Listar();
            dgvusuarios.Columns[0].Visible = false;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (id >= 0)
            {
               
                usuarios.Nombre = TxtNombre.Text;
                usuarios.UserName = TxtNombreusuario.Text;
                usuarios.Apellido= TxtApellido.Text;
                usuarios.Email = TxtEmail.Text;
                usuarios.Telefono = Txttelefono.Text;
                usuarios.Contraseña = TxtContraseña.Text;
                usuarios.Contraseña= TxtConfimarContra.Text;
                mantenimientouser.Actualizar(usuarios);
                dgvusuarios.Refresh();


            }

        }


        private void dgvusuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                id = Convert.ToInt32(dgvusuarios.Rows[e.RowIndex].Cells[0].Value.ToString());


                usuarios = mantenimientouser.Listarporid(id);
                TxtNombre.Text = usuarios.Nombre;
                TxtNombreusuario.Text = usuarios.UserName;
                TxtApellido.Text = usuarios.Apellido;
                TxtEmail.Text = usuarios.Email;
                Txttelefono.Text = usuarios.Telefono;
                TxtContraseña.Text = usuarios.Contraseña;

                MessageBox.Show("Se ah actualizado corretacmente");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            TxtNombre.Text = "";
            TxtNombreusuario.Text = "";
            TxtApellido.Text = "";
            TxtEmail.Text = "";
            Txttelefono.Text = "";
            TxtContraseña.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            mantenimientouser.Eliminar(id);
            MessageBox.Show("Se ah eliminado corretacmente");
            dgvusuarios.Refresh();
        }
    }
}
