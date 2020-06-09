using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace Tecnocom_Wolf
{
    class Consultas
    {
        SqlConnection Conexion = new SqlConnection("server = LAPTOP-43NCBRR5\\SQLEXPRESS; Initial Catalog = cpu_fix; integrated security = true");
        SqlDataReader sqldr;
                 
         /*Clientes*/
        
        public void Consultar(DataGridView Consultas, string Cadena)
        {
            /*Este metodo se utiliza para agregar los datos de la busqueda al datagridview
             de la interfaz ConsultarClientes*/

            Conexion.Open();
            SqlCommand comando = new SqlCommand(Cadena, Conexion);
            sqldr = comando.ExecuteReader();
            while (sqldr.Read())
            {

                Consultas.Rows.Add(sqldr["NUM_CLIENTE"].ToString(), sqldr["NOMBRE"].ToString(), sqldr["CELULAR"].ToString(), (sqldr["DIRECCION"].ToString()), sqldr["CORREO"].ToString());
            }

            Conexion.Close();
        }
        public void ConsultasCbx(ComboBox Nombre, ComboBox Clave, string Cadena, string Aux)
        {
            /*Este metodo se utiliza para cargar los datos a los combobox de busqueda de las
             interfaces Consultar clientes y modificar clientes */

            if (Aux == "Nombre")
            {
                
                Cadena = "SELECT DISTINCT NOMBRE  FROM CLIENTES";
            }
            else if (Aux == "Clave")
            {
                Cadena = "SELECT DISTINCT NUM_CLIENTE  FROM CLIENTES";
            }
            Conexion.Open();
            SqlCommand comando = new SqlCommand(Cadena, Conexion);
            sqldr = comando.ExecuteReader();
            while (sqldr.Read())
            {
                if (Aux == "Nombre")
                {
                    Nombre.Items.Add(sqldr["NOMBRE"].ToString());
                }
                else if (Aux == "Clave")
                {
                    Clave.Items.Add(sqldr["NUM_CLIENTE"].ToString());
                }
            }

            Conexion.Close();
        }

        public void ConsultasCbxTarea(ComboBox Clave, string Cadena, string Aux)
        {
            if (Aux == "Nombre")
            {

                Cadena = "SELECT DISTINCT CLAVE_TRABAJO  FROM CONSULTARDATOS";
            }
            else if (Aux == "Clave")
            {
                Cadena = "SELECT DISTINCT CLAVE_TRABAJO FROM CONSULTARDATOS";
            }
            Conexion.Open();
            SqlCommand comando = new SqlCommand(Cadena, Conexion);
            sqldr = comando.ExecuteReader();
            while (sqldr.Read())
            {
                if (Aux == "Nombre")
                {
                    //Nombre.Items.Add(sqldr["NOMBRE"].ToString());
                }
                else if (Aux == "Clave")
                {
                    Clave.Items.Add(sqldr["CLAVE_TRABAJO"].ToString());
                }
            }

            Conexion.Close();
        }
        public void ConsultasCbxRegisClav(ComboBox Clave, string Cadena, string Aux)
        {
            if (Aux == "Clave")
            {
                Cadena = "SELECT DISTINCT NUM_CLIENTE FROM CLIENTES";
            }
            Conexion.Open();
            SqlCommand comando = new SqlCommand(Cadena, Conexion);
            sqldr = comando.ExecuteReader();
            while (sqldr.Read())
            {
                if (Aux == "Clave")
                {
                    Clave.Items.Add(sqldr["NUM_CLIENTE"].ToString());
                }
            }
            Conexion.Close();
        }
        public void ConsultasCbxRegisNomb(ComboBox Nombre, string Cadena, string Aux)
        {
            if (Aux == "Nombre")
            {
                Cadena = "SELECT DISTINCT NOMBRE  FROM CLIENTES";
            }
            Conexion.Open();
            SqlCommand comando = new SqlCommand(Cadena, Conexion);
            sqldr = comando.ExecuteReader();
            while (sqldr.Read())
            {
                if (Aux == "Nombre")
                {
                    Nombre.Items.Add(sqldr["NOMBRE"].ToString());
                }
            }
            Conexion.Close();
        }

        public void ConsultasCbxRegisClavEmpl(ComboBox Clave, string Cadena, string Aux)
        {
            if (Aux == "Clave")
            {
                Cadena = "SELECT DISTINCT CLAVE_EMPLEADO FROM EMPLEADOS";
            }
            Conexion.Open();
            SqlCommand comando = new SqlCommand(Cadena, Conexion);
            sqldr = comando.ExecuteReader();
            while (sqldr.Read())
            {
                if (Aux == "Clave")
                {
                    Clave.Items.Add(sqldr["CLAVE_EMPLEADO"].ToString());
                }
            }
            Conexion.Close();
    }
        public void CargarConsulta(TextBox Nombre, TextBox Clave, TextBox Correo, TextBox Direccion, MaskedTextBox Telefono, string Cadena)
        {
            /*Este metodo se utiliza para agregar los datos de la consulta a los 
             textbox de la interfaz ModificarCliente*/

            Conexion.Open();
            SqlCommand comando = new SqlCommand(Cadena, Conexion);
            sqldr = comando.ExecuteReader();

            while (sqldr.Read())
            {
                Nombre.Text = sqldr["NOMBRE"].ToString();
                Clave.Text = sqldr["NUM_CLIENTE"].ToString();
                Correo.Text = sqldr["CORREO"].ToString();
                Direccion.Text = sqldr["DIRECCION"].ToString();
                Telefono.Text = sqldr["CELULAR"].ToString();

            }

            Conexion.Close();
        }
        public void CargarConsultaS(TextBox Numero, TextBox Nombre, string Cadena)
        {
            /* Metodo para verificar cliente en la interfaz de servicios*/

            Conexion.Open();
            SqlCommand comando = new SqlCommand(Cadena, Conexion);
            sqldr = comando.ExecuteReader();

            while (sqldr.Read())
            {
                Nombre.Text = sqldr["NOMBRE"].ToString();
                Numero.Text = sqldr["NUM_CLIENTE"].ToString();
            }
            Conexion.Close();
        }
        private void CargarConsultaClavEmp(ComboBox Clave, string Cadena)
        {
            Conexion.Open();
            SqlCommand comando = new SqlCommand(Cadena, Conexion);
            sqldr = comando.ExecuteReader();

            while (sqldr.Read())
            {
                Clave.Text = sqldr["CLAVE_EMPLEADO"].ToString();
            }
            Conexion.Close();
        }

        public void CargarConsultaClavEmpl(ComboBox Nombre, string Cadena)
        {
            /* Metodo para verificar cliente en la interfaz de servicios*/

            Conexion.Open();
            SqlCommand comando = new SqlCommand(Cadena, Conexion);
            sqldr = comando.ExecuteReader();

            while (sqldr.Read())
            {
                Nombre.Text = sqldr["NOMBRE"].ToString();
            }
            Conexion.Close();
        }
        public string VerificarClave(TextBox TxtClave)
        {
            /*Este metodo sirve para verificar si la clave ya se encuentra 
              registrada o esta disponible se utiliza en la interfaz de RegistroClientes*/
            string Cadena = "", Clave = ""; 
            Cadena = "SELECT *  FROM CLIENTES WHERE NUM_CLIENTE =" + "'" + TxtClave.Text + "'";
            Conexion.Open();
            SqlDataReader sqldr;
            SqlCommand comando = new SqlCommand(Cadena, Conexion);
            sqldr = comando.ExecuteReader();
            while (sqldr.Read())
            {
                Clave = sqldr["NUM_CLIENTE"].ToString();
            }

            Conexion.Close();
            return Clave; 
        }

        /*Empleados*/

        public string VerificarClaveEmpleado(TextBox TxtClave)
        {
            string Cadena = "", Clave = "";
            Cadena = "SELECT *  FROM EMPLEADOS WHERE CLAVE_EMPLEADO =" + "'" + TxtClave.Text + "'";
            Conexion.Open();
            SqlDataReader sqldr;
            SqlCommand comando = new SqlCommand(Cadena, Conexion);
            sqldr = comando.ExecuteReader();
            while (sqldr.Read())
            {
                Clave = sqldr["CLAVE_EMPLEADO"].ToString();
            }
            Conexion.Close();
            return Clave;
        }
        public string VerificarIdUser(TextBox TxtIDUsuaro)
        {
            string Cadena = "", IdUsuario = "";
            Cadena = "SELECT *  FROM EMPLEADOS WHERE ID_USUARIO =" + "'" + TxtIDUsuaro.Text + "'";
            Conexion.Open();
            SqlDataReader sqldr;
            SqlCommand comando = new SqlCommand(Cadena, Conexion);
            sqldr = comando.ExecuteReader();
            while (sqldr.Read())
            {
                IdUsuario = sqldr["ID_USUARIO"].ToString();
            }

            Conexion.Close();
            return IdUsuario;
        }

        public void ConsultarEmpleados(ComboBox Nombre, ComboBox Clave, string Cadena, string Aux)
        {
            /*Este Metodo Se utiliza para cargar los combobox con los nombre y claves de los empleados*/

            if (Aux == "Nombre")
            {

                Cadena = "SELECT DISTINCT NOMBRE  FROM EMPLEADOS";
            }
            else if (Aux == "Clave")
            {
                Cadena = "SELECT DISTINCT CLAVE_EMPLEADO  FROM EMPLEADOS";
            }
            Conexion.Open();
            SqlCommand comando = new SqlCommand(Cadena, Conexion);
            sqldr = comando.ExecuteReader();
            while (sqldr.Read())
            {
                if (Aux == "Nombre")
                {
                    Nombre.Items.Add(sqldr["NOMBRE"].ToString());
                }
                else if (Aux == "Clave")
                {
                    Clave.Items.Add(sqldr["CLAVE_EMPLEADO"].ToString());
                }

            }

            Conexion.Close();
        }
        public void CargarConsulta_Empleados(TextBox Nombre, TextBox Clave,TextBox Usuario,TextBox Contraseña, ComboBox Tipo, string Cadena)
        {
            /*ESTE METODO SE UTILIZA PARA CARGAR LOS DATOS EN LOS TEXBOX DE LA INTERFAZ MODIFICAREMPLEADO*/

            Conexion.Open();
            SqlCommand comando = new SqlCommand(Cadena, Conexion);
            sqldr = comando.ExecuteReader();

            while (sqldr.Read())
            {
                Nombre.Text = sqldr["NOMBRE"].ToString();
                Clave.Text = sqldr["CLAVE_EMPLEADO"].ToString();
                Usuario.Text = sqldr["ID_USUARIO"].ToString();
                Contraseña.Text = sqldr["CONTRASEÑA"].ToString();
                Tipo.Text = sqldr["TIPO_USUARIO"].ToString();

            }

            Conexion.Close();
        }

        public void ConsultasEmpleadosDgv(DataGridView ConsultasE , string Cadena)
        {
            Conexion.Open();
            SqlCommand comando = new SqlCommand(Cadena, Conexion);
            sqldr = comando.ExecuteReader();
            while (sqldr.Read())
            {

                ConsultasE.Rows.Add(sqldr["NOMBRE"].ToString(), sqldr["CLAVE_EMPLEADO"].ToString(), sqldr["TIPO_USUARIO"].ToString()
                , (sqldr["ID_USUARIO"].ToString()));
            }

            Conexion.Close();
        }

        public void ConsultasTareasDgv()
        {

        }
        public void ConsultaDatos(DataGridView Datos , string Cadena, ComboBox CbxClaveT)
        {
            Cadena = "SELECT  * FROM CONSULTARDATOS WHERE CLAVE_TRABAJO = '" + CbxClaveT.Text + "'";

            Conexion.Open();

            SqlCommand comando = new SqlCommand(Cadena, Conexion);
            sqldr = comando.ExecuteReader();
            while (sqldr.Read())
            {
                Datos.Rows.Add(sqldr["CLAVE_TRABAJO"].ToString(), sqldr["NOMBRE"].ToString(), sqldr["CLAVE_EMPLEADO"].ToString()
                , sqldr["NUM_CLIENTE"].ToString(), sqldr["TIPOPC"].ToString(), sqldr["SISTEMA_OPERATIVO"].ToString()
                , sqldr["SOFTWARE_INSTALACION"].ToString(), sqldr["DESCRIPCION"].ToString(), sqldr["FECHA"].ToString()
                , sqldr["PAGO"].ToString(), sqldr["ESTADO"].ToString(),sqldr["ANTICIPO"].ToString());
            }

            Conexion.Close();
        }
        public string COnsultarClavetarea(TextBox Clave , string ClaveT)
        {
            string Cadena = "";

            Cadena = "SELECT  * FROM DATOS WHERE CLAVE_TRABAJO ='" + Clave.Text + "'";

            Conexion.Open();

            SqlCommand comando = new SqlCommand(Cadena, Conexion);
            sqldr = comando.ExecuteReader();
            while (sqldr.Read())
            {
                 if(Clave.Text == sqldr["CLAVE_TRABAJO"].ToString())
                {
                    ClaveT = sqldr["CLAVE_TRABAJO"].ToString();
                }
            }
            Conexion.Close();
            return ClaveT;
        }

        public string CEmpleado(TextBox CEmpleado, string ClaveE)
        {
            string Cadena = "";

            Cadena = "SELECT  * FROM EMPLEADOS WHERE CLAVE_EMPLEADO ='" + CEmpleado.Text + "'";

            Conexion.Open();

            SqlCommand comando = new SqlCommand(Cadena, Conexion);
            sqldr = comando.ExecuteReader();
            while (sqldr.Read())
            {
                if (CEmpleado.Text == sqldr["CLAVE_EMPLEADO"].ToString())
                {
                    ClaveE = sqldr["CLAVE_EMPLEADO"].ToString();
                }
            }

            Conexion.Close();
            return ClaveE;
        }
        public string CCliente(TextBox CCliente, string ClaveC)
        {
            string Cadena = "";

            Cadena = "SELECT  * FROM CLIENTES WHERE NUM_CLIENTE ='" + CCliente.Text + "'";

            Conexion.Open();

            SqlCommand comando = new SqlCommand(Cadena, Conexion);
            sqldr = comando.ExecuteReader();
            while (sqldr.Read())
            {
                if (CCliente.Text == sqldr["NUM_CLIENTE"].ToString())
                {
                    ClaveC = sqldr["NUM_CLIENTE"].ToString();
                }
            }

            Conexion.Close();
            return ClaveC;
        }
    }
}
