using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace García_Daniel_Jardinería
{
    public partial class MainForm : Form
    {
        private ClienteInsertar insertarCliente;
        private ClienteModificar modificarCliente;

        public MainForm()
        {
            InitializeComponent();
        }

        private void insertarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // panel 1 se usa porque al establecer el formulario como 
            // contenedor de formularios MDI, adopta como color de 
            // fondo un gris establecido como color de sistema operativo
            cierra_formularios();

            // Lanzo un formulario F_mdi 1
            // De esta forma limpio la lista de hijos MDI 
            // del formulario
            this.IsMdiContainer = false;
            this.IsMdiContainer = true;

            insertarCliente = new ClienteInsertar();

            // Indico que está contenido dentro del 
            // formulario principal
            insertarCliente.MdiParent = this;

            // No mostramos los botones de minimizar y cerrar
            insertarCliente.ControlBox = false;

            // El formulario MDI no tendrá bordes.
            // De está forma el usuario no lo puede 
            // redimensionar manualmente
            insertarCliente.FormBorderStyle = FormBorderStyle.None;

            // f_mdi1.WindowState = FormWindowState.Maximized;
            insertarCliente.Show();
        }

        private void cierra_formularios()
        {
            this.Controls.Remove(panel1);

            for (int i = 0; i < this.MdiChildren.Count(); i++)
            {
                Form f = this.MdiChildren[i];
                f.Close();
            }
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cierra_formularios();
            this.IsMdiContainer = false;
            this.IsMdiContainer = true;
            modificarCliente = new ClienteModificar();
            modificarCliente.MdiParent = this;
            modificarCliente.ControlBox = false;
            modificarCliente.FormBorderStyle = FormBorderStyle.None;
            modificarCliente.Show();
        }
    }
}
