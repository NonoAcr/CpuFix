namespace Tecnocom_Wolf
{
    partial class Estandar
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Estandar));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Reg_clientes = new System.Windows.Forms.ToolStripMenuItem();
            this.Mod_clientes = new System.Windows.Forms.ToolStripMenuItem();
            this.Cons_clientes = new System.Windows.Forms.ToolStripMenuItem();
            this.tareasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Add_tareas = new System.Windows.Forms.ToolStripMenuItem();
            this.Cons_tareas = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblBienv = new System.Windows.Forms.Label();
            this.lblNomUs = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.tareasToolStripMenuItem,
            this.cerrarSesionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(346, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Reg_clientes,
            this.Mod_clientes,
            this.Cons_clientes});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // Reg_clientes
            // 
            this.Reg_clientes.Name = "Reg_clientes";
            this.Reg_clientes.Size = new System.Drawing.Size(125, 22);
            this.Reg_clientes.Text = "Registrar";
            this.Reg_clientes.Click += new System.EventHandler(this.Reg_clientes_Click);
            // 
            // Mod_clientes
            // 
            this.Mod_clientes.Name = "Mod_clientes";
            this.Mod_clientes.Size = new System.Drawing.Size(125, 22);
            this.Mod_clientes.Text = "Modificar";
            this.Mod_clientes.Click += new System.EventHandler(this.Mod_clientes_Click);
            // 
            // Cons_clientes
            // 
            this.Cons_clientes.Name = "Cons_clientes";
            this.Cons_clientes.Size = new System.Drawing.Size(125, 22);
            this.Cons_clientes.Text = "Consultar";
            this.Cons_clientes.Click += new System.EventHandler(this.Cons_clientes_Click);
            // 
            // tareasToolStripMenuItem
            // 
            this.tareasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Add_tareas,
            this.Cons_tareas});
            this.tareasToolStripMenuItem.Name = "tareasToolStripMenuItem";
            this.tareasToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.tareasToolStripMenuItem.Text = "Servicios";
            // 
            // Add_tareas
            // 
            this.Add_tareas.Name = "Add_tareas";
            this.Add_tareas.Size = new System.Drawing.Size(125, 22);
            this.Add_tareas.Text = "Agregar";
            this.Add_tareas.Click += new System.EventHandler(this.Add_tareas_Click);
            // 
            // Cons_tareas
            // 
            this.Cons_tareas.Name = "Cons_tareas";
            this.Cons_tareas.Size = new System.Drawing.Size(125, 22);
            this.Cons_tareas.Text = "Consultar";
            this.Cons_tareas.Click += new System.EventHandler(this.Cons_tareas_Click);
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // lblBienv
            // 
            this.lblBienv.AutoSize = true;
            this.lblBienv.BackColor = System.Drawing.Color.Transparent;
            this.lblBienv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienv.ForeColor = System.Drawing.SystemColors.Control;
            this.lblBienv.Location = new System.Drawing.Point(12, 35);
            this.lblBienv.Name = "lblBienv";
            this.lblBienv.Size = new System.Drawing.Size(115, 24);
            this.lblBienv.TabIndex = 14;
            this.lblBienv.Text = "Bienvenido";
            // 
            // lblNomUs
            // 
            this.lblNomUs.AutoSize = true;
            this.lblNomUs.BackColor = System.Drawing.Color.Transparent;
            this.lblNomUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomUs.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNomUs.Location = new System.Drawing.Point(133, 35);
            this.lblNomUs.Name = "lblNomUs";
            this.lblNomUs.Size = new System.Drawing.Size(77, 24);
            this.lblNomUs.TabIndex = 15;
            this.lblNomUs.Text = "Prueba";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Estandar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tecnocom_Wolf.Properties.Resources.fondoprincipal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(346, 261);
            this.Controls.Add(this.lblNomUs);
            this.Controls.Add(this.lblBienv);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Estandar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estandar";
            this.Load += new System.EventHandler(this.Estandar_Load);
            this.Click += new System.EventHandler(this.Estandar_Click);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Estandar_KeyPress);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tareasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Reg_clientes;
        private System.Windows.Forms.ToolStripMenuItem Mod_clientes;
        private System.Windows.Forms.ToolStripMenuItem Cons_clientes;
        private System.Windows.Forms.ToolStripMenuItem Add_tareas;
        private System.Windows.Forms.ToolStripMenuItem Cons_tareas;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.Label lblBienv;
        private System.Windows.Forms.Label lblNomUs;
        private System.Windows.Forms.Timer timer1;
    }
}