namespace Tecnocom_Wolf
{
    partial class Backup_BD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Backup_BD));
            this.dir_respaldo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnrespaldo = new System.Windows.Forms.Button();
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
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dir_respaldo
            // 
            this.dir_respaldo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.dir_respaldo.Enabled = false;
            this.dir_respaldo.Location = new System.Drawing.Point(15, 139);
            this.dir_respaldo.Name = "dir_respaldo";
            this.dir_respaldo.Size = new System.Drawing.Size(349, 20);
            this.dir_respaldo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Direccion:";
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackgroundImage = global::Tecnocom_Wolf.Properties.Resources.fondoP2;
            this.btn_buscar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_buscar.Location = new System.Drawing.Point(370, 136);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 2;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btnrespaldo
            // 
            this.btnrespaldo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnrespaldo.Image = global::Tecnocom_Wolf.Properties.Resources.LOGIN;
            this.btnrespaldo.Location = new System.Drawing.Point(143, 192);
            this.btnrespaldo.Name = "btnrespaldo";
            this.btnrespaldo.Size = new System.Drawing.Size(180, 33);
            this.btnrespaldo.TabIndex = 3;
            this.btnrespaldo.Text = "Generar respaldo";
            this.btnrespaldo.UseVisualStyleBackColor = true;
            this.btnrespaldo.Click += new System.EventHandler(this.btnrespaldo_Click);
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
            this.menuStrip1.Size = new System.Drawing.Size(473, 24);
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
            this.Reg_empleado.Click += new System.EventHandler(this.Reg_empleado_Click_1);
            // 
            // Cons_empleado
            // 
            this.Cons_empleado.Name = "Cons_empleado";
            this.Cons_empleado.Size = new System.Drawing.Size(125, 22);
            this.Cons_empleado.Text = "Consultar";
            this.Cons_empleado.Click += new System.EventHandler(this.Cons_empleado_Click_1);
            // 
            // Mod_empleado
            // 
            this.Mod_empleado.Name = "Mod_empleado";
            this.Mod_empleado.Size = new System.Drawing.Size(125, 22);
            this.Mod_empleado.Text = "Modificar";
            this.Mod_empleado.Click += new System.EventHandler(this.Mod_empleado_Click_1);
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
            this.Reg_cliente.Click += new System.EventHandler(this.Reg_cliente_Click_1);
            // 
            // Mod_cliente
            // 
            this.Mod_cliente.Name = "Mod_cliente";
            this.Mod_cliente.Size = new System.Drawing.Size(125, 22);
            this.Mod_cliente.Text = "Modificar";
            this.Mod_cliente.Click += new System.EventHandler(this.Mod_cliente_Click_1);
            // 
            // Cons_cliente
            // 
            this.Cons_cliente.Name = "Cons_cliente";
            this.Cons_cliente.Size = new System.Drawing.Size(125, 22);
            this.Cons_cliente.Text = "Consultar";
            this.Cons_cliente.Click += new System.EventHandler(this.Cons_cliente_Click_1);
            // 
            // tareasToolStripMenuItem
            // 
            this.tareasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Add_tarea,
            this.Cons_tarea});
            this.tareasToolStripMenuItem.Name = "tareasToolStripMenuItem";
            this.tareasToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.tareasToolStripMenuItem.Text = "Tareas";
            // 
            // Add_tarea
            // 
            this.Add_tarea.Name = "Add_tarea";
            this.Add_tarea.Size = new System.Drawing.Size(125, 22);
            this.Add_tarea.Text = "Agregar";
            this.Add_tarea.Click += new System.EventHandler(this.Add_tarea_Click_1);
            // 
            // Cons_tarea
            // 
            this.Cons_tarea.Name = "Cons_tarea";
            this.Cons_tarea.Size = new System.Drawing.Size(125, 22);
            this.Cons_tarea.Text = "Consultar";
            this.Cons_tarea.Click += new System.EventHandler(this.Cons_tarea_Click_1);
            // 
            // respaldoToolStripMenuItem
            // 
            this.respaldoToolStripMenuItem.Name = "respaldoToolStripMenuItem";
            this.respaldoToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.respaldoToolStripMenuItem.Text = "Respaldo";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click_1);
            // 
            // Backup_BD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Tecnocom_Wolf.Properties.Resources.fondoP2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(473, 299);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnrespaldo);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dir_respaldo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Backup_BD";
            this.Text = "Respaldo de base de datos";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dir_respaldo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnrespaldo;
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
    }
}