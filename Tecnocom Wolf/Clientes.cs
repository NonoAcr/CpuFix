﻿using System;
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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        public string b = "";

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
   
            this.Dispose();
            RegistrarClientes RC = new RegistrarClientes();
            RC.Show();
            b = "no";
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            
            this.Dispose();
            ConsultarClientes CC = new ConsultarClientes();
            CC.Show();
            b = "no";

        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            ModificarClientes MC = new ModificarClientes();
            MC.Show();
            b = "no";
        }

        //Eventos

        private void Clientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            if (b == "si")
            {
                this.Visible = true;
                if(this.Owner != null)
                { 
                this.Owner.Show();
                }
            }
        }

        private void Clientes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == (Keys.Escape))
            {
                this.Close();
            }
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            b = "si";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            
            if (tipoUsuario.tipoUs == "ADMINISTRADOR")
            {
                Bienvenido Prin = new Bienvenido();
                Prin.Show();
                this.Close();
                /*this.Visible = true;
                this.Owner.Show();*/
            }
            else
            {
                Estandar Est = new Estandar();
                Est.Show();
                this.Close();
            }
        }
    }
}