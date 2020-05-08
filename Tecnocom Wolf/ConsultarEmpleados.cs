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
    public partial class DgvConsultarEmpleados : Form
    {
        public DgvConsultarEmpleados()
        {
            InitializeComponent();
            RbNombre.Checked = true;
            this.KeyPreview = true;
        }
        string Aux = "", cadena = "";
        Consultas Consultas = new Consultas();
        string Borrar = "";
        private void ConsultarEmpleados_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == (Keys.Escape))
            {
                this.Close();
            }
        }

        Registros Registros = new Registros();

        public void ConsultarEmpleado()
        {
            DgvConsulta.Rows.Clear();
            if (Aux == "Nombre")
            {
                cadena = "SELECT * FROM EMPLEADOS WHERE NOMBRE =" + "'" + CbxNombre.Text + "'";
            }
            else if (Aux == "Clave")
            {
                cadena = "SELECT * FROM EMPLEADOS WHERE CLAVE_EMPLEADO =" + "'" + CbxClaveE.Text + "'";
            }
            Consultas.ConsultasEmpleadosDgv(DgvConsulta, cadena);
        }

        private void DgvConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.DgvConsulta.Columns[e.ColumnIndex].Name.Equals("Eliminar"))
            {
                if (MessageBox.Show("¿Seguro Que Desea Borrar?", "Borrar Empleado", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    Borrar = DgvConsulta.CurrentRow.Cells[1].Value.ToString();

                    Registros.BorrarEmpleado(Borrar);
                    CbxNombre.Items.Clear();
                    CbxClaveE.Items.Clear();
                    Consultas.ConsultarEmpleados(CbxNombre, CbxClaveE, null, Aux);
                    CbxNombre.Text = CbxNombre.Items[0].ToString();
                    MessageBox.Show("Empleado Borrado Correctamente");
                }
                
            }  
        }

        //Eventos

        private void ConsultarEmpleados_FormClosing(object sender, FormClosingEventArgs e)
        {
            Trabajadores T = new Trabajadores();
            T.Show();
        }

        private void RbNombre_CheckedChanged(object sender, EventArgs e)
        {
            CbxClaveE.Text = "";
            CbxNombre.Items.Clear();
            CbxClaveE.Enabled = false;
            CbxNombre.Enabled = true;
            Aux = "Nombre";
            
            Consultas.ConsultarEmpleados(CbxNombre, CbxClaveE, null, Aux);
            CbxNombre.Text = CbxNombre.Items[0].ToString();
        }

        private void RbClave_CheckedChanged(object sender, EventArgs e)
        {
            CbxNombre.Text = "";
            CbxClaveE.Items.Clear();
            CbxNombre.Enabled = false;
            CbxClaveE.Enabled = true;
            Aux = "Clave";
            
            Consultas.ConsultarEmpleados(CbxNombre, CbxClaveE, null, Aux);
            CbxClaveE.Text = CbxClaveE.Items[0].ToString();
        }

        private void CbxNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConsultarEmpleado();
        }

        private void CbxClaveE_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConsultarEmpleado();
        }

        private void CbxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space) && (e.KeyChar != (char)Keys.Enter))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void CbxClaveE_KeyPress(object sender, KeyPressEventArgs e)
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

        private void CbxNombre_TextChanged(object sender, EventArgs e)
        {
            ConsultarEmpleado();
        }

        private void DgvConsultarEmpleados_Load(object sender, EventArgs e)
        {

        }
        private void CbxClaveE_TextChanged(object sender, EventArgs e)
        {
            ConsultarEmpleado();
        }

        
    }
}
