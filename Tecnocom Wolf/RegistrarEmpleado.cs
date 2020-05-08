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
            Trabajadores T = new Trabajadores();
            T.Show();
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
    }
}
