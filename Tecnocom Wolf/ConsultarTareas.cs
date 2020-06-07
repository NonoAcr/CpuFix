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
    public partial class ConsultarTareas : Form
    {
        public ConsultarTareas()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }
        public string b = "";

        Consultas Consultas = new Consultas();
       
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (TxtClaveTarea.Text == "")
            {
                MessageBox.Show("Datos Incompletos");
                TxtClaveTarea.Focus();
            }
            else
            {      
                    Consultas.ConsultaDatos(DgvConsulta, TxtClaveTarea);
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtClaveTarea.Text = "";
            DgvConsulta.Rows.Clear();
        }

        private void ConsultarTareas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == (Keys.Escape))
            {
                this.Close();
            }
        }

        private void ConsultarTareas_FormClosing(object sender, FormClosingEventArgs e)
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

        private void DgvConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DgvConsulta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Registros Registros = new Registros();
            if (this.DgvConsulta.Columns[e.ColumnIndex].Name.Equals("Modificar"))
            {
                Registros.ModificarTrabajo(DgvConsulta);
                DgvConsulta.Rows.Clear();
                TxtClaveTarea.Text = "";
                TxtClaveTarea.Focus();
                MessageBox.Show("Actualizacion Correcta");
            }else
                if (this.DgvConsulta.Columns[e.ColumnIndex].Name.Equals("Borrar"))
            {
                if (MessageBox.Show("¿Seguro Que Desea Borrar?", "Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    Registros.borrarTarea(DgvConsulta);
                    DgvConsulta.Rows.Clear();
                    TxtClaveTarea.Text = "";
                    TxtClaveTarea.Focus();
                    MessageBox.Show("La Tarea Se Borro Exitosamente");
                }
            }
        }

        private void ConsultarTareas_Load(object sender, EventArgs e)
        {

        }

        private void TxtClaveTarea_KeyPress(object sender, KeyPressEventArgs e)
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
