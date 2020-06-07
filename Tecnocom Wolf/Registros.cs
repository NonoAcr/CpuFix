using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Tecnocom_Wolf
{
    class Registros
    {
        SqlConnection Conexion = new SqlConnection("server = DESKTOP-P381C99; Initial Catalog = cpu_fix; integrated security = true");
        string Cadena = "";

        public void RegistrarClientes_ModificarClientes(TextBox TxtNombre, TextBox TxtClave, TextBox TxtDireccion, TextBox TxtCorreo, TextBox TxtTelefono,string Operacion)
        {
            /*Con este metodo se realizan los registros de Clientes en la interfaz RegistrarClientes*/
            if (Operacion == "Actualizar")
            {
                Cadena = "  UPDATE  clientes set NOMBRE = @nom, CELULAR = @telefono, DIRECCION = @direc, CORREO = @correo WHERE NUM_CLIENTE = @Clave";
            }
            else
            {
                Cadena = "insert into clientes(NUM_CLIENTE, NOMBRE, CELULAR, DIRECCION, CORREO) values (@Clave, @nom, @telefono, @direc, @correo)";
            }
            

            SqlCommand com = new SqlCommand(Cadena, Conexion);
            Conexion.Open();
            com.Parameters.AddWithValue("@nom", TxtNombre.Text);
            com.Parameters.AddWithValue("@Clave", TxtClave.Text);
            com.Parameters.AddWithValue("@direc", TxtDireccion.Text);
            com.Parameters.AddWithValue("@correo", TxtCorreo.Text);
            com.Parameters.AddWithValue("@telefono", TxtTelefono.Text);
            com.ExecuteNonQuery();


            Conexion.Close();
        }

                  /*Empleado*/

        public void RegistrarEmpleado_ModificarEmpleado(TextBox TxtNombre, TextBox TxtClave, TextBox TxtUsuario, TextBox TxtContraseña, ComboBox TxtTipoEmpleado, string Operacion)
        {
            /*Con este metodo Se realizan los registros de empleados y su modificaciones de datos*/

            if (Operacion == "Actualizar")
            {
                Cadena = "  UPDATE  EMPLEADOS SET NOMBRE = @NOMBRE, CLAVE_EMPLEADO = @CLAVE_EMPLEADO, ID_USUARIO = @ID_USUARIO, CONTRASEÑA = @CONTRASEÑA, TIPO_USUARIO = @TIPO_USUARIO WHERE CLAVE_EMPLEADO = @CLAVE_EMPLEADO";
            }
            else
            {
                Cadena = "INSERT INTO EMPLEADOS (NOMBRE, CLAVE_EMPLEADO, ID_USUARIO, CONTRASEÑA, TIPO_USUARIO) values (@NOMBRE, @CLAVE_EMPLEADO, @ID_USUARIO, @CONTRASEÑA, @TIPO_USUARIO)";
            }


            SqlCommand com = new SqlCommand(Cadena, Conexion);
            Conexion.Open();
            com.Parameters.AddWithValue("@Nombre", TxtNombre.Text);
            com.Parameters.AddWithValue("@Clave_Empleado", Convert.ToInt32( TxtClave.Text));
            com.Parameters.AddWithValue("@ID_Usuario", TxtUsuario.Text);
            com.Parameters.AddWithValue("@Contraseña", TxtContraseña.Text);
            com.Parameters.AddWithValue("@Tipo_Usuario", TxtTipoEmpleado.Text);
            com.ExecuteNonQuery();


            Conexion.Close();
        }

        public void BorrarEmpleado(string Borrar)
        {
            Cadena = "DELETE FROM EMPLEADOS WHERE CLAVE_EMPLEADO = @CLAVE_EMPLEADO";
            SqlCommand com = new SqlCommand(Cadena, Conexion);
            Conexion.Open();
            com.Parameters.AddWithValue("@CLAVE_EMPLEADO", Borrar);
            com.ExecuteNonQuery();
            Conexion.Close();
            
        }

        public void Registrartareas(ComboBox cbxClaveEmp, TextBox TxtNCliente, TextBox TxtCTarea, ComboBox CbxTipoPc, ComboBox CbxTReparacion,
            ComboBox CbxSO, ComboBox CbxSOI, TextBox TxtDescripcion, ComboBox cbxAnticipo,ComboBox cbxEstado,TextBox txtPago
            ,DateTimePicker DtpFecha )
        {

            Conexion.Open();

            Cadena = "INSERT INTO DATOS (CLAVE_EMPLEADO,CLAVE_TRABAJO,NUM_CLIENTE,TIPOPC,TIPO_REPARACION,SISTEMA_OPERATIVO" +
                ",SOFTWARE_INSTALACION,DESCRIPCION,FECHA,PAGO,ESTADO,ANTICIPO) VALUES (@CEMPLEADO,@CTAREA,@NCLIENTE,@TIPOPC,@TIPOREPARACION" +
                ",@SO,@SOI,@DESCRIPCION,@FECHA,@PAGO,@ESTADO,@ANTICIPO)";
            SqlCommand com = new SqlCommand(Cadena, Conexion);
      
            com.Parameters.AddWithValue("@CEmpleado", cbxClaveEmp.Text);
            com.Parameters.AddWithValue("@NCliente", Convert.ToInt32(TxtNCliente.Text));
            com.Parameters.AddWithValue("@CTarea", TxtCTarea.Text);
            com.Parameters.AddWithValue("@TipoPc", CbxTipoPc.Text);
            com.Parameters.AddWithValue("@TipoReparacion", CbxTReparacion.Text);
            com.Parameters.AddWithValue("@SO", CbxSO.Text);
            com.Parameters.AddWithValue("@SOI", CbxSOI.Text);
            com.Parameters.AddWithValue("@Descripcion", TxtDescripcion.Text);
            com.Parameters.AddWithValue("@Fecha", DtpFecha.Text);
            com.Parameters.AddWithValue("@Pago", txtPago.Text);
            com.Parameters.AddWithValue("@Estado", cbxEstado.Text);
            com.Parameters.AddWithValue("@Anticipo", cbxAnticipo.Text);
            com.ExecuteNonQuery();


            Conexion.Close();
        }

        public void ModificarTrabajo(DataGridView Datos)
        {
            Cadena = "  UPDATE  DATOS SET  CLAVE_EMPLEADO = @CLAVE_EMPLEADO, NUM_CLIENTE = @NUM_CLIENTE, TIPOPC = @TIPOPC," +
                " SISTEMA_OPERATIVO = @SISTEMA_OPERATIVO, SOFTWARE_INSTALACION = @SOFTWARE_INSTALACION,DESCRIPCION = @DESCRIPCION," +
                " PAGO = @PAGO, ESTADO = @ESTADO, ANTICIPO = @ANTICIPO, FECHA = @FECHA WHERE CLAVE_TRABAJO = @CLAVE_TRABAJO";
            SqlCommand com = new SqlCommand(Cadena, Conexion);
            Conexion.Open();
            com.Parameters.AddWithValue("@CLAVE_TRABAJO", Datos.CurrentRow.Cells[0].Value.ToString());
            com.Parameters.AddWithValue("@CLAVE_EMPLEADO", Datos.CurrentRow.Cells[2].Value.ToString());
            com.Parameters.AddWithValue("@NUM_CLIENTE", Datos.CurrentRow.Cells[4].Value.ToString());
            com.Parameters.AddWithValue("@TIPOPC", Datos.CurrentRow.Cells[5].Value.ToString());
            com.Parameters.AddWithValue("@SISTEMA_OPERATIVO", Datos.CurrentRow.Cells[6].Value.ToString());
            com.Parameters.AddWithValue("@SOFTWARE_INSTALACION", Datos.CurrentRow.Cells[7].Value.ToString());
            com.Parameters.AddWithValue("@DESCRIPCION", Datos.CurrentRow.Cells[8].Value.ToString());
            com.Parameters.AddWithValue("@FECHA", Datos.CurrentRow.Cells[9].Value.ToString());
            com.Parameters.AddWithValue("@PAGO", Datos.CurrentRow.Cells[10].Value.ToString());
            com.Parameters.AddWithValue("@ESTADO", Datos.CurrentRow.Cells[11].Value.ToString());
            com.Parameters.AddWithValue("@ANTICIPO", Datos.CurrentRow.Cells[12].Value.ToString());
            com.ExecuteNonQuery();

            Conexion.Close();
        }
        public void borrarTarea(DataGridView Datos)
        {
            Cadena = "DELETE  FROM DATOS WHERE CLAVE_TRABAJO = @CLAVE_TRABAJO";
            SqlCommand com = new SqlCommand(Cadena, Conexion);
            Conexion.Open();

            com.Parameters.AddWithValue("@CLAVE_TRABAJO", Datos.CurrentRow.Cells[0].Value.ToString());
            com.ExecuteNonQuery();
            Conexion.Close();
        }
    }
}
