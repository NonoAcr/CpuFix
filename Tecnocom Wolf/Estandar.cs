using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
        public int count = 0;


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
            Login log = new Login();
            log.Show();
            this.Close();
        }

        private void Estandar_Load(object sender, EventArgs e)
        {
            lblNomUs.Text = tipoUsuario.NombreUs;
        }
        #region Timeout
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

        private void Estandar_KeyPress(object sender, KeyPressEventArgs e)
        {
            timer1.Stop();
            timer1.Start();
            count = 0;
        }

        private void Estandar_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Start();
            count = 0;
        }
        #endregion
    }
}
