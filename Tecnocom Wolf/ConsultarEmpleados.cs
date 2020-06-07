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
    public partial class DgvConsultarEmpleados : Form
    {
        public DgvConsultarEmpleados()
        {
            InitializeComponent();
            RbNombre.Checked = true;
            this.KeyPreview = true;
        }

        public string b = "";
        string Aux = "", cadena = "";
        Consultas Consultas = new Consultas();
        string Borrar = "";
        private void ConsultarEmpleados_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == (Keys.Escape))
            {
                this.Close();
            }
        }

        Registros Registros = new Registros();

        public void ConsultarEmpleado()
        {
            DgvConsulta.Rows.Clear();
            if (Aux == "Nombre")
            {
                cadena = "SELECT * FROM EMPLEADOS WHERE NOMBRE =" + "'" + CbxNombre.Text + "'";
            }
            else if (Aux == "Clave")
            {
                cadena = "SELECT * FROM EMPLEADOS WHERE CLAVE_EMPLEADO =" + "'" + CbxClaveE.Text + "'";
            }
            Consultas.ConsultasEmpleadosDgv(DgvConsulta, cadena);
        }

        private void DgvConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.DgvConsulta.Columns[e.ColumnIndex].Name.Equals("Eliminar"))
            {
                if (MessageBox.Show("¿Seguro Que Desea Borrar?", "Borrar Empleado", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    Borrar = DgvConsulta.CurrentRow.Cells[1].Value.ToString();

                    Registros.BorrarEmpleado(Borrar);
                    CbxNombre.Items.Clear();
                    CbxClaveE.Items.Clear();
                    Consultas.ConsultarEmpleados(CbxNombre, CbxClaveE, null, Aux);
                    CbxNombre.Text = CbxNombre.Items[0].ToString();
                    MessageBox.Show("Empleado Borrado Correctamente");
                }
                
            }  
        }

        //Eventos

        private void ConsultarEmpleados_FormClosing(object sender, FormClosingEventArgs e)
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

        private void RbNombre_CheckedChanged(object sender, EventArgs e)
        {
            CbxClaveE.Text = "";
            CbxNombre.Items.Clear();
            CbxClaveE.Enabled = false;
            CbxNombre.Enabled = true;
            Aux = "Nombre";
            
            Consultas.ConsultarEmpleados(CbxNombre, CbxClaveE, null, Aux);
            CbxNombre.Text = CbxNombre.Items[0].ToString();
        }

        private void RbClave_CheckedChanged(object sender, EventArgs e)
        {
            CbxNombre.Text = "";
            CbxClaveE.Items.Clear();
            CbxNombre.Enabled = false;
            CbxClaveE.Enabled = true;
            Aux = "Clave";
            
            Consultas.ConsultarEmpleados(CbxNombre, CbxClaveE, null, Aux);
            CbxClaveE.Text = CbxClaveE.Items[0].ToString();
        }

        private void CbxNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConsultarEmpleado();
        }

        private void CbxClaveE_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConsultarEmpleado();
        }

        private void CbxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space) && (e.KeyChar != (char)Keys.Enter))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void CbxClaveE_KeyPress(object sender, KeyPressEventArgs e)
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

        private void CbxNombre_TextChanged(object sender, EventArgs e)
        {
            ConsultarEmpleado();
        }

        private void DgvConsultarEmpleados_Load(object sender, EventArgs e)
        {

        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            if (tipoUsuario.tipoUs == "ADMINISTRADOR")
            {
                Bienvenido Prin = new Bienvenido();
                Prin.Show();
                this.Close();
                /*this.Visible = true;
                this.Owner.Show();*/
            }
            else
            {
                Estandar Est = new Estandar();
                Est.Show();
                this.Close();
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

        private void CbxClaveE_TextChanged(object sender, EventArgs e)
        {
            ConsultarEmpleado();
        }

        
    }
}
