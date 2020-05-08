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

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            Clientes C = new Clientes();
            //C.Owner = this;
            C.Show();
            this.Close();
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
