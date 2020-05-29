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
    public partial class Estandar : Form
    {
        public Estandar()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        public bool validacion = false;
        public string c = "si";
        public string b = "";


        #region Clientes
        private void Reg_clientes_Click(object sender, EventArgs e)
        {
            this.Dispose();
            RegistrarClientes RC = new RegistrarClientes();
            RC.Show();
            b = "no";
        }

        private void Mod_clientes_Click(object sender, EventArgs e)
        {
            ModificarClientes MC = new ModificarClientes();
            MC.Show();
            b = "no";
        }

        private void Cons_clientes_Click(object sender, EventArgs e)
        {
            this.Dispose();
            ConsultarClientes CC = new ConsultarClientes();
            CC.Show();
            b = "no";
        }

        #endregion

        #region Tareas
        private void Add_tareas_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Registro R = new Registro();
            R.Show();
            b = "no";
        }

        private void Cons_tareas_Click(object sender, EventArgs e)
        {
            this.Dispose();
            ConsultarTareas CT = new ConsultarTareas();
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
