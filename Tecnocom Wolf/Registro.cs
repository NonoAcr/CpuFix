using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tecnocom_Wolf
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }
        Validaciones Validacion = new Validaciones();

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            Validacion.RegistrarTrabajos(TxtNombreC,TxtNumeroC, TxtCEmpleado, TxtCTarea, CbxTipoReparacion, CbxSOI, CbxSO, CbxTipoPC, 
            TxtDescripcion, pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, 
            pictureBox9, DtpFecha);
        }

        private void Registro_FormClosing(object sender, FormClosingEventArgs e)
        {
            Trabajos Trabajos = new Trabajos();
            Trabajos.Show(); 
        }

        private void Registro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == (Keys.Escape))
            {
                this.Close();
            }
        }

        private void TxtNombreC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space) && (e.KeyChar != (char)Keys.Enter))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TxtNumeroC_KeyPress(object sender, KeyPressEventArgs e)
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

        private void DtpFecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CbxNombre_SelectedIndexChanged(object sender, EventArgs e)
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
            }
        }

        private void TxtCTarea_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
