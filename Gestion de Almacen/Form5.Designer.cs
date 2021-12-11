
namespace Gestion_de_Almacen
{
    partial class Form5
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btncerrarsesion = new System.Windows.Forms.Button();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.txtPrecioProducto = new System.Windows.Forms.TextBox();
            this.txtMarcaProducto = new System.Windows.Forms.TextBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.txtStockProducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(509, 331);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.Location = new System.Drawing.Point(12, 368);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(139, 50);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btneliminar.Location = new System.Drawing.Point(282, 368);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(84, 50);
            this.btneliminar.TabIndex = 2;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btncerrarsesion
            // 
            this.btncerrarsesion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btncerrarsesion.Location = new System.Drawing.Point(382, 368);
            this.btncerrarsesion.Name = "btncerrarsesion";
            this.btncerrarsesion.Size = new System.Drawing.Size(139, 50);
            this.btncerrarsesion.TabIndex = 3;
            this.btncerrarsesion.Text = "Cerrar Sesion";
            this.btncerrarsesion.UseVisualStyleBackColor = true;
            this.btncerrarsesion.Click += new System.EventHandler(this.btncerrarsesion_Click);
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(709, 51);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(164, 23);
            this.txtNombreProducto.TabIndex = 4;
            // 
            // txtPrecioProducto
            // 
            this.txtPrecioProducto.Location = new System.Drawing.Point(709, 187);
            this.txtPrecioProducto.Name = "txtPrecioProducto";
            this.txtPrecioProducto.Size = new System.Drawing.Size(164, 23);
            this.txtPrecioProducto.TabIndex = 5;
            // 
            // txtMarcaProducto
            // 
            this.txtMarcaProducto.Location = new System.Drawing.Point(709, 100);
            this.txtMarcaProducto.Name = "txtMarcaProducto";
            this.txtMarcaProducto.Size = new System.Drawing.Size(164, 23);
            this.txtMarcaProducto.TabIndex = 6;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(709, 141);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(164, 23);
            this.txtCategoria.TabIndex = 7;
            // 
            // txtStockProducto
            // 
            this.txtStockProducto.Location = new System.Drawing.Point(709, 240);
            this.txtStockProducto.Name = "txtStockProducto";
            this.txtStockProducto.Size = new System.Drawing.Size(164, 23);
            this.txtStockProducto.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(556, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nombre del Producto";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(556, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Marca del Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(556, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Categoria_Producto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(556, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Precio del Producto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(556, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Stock del Producto";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLimpiar.Location = new System.Drawing.Point(168, 368);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(85, 50);
            this.btnLimpiar.TabIndex = 14;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 450);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStockProducto);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.txtMarcaProducto);
            this.Controls.Add(this.txtPrecioProducto);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.btncerrarsesion);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form5";
            this.Text = "Mantenimiento_de_Producto";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btncerrarsesion;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.TextBox txtPrecioProducto;
        private System.Windows.Forms.TextBox txtMarcaProducto;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.TextBox txtStockProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLimpiar;
    }
}