using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Capadenegocio;
using Basedatos.modelos;

namespace Gestion_de_Almacen
{
    public partial class Form2 : Form
    {

        mantenimientoUsuario usuario;
        public Form2()
        {  

            InitializeComponent();
            SqlConnection conexion = new SqlConnection("server=DESKTOP-5G0QSH9 ;database=Almacen_de_productos; INTEGRATED SECURITY=true");

            usuario = new mantenimientoUsuario(conexion);
      
        }


        private void Registrar_Click(object sender, EventArgs e)
        { 
            {   

                usuarios usuarios = new usuarios();

                usuarios.Nombre = txtnombre.Text;
                usuarios.Apellido = txtapellido.Text;
                usuarios.UserName = txtnombreusuario.Text;
                usuarios.Telefono = txttelefono.Text;
                usuarios.Email = txtemail.Text;
                usuarios.Contraseña = txtcontraseña.Text;

                if (string.IsNullOrEmpty(txtnombre.Text))
                {
                    MessageBox.Show("Porvafor llene el campo Nombre");
                }
                else if (string.IsNullOrEmpty(txtapellido.Text))
                {
                    MessageBox.Show("Porvafor llene el campo Apellido");
                }
                else if (string.IsNullOrEmpty(txtnombreusuario.Text))
                {
                    MessageBox.Show("Porvafor llene el campo Nombre de Usuario");
                }
                else if (string.IsNullOrEmpty(txttelefono.Text))
                {
                    MessageBox.Show("Porvafor llene el campo Telefono");
                }
                else if (string.IsNullOrEmpty(txtemail.Text))
                {
                    MessageBox.Show("Porvafor llene el campo Correo Electronico");
                }
               
                else if (string.IsNullOrEmpty(txtcontraseña.Text))
                {
                    MessageBox.Show("Porvafor llene el campo Contraseña");
                }
                else if (string.IsNullOrEmpty(txtconfirmarcontraseña.Text))
                {
                    MessageBox.Show("Porvafor llene el campo Verificacion de contraseña");
                }
                else if (txtcontraseña.Text != txtconfirmarcontraseña.Text)
                {
                    MessageBox.Show(" Las contraseñas no coinciden ", "Advertencia ");
                }
                else
                {
                    usuario.Agregar(usuarios);
                    MessageBox.Show("Se ah agregado el usuario correctamente", "Notificacion");
                    Form1 form1 = new Form1();
                    form1.Show();
                    this.Close();
                }
            }
        }


        
    }
}
