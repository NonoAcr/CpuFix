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
    public partial class ModificarClientes : Form
    {
        public ModificarClientes()
        {
            InitializeComponent();
            RbNombre.Checked = true;
            this.KeyPreview = true;
        }

        public string b = "";
        string cadena = "", Operacion = "";
        string Aux = "";
        Consultas Consultas = new Consultas();
        Registros Registros = new Registros();
        SqlConnection Conexion = new SqlConnection("server = LAPTOP-43NCBRR5\\SQLEXPRESS; Initial Catalog = cpu_fix; integrated security = true");

        private void RbNombre_CheckedChanged(object sender, EventArgs e)
        {
            CbxClaveM.Text = "";
            CbxNombreM.Items.Clear();
            CbxClaveM.Enabled = false;
            CbxNombreM.Enabled = true;
            Aux = "Nombre";
            ConsultarClientes();
            CbxNombreM.Text = CbxNombreM.Items[0].ToString();
        }

        private void RbClave_CheckedChanged(object sender, EventArgs e)
        {
            CbxNombreM.Text = "";
            CbxClaveM.Items.Clear();
            CbxNombreM.Enabled = false;
            CbxClaveM.Enabled = true;
            Aux = "Clave";
            ConsultarClientes();
            CbxClaveM.Text = CbxClaveM.Items[0].ToString();
        }

       
        private void BtnActualizar_Click_1(object sender, EventArgs e)
        {
            bool bande = true;
            bool band = true;
            string N = TxtNombre.Text;
            string C = TxtClave.Text;
            string T = TxtTelefono.Text;
            string D = TxtDireccion.Text;

            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
            pictureBox5.Hide();

            if (N.Length < 4)
            {
                band = false;
                MessageBox.Show("Nombre de minimo 4 letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (N.Length > 20)
            {
                band = false;
                MessageBox.Show("Nombre de maximo 20 letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (C.Length > 2)
            {
                band = false;
                MessageBox.Show("Id. Cliente maximo 2 numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (T.Length > 10)
            {
                band = false;
                MessageBox.Show("Telefono maximo 10 numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (D.Length > 25)
            {
                band = false;
                MessageBox.Show("Dirección maximo 25 caracteres", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (band == true)
            {
                if (TxtCorreo.Text == "")
                {
                    pictureBox3.Show();
                    bande = false;
                }
                if (TxtDireccion.Text == "")
                {
                    pictureBox5.Show();
                    bande = false;
                }
                if (TxtTelefono.Text == "")
                {
                    pictureBox4.Show();
                    bande = false;
                }
                if (TxtNombre.Text == "")
                {
                    pictureBox1.Show();
                    bande = false;
                }

                if (TxtClave.Text == "")
                {
                    pictureBox2.Show();
                    bande = false;
                }
                if (bande == true)
                {
                    Operacion = "Actualizar";
                    Registros.RegistrarClientes_ModificarClientes(TxtNombre, TxtClave, TxtDireccion, TxtCorreo, TxtTelefono, Operacion);


                    CbxNombreM.Items.Clear();
                    CbxClaveM.Items.Clear();
                    ConsultarClientes();
                    Limpiar();
                    MessageBox.Show("DATOS ACTUALIZADOS");
                }
                else
                {
                    MessageBox.Show("Los campos señalados son obligatorios. Favor de llenarlos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        public void ConsultarClientes()
        {
            cadena = "";
            Consultas.ConsultasCbx(CbxNombreM, CbxClaveM, cadena, Aux);

        }
        public void Consultardatos()
        {
            if (Aux == "Nombre")
            {
                cadena = "SELECT * FROM CLIENTES WHERE NOMBRE =" + "'" + CbxNombreM.Text + "'";
            }
            else if (Aux == "Clave")
            {
                cadena = "SELECT * FROM CLIENTES WHERE NUM_CLIENTE =" + "'" + CbxClaveM.Text + "'";
            }

            Consultas.CargarConsulta(TxtNombre, TxtClave, TxtCorreo, TxtDireccion, TxtTelefono, cadena);
        
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        public void Limpiar()
        {
            TxtNombre.Text = "";
            TxtClave.Text = "";
            TxtDireccion.Text = "";
            TxtClave.Text = "";
            TxtTelefono.Text = "";
            TxtNombre.Focus();
            TxtCorreo.Text = "";
            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
            pictureBox5.Hide();

        }

        // Eventos

        private void ModificarClientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (b == "si")
            {
                this.Visible = true;
                if (this.Owner != null)
                {
                    this.Owner.Show();
                }
            }
        }

        private void CbxNombreM_SelectedIndexChanged(object sender, EventArgs e)
        {
            Consultardatos();
        }

        private void CbxClaveM_SelectedIndexChanged(object sender, EventArgs e)
        {
            Consultardatos(); 
        }

        private void ModificarClientes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == (Keys.Escape))
            {
                this.Close();
            }
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space) && (e.KeyChar != (char)Keys.Enter))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

        }

        private void TxtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void CbxClaveM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void CbxNombreM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space) && (e.KeyChar != (char)Keys.Enter))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

        }

        private void CbxNombreM_TextChanged(object sender, EventArgs e)
        {
            Consultardatos();
        }

        private void ModificarClientes_Load(object sender, EventArgs e)
        {

        }

        
        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        #region Menustrip

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

        #endregion

        private void CbxClaveM_TextChanged(object sender, EventArgs e)
        {
            Consultardatos();
        }

       
    }
}
