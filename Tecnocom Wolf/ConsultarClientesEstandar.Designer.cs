namespace Tecnocom_Wolf
{
    partial class ConsultarClientesEstandar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarClientesEstandar));
            this.label1 = new System.Windows.Forms.Label();
            this.RbClave = new System.Windows.Forms.RadioButton();
            this.RbNombre = new System.Windows.Forms.RadioButton();
            this.CbxClaveC = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CbxNombreC = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DgvClientes = new System.Windows.Forms.DataGridView();
            this.ClaveCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CelularCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DireccionCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CorreoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LbClaveE = new System.Windows.Forms.Label();
            this.LbNombre = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Reg_clientes = new System.Windows.Forms.ToolStripMenuItem();
            this.Mod_clientes = new System.Windows.Forms.ToolStripMenuItem();
            this.Cons_clientes = new System.Windows.Forms.ToolStripMenuItem();
            this.tareasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Add_tareas = new System.Windows.Forms.ToolStripMenuItem();
            this.Cons_tareas = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DgvClientes)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(437, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Consultar Clientes";
            // 
            // RbClave
            // 
            this.RbClave.AutoSize = true;
            this.RbClave.BackColor = System.Drawing.Color.Transparent;
            this.RbClave.Location = new System.Drawing.Point(375, 205);
            this.RbClave.Name = "RbClave";
            this.RbClave.Size = new System.Drawing.Size(14, 13);
            this.RbClave.TabIndex = 2;
            this.RbClave.TabStop = true;
            this.RbClave.UseVisualStyleBackColor = false;
            this.RbClave.CheckedChanged += new System.EventHandler(this.RbClave_CheckedChanged);
            // 
            // RbNombre
            // 
            this.RbNombre.AutoSize = true;
            this.RbNombre.BackColor = System.Drawing.Color.Transparent;
            this.RbNombre.Location = new System.Drawing.Point(375, 159);
            this.RbNombre.Name = "RbNombre";
            this.RbNombre.Size = new System.Drawing.Size(14, 13);
            this.RbNombre.TabIndex = 1;
            this.RbNombre.TabStop = true;
            this.RbNombre.UseVisualStyleBackColor = false;
            this.RbNombre.CheckedChanged += new System.EventHandler(this.RbNombre_CheckedChanged);
            // 
            // CbxClaveC
            // 
            this.CbxClaveC.FormattingEnabled = true;
            this.CbxClaveC.Location = new System.Drawing.Point(198, 202);
            this.CbxClaveC.MaxLength = 6;
            this.CbxClaveC.Name = "CbxClaveC";
            this.CbxClaveC.Size = new System.Drawing.Size(163, 21);
            this.CbxClaveC.TabIndex = 4;
            this.CbxClaveC.SelectedIndexChanged += new System.EventHandler(this.CbxClaveC_SelectedIndexChanged);
            this.CbxClaveC.TextChanged += new System.EventHandler(this.CbxClaveC_TextChanged);
            this.CbxClaveC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CbxClaveC_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(399, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Buscar Por Clave";
            // 
            // CbxNombreC
            // 
            this.CbxNombreC.FormattingEnabled = true;
            this.CbxNombreC.Location = new System.Drawing.Point(198, 156);
            this.CbxNombreC.MaxLength = 50;
            this.CbxNombreC.Name = "CbxNombreC";
            this.CbxNombreC.Size = new System.Drawing.Size(163, 21);
            this.CbxNombreC.TabIndex = 3;
            this.CbxNombreC.SelectedIndexChanged += new System.EventHandler(this.CbxNombreC_SelectedIndexChanged_1);
            this.CbxNombreC.TextChanged += new System.EventHandler(this.CbxNombreC_TextChanged);
            this.CbxNombreC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CbxNombreC_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(399, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Buscar Por Nombre";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // DgvClientes
            // 
            this.DgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClaveCliente,
            this.NombreCliente,
            this.CelularCliente,
            this.DireccionCliente,
            this.CorreoCliente});
            this.DgvClientes.Location = new System.Drawing.Point(10, 257);
            this.DgvClientes.Name = "DgvClientes";
            this.DgvClientes.ReadOnly = true;
            this.DgvClientes.Size = new System.Drawing.Size(575, 150);
            this.DgvClientes.TabIndex = 5;
            // 
            // ClaveCliente
            // 
            this.ClaveCliente.HeaderText = "Clave";
            this.ClaveCliente.Name = "ClaveCliente";
            this.ClaveCliente.ReadOnly = true;
            // 
            // NombreCliente
            // 
            this.NombreCliente.HeaderText = "Nombre";
            this.NombreCliente.Name = "NombreCliente";
            this.NombreCliente.ReadOnly = true;
            // 
            // CelularCliente
            // 
            this.CelularCliente.HeaderText = "Telefono";
            this.CelularCliente.Name = "CelularCliente";
            this.CelularCliente.ReadOnly = true;
            // 
            // DireccionCliente
            // 
            this.DireccionCliente.HeaderText = "Direccion";
            this.DireccionCliente.Name = "DireccionCliente";
            this.DireccionCliente.ReadOnly = true;
            // 
            // CorreoCliente
            // 
            this.CorreoCliente.HeaderText = "Correo";
            this.CorreoCliente.Name = "CorreoCliente";
            this.CorreoCliente.ReadOnly = true;
            // 
            // LbClaveE
            // 
            this.LbClaveE.AutoSize = true;
            this.LbClaveE.BackColor = System.Drawing.Color.Transparent;
            this.LbClaveE.ForeColor = System.Drawing.Color.White;
            this.LbClaveE.Location = new System.Drawing.Point(106, 202);
            this.LbClaveE.Name = "LbClaveE";
            this.LbClaveE.Size = new System.Drawing.Size(72, 13);
            this.LbClaveE.TabIndex = 37;
            this.LbClaveE.Text = "Clave Cliente:";
            // 
            // LbNombre
            // 
            this.LbNombre.AutoSize = true;
            this.LbNombre.BackColor = System.Drawing.Color.Transparent;
            this.LbNombre.ForeColor = System.Drawing.Color.White;
            this.LbNombre.Location = new System.Drawing.Point(131, 159);
            this.LbNombre.Name = "LbNombre";
            this.LbNombre.Size = new System.Drawing.Size(47, 13);
            this.LbNombre.TabIndex = 36;
            this.LbNombre.Text = "Nombre:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.tareasToolStripMenuItem,
            this.cerrarSesionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(598, 24);
            this.menuStrip1.TabIndex = 39;
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
            // ConsultarClientesEstandar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tecnocom_Wolf.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(598, 436);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.LbClaveE);
            this.Controls.Add(this.LbNombre);
            this.Controls.Add(this.DgvClientes);
            this.Controls.Add(this.RbClave);
            this.Controls.Add(this.RbNombre);
            this.Controls.Add(this.CbxClaveC);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CbxNombreC);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultarClientesEstandar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultarClientes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConsultarClientes_FormClosing);
            this.Load += new System.EventHandler(this.ConsultarClientes_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ConsultarClientes_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.DgvClientes)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton RbClave;
        private System.Windows.Forms.RadioButton RbNombre;
        private System.Windows.Forms.ComboBox CbxClaveC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CbxNombreC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView DgvClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClaveCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CelularCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn DireccionCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CorreoCliente;
        private System.Windows.Forms.Label LbClaveE;
        private System.Windows.Forms.Label LbNombre;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Reg_clientes;
        private System.Windows.Forms.ToolStripMenuItem Mod_clientes;
        private System.Windows.Forms.ToolStripMenuItem Cons_clientes;
        private System.Windows.Forms.ToolStripMenuItem tareasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Add_tareas;
        private System.Windows.Forms.ToolStripMenuItem Cons_tareas;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
    }
}