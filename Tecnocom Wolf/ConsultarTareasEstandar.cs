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
    public partial class ConsultarTareasEstandar : Form
    {
        public ConsultarTareasEstandar()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }
        public string b = "";
        public int count = 0;
        string cadena = "";
        string Aux = "";

        Consultas Consultas = new Consultas();
       
        /*private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (TxtClaveTarea.Text == "")
            {
                MessageBox.Show("Datos Incompletos");
                TxtClaveTarea.Focus();
            }
            else
            {      
                    //Consultas.ConsultaDatos(DgvConsulta, CbxClaveT);
            }
        }
        */

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            DgvConsulta.Rows.Clear();
        }

        private void ConsultarTareas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == (Keys.Escape))
            {
                this.Close();
            }
        }

        private void ConsultarTareas_FormClosing(object sender, FormClosingEventArgs e)
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

        private void DgvConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DgvConsulta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Registros Registros = new Registros();
            if (this.DgvConsulta.Columns[e.ColumnIndex].Name.Equals("Modificar"))
            {
                Registros.ModificarTrabajo(DgvConsulta);
                DgvConsulta.Rows.Clear();
                //TxtClaveTarea.Text = "";
                CbxClaveT.Focus();
                MessageBox.Show("Actualizacion Correcta");
            }else
                if (this.DgvConsulta.Columns[e.ColumnIndex].Name.Equals("Borrar"))
            {
                if (MessageBox.Show("¿Seguro Que Desea Borrar?", "Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    Registros.borrarTarea(DgvConsulta);
                    DgvConsulta.Rows.Clear();
                    //TxtClaveTarea.Text = "";
                    CbxClaveT.Focus();
                    MessageBox.Show("La Tarea Se Borro Exitosamente");
                }
            }
        }

        private void ConsultarTareas_Load(object sender, EventArgs e)
        {

        }

        private void TxtClaveTarea_KeyPress(object sender, KeyPressEventArgs e)
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
            this.Dispose();
            Login log = new Login();
            log.Show();
            this.Close();
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

        private void ConsultarTareasEstandar_KeyPress(object sender, KeyPressEventArgs e)
        {
            timer1.Stop();
            timer1.Start();
            count = 0;
        }

        private void ConsultarTareasEstandar_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Start();
            count = 0;
        }

        #endregion

        private void RbClave_CheckedChanged(object sender, EventArgs e)
        {
            Aux = "Clave";
            Consultas.ConsultasCbxTarea(CbxClaveT, null, Aux);
            CbxClaveT.Text = CbxClaveT.Items[0].ToString();
        }

        public void Consultar()
        {
            //cadena = "";
            //Consultas.ConsultasCbxTarea(CbxClaveT, cadena, Aux);
        }

        private void CbxClaveT_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConsultarDatosTarea();
        }
        private void ConsultarDatosTarea()
        {
            DgvConsulta.Rows.Clear();
            if (Aux == "Nombre")
            {
                //cadena = "SELECT * FROM EMPLEADOS WHERE NOMBRE =" + "'" + CbxNombre.Text + "'";
            }
            else if (Aux == "Clave")
            {
                cadena = "SELECT * FROM EMPLEADOS WHERE CLAVE_EMPLEADO =" + "'" + CbxClaveT.Text + "'";
            }
            Consultas.ConsultaDatos(DgvConsulta, cadena, CbxClaveT);
            //Consultas.ConsultaDatos(DgvConsulta, CbxClaveT);
        }
    }
}
