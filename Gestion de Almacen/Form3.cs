using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Gestion_de_Almacen
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnmantenimientousuario_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Close();
        }

        private void btnmantenimientoproducto_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Close();
        }

        private void btncerrarsesion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ah cerrado sesion correctamente", "Notificacion");
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
