using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Tecnocom_Wolf
{
    public partial class RegistrarEmpleado : Form
    {
        public RegistrarEmpleado()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        public string b = "";
        Registros Registros = new Registros();
        Consultas Consultas = new Consultas();
        Validaciones Validacion = new Validaciones();

        private void Registrar_Click(object sender, EventArgs e)
        {
            Validacion.ValidarRegistrarEmpleado(TxtNombreE, CbxTipoE, TxtCEmpleado, TxtIDUsuaro, TxtContraseña, pictureBox1, pictureBox2,
            pictureBox3, pictureBox4, pictureBox5);
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
            lblBaja.Hide();
            lblMedia.Hide();
            lblSegura.Hide();
        }
        public void limpiar()
        {
            TxtNombreE.Clear();
            TxtIDUsuaro.Clear();
            TxtContraseña.Clear();
            TxtCEmpleado.Clear();
            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
            pictureBox5.Hide();
        }

        //Eventos

        private void RegistrarEmpleado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == (Keys.Escape))
            {
                this.Close();
            }
        }

        private void RegistrarEmpleado_FormClosing(object sender, FormClosingEventArgs e)
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

        private void TxtNombreE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space) && (e.KeyChar != (char)Keys.Enter))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void CbxTipoE_KeyPress(object sender, KeyPressEventArgs e)
        {

            // posiblemente error en validacion 

            if (Char.IsLetter(e.KeyChar))
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

        private void CbxTipoE_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(CbxTipoE, "uwu");
        }

        private void TxtNombreE_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtContraseña_TextChanged(object sender, EventArgs e)
        {
        }

        private void TxtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            string s = TxtContraseña.Text;
            if (s == "")
            {
                lblBaja.Hide();
                lblMedia.Hide();
                lblSegura.Hide();
            }
            if (s.Length <= 3)
            {
                lblBaja.Show();
                lblMedia.Hide();
                lblSegura.Hide();
            }
            if (s.Length >= 4 && s.Length <= 7)
            {
                lblBaja.Hide();
                lblMedia.Show();
                lblSegura.Hide();
            }
            if (s.Length >= 9)
            {
                lblBaja.Hide();
                lblMedia.Hide();
                lblSegura.Show();
            }
        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void RegistrarEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void TxtCEmpleado_KeyPress(object sender, KeyPressEventArgs e)
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
                MessageBox.Show("Solo numeros");
            }
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
    }
}
