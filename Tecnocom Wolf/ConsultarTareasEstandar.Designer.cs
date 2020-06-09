namespace Tecnocom_Wolf
{
    partial class ConsultarTareasEstandar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarTareasEstandar));
            this.DgvConsulta = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Reg_clientes = new System.Windows.Forms.ToolStripMenuItem();
            this.Mod_clientes = new System.Windows.Forms.ToolStripMenuItem();
            this.Cons_clientes = new System.Windows.Forms.ToolStripMenuItem();
            this.tareasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Add_tareas = new System.Windows.Forms.ToolStripMenuItem();
            this.Cons_tareas = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
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
            this.label2.Location = new System.Drawing.Point(164, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Clave De Tarea";
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.ForeColor = System.Drawing.Color.Black;
            this.BtnLimpiar.Location = new System.Drawing.Point(514, 175);
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
            this.clientesToolStripMenuItem,
            this.tareasToolStripMenuItem,
            this.cerrarSesionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(947, 24);
            this.menuStrip1.TabIndex = 14;
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
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // RbClave
            // 
            this.RbClave.AutoSize = true;
            this.RbClave.BackColor = System.Drawing.Color.Transparent;
            this.RbClave.Location = new System.Drawing.Point(433, 180);
            this.RbClave.Name = "RbClave";
            this.RbClave.Size = new System.Drawing.Size(14, 13);
            this.RbClave.TabIndex = 15;
            this.RbClave.TabStop = true;
            this.RbClave.UseVisualStyleBackColor = false;
            this.RbClave.CheckedChanged += new System.EventHandler(this.RbClave_CheckedChanged);
            // 
            // CbxClaveT
            // 
            this.CbxClaveT.FormattingEnabled = true;
            this.CbxClaveT.Location = new System.Drawing.Point(252, 177);
            this.CbxClaveT.MaxLength = 6;
            this.CbxClaveT.Name = "CbxClaveT";
            this.CbxClaveT.Size = new System.Drawing.Size(163, 21);
            this.CbxClaveT.TabIndex = 16;
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
            // ConsultarTareasEstandar
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
            this.Name = "ConsultarTareasEstandar";
            this.Text = "Consultar Servicios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConsultarTareas_FormClosing);
            this.Load += new System.EventHandler(this.ConsultarTareas_Load);
            this.Click += new System.EventHandler(this.ConsultarTareasEstandar_Click);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ConsultarTareas_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ConsultarTareasEstandar_KeyPress);
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
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Reg_clientes;
        private System.Windows.Forms.ToolStripMenuItem Mod_clientes;
        private System.Windows.Forms.ToolStripMenuItem Cons_clientes;
        private System.Windows.Forms.ToolStripMenuItem tareasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Add_tareas;
        private System.Windows.Forms.ToolStripMenuItem Cons_tareas;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
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