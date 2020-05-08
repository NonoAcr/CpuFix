namespace Tecnocom_Wolf
{
    partial class Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNombreC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.CbxTipoReparacion = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CbxSO = new System.Windows.Forms.ComboBox();
            this.CbxSOI = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNumeroC = new System.Windows.Forms.TextBox();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CbxTipoPC = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtCTarea = new System.Windows.Forms.TextBox();
            this.TxtCEmpleado = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(117, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del Cliente";
            // 
            // TxtNombreC
            // 
            this.TxtNombreC.Location = new System.Drawing.Point(219, 163);
            this.TxtNombreC.MaxLength = 50;
            this.TxtNombreC.Name = "TxtNombreC";
            this.TxtNombreC.Size = new System.Drawing.Size(283, 20);
            this.TxtNombreC.TabIndex = 1;
            this.TxtNombreC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombreC_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(343, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fecha ";
            // 
            // DtpFecha
            // 
            this.DtpFecha.Enabled = false;
            this.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFecha.Location = new System.Drawing.Point(313, 213);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Size = new System.Drawing.Size(100, 20);
            this.DtpFecha.TabIndex = 5;
            this.DtpFecha.ValueChanged += new System.EventHandler(this.DtpFecha_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(305, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Tipo De Reparacion";
            // 
            // CbxTipoReparacion
            // 
            this.CbxTipoReparacion.FormattingEnabled = true;
            this.CbxTipoReparacion.Items.AddRange(new object[] {
            "INSTALACION DE S.O.",
            "MANTENIMIENTO CORRECTIVO ",
            "INSTALACION DE SOFTWARE",
            "OPTIMIZACION"});
            this.CbxTipoReparacion.Location = new System.Drawing.Point(277, 262);
            this.CbxTipoReparacion.Name = "CbxTipoReparacion";
            this.CbxTipoReparacion.Size = new System.Drawing.Size(178, 21);
            this.CbxTipoReparacion.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(489, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Sistema Operativo:";
            // 
            // CbxSO
            // 
            this.CbxSO.FormattingEnabled = true;
            this.CbxSO.Items.AddRange(new object[] {
            "WINDOWS XP",
            "WINDOWS 7",
            "WINDOWS 8 ",
            "WINDOWS 10"});
            this.CbxSO.Location = new System.Drawing.Point(598, 233);
            this.CbxSO.Name = "CbxSO";
            this.CbxSO.Size = new System.Drawing.Size(121, 21);
            this.CbxSO.TabIndex = 8;
            // 
            // CbxSOI
            // 
            this.CbxSOI.FormattingEnabled = true;
            this.CbxSOI.Items.AddRange(new object[] {
            "WINDOWS XP",
            "WINDOWS 7",
            "WINDOWS 8 ",
            "WINDOWS 10"});
            this.CbxSOI.Location = new System.Drawing.Point(598, 206);
            this.CbxSOI.Name = "CbxSOI";
            this.CbxSOI.Size = new System.Drawing.Size(121, 21);
            this.CbxSOI.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(489, 213);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "S.O. Instalacion";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(289, 315);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(185, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Descripcion de la Pc y la Reparacion ";
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Location = new System.Drawing.Point(144, 341);
            this.TxtDescripcion.MaxLength = 150;
            this.TxtDescripcion.Multiline = true;
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(467, 91);
            this.TxtDescripcion.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Numero De Cliente";
            // 
            // TxtNumeroC
            // 
            this.TxtNumeroC.Location = new System.Drawing.Point(123, 211);
            this.TxtNumeroC.MaxLength = 6;
            this.TxtNumeroC.Name = "TxtNumeroC";
            this.TxtNumeroC.Size = new System.Drawing.Size(100, 20);
            this.TxtNumeroC.TabIndex = 2;
            this.TxtNumeroC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumeroC_KeyPress);
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.ForeColor = System.Drawing.Color.Black;
            this.BtnRegistrar.Location = new System.Drawing.Point(334, 453);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.BtnRegistrar.TabIndex = 11;
            this.BtnRegistrar.Text = "Registrar";
            this.BtnRegistrar.UseVisualStyleBackColor = true;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(548, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 23);
            this.label3.TabIndex = 32;
            this.label3.Text = "Registrar Tareas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(489, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Tipo de Pc";
            // 
            // CbxTipoPC
            // 
            this.CbxTipoPC.FormattingEnabled = true;
            this.CbxTipoPC.Items.AddRange(new object[] {
            "LAPTOP",
            "ESCRITORIO"});
            this.CbxTipoPC.Location = new System.Drawing.Point(598, 260);
            this.CbxTipoPC.Name = "CbxTipoPC";
            this.CbxTipoPC.Size = new System.Drawing.Size(121, 21);
            this.CbxTipoPC.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(12, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Clave De Tarea";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(12, 241);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "Clave De Empleado";
            // 
            // TxtCTarea
            // 
            this.TxtCTarea.Location = new System.Drawing.Point(123, 264);
            this.TxtCTarea.MaxLength = 6;
            this.TxtCTarea.Name = "TxtCTarea";
            this.TxtCTarea.Size = new System.Drawing.Size(100, 20);
            this.TxtCTarea.TabIndex = 4;
            this.TxtCTarea.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCTarea_KeyPress);
            // 
            // TxtCEmpleado
            // 
            this.TxtCEmpleado.Location = new System.Drawing.Point(123, 238);
            this.TxtCEmpleado.MaxLength = 6;
            this.TxtCEmpleado.Name = "TxtCEmpleado";
            this.TxtCEmpleado.Size = new System.Drawing.Size(100, 20);
            this.TxtCEmpleado.TabIndex = 3;
            this.TxtCEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCEmpleado_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Tecnocom_Wolf.Properties.Resources._11_Senal_de_peligro_indeterminado;
            this.pictureBox1.Location = new System.Drawing.Point(526, 163);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Tecnocom_Wolf.Properties.Resources._11_Senal_de_peligro_indeterminado;
            this.pictureBox2.Location = new System.Drawing.Point(238, 211);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 38;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Tecnocom_Wolf.Properties.Resources._11_Senal_de_peligro_indeterminado;
            this.pictureBox3.Location = new System.Drawing.Point(238, 238);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(22, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 39;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::Tecnocom_Wolf.Properties.Resources._11_Senal_de_peligro_indeterminado;
            this.pictureBox4.Location = new System.Drawing.Point(238, 264);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(22, 20);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 40;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Visible = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::Tecnocom_Wolf.Properties.Resources._11_Senal_de_peligro_indeterminado;
            this.pictureBox5.Location = new System.Drawing.Point(461, 262);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(22, 20);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 41;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Visible = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::Tecnocom_Wolf.Properties.Resources._11_Senal_de_peligro_indeterminado;
            this.pictureBox6.Location = new System.Drawing.Point(741, 207);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(22, 20);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 42;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Visible = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = global::Tecnocom_Wolf.Properties.Resources._11_Senal_de_peligro_indeterminado;
            this.pictureBox7.Location = new System.Drawing.Point(741, 233);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(22, 20);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 43;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Visible = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Image = global::Tecnocom_Wolf.Properties.Resources._11_Senal_de_peligro_indeterminado;
            this.pictureBox8.Location = new System.Drawing.Point(741, 260);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(22, 20);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 44;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Visible = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox9.Image = global::Tecnocom_Wolf.Properties.Resources._11_Senal_de_peligro_indeterminado;
            this.pictureBox9.Location = new System.Drawing.Point(617, 374);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(22, 20);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 45;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Visible = false;
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tecnocom_Wolf.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(775, 480);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TxtCEmpleado);
            this.Controls.Add(this.TxtCTarea);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CbxTipoPC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnRegistrar);
            this.Controls.Add(this.TxtNumeroC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtDescripcion);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CbxSOI);
            this.Controls.Add(this.CbxSO);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CbxTipoReparacion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DtpFecha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtNombreC);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "+";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Registro_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Registro_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNombreC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DtpFecha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CbxTipoReparacion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CbxSO;
        private System.Windows.Forms.ComboBox CbxSOI;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNumeroC;
        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CbxTipoPC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtCTarea;
        private System.Windows.Forms.TextBox TxtCEmpleado;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
    }
}