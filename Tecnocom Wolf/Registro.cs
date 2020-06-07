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

        string cadena = "";
        string Aux = "";
        Consultas Consultas = new Consultas();
        Validaciones Validacion = new Validaciones();
        public string b = "";
        public bool validacion = false;
        public string c = "si";

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
