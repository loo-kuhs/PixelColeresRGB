
namespace PixelColeresRGB
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtRojo = new System.Windows.Forms.TextBox();
            this.txtVerde = new System.Windows.Forms.TextBox();
            this.txtAzul = new System.Windows.Forms.TextBox();
            this.lblRojo = new System.Windows.Forms.Label();
            this.lblVerde = new System.Windows.Forms.Label();
            this.lblAzul = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::PixelColeresRGB.Properties.Resources.HLSColorSpace;
            this.pictureBox1.Location = new System.Drawing.Point(25, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(404, 404);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // txtRojo
            // 
            this.txtRojo.Location = new System.Drawing.Point(70, 29);
            this.txtRojo.Name = "txtRojo";
            this.txtRojo.Size = new System.Drawing.Size(100, 20);
            this.txtRojo.TabIndex = 1;
            // 
            // txtVerde
            // 
            this.txtVerde.Location = new System.Drawing.Point(70, 70);
            this.txtVerde.Name = "txtVerde";
            this.txtVerde.Size = new System.Drawing.Size(100, 20);
            this.txtVerde.TabIndex = 2;
            // 
            // txtAzul
            // 
            this.txtAzul.Location = new System.Drawing.Point(70, 108);
            this.txtAzul.Name = "txtAzul";
            this.txtAzul.Size = new System.Drawing.Size(100, 20);
            this.txtAzul.TabIndex = 3;
            // 
            // lblRojo
            // 
            this.lblRojo.AutoSize = true;
            this.lblRojo.Location = new System.Drawing.Point(29, 32);
            this.lblRojo.Name = "lblRojo";
            this.lblRojo.Size = new System.Drawing.Size(29, 13);
            this.lblRojo.TabIndex = 4;
            this.lblRojo.Text = "Rojo";
            // 
            // lblVerde
            // 
            this.lblVerde.AutoSize = true;
            this.lblVerde.Location = new System.Drawing.Point(29, 73);
            this.lblVerde.Name = "lblVerde";
            this.lblVerde.Size = new System.Drawing.Size(35, 13);
            this.lblVerde.TabIndex = 5;
            this.lblVerde.Text = "Verde";
            // 
            // lblAzul
            // 
            this.lblAzul.AutoSize = true;
            this.lblAzul.Location = new System.Drawing.Point(29, 115);
            this.lblAzul.Name = "lblAzul";
            this.lblAzul.Size = new System.Drawing.Size(27, 13);
            this.lblAzul.TabIndex = 6;
            this.lblAzul.Text = "Azul";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAzul);
            this.groupBox1.Controls.Add(this.txtRojo);
            this.groupBox1.Controls.Add(this.lblVerde);
            this.groupBox1.Controls.Add(this.txtVerde);
            this.groupBox1.Controls.Add(this.lblRojo);
            this.groupBox1.Controls.Add(this.txtAzul);
            this.groupBox1.Location = new System.Drawing.Point(451, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 155);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RGB";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 433);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtRojo;
        private System.Windows.Forms.TextBox txtVerde;
        private System.Windows.Forms.TextBox txtAzul;
        private System.Windows.Forms.Label lblRojo;
        private System.Windows.Forms.Label lblVerde;
        private System.Windows.Forms.Label lblAzul;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

