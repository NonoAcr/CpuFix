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

        public string b = "";
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
                
                Validacion.ValidarRegistrarClientes(TxtNombre, TxtIdClave, TxtDireccion, TxtCorreo, mtbTelefono, pictureBox1, pictureBox2,
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
            mtbTelefono.Text = "";
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
            if (b == "si")
            {
                this.Visible = true;
                if (this.Owner != null)
                {
                    this.Owner.Show();
                }
            }
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

        
        #region Menustrip

        private void Reg_empleado_Click(object sender, EventArgs e)
        {
            this.Dispose();
            RegistrarEmpleado RE = new RegistrarEmpleado();
            RE.Show();
            b = "si";
        }

        private void Cons_empleado_Click(object sender, EventArgs e)
        {
            this.Dispose();
            DgvConsultarEmpleados CE = new DgvConsultarEmpleados();
            CE.Show();
            b = "si";
        }

        private void Mod_empleado_Click(object sender, EventArgs e)
        {
            this.Dispose();
            ModificarEmpleado ME = new ModificarEmpleado();
            ME.Show();
            b = "si";
        }

        private void Reg_cliente_Click(object sender, EventArgs e)
        {
            this.Dispose();
            RegistrarClientes RC = new RegistrarClientes();
            RC.Show();
            b = "si";
        }

        private void Mod_cliente_Click(object sender, EventArgs e)
        {
            this.Dispose();
            ModificarClientes MC = new ModificarClientes();
            MC.Show();
            b = "si";
        }

        private void Cons_cliente_Click(object sender, EventArgs e)
        {
            this.Dispose();
            ConsultarClientes CC = new ConsultarClientes();
            CC.Show();
            b = "si";
        }

        private void Add_tarea_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Registro R = new Registro();
            R.Show();
            b = "si";
        }

        private void Cons_tarea_Click(object sender, EventArgs e)
        {
            this.Dispose();
            ConsultarTareas CT = new ConsultarTareas();
            CT.Show();
            b = "si";
        }

        private void respaldoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Backup_BD bck = new Backup_BD();
            bck.Show();
            b = "si";
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Login log = new Login();
            log.Show();
            this.Close();
        }

        #endregion

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
