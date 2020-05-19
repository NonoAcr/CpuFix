namespace Tecnocom_Wolf
{
    partial class DgvConsultarEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DgvConsultarEmpleados));
            this.RbClave = new System.Windows.Forms.RadioButton();
            this.RbNombre = new System.Windows.Forms.RadioButton();
            this.CbxClaveE = new System.Windows.Forms.ComboBox();
            this.CbxNombre = new System.Windows.Forms.ComboBox();
            this.LbClaveE = new System.Windows.Forms.Label();
            this.LbNombre = new System.Windows.Forms.Label();
            this.DgvConsulta = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clave_Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // RbClave
            // 
            this.RbClave.AutoSize = true;
            this.RbClave.BackColor = System.Drawing.Color.Transparent;
            this.RbClave.ForeColor = System.Drawing.Color.Transparent;
            this.RbClave.Location = new System.Drawing.Point(327, 199);
            this.RbClave.Name = "RbClave";
            this.RbClave.Size = new System.Drawing.Size(102, 17);
            this.RbClave.TabIndex = 16;
            this.RbClave.TabStop = true;
            this.RbClave.Text = "Bucar Por Clave";
            this.RbClave.UseVisualStyleBackColor = false;
            this.RbClave.CheckedChanged += new System.EventHandler(this.RbClave_CheckedChanged);
            // 
            // RbNombre
            // 
            this.RbNombre.AutoSize = true;
            this.RbNombre.BackColor = System.Drawing.Color.Transparent;
            this.RbNombre.ForeColor = System.Drawing.Color.White;
            this.RbNombre.Location = new System.Drawing.Point(327, 147);
            this.RbNombre.Name = "RbNombre";
            this.RbNombre.Size = new System.Drawing.Size(117, 17);
            this.RbNombre.TabIndex = 2;
            this.RbNombre.TabStop = true;
            this.RbNombre.Text = "Buscar Por Nombre";
            this.RbNombre.UseVisualStyleBackColor = false;
            this.RbNombre.CheckedChanged += new System.EventHandler(this.RbNombre_CheckedChanged);
            // 
            // CbxClaveE
            // 
            this.CbxClaveE.FormattingEnabled = true;
            this.CbxClaveE.Location = new System.Drawing.Point(112, 186);
            this.CbxClaveE.MaxLength = 6;
            this.CbxClaveE.Name = "CbxClaveE";
            this.CbxClaveE.Size = new System.Drawing.Size(198, 21);
            this.CbxClaveE.TabIndex = 3;
            this.CbxClaveE.SelectedIndexChanged += new System.EventHandler(this.CbxClaveE_SelectedIndexChanged);
            this.CbxClaveE.TextChanged += new System.EventHandler(this.CbxClaveE_TextChanged);
            this.CbxClaveE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CbxClaveE_KeyPress);
            // 
            // CbxNombre
            // 
            this.CbxNombre.FormattingEnabled = true;
            this.CbxNombre.Location = new System.Drawing.Point(112, 143);
            this.CbxNombre.MaxLength = 50;
            this.CbxNombre.Name = "CbxNombre";
            this.CbxNombre.Size = new System.Drawing.Size(198, 21);
            this.CbxNombre.TabIndex = 1;
            this.CbxNombre.SelectedIndexChanged += new System.EventHandler(this.CbxNombre_SelectedIndexChanged);
            this.CbxNombre.TextChanged += new System.EventHandler(this.CbxNombre_TextChanged);
            this.CbxNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CbxNombre_KeyPress);
            // 
            // LbClaveE
            // 
            this.LbClaveE.AutoSize = true;
            this.LbClaveE.BackColor = System.Drawing.Color.Transparent;
            this.LbClaveE.ForeColor = System.Drawing.Color.White;
            this.LbClaveE.Location = new System.Drawing.Point(19, 189);
            this.LbClaveE.Name = "LbClaveE";
            this.LbClaveE.Size = new System.Drawing.Size(87, 13);
            this.LbClaveE.TabIndex = 13;
            this.LbClaveE.Text = "Clave Empleado:";
            // 
            // LbNombre
            // 
            this.LbNombre.AutoSize = true;
            this.LbNombre.BackColor = System.Drawing.Color.Transparent;
            this.LbNombre.ForeColor = System.Drawing.Color.White;
            this.LbNombre.Location = new System.Drawing.Point(59, 146);
            this.LbNombre.Name = "LbNombre";
            this.LbNombre.Size = new System.Drawing.Size(47, 13);
            this.LbNombre.TabIndex = 11;
            this.LbNombre.Text = "Nombre:";
            // 
            // DgvConsulta
            // 
            this.DgvConsulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Clave_Empleado,
            this.TipoE,
            this.ID_Usuario,
            this.Eliminar});
            this.DgvConsulta.Location = new System.Drawing.Point(62, 246);
            this.DgvConsulta.Name = "DgvConsulta";
            this.DgvConsulta.RowHeadersVisible = false;
            this.DgvConsulta.Size = new System.Drawing.Size(368, 140);
            this.DgvConsulta.TabIndex = 4;
            this.DgvConsulta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvConsulta_CellContentClick);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 69;
            // 
            // Clave_Empleado
            // 
            this.Clave_Empleado.HeaderText = "Clave";
            this.Clave_Empleado.Name = "Clave_Empleado";
            this.Clave_Empleado.Width = 59;
            // 
            // TipoE
            // 
            this.TipoE.HeaderText = "Tipo Empleado";
            this.TipoE.Name = "TipoE";
            this.TipoE.Width = 95;
            // 
            // ID_Usuario
            // 
            this.ID_Usuario.HeaderText = "ID De Usuario";
            this.ID_Usuario.Name = "ID_Usuario";
            this.ID_Usuario.Width = 91;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Width = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(318, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 23);
            this.label1.TabIndex = 20;
            this.label1.Text = "Consultar Empleados";
            // 
            // BtnVolver
            // 
            this.BtnVolver.Location = new System.Drawing.Point(430, 392);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(75, 23);
            this.BtnVolver.TabIndex = 21;
            this.BtnVolver.Text = "Volver";
            this.BtnVolver.UseVisualStyleBackColor = true;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // DgvConsultarEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tecnocom_Wolf.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(506, 422);
            this.Controls.Add(this.BtnVolver);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RbClave);
            this.Controls.Add(this.RbNombre);
            this.Controls.Add(this.CbxClaveE);
            this.Controls.Add(this.CbxNombre);
            this.Controls.Add(this.LbClaveE);
            this.Controls.Add(this.LbNombre);
            this.Controls.Add(this.DgvConsulta);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DgvConsultarEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultarEmpleados";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConsultarEmpleados_FormClosing);
            this.Load += new System.EventHandler(this.DgvConsultarEmpleados_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ConsultarEmpleados_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.DgvConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton RbClave;
        private System.Windows.Forms.RadioButton RbNombre;
        private System.Windows.Forms.ComboBox CbxClaveE;
        private System.Windows.Forms.ComboBox CbxNombre;
        private System.Windows.Forms.Label LbClaveE;
        private System.Windows.Forms.Label LbNombre;
        private System.Windows.Forms.DataGridView DgvConsulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clave_Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Usuario;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.Button BtnVolver;
    }
}