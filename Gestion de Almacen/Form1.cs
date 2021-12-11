using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using Capadenegocio;
using Basedatos.modelos;


namespace Gestion_de_Almacen
{
    public partial class Form1 : Form
    {
        private mantenimientoUsuario mantenimientouser;
        public Form1()
        {

            InitializeComponent();
           SqlConnection conexion = new SqlConnection("server=DESKTOP-5G0QSH9 ;database=Almacen_de_productos; INTEGRATED SECURITY=true");

            mantenimientouser = new mantenimientoUsuario(conexion);
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            bool boton;
            boton = mantenimientouser.Leer(txtuser.Text);

            if (string.IsNullOrEmpty(txtuser.Text))
            {
                MessageBox.Show("Porfavor llene el campo Nombre de usuario", "advertencia");
            }
            else if (string.IsNullOrEmpty(txtpass.Text))
            {
                MessageBox.Show("Porfavor llene el campo Contraseña", "advertencia");
            }
            else
            {
                if (boton == true)
                {
                    usuarios usuarios = mantenimientouser.usuarios(txtuser.Text);

                    if (txtpass.Text != usuarios.Contraseña)
                    {
                        MessageBox.Show("La contraseña es incorrecta");
                    }
                    else if (txtuser.Text != usuarios.UserName)
                    {
                        MessageBox.Show("El Nombre de usuario es incorrecto");
                    }
                    else 
                    {
                        Form3 form3 = new Form3();
                        form3.Show();
                    }
                }
                else
                {
                    MessageBox.Show("El Usuario o la contraseña  no existe", "advertencia");
                } 
            }
            
        }

        private void linkcuenta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
