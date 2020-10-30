using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Entidad;

namespace García_Daniel_Jardinería
{
    public partial class LoginForm : Form
    {
        private Neg neg;

        public LoginForm()
        {
            InitializeComponent();
            neg = new Neg();
        }

        private void btnValidacion_Click(object sender, EventArgs e)
        {
            MainForm f = new MainForm();

            this.Hide();
            f.Show();

            /*
            if (neg.validar(tbUsuario.Text, tbContrasenya.Text))
            {
                this.Hide();
                f.Show();
            }
            else
            {
                MessageBox.Show("Acceso denegado");
            }
            */
        }

        public static void Message(string msg)
        {
            MessageBox.Show(msg);
        }
    }
}
