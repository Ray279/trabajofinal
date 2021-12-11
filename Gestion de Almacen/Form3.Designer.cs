
namespace Gestion_de_Almacen
{
    partial class Form3
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
            this.btnmantenimientousuario = new System.Windows.Forms.Button();
            this.btnmantenimientoproducto = new System.Windows.Forms.Button();
            this.btncerrarsesion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnmantenimientousuario
            // 
            this.btnmantenimientousuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnmantenimientousuario.Location = new System.Drawing.Point(12, 36);
            this.btnmantenimientousuario.Name = "btnmantenimientousuario";
            this.btnmantenimientousuario.Size = new System.Drawing.Size(148, 74);
            this.btnmantenimientousuario.TabIndex = 0;
            this.btnmantenimientousuario.Text = "Mantenimiento de Usuario";
            this.btnmantenimientousuario.UseVisualStyleBackColor = true;
            this.btnmantenimientousuario.Click += new System.EventHandler(this.btnmantenimientousuario_Click);
            // 
            // btnmantenimientoproducto
            // 
            this.btnmantenimientoproducto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnmantenimientoproducto.Location = new System.Drawing.Point(12, 126);
            this.btnmantenimientoproducto.Name = "btnmantenimientoproducto";
            this.btnmantenimientoproducto.Size = new System.Drawing.Size(148, 72);
            this.btnmantenimientoproducto.TabIndex = 1;
            this.btnmantenimientoproducto.Text = "Mantenimiento de Producto";
            this.btnmantenimientoproducto.UseVisualStyleBackColor = true;
            this.btnmantenimientoproducto.Click += new System.EventHandler(this.btnmantenimientoproducto_Click);
            // 
            // btncerrarsesion
            // 
            this.btncerrarsesion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btncerrarsesion.Location = new System.Drawing.Point(166, 77);
            this.btncerrarsesion.Name = "btncerrarsesion";
            this.btncerrarsesion.Size = new System.Drawing.Size(148, 77);
            this.btncerrarsesion.TabIndex = 2;
            this.btncerrarsesion.Text = "Cerrar Sesion";
            this.btncerrarsesion.UseVisualStyleBackColor = true;
            this.btncerrarsesion.Click += new System.EventHandler(this.btncerrarsesion_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 233);
            this.Controls.Add(this.btncerrarsesion);
            this.Controls.Add(this.btnmantenimientoproducto);
            this.Controls.Add(this.btnmantenimientousuario);
            this.Name = "Form3";
            this.Text = "Tipo de mantenimiento";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnmantenimientousuario;
        private System.Windows.Forms.Button btnmantenimientoproducto;
        private System.Windows.Forms.Button btncerrarsesion;
    }
}