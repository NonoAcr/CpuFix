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
        }

        SqlConnection Con = new SqlConnection("server = DESKTOP-P381C99; Initial Catalog =cpu_fix ; integrated security = true");

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

            SqlCommand cmd = new SqlCommand(com_consul, Con);

            try
            {
                Con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se a creado copia de seguridad de manera exitosa.");
            }
            catch (Exception)
            {
                MessageBox.Show("El nombre del archivo ya existe, intente con otro nombre.");


            }
            finally
            {
                Con.Close();
                Con.Dispose();
            }
        }
    }
}
