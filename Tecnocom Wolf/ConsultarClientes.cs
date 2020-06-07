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

namespace Tecnocom_Wolf
{
    public partial class ConsultarClientes : Form
    {
        public ConsultarClientes()
        {
            InitializeComponent();
            RbNombre.Checked = true ;
            this.KeyPreview = true;
        }

        public string b = "";
        string cadena = "";
        string Aux = "";

        Consultas Consultas = new Consultas();
        
        private void RbNombre_CheckedChanged(object sender, EventArgs e)
        {
            CbxClaveC.Text = ""; 
            CbxNombreC.Items.Clear(); 
            CbxClaveC.Enabled = false;
            CbxNombreC.Enabled = true;
            Aux = "Nombre";
            Consultar();
            CbxNombreC .Text = CbxNombreC.Items[0].ToString();
        }

        private void RbClave_CheckedChanged(object sender, EventArgs e)
        {
            CbxNombreC.Text = "";
            CbxClaveC.Items.Clear(); 
            CbxNombreC.Enabled = false;
            CbxClaveC.Enabled = true;
            Aux = "Clave";
            Consultar();
            CbxClaveC.Text = CbxClaveC.Items[0].ToString(); 
        }

        private void ConsultarClientes_FormClosing(object sender, FormClosingEventArgs e)
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

        public void Consultar()
        {
            cadena = "";
            Consultas.ConsultasCbx(CbxNombreC, CbxClaveC, cadena,Aux);
        }

       
        public void ConsultarDatos()
        {
            DgvClientes.Rows.Clear();
            if (Aux == "Nombre")
            {
                cadena = "SELECT * FROM CLIENTES WHERE NOMBRE =" + "'" + CbxNombreC.Text + "'";
            }
            else if (Aux == "Clave")
            {
                cadena = "SELECT * FROM CLIENTES WHERE NUM_CLIENTE =" + "'" + CbxClaveC.Text + "'";
            }

            Consultas.Consultar(DgvClientes, cadena);

        }
        
        // Eventos
       
        private void CbxNombreC_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ConsultarDatos();
        }

        private void CbxClaveC_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConsultarDatos();
        }

        private void ConsultarClientes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == (Keys.Escape))
            {
                this.Close();
            }
        }

        private void CbxNombreC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space) && (e.KeyChar != (char)Keys.Enter))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

        }

        private void CbxClaveC_KeyPress(object sender, KeyPressEventArgs e)
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

        private void CbxNombreC_TextChanged(object sender, EventArgs e)
        {
            ConsultarDatos();
        }

        private void CbxClaveC_TextChanged(object sender, EventArgs e)
        {
            ConsultarDatos();
        }

        private void ConsultarClientes_Load(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
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
