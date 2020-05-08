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

        private void button2_Click(object sender, EventArgs e)
        {
            Registro RGTO = new Registro();
            this.Hide();
            RGTO.ShowDialog();
            this.Show();
        }
        private void BtnClientes_Click(object sender, EventArgs e)
        {
            Clientes C = new Clientes();
            C.ShowDialog();
            c = "no";
            this.Close();
        }

        private void BtnEmpleado_Click(object sender, EventArgs e)
        {
            Trabajadores T = new Trabajadores();
            T.Show();
            c = "no";
            this.Close();
        }

        // Eventos

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

        private void BtnTareas_Click(object sender, EventArgs e)
        {
            Trabajos Trabajos = new Trabajos();
            Trabajos.Show();
            c = "no";
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Close();
        }
    }
}
