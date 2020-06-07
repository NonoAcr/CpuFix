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
    public partial class ModificarEmpleado : Form
    {
        public ModificarEmpleado()
        {
            InitializeComponent();
            RbNombre.Checked = true;
            this.KeyPreview = true;
        }

        public string b = "";
        string Operacion = "", Clave = "", Aux= "", cadena = "";
        Registros Registros = new Registros();
        Consultas Consultas = new Consultas();

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            bool bande = true;
            bool band = true;
            string N = TxtNombre.Text;
            string C = TxtCEmpleado.Text;
            string U = TxtUsuario.Text;
            string P = TxtContraseñas.Text;
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
                MessageBox.Show("Clave Empleado maximo 2 numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (U.Length > 6)
            {
                band = false;
                MessageBox.Show("Id. Usuario maxima 6 caracteres", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (band == true)
            {
                if (TxtCEmpleado.Text == "")
                {
                    pictureBox3.Show();
                    bande = false;
                }
                if (TxtContraseñas.Text == "")
                {
                    pictureBox5.Show();
                    bande = false;
                }
                if (TxtUsuario.Text == "")
                {
                    pictureBox4.Show();
                    bande = false;
                }
                if (TxtNombre.Text == "")
                {
                    pictureBox1.Show();
                    bande = false;
                }

                if (CbxTipo.Text == "")
                {
                    pictureBox2.Show();
                    bande = false;
                }
                if (bande == true)
                {
                    Operacion = "Actualizar";
                    Registros.RegistrarEmpleado_ModificarEmpleado(TxtNombre, TxtCEmpleado, TxtUsuario, TxtContraseñas, CbxTipo, Operacion);
                    CbxNombres.Items.Clear();
                    CbxClave.Items.Clear();

                    Consultas.ConsultarEmpleados(CbxNombres, CbxClave, null, Aux);
                    if (Aux == "Nombre") { CbxNombres.Text = CbxNombres.Items[0].ToString(); }
                    else { CbxClave.Text = CbxClave.Items[0].ToString(); }
                    MessageBox.Show("Datos Actualizados Correctamente");
                }
                else
                {
                    MessageBox.Show("Los campos señalados son obligatorios. Favor de llenarlos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void ModificarEmpleado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == (Keys.Escape))
            {
                this.Close();
            }
        }

        private void RbNombre_CheckedChanged(object sender, EventArgs e)
        {
            CbxNombres.Items.Clear();
            CbxClave.Text = "";
            CbxNombres.Enabled = true;
            CbxClave.Enabled = false;
            Aux = "Nombre";
            Consultas.ConsultarEmpleados (CbxNombres, CbxClave, null, Aux);
            CbxNombres.Text = CbxNombres.Items[0].ToString();

        }
        public void CargarDatosEmpleado()
        {
            if (Aux == "Nombre")
            {
                cadena = "SELECT * FROM EMPLEADOS WHERE NOMBRE =" + "'" + CbxNombres.Text + "'";
            }
            else if (Aux == "Clave")
            {
                cadena = "SELECT * FROM EMPLEADOS WHERE CLAVE_EMPLEADO =" + "'" + CbxClave.Text + "'";
            }

            Consultas.CargarConsulta_Empleados(TxtNombre, TxtCEmpleado, TxtUsuario, TxtContraseñas, CbxTipo, cadena);
        }

        //Eventos

        private void CbxNombres_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarDatosEmpleado();
        }

        private void CbxClave_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarDatosEmpleado();
        }

        private void CbxNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space) && (e.KeyChar != (char)Keys.Enter))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void CbxClave_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space) && (e.KeyChar != (char)Keys.Enter))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TxtCEmpleado_KeyPress(object sender, KeyPressEventArgs e)
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

        private void CbxTipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
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

        private void CbxNombres_TextChanged(object sender, EventArgs e)
        {
            CargarDatosEmpleado();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtNombre.Text = "";
            CbxTipo.Text = "";
            TxtCEmpleado.Text = "";
            TxtUsuario.Text = "";
            TxtContraseñas.Text = "";
            TxtNombre.Focus();
            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
            pictureBox5.Hide();
            lblBaja.Hide();
            lblMedia.Hide();
            lblSegura.Hide();
        }

        private void TxtContraseñas_TextChanged(object sender, EventArgs e)
        {
            string s = TxtContraseñas.Text;
            if (s == "")
            {
                lblBaja.Hide();
                lblMedia.Hide();
                lblSegura.Hide();
            }
            if (s.Length <= 3)
            {
                lblBaja.Show();
                lblMedia.Hide();
                lblSegura.Hide();
            }
            if (s.Length >= 4 && s.Length <= 7)
            {
                lblBaja.Hide();
                lblMedia.Show();
                lblSegura.Hide();
            }
            if (s.Length >= 9)
            {
                lblBaja.Hide();
                lblMedia.Hide();
                lblSegura.Show();
            }
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

        private void CbxClave_TextChanged(object sender, EventArgs e)
        {
            CargarDatosEmpleado();
        }

        private void RbClave_CheckedChanged(object sender, EventArgs e)
        {
            CbxClave.Items.Clear();
            CbxNombres.Text = "";
            CbxNombres.Enabled = false;
            CbxClave.Enabled = true;
            Aux = "Clave";

            Consultas.ConsultarEmpleados(CbxNombres, CbxClave, null, Aux);
            CbxClave.Text = CbxClave.Items[0].ToString();
        }

        private void ModificarEmpleado_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
