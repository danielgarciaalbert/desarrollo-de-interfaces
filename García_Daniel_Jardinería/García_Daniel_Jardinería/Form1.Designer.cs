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
            this.usuario = new System.Windows.Forms.Label();
            this.contraseña = new System.Windows.Forms.Label();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.tbContrasenya = new System.Windows.Forms.TextBox();
            this.btnValidacion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usuario
            // 
            this.usuario.AutoSize = true;
            this.usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuario.Location = new System.Drawing.Point(28, 42);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(77, 20);
            this.usuario.TabIndex = 0;
            this.usuario.Text = "Usuario: ";
            // 
            // contraseña
            // 
            this.contraseña.AutoSize = true;
            this.contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contraseña.Location = new System.Drawing.Point(28, 109);
            this.contraseña.Name = "contraseña";
            this.contraseña.Size = new System.Drawing.Size(100, 20);
            this.contraseña.TabIndex = 1;
            this.contraseña.Text = "Contraseña:";
            // 
            // tbUsuario
            // 
            this.tbUsuario.Location = new System.Drawing.Point(177, 42);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(163, 22);
            this.tbUsuario.TabIndex = 2;
            // 
            // tbContrasenya
            // 
            this.tbContrasenya.Location = new System.Drawing.Point(177, 109);
            this.tbContrasenya.Name = "tbContrasenya";
            this.tbContrasenya.Size = new System.Drawing.Size(163, 22);
            this.tbContrasenya.TabIndex = 3;
            // 
            // btnValidacion
            // 
            this.btnValidacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidacion.Location = new System.Drawing.Point(32, 176);
            this.btnValidacion.Name = "btnValidacion";
            this.btnValidacion.Size = new System.Drawing.Size(308, 43);
            this.btnValidacion.TabIndex = 4;
            this.btnValidacion.Text = "Validar";
            this.btnValidacion.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 241);
            this.Controls.Add(this.btnValidacion);
            this.Controls.Add(this.tbContrasenya);
            this.Controls.Add(this.tbUsuario);
            this.Controls.Add(this.contraseña);
            this.Controls.Add(this.usuario);
            this.MaximumSize = new System.Drawing.Size(393, 288);
            this.MinimumSize = new System.Drawing.Size(393, 288);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usuario;
        private System.Windows.Forms.Label contraseña;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.TextBox tbContrasenya;
        private System.Windows.Forms.Button btnValidacion;
    }
}

