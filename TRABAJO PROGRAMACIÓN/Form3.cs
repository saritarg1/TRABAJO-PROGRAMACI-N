using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRABAJO_PROGRAMACIÓN
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm = new Form2();
            frm.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cboTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {

            
            

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            cboTipoDocumento.Items.Add("Cédula de Ciudadanía");
            cboTipoDocumento.Items.Add("Cédula de Extranjería");

            cboNivelEscolaridad.Items.Add("Preescolar");
            cboNivelEscolaridad.Items.Add("Básica Primaria");
            cboNivelEscolaridad.Items.Add("Básica Secundaria");
            cboNivelEscolaridad.Items.Add("Media Académica");
            cboNivelEscolaridad.Items.Add("Media Técnica");
            cboNivelEscolaridad.Items.Add("Técnica Profesional");
            cboNivelEscolaridad.Items.Add("Tecnológica");
            cboNivelEscolaridad.Items.Add("Profesional");
            cboNivelEscolaridad.Items.Add("Especialización");
            cboNivelEscolaridad.Items.Add("Maestría");
            cboNivelEscolaridad.Items.Add("Doctorado");
            cboNivelEscolaridad.Items.Add("Ninguno");
            cboNivelEscolaridad.Items.Add("Sin Información");

        }

        private void txtPrimerNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrimerNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permite ingresar letras. Presiona OK para continuar.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtSegundoNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permite ingresar letras. Presiona OK para continuar.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtPrimerApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permite ingresar letras. Presiona OK para continuar.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtSegundoApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permite ingresar letras. Presiona OK para continuar.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtNumeroIdentificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permite ingresar números. Presiona OK para continuar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textTelefonoContacto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permite ingresar números. Presiona OK para continuar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textEPS_TextChanged(object sender, EventArgs e)
        {

        }

        private void textEPS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permite ingresar letras. Presiona OK para continuar.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

        }

        private void txtContactoEnCasoDeEmergencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permite ingresar letras. Presiona OK para continuar.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            BorrarMensajeError();
            if (ValidarCampos())
            {
                MessageBox.Show("Datos Ingresados Correctamente");
            }


        }

        private bool ValidarCampos()
        {
            bool ok = true;

            if (txtPrimerNombre.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtPrimerNombre, "Ingresar Primer Nombre");

            }

            if (txtPrimerApellido.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtPrimerApellido, "Ingresar Primer Apellido");

            }

            if (txtSegundoApellido.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtSegundoApellido, "Ingresar Segundo Apellido");

            }

            if (txtNumeroIdentificacion.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtNumeroIdentificacion, "Ingresar Número de Identificación");

            }

            if (cboTipoDocumento.Text == "")
            {
                ok = false;
                errorProvider1.SetError(cboTipoDocumento, "Seleccionar el Tipo de Documento");

            }

            if (dtpFechaDeNacimiento.Text == "")
            {
                ok = false;
                errorProvider1.SetError(dtpFechaDeNacimiento, "Ingresar Fecha de Nacimiento");

            }

            if (txtDireccionDeResidencia.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtDireccionDeResidencia, "Ingresar Dirección de Residencia");

            }

            if (txtTelefonoContacto.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtTelefonoContacto, "Ingresar número de Teléfono de Contacto");

            }

            if (cboNivelEscolaridad.Text == "")
            {
                ok = false;
                errorProvider1.SetError(cboNivelEscolaridad, "Seleccionar un Nivel de Escolaridad");

            }

            if (txtEPS.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtEPS, "Ingresar nombre de EPS");

            }

            if (txtCorreoElectronico.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtCorreoElectronico, "Ingresar Correo Electrónico");

            }

            if (txtContactoEnCasoDeEmergencia.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtContactoEnCasoDeEmergencia, "Ingresar el contacto para caso de emergencia");

            }
            return ok;

    
        }

        private void  BorrarMensajeError()
        {
            errorProvider1.SetError(txtPrimerNombre, "");
            errorProvider1.SetError(txtPrimerApellido, "");
            errorProvider1.SetError(txtSegundoApellido, "");
            errorProvider1.SetError(txtNumeroIdentificacion, "");
            errorProvider1.SetError(cboTipoDocumento, "");
            errorProvider1.SetError(dtpFechaDeNacimiento, "");
            errorProvider1.SetError(txtDireccionDeResidencia, "");
            errorProvider1.SetError(txtTelefonoContacto, "");
            errorProvider1.SetError(cboNivelEscolaridad, "");
            errorProvider1.SetError(txtEPS, "");
            errorProvider1.SetError(txtCorreoElectronico, "");
            errorProvider1.SetError(txtContactoEnCasoDeEmergencia, "");

        }

        private void btnConfirmarRegistro_Click(object sender, EventArgs e)
        {
            
        }

        private void dtpFechaDeNacimiento_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
