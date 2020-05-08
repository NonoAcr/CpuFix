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
    public partial class Trabajos : Form
    {
        public Trabajos()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        public string b = "";

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Registro R = new Registro();
            R.Show();
            b = "no";
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            ConsultarTareas CT = new ConsultarTareas();
            CT.Show();
            b = "no";
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            /*this.Dispose();
            Registro R = new Registro();
            R.Show();
            b = "no";*/
        }

        // Eventos

        private void Trabajos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == (Keys.Escape))
            {
                this.Close();
            }
        }

        private void Trabajos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (b == "si")
            {
                Bienvenido bienvenido = new Bienvenido();
                bienvenido.Show();
                bienvenido.c = "si";
            }
        }

        private void Trabajos_Load(object sender, EventArgs e)
        {
            b = "si";
        }
    }
}
