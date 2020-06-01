namespace Tecnocom_Wolf
{
    partial class ModificarClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarClientes));
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.TxtCorreo = new System.Windows.Forms.TextBox();
            this.TxtClave = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CbxNombreM = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CbxClaveM = new System.Windows.Forms.ComboBox();
            this.RbNombre = new System.Windows.Forms.RadioButton();
            this.RbClave = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Location = new System.Drawing.Point(177, 463);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.BtnLimpiar.TabIndex = 10;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Location = new System.Drawing.Point(27, 463);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(75, 23);
            this.BtnActualizar.TabIndex = 9;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click_1);
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Location = new System.Drawing.Point(86, 398);
            this.TxtDireccion.MaxLength = 50;
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(148, 20);
            this.TxtDireccion.TabIndex = 8;
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Location = new System.Drawing.Point(86, 356);
            this.TxtTelefono.MaxLength = 10;
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(148, 20);
            this.TxtTelefono.TabIndex = 7;
            this.TxtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTelefono_KeyPress);
            // 
            // TxtCorreo
            // 
            this.TxtCorreo.Location = new System.Drawing.Point(84, 316);
            this.TxtCorreo.MaxLength = 30;
            this.TxtCorreo.Name = "TxtCorreo";
            this.TxtCorreo.Size = new System.Drawing.Size(150, 20);
            this.TxtCorreo.TabIndex = 6;
            // 
            // TxtClave
            // 
            this.TxtClave.Enabled = false;
            this.TxtClave.Location = new System.Drawing.Point(84, 268);
            this.TxtClave.MaxLength = 6;
            this.TxtClave.Name = "TxtClave";
            this.TxtClave.Size = new System.Drawing.Size(150, 20);
            this.TxtClave.TabIndex = 5;
            this.TxtClave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtClave_KeyPress);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(84, 225);
            this.TxtNombre.MaxLength = 50;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(236, 20);
            this.TxtNombre.TabIndex = 4;
            this.TxtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombre_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(25, 401);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Direccion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(31, 359);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Telefono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(31, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Correo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(31, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Clave:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nombre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(48, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Nombre de Cliente";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // CbxNombreM
            // 
            this.CbxNombreM.FormattingEnabled = true;
            this.CbxNombreM.Location = new System.Drawing.Point(13, 177);
            this.CbxNombreM.MaxLength = 50;
            this.CbxNombreM.Name = "CbxNombreM";
            this.CbxNombreM.Size = new System.Drawing.Size(163, 21);
            this.CbxNombreM.TabIndex = 2;
            this.CbxNombreM.SelectedIndexChanged += new System.EventHandler(this.CbxNombreM_SelectedIndexChanged);
            this.CbxNombreM.TextChanged += new System.EventHandler(this.CbxNombreM_TextChanged);
            this.CbxNombreM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CbxNombreM_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(223, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Clave Cliente";
            this.label7.Click += new System.EventHandler(this.Label7_Click);
            // 
            // CbxClaveM
            // 
            this.CbxClaveM.FormattingEnabled = true;
            this.CbxClaveM.Location = new System.Drawing.Point(199, 177);
            this.CbxClaveM.MaxLength = 6;
            this.CbxClaveM.Name = "CbxClaveM";
            this.CbxClaveM.Size = new System.Drawing.Size(121, 21);
            this.CbxClaveM.TabIndex = 3;
            this.CbxClaveM.SelectedIndexChanged += new System.EventHandler(this.CbxClaveM_SelectedIndexChanged);
            this.CbxClaveM.TextChanged += new System.EventHandler(this.CbxClaveM_TextChanged);
            this.CbxClaveM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CbxClaveM_KeyPress);
            // 
            // RbNombre
            // 
            this.RbNombre.AutoSize = true;
            this.RbNombre.BackColor = System.Drawing.Color.Transparent;
            this.RbNombre.Location = new System.Drawing.Point(19, 150);
            this.RbNombre.Name = "RbNombre";
            this.RbNombre.Size = new System.Drawing.Size(14, 13);
            this.RbNombre.TabIndex = 1;
            this.RbNombre.TabStop = true;
            this.RbNombre.UseVisualStyleBackColor = false;
            this.RbNombre.CheckedChanged += new System.EventHandler(this.RbNombre_CheckedChanged);
            // 
            // RbClave
            // 
            this.RbClave.AutoSize = true;
            this.RbClave.BackColor = System.Drawing.Color.Transparent;
            this.RbClave.Location = new System.Drawing.Point(199, 150);
            this.RbClave.Name = "RbClave";
            this.RbClave.Size = new System.Drawing.Size(14, 13);
            this.RbClave.TabIndex = 32;
            this.RbClave.TabStop = true;
            this.RbClave.UseVisualStyleBackColor = false;
            this.RbClave.CheckedChanged += new System.EventHandler(this.RbClave_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(79, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 25);
            this.label8.TabIndex = 33;
            this.label8.Text = "Modificar Cliente";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::Tecnocom_Wolf.Properties.Resources._11_Senal_de_peligro_indeterminado;
            this.pictureBox5.Location = new System.Drawing.Point(256, 398);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(22, 20);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 43;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::Tecnocom_Wolf.Properties.Resources._11_Senal_de_peligro_indeterminado;
            this.pictureBox4.Location = new System.Drawing.Point(256, 356);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(22, 20);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 42;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Tecnocom_Wolf.Properties.Resources._11_Senal_de_peligro_indeterminado;
            this.pictureBox3.Location = new System.Drawing.Point(256, 312);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(22, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 41;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Tecnocom_Wolf.Properties.Resources._11_Senal_de_peligro_indeterminado;
            this.pictureBox2.Location = new System.Drawing.Point(256, 268);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 40;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Tecnocom_Wolf.Properties.Resources._11_Senal_de_peligro_indeterminado;
            this.pictureBox1.Location = new System.Drawing.Point(345, 225);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // BtnVolver
            // 
            this.BtnVolver.Location = new System.Drawing.Point(327, 482);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(83, 23);
            this.BtnVolver.TabIndex = 44;
            this.BtnVolver.Text = "Volver";
            this.BtnVolver.UseVisualStyleBackColor = true;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // ModificarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tecnocom_Wolf.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(414, 506);
            this.Controls.Add(this.BtnVolver);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.RbClave);
            this.Controls.Add(this.RbNombre);
            this.Controls.Add(this.CbxClaveM);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CbxNombreM);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.TxtDireccion);
            this.Controls.Add(this.TxtTelefono);
            this.Controls.Add(this.TxtCorreo);
            this.Controls.Add(this.TxtClave);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModificarClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModificarClientes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ModificarClientes_FormClosing);
            this.Load += new System.EventHandler(this.ModificarClientes_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ModificarClientes_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.TextBox TxtCorreo;
        private System.Windows.Forms.TextBox TxtClave;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CbxNombreM;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CbxClaveM;
        private System.Windows.Forms.RadioButton RbNombre;
        private System.Windows.Forms.RadioButton RbClave;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnVolver;
    }
}