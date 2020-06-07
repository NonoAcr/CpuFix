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
    public partial class ConsultarClientesEstandar : Form
    {
        public ConsultarClientesEstandar()
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
    }
}
