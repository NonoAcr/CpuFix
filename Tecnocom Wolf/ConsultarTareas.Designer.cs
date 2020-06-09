namespace Tecnocom_Wolf
{
    partial class ConsultarTareas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarTareas));
            this.DgvConsulta = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnLimpiar = new System.Windows.Forms.Button();
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
            this.RbClave = new System.Windows.Forms.RadioButton();
            this.CbxClaveT = new System.Windows.Forms.ComboBox();
            this.IDTarea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoPc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SistemaO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anticipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Borrar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvConsulta)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvConsulta
            // 
            this.DgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDTarea,
            this.NombreE,
            this.IDEmpleado,
            this.IDCliente,
            this.TipoPc,
            this.SistemaO,
            this.SOI,
            this.Descripcion,
            this.Fecha,
            this.Pago,
            this.Estado,
            this.Anticipo,
            this.Modificar,
            this.Borrar});
            this.DgvConsulta.Location = new System.Drawing.Point(12, 232);
            this.DgvConsulta.Name = "DgvConsulta";
            this.DgvConsulta.Size = new System.Drawing.Size(923, 150);
            this.DgvConsulta.TabIndex = 4;
            this.DgvConsulta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvConsulta_CellClick);
            this.DgvConsulta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvConsulta_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(593, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Consultar Servicios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(164, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Clave De Tarea";
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.ForeColor = System.Drawing.Color.Black;
            this.BtnLimpiar.Location = new System.Drawing.Point(508, 160);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.BtnLimpiar.TabIndex = 3;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
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
            this.menuStrip1.Size = new System.Drawing.Size(947, 24);
            this.menuStrip1.TabIndex = 12;
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
            // RbClave
            // 
            this.RbClave.AutoSize = true;
            this.RbClave.BackColor = System.Drawing.Color.Transparent;
            this.RbClave.Location = new System.Drawing.Point(451, 165);
            this.RbClave.Name = "RbClave";
            this.RbClave.Size = new System.Drawing.Size(14, 13);
            this.RbClave.TabIndex = 17;
            this.RbClave.TabStop = true;
            this.RbClave.UseVisualStyleBackColor = false;
            this.RbClave.CheckedChanged += new System.EventHandler(this.RbClave_CheckedChanged);
            // 
            // CbxClaveT
            // 
            this.CbxClaveT.FormattingEnabled = true;
            this.CbxClaveT.Location = new System.Drawing.Point(270, 162);
            this.CbxClaveT.MaxLength = 6;
            this.CbxClaveT.Name = "CbxClaveT";
            this.CbxClaveT.Size = new System.Drawing.Size(163, 21);
            this.CbxClaveT.TabIndex = 18;
            this.CbxClaveT.SelectedIndexChanged += new System.EventHandler(this.CbxClaveT_SelectedIndexChanged);
            // 
            // IDTarea
            // 
            this.IDTarea.HeaderText = "ID Tarea";
            this.IDTarea.Name = "IDTarea";
            // 
            // NombreE
            // 
            this.NombreE.HeaderText = "Nombre Empleado";
            this.NombreE.Name = "NombreE";
            // 
            // IDEmpleado
            // 
            this.IDEmpleado.HeaderText = "ID Empleado";
            this.IDEmpleado.Name = "IDEmpleado";
            // 
            // IDCliente
            // 
            this.IDCliente.HeaderText = "ID Cliente";
            this.IDCliente.Name = "IDCliente";
            // 
            // TipoPc
            // 
            this.TipoPc.HeaderText = "Tipo Pc";
            this.TipoPc.Name = "TipoPc";
            // 
            // SistemaO
            // 
            this.SistemaO.HeaderText = "Sistema Opertivo";
            this.SistemaO.Name = "SistemaO";
            // 
            // SOI
            // 
            this.SOI.HeaderText = "Sistema O. I.";
            this.SOI.Name = "SOI";
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            // 
            // Pago
            // 
            this.Pago.HeaderText = "Pago";
            this.Pago.Name = "Pago";
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // Anticipo
            // 
            this.Anticipo.HeaderText = "Anticipo";
            this.Anticipo.Name = "Anticipo";
            // 
            // Modificar
            // 
            this.Modificar.HeaderText = "Modificar";
            this.Modificar.Name = "Modificar";
            this.Modificar.Text = "Modificar";
            // 
            // Borrar
            // 
            this.Borrar.HeaderText = "Borrar";
            this.Borrar.Name = "Borrar";
            // 
            // ConsultarTareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tecnocom_Wolf.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(947, 417);
            this.Controls.Add(this.RbClave);
            this.Controls.Add(this.CbxClaveT);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvConsulta);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultarTareas";
            this.Text = "Consultar Servicios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConsultarTareas_FormClosing);
            this.Load += new System.EventHandler(this.ConsultarTareas_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ConsultarTareas_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.DgvConsulta)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvConsulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Reg_empleado;
        private System.Windows.Forms.ToolStripMenuItem Cons_empleado;
        private System.Windows.Forms.ToolStripMenuItem Mod_empleado;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Reg_cliente;
        private System.Windows.Forms.ToolStripMenuItem Mod_cliente;
        private System.Windows.Forms.ToolStripMenuItem Cons_cliente;
        private System.Windows.Forms.ToolStripMenuItem tareasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Add_tarea;
        private System.Windows.Forms.ToolStripMenuItem Cons_tarea;
        private System.Windows.Forms.ToolStripMenuItem respaldoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.RadioButton RbClave;
        private System.Windows.Forms.ComboBox CbxClaveT;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDTarea;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreE;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoPc;
        private System.Windows.Forms.DataGridViewTextBoxColumn SistemaO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Anticipo;
        private System.Windows.Forms.DataGridViewButtonColumn Modificar;
        private System.Windows.Forms.DataGridViewButtonColumn Borrar;
    }
}