using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Tecnocom_Wolf
{
    class Validaciones
    {
        public void ValidarRegistrarClientes(TextBox TxtNombre, TextBox TxtIdClave, TextBox TxtDireccion, TextBox TxtCorreo, MaskedTextBox mtbTelefono, PictureBox pictureBox1,
        PictureBox pictureBox2, PictureBox pictureBox3, PictureBox pictureBox4, PictureBox pictureBox5)
        {
            string Clave = "", Operacion = "";
            bool bande = true;
            bool band = true;
            string N = TxtNombre.Text;
            string C = TxtIdClave.Text;
            string T = mtbTelefono.Text;
            string D = TxtDireccion.Text;
            Consultas Consultas = new Consultas();
            Registros Registros = new Registros();


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
                if (mtbTelefono.Text == "")
                {
                    pictureBox4.Show();
                    bande = false;
                }
                if (TxtNombre.Text == "")
                {
                    pictureBox1.Show();
                    bande = false;
                }

                if (TxtIdClave.Text == "")
                {
                    pictureBox2.Show();
                    bande = false;
                }

                Clave = Consultas.VerificarClave(TxtIdClave);
                if (bande == true)
                {

                    if (Clave == TxtIdClave.Text)
                    {
                        MessageBox.Show("La Clave Del Cliente Ya Existe");
                    }
                    else
                    {
                        Registros.RegistrarClientes_ModificarClientes(TxtNombre, TxtIdClave, TxtDireccion, TxtCorreo, mtbTelefono, Operacion);
                        MessageBox.Show("Agregado");
                        Limpiar(TxtNombre, TxtIdClave, TxtDireccion, TxtCorreo, mtbTelefono, pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5);

                    }
                }
                else
                {
                    MessageBox.Show("Los campos señalados son obligatorios. Favor de llenarlos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
        }
        public void Limpiar(TextBox TxtNombre, TextBox TxtClave, TextBox TxtDireccion, TextBox TxtCorreo, MaskedTextBox mtbTelefono, PictureBox pictureBox1,
        PictureBox pictureBox2, PictureBox pictureBox3, PictureBox pictureBox4, PictureBox pictureBox5)
        {
            TxtNombre.Text = "";
            TxtClave.Text = "";
            TxtCorreo.Text = "";
            TxtDireccion.Text = "";
            TxtClave.Text = "";
            mtbTelefono.Text = "";
            TxtNombre.Focus();
            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
            pictureBox5.Hide();
        }
        public void ValidarRegistrarEmpleado(TextBox TxtNombreE, ComboBox CbxTipoE, TextBox TxtCEmpleado, TextBox TxtIDUsuaro, TextBox TxtContraseña, PictureBox pictureBox1,
        PictureBox pictureBox2, PictureBox pictureBox3, PictureBox pictureBox4, PictureBox pictureBox5)
        {
            /*Patron de diseño Cadena de responsabilidad*/
            string Clave = "", Operacion = "", IdUsuario = "";
            bool bande = true;
            bool band = true;
            string N = TxtNombreE.Text;
            string C = TxtCEmpleado.Text;
            string U = TxtIDUsuaro.Text;
            Consultas Consultas = new Consultas();
            Registros Registros = new Registros();

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
            /*Patron de diseño Estado*/
            if (band == true)
            {
                if (TxtCEmpleado.Text == "")
                {
                    pictureBox3.Show();
                    bande = false;
                }
                if (TxtContraseña.Text == "")
                {
                    pictureBox5.Show();
                    bande = false;
                }
                if (TxtIDUsuaro.Text == "")
                {
                    pictureBox4.Show();
                    bande = false;
                }
                if (TxtNombreE.Text == "")
                {
                    pictureBox1.Show();
                    bande = false;
                }

                if (CbxTipoE.Text == "")
                {
                    pictureBox2.Show();
                    bande = false;
                }

                if (bande == true)
                {
                    IdUsuario = Consultas.VerificarIdUser(TxtIDUsuaro);
                    Clave = Consultas.VerificarClaveEmpleado(TxtCEmpleado);
                    if (IdUsuario == TxtIDUsuaro.Text)
                    {
                        MessageBox.Show("El id de usuario Ya Se Encuentra Registrada");
                        TxtIDUsuaro.Focus();
                    }
                    else if(Clave == TxtCEmpleado.Text)
                    {
                        MessageBox.Show("La Clave De Empleado Ya Se Encuentra Registrada");
                        TxtCEmpleado.Focus();
                    }
                    else
                    {
                        Registros.RegistrarEmpleado_ModificarEmpleado(TxtNombreE, TxtCEmpleado, TxtIDUsuaro, TxtContraseña, CbxTipoE, Operacion);
                        LimpiarE(TxtNombreE, CbxTipoE, TxtCEmpleado, TxtIDUsuaro, TxtContraseña, pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5);
                        MessageBox.Show("Datos Agregados Correctamente");
                    }
                }
                else
                {
                    MessageBox.Show("Los campos señalados son obligatorios. Favor de llenarlos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        public void LimpiarE(TextBox TxtNombreE, ComboBox CbxTipoE, TextBox TxtCEmpleado, TextBox TxtIDUsuaro, TextBox TxtContraseña, PictureBox pictureBox1,
        PictureBox pictureBox2, PictureBox pictureBox3, PictureBox pictureBox4, PictureBox pictureBox5)
        {
            TxtNombreE.Clear();
            TxtIDUsuaro.Clear();
            TxtContraseña.Clear();
            TxtCEmpleado.Clear();
            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
            pictureBox5.Hide();
        }

        public void RegistrarTrabajos(ComboBox cbxNombreCliente, TextBox TxtNumeroC, ComboBox cbxClaveEmp, TextBox TxtCTarea,
         ComboBox CbxTipoReparacion, ComboBox CbxSOI, ComboBox CbxSO, ComboBox CbxTipoPC, TextBox TxtDescripcion, ComboBox cbxAnticipo,
         ComboBox cbxEstado, TextBox txtPago,
         PictureBox pictureBox1, PictureBox pictureBox2, PictureBox pictureBox3, PictureBox pictureBox4, PictureBox pictureBox5,
         PictureBox pictureBox6, PictureBox pictureBox7, PictureBox pictureBox8, PictureBox pictureBox9, PictureBox pictureBox10
         , PictureBox pictureBox11, PictureBox pictureBox12, PictureBox pictureBox13, DateTimePicker DtpFecha)
        {
            bool bande = true;
            bool band = true;
            string CT = TxtCTarea.Text;
            string D = TxtDescripcion.Text;
            /*Patron de diseño Mediador*/
            Registros Registros = new Registros();
            Consultas Consultas = new Consultas();
            string Clavet = "", ClaveE = "", ClaveC = "";

            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
            pictureBox5.Hide();
            pictureBox6.Hide();
            pictureBox7.Hide();
            pictureBox8.Hide();
            pictureBox9.Hide();
            pictureBox10.Hide();
            pictureBox11.Hide();
            pictureBox12.Hide();
            pictureBox13.Hide();
            if (CT.Length > 2)
            {
                band = false;
                MessageBox.Show("Clave Tarea maximo 2 numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (band == true)
            {
                if (cbxNombreCliente.Text == "")
                {
                    pictureBox1.Show();
                    bande = false;
                }
                if (TxtNumeroC.Text == "")
                {
                    pictureBox3.Show();
                    bande = false;
                }
                if (cbxClaveEmp.Text == "")
                {
                    pictureBox4.Show();
                    bande = false;
                }
                if (TxtCTarea.Text == "")
                {
                    pictureBox5.Show();
                    bande = false;
                }
                if (CbxTipoReparacion.Text == "")
                {
                    pictureBox6.Show();
                    bande = false;
                }
                if (CbxSOI.Text == "")
                {
                    pictureBox7.Show();
                    bande = false;
                }
                if (CbxSO.Text == "")
                {
                    pictureBox8.Show();
                    bande = false;
                }
                if (CbxTipoPC.Text == "")
                {
                    pictureBox9.Show();
                    bande = false;
                }
                if (TxtDescripcion.Text == "")
                {
                    pictureBox13.Show();
                    bande = false;
                }
                if(cbxAnticipo.Text == "")
                {
                    pictureBox10.Show();
                    bande = false;
                }
                if(cbxEstado.Text == "")
                {
                    pictureBox11.Show();
                    bande = false;
                }
                if(txtPago.Text == "")
                {
                    pictureBox12.Show();
                    bande = false;
                }
                if (D.Length < 10)
                {
                    band = false;
                    MessageBox.Show("Descripción minima 10 caracteres", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    pictureBox9.Show();
                }
                if (D.Length > 100)
                {
                    band = false;
                    MessageBox.Show("Descripción maxima 100 caracteres", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    pictureBox9.Show();
                }
                Clavet = Consultas.COnsultarClavetarea(TxtCTarea, Clavet);
               /* ClaveE = Consultas.CEmpleado(TxtCEmpleado, ClaveE);
                ClaveC = Consultas.CCliente(TxtNumeroC, ClaveC);*/
                if (bande == true)
                {
                    if (Clavet == TxtCTarea.Text)
                    {
                        MessageBox.Show("La Clave De Tarea Ya Se Encuenta Registrada");
                        TxtCTarea.Focus();
                    }
                    else
                    /*if (ClaveE != TxtCEmpleado.Text)
                    {
                        MessageBox.Show("El Empleado No Esta Registrado");
                        TxtCEmpleado.Focus();
                    }
                    else if (ClaveC != TxtNumeroC.Text)
                    {
                        MessageBox.Show("El Cliente No esta Registrado");
                    }
                    else*/
                    {
                        Registros.Registrartareas(cbxClaveEmp, TxtNumeroC, TxtCTarea, CbxTipoPC, CbxTipoReparacion, CbxSO, CbxSOI, TxtDescripcion,
                            cbxAnticipo, cbxEstado, txtPago, DtpFecha);
                        MessageBox.Show("Tarea Registrada Correctamente");
                    }

                }
                else
                {
                    MessageBox.Show("Los campos señalados son obligatorios. Favor de llenarlos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
