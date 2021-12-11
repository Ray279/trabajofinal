
namespace Gestion_de_Almacen
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvusuarios = new System.Windows.Forms.DataGridView();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.TxtContraseña = new System.Windows.Forms.TextBox();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.Txttelefono = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtNombreusuario = new System.Windows.Forms.TextBox();
            this.TxtConfimarContra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvusuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvusuarios
            // 
            this.dgvusuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvusuarios.Location = new System.Drawing.Point(58, 160);
            this.dgvusuarios.MultiSelect = false;
            this.dgvusuarios.Name = "dgvusuarios";
            this.dgvusuarios.RowTemplate.Height = 25;
            this.dgvusuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvusuarios.Size = new System.Drawing.Size(681, 282);
            this.dgvusuarios.TabIndex = 0;
            this.dgvusuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvusuarios_CellClick);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCerrarSesion.Location = new System.Drawing.Point(616, 457);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(123, 45);
            this.btnCerrarSesion.TabIndex = 2;
            this.btnCerrarSesion.Text = "Cerrar Sesion";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEliminar.Location = new System.Drawing.Point(449, 458);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(123, 45);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnActualizar.Location = new System.Drawing.Point(58, 458);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(123, 45);
            this.btnActualizar.TabIndex = 4;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLimpiar.Location = new System.Drawing.Point(263, 458);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(123, 45);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // TxtContraseña
            // 
            this.TxtContraseña.Location = new System.Drawing.Point(578, 67);
            this.TxtContraseña.Name = "TxtContraseña";
            this.TxtContraseña.Size = new System.Drawing.Size(149, 23);
            this.TxtContraseña.TabIndex = 7;
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(185, 46);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(149, 23);
            this.TxtApellido.TabIndex = 8;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(185, 9);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(149, 23);
            this.TxtNombre.TabIndex = 9;
            // 
            // Txttelefono
            // 
            this.Txttelefono.Location = new System.Drawing.Point(185, 121);
            this.Txttelefono.Name = "Txttelefono";
            this.Txttelefono.Size = new System.Drawing.Size(149, 23);
            this.Txttelefono.TabIndex = 10;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(578, 30);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(149, 23);
            this.TxtEmail.TabIndex = 11;
            // 
            // TxtNombreusuario
            // 
            this.TxtNombreusuario.Location = new System.Drawing.Point(185, 80);
            this.TxtNombreusuario.Name = "TxtNombreusuario";
            this.TxtNombreusuario.Size = new System.Drawing.Size(149, 23);
            this.TxtNombreusuario.TabIndex = 12;
            // 
            // TxtConfimarContra
            // 
            this.TxtConfimarContra.Location = new System.Drawing.Point(578, 116);
            this.TxtConfimarContra.Name = "TxtConfimarContra";
            this.TxtConfimarContra.Size = new System.Drawing.Size(149, 23);
            this.TxtConfimarContra.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Nombre de Usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Telefono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(518, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(487, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 19;
            this.label6.Text = "Contraseña";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(430, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "Confirmar Contraseña";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 524);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtConfimarContra);
            this.Controls.Add(this.TxtNombreusuario);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.Txttelefono);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtApellido);
            this.Controls.Add(this.TxtContraseña);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.dgvusuarios);
            this.Name = "Form4";
            this.Text = "Mantenimiento de Usuario";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvusuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvusuarios;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox TxtContraseña;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox Txttelefono;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtNombreusuario;
        private System.Windows.Forms.TextBox TxtConfimarContra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}