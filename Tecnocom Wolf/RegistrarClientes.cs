using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Tecnocom_Wolf
{
    public partial class RegistrarClientes : Form
    {
        public RegistrarClientes()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        string Clave = "", Operacion = "";
        Consultas Consultas = new Consultas();
        Registros Registros = new Registros();
        Validaciones Validacion = new Validaciones();
        

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            string correoIngresado = "";
            correoIngresado = TxtCorreo.Text;
            if(email_bien_escrito(correoIngresado) == true)
            {
                MessageBox.Show("Correo Valido");
                Validacion.ValidarRegistrarClientes(TxtNombre, TxtIdClave, TxtDireccion, TxtCorreo, TxtTelefono, pictureBox1, pictureBox2,
                pictureBox3, pictureBox4, pictureBox5);
            }
            else
            {
                MessageBox.Show("Correo Invalido");
            }
        }
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        public void Limpiar()
        {
            TxtNombre.Text = "";
            TxtIdClave.Text = "";
            TxtCorreo.Text = "";
            TxtDireccion.Text = "";
            TxtIdClave.Text = "";
            TxtTelefono.Text = "";
            TxtNombre.Focus();
            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
            pictureBox5.Hide();
        }
        
        // Eventos

        private void RegistrarClientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            Clientes C = new Clientes();
            C.Show();
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space) && (e.KeyChar != (char)Keys.Enter))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
                
            }

        private void TxtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void RegistrarClientes_Load(object sender, EventArgs e)
        {

        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtClave_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegistrarClientes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == (Keys.Escape))
            {
                this.Close();
            }
        }

        private void TxtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Estandar E = new Estandar();
            E.Show();
            this.Close();
        }

        private Boolean email_bien_escrito(string email)
        {
            string expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
