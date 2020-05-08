namespace Tecnocom_Wolf
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
            this.BtnEmpleado = new System.Windows.Forms.Button();
            this.BtnClientes = new System.Windows.Forms.Button();
            this.BtnTareas = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnEmpleado
            // 
            this.BtnEmpleado.BackColor = System.Drawing.Color.Black;
            this.BtnEmpleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnEmpleado.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEmpleado.ForeColor = System.Drawing.Color.White;
            this.BtnEmpleado.Location = new System.Drawing.Point(67, 225);
            this.BtnEmpleado.Name = "BtnEmpleado";
            this.BtnEmpleado.Size = new System.Drawing.Size(75, 23);
            this.BtnEmpleado.TabIndex = 1;
            this.BtnEmpleado.Text = "Empleados";
            this.BtnEmpleado.UseVisualStyleBackColor = false;
            this.BtnEmpleado.Click += new System.EventHandler(this.BtnEmpleado_Click);
            // 
            // BtnClientes
            // 
            this.BtnClientes.BackColor = System.Drawing.Color.Black;
            this.BtnClientes.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClientes.ForeColor = System.Drawing.Color.White;
            this.BtnClientes.Location = new System.Drawing.Point(188, 225);
            this.BtnClientes.Name = "BtnClientes";
            this.BtnClientes.Size = new System.Drawing.Size(75, 23);
            this.BtnClientes.TabIndex = 2;
            this.BtnClientes.Text = "Clientes";
            this.BtnClientes.UseVisualStyleBackColor = false;
            this.BtnClientes.Click += new System.EventHandler(this.BtnClientes_Click);
            // 
            // BtnTareas
            // 
            this.BtnTareas.BackColor = System.Drawing.Color.Black;
            this.BtnTareas.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTareas.ForeColor = System.Drawing.Color.White;
            this.BtnTareas.Location = new System.Drawing.Point(300, 225);
            this.BtnTareas.Name = "BtnTareas";
            this.BtnTareas.Size = new System.Drawing.Size(75, 23);
            this.BtnTareas.TabIndex = 9;
            this.BtnTareas.Text = "Tareas";
            this.BtnTareas.UseVisualStyleBackColor = false;
            this.BtnTareas.Click += new System.EventHandler(this.BtnTareas_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(174, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 24);
            this.button1.TabIndex = 10;
            this.button1.Text = "Cerrar Sesión";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Bienvenido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tecnocom_Wolf.Properties.Resources.fondo_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(437, 318);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnTareas);
            this.Controls.Add(this.BtnClientes);
            this.Controls.Add(this.BtnEmpleado);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Bienvenido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CPUFIX";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Bienvenido_FormClosing);
            this.Load += new System.EventHandler(this.Bienvenido_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Bienvenido_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnEmpleado;
        private System.Windows.Forms.Button BtnClientes;
        private System.Windows.Forms.Button BtnTareas;
        private System.Windows.Forms.Button button1;
    }
}

