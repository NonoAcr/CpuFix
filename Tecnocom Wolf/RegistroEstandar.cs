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
    public partial class RegistroEstandar : Form
    {
        public RegistroEstandar()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        public int count = 0;
        string cadena = "";
        string Aux = "";
        Consultas Consultas = new Consultas();
        Validaciones Validacion = new Validaciones();
        public string b = "";

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
                Validacion.RegistrarTrabajos(CbxNombreM, TxtNumeroC, cbxClaveEmp, TxtCTarea, CbxTipoReparacion, CbxSOI, CbxSO, CbxTipoPC,
                TxtDescripcion, cbxAnticipo, cbxEstado, txtPago, pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7
                , pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13, DtpFecha);
        }

        private void Registro_FormClosing(object sender, FormClosingEventArgs e)
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

       
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Consultardatos();
        }

        private void Consultardatos()
        {
            if (Aux == "Nombre")
            {
                cadena = "SELECT * FROM CLIENTES WHERE NOMBRE =" + "'" + CbxNombreM.Text + "'";
            }
            else if (Aux == "Clave")
            {
                cadena = "SELECT * FROM CLIENTES WHERE NUM_CLIENTE =" + "'" + CbxClaveM.Text + "'";
            }

            Consultas.CargarConsultaS(TxtNumeroC, txtNomClien, cadena);
        }
        private void ConsultarClientesClave()
        {
            cadena = "";
            Consultas.ConsultasCbxRegisClav(CbxClaveM, cadena, Aux);
        }
        public void ConsultarClientesNom()
        {
            cadena = "";
            Consultas.ConsultasCbxRegisNomb(CbxNombreM, cadena, Aux);
        }

        private void CbxSOI_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CbxNombreCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            Consultardatos();
        }

        private void CbxClaveClien_SelectedIndexChanged(object sender, EventArgs e)
        {
            Consultardatos();
        }

        private void CbxNombreCliente_TextChanged(object sender, EventArgs e)
        {
            Consultardatos();
        }

        private void RbClave_CheckedChanged_1(object sender, EventArgs e)
        {
            CbxNombreM.Text = "";
            CbxClaveM.Items.Clear();
            CbxNombreM.Enabled = false;
            CbxClaveM.Enabled = true;
            lblNumClient.Visible = false;
            lblNomClien.Visible = true;
            TxtNumeroC.Visible = false;
            txtNomClien.Visible = true;
            Aux = "Clave";
            ConsultarClientesClave();
            CbxClaveM.Text = CbxClaveM.Items[0].ToString();
        }

        private void RbNombre_CheckedChanged_1(object sender, EventArgs e)
        {
            CbxClaveM.Text = "";
            CbxNombreM.Items.Clear();
            CbxClaveM.Enabled = false;
            CbxNombreM.Enabled = true;
            lblNumClient.Visible = true;
            lblNomClien.Visible = false;
            TxtNumeroC.Visible = true;
            txtNomClien.Visible = false;
            Aux = "Nombre";
            ConsultarClientesNom();
            CbxNombreM.Text = CbxNombreM.Items[0].ToString();
        }

        private void CbxNombreM_SelectedIndexChanged(object sender, EventArgs e)
        {
            Consultardatos();
        }

        private void CbxClaveM_SelectedIndexChanged(object sender, EventArgs e)
        {
            Consultardatos();
        }

        private void LblNomClien_Click(object sender, EventArgs e)
        {

        }

        private void CbxNombreM_TextChanged(object sender, EventArgs e)
        {
            Consultardatos();
        }

        private void CbxClaveM_TextChanged(object sender, EventArgs e)
        {
            Consultardatos();
        }

        private void CbxClaveEmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConsultarDatosEmpl();

        }
        private void ConsultarDatosEmpl()
        {
            cadena = "SELECT * FROM EMPLEADOS WHERE CLAVE_EMPLEADO =" + "'" + cbxClaveEmp.Text + "'";

            //Consultas.CargarConsultaClavEmp(cbxClaveEmp, cadena);
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            cbxClaveEmp.Items.Clear();
            Aux = "Clave";
            ConsultarClaveEmpl();
            cbxClaveEmp.Text = cbxClaveEmp.Items[0].ToString();
        }
        private void ConsultarClaveEmpl()
        {
            cadena = "";
            Consultas.ConsultasCbxRegisClavEmpl(cbxClaveEmp, cadena, Aux);
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void CbxTipoPC_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        #region Clientes
        private void Reg_clientes_Click(object sender, EventArgs e)
        {
            this.Dispose();
            RegistrarClientesEstandar RC = new RegistrarClientesEstandar();
            RC.Show();
            b = "no";
        }

        private void Mod_clientes_Click(object sender, EventArgs e)
        {
            ModificarClientesEstandar MC = new ModificarClientesEstandar();
            MC.Show();
            b = "no";
        }

        private void Cons_clientes_Click(object sender, EventArgs e)
        {
            this.Dispose();
            ConsultarClientesEstandar CC = new ConsultarClientesEstandar();
            CC.Show();
            b = "no";
        }

        #endregion

        #region Tareas
        private void Add_tareas_Click(object sender, EventArgs e)
        {
            this.Dispose();
            RegistroEstandar R = new RegistroEstandar();
            R.Show();
            b = "no";
        }

        private void Cons_tareas_Click(object sender, EventArgs e)
        {
            this.Dispose();
            ConsultarTareasEstandar CT = new ConsultarTareasEstandar();
            CT.Show();
            b = "no";
        }

        #endregion

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Dispose();
            Login log = new Login();
            log.Show();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            if (count == 10)
            {
                timer1.Stop();
                MessageBox.Show("La sesion a expirado, favor de volver a iniciar sesion");
                timer1.Dispose();
                this.Dispose();
                Login log = new Login();
                log.Show();
                this.Close();
            }
        }

        private void RegistroEstandar_KeyPress(object sender, KeyPressEventArgs e)
        {
            timer1.Stop();
            timer1.Start();
            count = 0;
        }

        private void RegistroEstandar_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Start();
            count = 0;
        }
    }
}
