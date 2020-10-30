using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;
using Negocio;

namespace García_Daniel_Jardinería
{
    public partial class ClienteInsertar : Form
    {
        private Neg neg;
        private ErrorProvider errorNombre;
        private ErrorProvider errorPass;
        private ErrorProvider errorTelefono;
        private ErrorProvider errorFax;
        private ErrorProvider errorLinea1;
        private ErrorProvider errorCiudad;

        public ClienteInsertar()
        {
            InitializeComponent();
            neg = new Neg();
            errorNombre = new ErrorProvider();
            errorPass = new ErrorProvider();
            errorTelefono = new ErrorProvider();
            errorFax = new ErrorProvider();
            errorLinea1 = new ErrorProvider();
            errorCiudad = new ErrorProvider();
        }

        private void tbNombreCliente_Leave(object sender, EventArgs e)
        {
            if (tbNombreCliente.Text == "")
                errorNombre.SetError(tbNombreCliente, "Debes escribir un nombre");
            else
                errorNombre.Clear();
        }


        private void tbPass_Leave(object sender, EventArgs e)
        {
            if (tbPass.Text == "")
            {
                errorPass.SetError(tbPass, "Debes escribir una contraseña");
            }
            else
            {
                errorPass.Clear();
            }
        }

        private void tbTelefono_Validating(object sender, CancelEventArgs e)
        {
            if (tbTelefono.Text == "")
            {
                errorTelefono.SetError(tbPass, "Debes escribir un número de teléfono");
            }
            else
            {
                errorTelefono.Clear();
            }
        }

        private void tbFax_Validating(object sender, CancelEventArgs e)
        {
            if (tbFax.Text == "")
            {
                errorFax.SetError(tbPass, "Debes escribir un número de fax");
            }
            else
            {
                errorFax.Clear();
            }
        }

        private void tbLinea1_Validating(object sender, CancelEventArgs e)
        {
            if (tbLinea1.Text == "")
            {
                errorLinea1.SetError(tbPass, "Debes escribir una dirección");
            }
            else
            {
                errorLinea1.Clear();
            }
        }

        private void tbCiudad_Validating(object sender, CancelEventArgs e)
        {
            if (tbCiudad.Text == "")
            {
                errorCiudad.SetError(tbPass, "Debes escribir una ciudad");
            }
            else
            {
                errorCiudad.Clear();
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            // lbError.Text = neg.obtenerListaCliente().Count.ToString();

            if (tbNombreCliente.Text == "" || tbPass.Text == "" || tbTelefono.Text == "" 
                || tbFax.Text == "" || tbLinea1.Text == "" || tbCiudad.Text == "")
            {
                lbError.Text = "Debes rellenar todos los campos obligatorios";
            }
            else
            {
                if (neg.crearUsuario(new Cliente(tbNombreCliente.Text, tbNombreContacto.Text, tbApellidoContacto.Text, tbTelefono.Text,
                    tbFax.Text, tbLinea1.Text, tbLinea2.Text, tbCiudad.Text, tbRegion.Text, tbPais.Text, tbCodigoPostal.Text,
                    tbCodigoEmpleado.Text, Convert.ToDouble(tbLimiteCredito.Text), tbPass.Text)) == true)
                {
                    this.Close();
                }
            }
        }
    }
}
