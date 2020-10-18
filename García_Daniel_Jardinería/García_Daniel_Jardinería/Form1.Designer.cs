namespace García_Daniel_Jardinería
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.tbContrasenya = new System.Windows.Forms.TextBox();
            this.btnValidacion = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbUsuario
            // 
            this.tbUsuario.Location = new System.Drawing.Point(72, 276);
            this.tbUsuario.MaximumSize = new System.Drawing.Size(400, 22);
            this.tbUsuario.MinimumSize = new System.Drawing.Size(350, 22);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(376, 22);
            this.tbUsuario.TabIndex = 2;
            // 
            // tbContrasenya
            // 
            this.tbContrasenya.Location = new System.Drawing.Point(72, 337);
            this.tbContrasenya.MaximumSize = new System.Drawing.Size(400, 50);
            this.tbContrasenya.MinimumSize = new System.Drawing.Size(350, 22);
            this.tbContrasenya.Name = "tbContrasenya";
            this.tbContrasenya.Size = new System.Drawing.Size(376, 22);
            this.tbContrasenya.TabIndex = 3;
            // 
            // btnValidacion
            // 
            this.btnValidacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidacion.Location = new System.Drawing.Point(32, 438);
            this.btnValidacion.Name = "btnValidacion";
            this.btnValidacion.Size = new System.Drawing.Size(416, 87);
            this.btnValidacion.TabIndex = 4;
            this.btnValidacion.Text = "Validar";
            this.btnValidacion.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(34, 337);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(32, 22);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(34, 276);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(32, 22);
            this.panel2.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(72, 143);
            this.textBox1.MaximumSize = new System.Drawing.Size(400, 50);
            this.textBox1.MinimumSize = new System.Drawing.Size(350, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(350, 22);
            this.textBox1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 553);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnValidacion);
            this.Controls.Add(this.tbContrasenya);
            this.Controls.Add(this.tbUsuario);
            this.MaximumSize = new System.Drawing.Size(500, 600);
            this.MinimumSize = new System.Drawing.Size(500, 600);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.TextBox tbContrasenya;
        private System.Windows.Forms.Button btnValidacion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

