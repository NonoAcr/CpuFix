﻿namespace Tecnocom_Wolf
{
    partial class Bienvenido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bienvenido));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Reg_empleado = new System.Windows.Forms.ToolStripMenuItem();
            this.Cons_empleado = new System.Windows.Forms.ToolStripMenuItem();
            this.Mod_empleado = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Reg_cliente = new System.Windows.Forms.ToolStripMenuItem();
            this.Mod_cliente = new System.Windows.Forms.ToolStripMenuItem();
            this.Cons_cliente = new System.Windows.Forms.ToolStripMenuItem();
            this.tareasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Add_tarea = new System.Windows.Forms.ToolStripMenuItem();
            this.Cons_tarea = new System.Windows.Forms.ToolStripMenuItem();
            this.respaldoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblNomUs = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empleadosToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.tareasToolStripMenuItem,
            this.respaldoToolStripMenuItem,
            this.cerrarSesionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(437, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Reg_empleado,
            this.Cons_empleado,
            this.Mod_empleado});
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            // 
            // Reg_empleado
            // 
            this.Reg_empleado.Name = "Reg_empleado";
            this.Reg_empleado.Size = new System.Drawing.Size(125, 22);
            this.Reg_empleado.Text = "Registrar";
            this.Reg_empleado.Click += new System.EventHandler(this.Reg_empleado_Click);
            // 
            // Cons_empleado
            // 
            this.Cons_empleado.Name = "Cons_empleado";
            this.Cons_empleado.Size = new System.Drawing.Size(125, 22);
            this.Cons_empleado.Text = "Consultar";
            this.Cons_empleado.Click += new System.EventHandler(this.Cons_empleado_Click);
            // 
            // Mod_empleado
            // 
            this.Mod_empleado.Name = "Mod_empleado";
            this.Mod_empleado.Size = new System.Drawing.Size(125, 22);
            this.Mod_empleado.Text = "Modificar";
            this.Mod_empleado.Click += new System.EventHandler(this.Mod_empleado_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Reg_cliente,
            this.Mod_cliente,
            this.Cons_cliente});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // Reg_cliente
            // 
            this.Reg_cliente.Name = "Reg_cliente";
            this.Reg_cliente.Size = new System.Drawing.Size(125, 22);
            this.Reg_cliente.Text = "Registrar";
            this.Reg_cliente.Click += new System.EventHandler(this.Reg_cliente_Click);
            // 
            // Mod_cliente
            // 
            this.Mod_cliente.Name = "Mod_cliente";
            this.Mod_cliente.Size = new System.Drawing.Size(125, 22);
            this.Mod_cliente.Text = "Modificar";
            this.Mod_cliente.Click += new System.EventHandler(this.Mod_cliente_Click);
            // 
            // Cons_cliente
            // 
            this.Cons_cliente.Name = "Cons_cliente";
            this.Cons_cliente.Size = new System.Drawing.Size(125, 22);
            this.Cons_cliente.Text = "Consultar";
            this.Cons_cliente.Click += new System.EventHandler(this.Cons_cliente_Click);
            // 
            // tareasToolStripMenuItem
            // 
            this.tareasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Add_tarea,
            this.Cons_tarea});
            this.tareasToolStripMenuItem.Name = "tareasToolStripMenuItem";
            this.tareasToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.tareasToolStripMenuItem.Text = "Servicios";
            // 
            // Add_tarea
            // 
            this.Add_tarea.Name = "Add_tarea";
            this.Add_tarea.Size = new System.Drawing.Size(125, 22);
            this.Add_tarea.Text = "Agregar";
            this.Add_tarea.Click += new System.EventHandler(this.Add_tarea_Click);
            // 
            // Cons_tarea
            // 
            this.Cons_tarea.Name = "Cons_tarea";
            this.Cons_tarea.Size = new System.Drawing.Size(125, 22);
            this.Cons_tarea.Text = "Consultar";
            this.Cons_tarea.Click += new System.EventHandler(this.Cons_tarea_Click);
            // 
            // respaldoToolStripMenuItem
            // 
            this.respaldoToolStripMenuItem.Name = "respaldoToolStripMenuItem";
            this.respaldoToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.respaldoToolStripMenuItem.Text = "Respaldo";
            this.respaldoToolStripMenuItem.Click += new System.EventHandler(this.respaldoToolStripMenuItem_Click);
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // lblNomUs
            // 
            this.lblNomUs.AutoSize = true;
            this.lblNomUs.BackColor = System.Drawing.Color.Transparent;
            this.lblNomUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomUs.Location = new System.Drawing.Point(131, 35);
            this.lblNomUs.Name = "lblNomUs";
            this.lblNomUs.Size = new System.Drawing.Size(77, 24);
            this.lblNomUs.TabIndex = 12;
            this.lblNomUs.Text = "Prueba";
            // 
            // Bienvenido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tecnocom_Wolf.Properties.Resources.fondo_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(437, 318);
            this.Controls.Add(this.lblNomUs);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Bienvenido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Bienvenido_FormClosing);
            this.Load += new System.EventHandler(this.Bienvenido_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Bienvenido_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tareasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Reg_empleado;
        private System.Windows.Forms.ToolStripMenuItem Cons_empleado;
        private System.Windows.Forms.ToolStripMenuItem Mod_empleado;
        private System.Windows.Forms.ToolStripMenuItem Reg_cliente;
        private System.Windows.Forms.ToolStripMenuItem Mod_cliente;
        private System.Windows.Forms.ToolStripMenuItem Cons_cliente;
        private System.Windows.Forms.ToolStripMenuItem Add_tarea;
        private System.Windows.Forms.ToolStripMenuItem Cons_tarea;
        private System.Windows.Forms.ToolStripMenuItem respaldoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.Label lblNomUs;
    }
}

