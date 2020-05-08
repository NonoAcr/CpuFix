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
    public partial class Trabajadores : Form
    {
        public Trabajadores()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        public string b = "";

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            RegistrarEmpleado RE = new RegistrarEmpleado();
            RE.Show();
            b = "no";
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            DgvConsultarEmpleados CE = new DgvConsultarEmpleados();
            CE.Show();
            b = "no";
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            ModificarEmpleado ME = new ModificarEmpleado();
            ME.Show();
            b = "no";
        }

       //Eventos

        private void Trabajadores_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (b == "si")
            {
                Bienvenido bienvenido = new Bienvenido();
                bienvenido.Show();
                bienvenido.c = "si";
            }
        }

        private void Trabajadores_Load(object sender, EventArgs e)
        {
            b = "si";
        }

        private void Trabajadores_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == (Keys.Escape))
            {
                this.Close();
            }
        }
    }
}
