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
    
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.KeyPreview = true; 
        }

        // Declaracion De Variables Gloables 

        //SqlConnection conexion = new SqlConnection("server = localhost; Initial Catalog = cpu_fix; integrated security = true");
        SqlConnection conexion = new SqlConnection("server = DESKTOP-P381C99; Initial Catalog = cpu_fix; integrated security = true");
        string cadena = "";
        Consultas Consultas = new Consultas();
        string User = "", Pass = "", Tipo = "";

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            bool bande = true;
            pictureBox1.Hide();
            pictureBox2.Hide();

            if (TxtUsuario.Text == "")
            {
                pictureBox1.Show();
                bande = false;
            }

            if (TxtContraseña.Text == "")
            {
                pictureBox2.Show();
                bande = false;
            }
            if (bande == true)
            {
                conexion.Open();
                cadena = "SELECT * FROM EMPLEADOS WHERE ID_USUARIO = '" + TxtUsuario.Text + "'";
                SqlDataReader sqldr;
                SqlCommand comando = new SqlCommand(cadena, conexion);
                sqldr = comando.ExecuteReader();
                while (sqldr.Read())
                {
                    User = sqldr["ID_USUARIO"].ToString();
                    Pass = sqldr["CONTRASEÑA"].ToString();
                    Tipo = sqldr["TIPO_USUARIO"].ToString();
                }

                conexion.Close();

                if (TxtUsuario.Text == User && TxtContraseña.Text == Pass)
                {
                    //Patron de diseño GRASP
                    if (Tipo == "ADMINISTRADOR")
                    {
                        tipoUsuario.tipoUs = "ADMINISTRADOR";
                        this.Hide();
                        Bienvenido B = new Bienvenido();
                        B.ShowDialog();

                    }
                    else if (Tipo == "ESTANDAR")
                    {
                        tipoUsuario.tipoUs = "ESTANDAR";
                        this.Hide();
                        Estandar E = new Estandar();
                        E.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Usuario O Contraseña Incorrectos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TxtUsuario.Text = "";
                    TxtContraseña.Text = "";
                    TxtUsuario.Focus();
                    MessageBox.Show("Los campos señalados son obligatorios. Favor de llenarlos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Los campos señalados son obligatorios. Favor de llenarlos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        public void Log_in(string Usuario, string Contraseña)
        {
            if (TxtUsuario.Text == Usuario && TxtContraseña.Text == Contraseña)
            {
                this.Hide();

                Bienvenido B = new Bienvenido();
                B.ShowDialog();
               
            }
            else
            {
                MessageBox.Show("Usuario O Contraseña Incorrectos");
                TxtUsuario.Text = "";
                TxtContraseña.Text = "";
                TxtUsuario.Focus();

            }
        }

        // Eventos 

        private void Login_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == (Keys.Escape))
            {
                if (MessageBox.Show("¿Seguro Que Desea Salir Del Programa?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    Application.Exit();
                }
               
            }

        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
