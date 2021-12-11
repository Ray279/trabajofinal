
namespace Gestion_de_Almacen
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.btnAcceder = new System.Windows.Forms.Button();
            this.linkcuenta = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(218, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(84, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(74, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contraseña";
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(183, 141);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(180, 23);
            this.txtuser.TabIndex = 3;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(183, 83);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(180, 23);
            this.txtpass.TabIndex = 4;
            // 
            // btnAcceder
            // 
            this.btnAcceder.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAcceder.Location = new System.Drawing.Point(202, 235);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Size = new System.Drawing.Size(106, 33);
            this.btnAcceder.TabIndex = 5;
            this.btnAcceder.Text = "Acceder";
            this.btnAcceder.UseVisualStyleBackColor = true;
            this.btnAcceder.Click += new System.EventHandler(this.btnAcceder_Click);
            // 
            // linkcuenta
            // 
            this.linkcuenta.AutoSize = true;
            this.linkcuenta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkcuenta.Location = new System.Drawing.Point(183, 275);
            this.linkcuenta.Name = "linkcuenta";
            this.linkcuenta.Size = new System.Drawing.Size(136, 21);
            this.linkcuenta.TabIndex = 6;
            this.linkcuenta.TabStop = true;
            this.linkcuenta.Text = "¿tienes cuenta?";
            this.linkcuenta.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkcuenta_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(409, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(357, 306);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 305);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkcuenta);
            this.Controls.Add(this.btnAcceder);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Button btnAcceder;
        private System.Windows.Forms.LinkLabel linkcuenta;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

