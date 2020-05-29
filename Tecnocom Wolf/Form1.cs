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
    public partial class Bienvenido : Form
    {
        public Bienvenido()
        {
            InitializeComponent();
            this.KeyPreview = true; 
        }

        public bool validacion = false;
        public string c = "si";
        public string b = "";


        # region Eventos

        private void Bienvenido_Load(object sender, EventArgs e)
        {
            Login Log = new Login();
            Log.Hide();
        }

        private void Bienvenido_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }
        private void Bienvenido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == (Keys.Escape))
            {
                if (MessageBox.Show("¿Seguro Que Desea Salir Del Programa?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }
        #endregion

        #region Empleados


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


        #endregion

        #region Cliente

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

        #endregion

        #region Tareas

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

        #endregion

        private void EmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
    }
}
