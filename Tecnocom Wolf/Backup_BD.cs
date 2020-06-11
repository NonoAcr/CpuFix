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
    public partial class Backup_BD : Form
    {
        public Backup_BD()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }
        public bool validacion = false;
        public string c = "si";
        public string b = "";

        #region Backup BD
        SqlConnection Con = new SqlConnection("server = LAPTOP-43NCBRR5\\SQLEXPRESS; Initial Catalog =cpu_fix ; integrated security = true");

        public SqlConnection Con1 { get => Con; set => Con = value; }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                dir_respaldo.Text = saveFileDialog1.FileName;
            }
        }

        private void btnrespaldo_Click(object sender, EventArgs e)
        {
            string com_consul = "BACKUP DATABASE [cpu_fix] TO  DISK = N'" + dir_respaldo.Text + ".bak' WITH NOFORMAT, NOINIT,  NAME = N'cpu_fix-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10";

            SqlCommand cmd = new SqlCommand(com_consul, Con1);

            try
            {
                Con1.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se a creado copia de seguridad de manera exitosa.");
            }
            catch (Exception)
            {
                MessageBox.Show("El nombre del archivo ya existe, intente con otro nombre.");


            }
            finally
            {
                Con1.Close();
                Con1.Dispose();
            }
        }
        #endregion
       
        #region Empleados


        private void Reg_empleado_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
            RegistrarEmpleado RE = new RegistrarEmpleado();
            RE.Show();
            b = "si";
        }

        private void Cons_empleado_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
            DgvConsultarEmpleados CE = new DgvConsultarEmpleados();
            CE.Show();
            b = "si";
        }

        private void Mod_empleado_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
            ModificarEmpleado ME = new ModificarEmpleado();
            ME.Show();
            b = "si";
        }


        #endregion

        #region Cliente

        private void Reg_cliente_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
            RegistrarClientes RC = new RegistrarClientes();
            RC.Show();
            b = "si";
        }

        private void Mod_cliente_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
            ModificarClientes MC = new ModificarClientes();
            MC.Show();
            b = "si";
        }

        private void Cons_cliente_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
            ConsultarClientes CC = new ConsultarClientes();
            CC.Show();
            b = "si";
        }

        #endregion

        #region Tareas

        private void Add_tarea_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
            Registro R = new Registro();
            R.Show();
            b = "si";
        }

        private void Cons_tarea_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
            ConsultarTareas CT = new ConsultarTareas();
            CT.Show();
            b = "si";
        }

        #endregion

        private void respaldoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Backup_BD bck = new Backup_BD();
            bck.Show();
            b = "si";
        }

        private void cerrarSesionToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
            Login log = new Login();
            log.Show();
            this.Close();
        }


    }
}