namespace Tecnocom_Wolf
{
    partial class RegistrarEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarEmpleado));
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.Registrar = new System.Windows.Forms.Button();
            this.TxtContraseña = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtIDUsuaro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CbxTipoE = new System.Windows.Forms.ComboBox();
            this.LbTipoE = new System.Windows.Forms.Label();
            this.TxtNombreE = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtCEmpleado = new System.Windows.Forms.TextBox();
            this.lblBaja = new System.Windows.Forms.Label();
            this.lblMedia = new System.Windows.Forms.Label();
            this.lblSegura = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Location = new System.Drawing.Point(217, 362);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.BtnLimpiar.TabIndex = 7;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // Registrar
            // 
            this.Registrar.Location = new System.Drawing.Point(39, 362);
            this.Registrar.Name = "Registrar";
            this.Registrar.Size = new System.Drawing.Size(75, 23);
            this.Registrar.TabIndex = 6;
            this.Registrar.Text = "Registrar";
            this.Registrar.UseVisualStyleBackColor = true;
            this.Registrar.Click += new System.EventHandler(this.Registrar_Click);
            // 
            // TxtContraseña
            // 
            this.TxtContraseña.Location = new System.Drawing.Point(120, 290);
            this.TxtContraseña.MaxLength = 30;
            this.TxtContraseña.Name = "TxtContraseña";
            this.TxtContraseña.PasswordChar = '*';
            this.TxtContraseña.Size = new System.Drawing.Size(100, 20);
            this.TxtContraseña.TabIndex = 5;
            this.TxtContraseña.TextChanged += new System.EventHandler(this.TxtContraseña_TextChanged);
            this.TxtContraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtContraseña_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(50, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Contraseña:";
            // 
            // TxtIDUsuaro
            // 
            this.TxtIDUsuaro.Location = new System.Drawing.Point(120, 253);
            this.TxtIDUsuaro.MaxLength = 30;
            this.TxtIDUsuaro.Name = "TxtIDUsuaro";
            this.TxtIDUsuaro.Size = new System.Drawing.Size(100, 20);
            this.TxtIDUsuaro.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(51, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "ID_Usuario:";
            // 
            // CbxTipoE
            // 
            this.CbxTipoE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxTipoE.FormattingEnabled = true;
            this.CbxTipoE.Items.AddRange(new object[] {
            "ADMINISTRADOR",
            "ESTANDAR"});
            this.CbxTipoE.Location = new System.Drawing.Point(120, 178);
            this.CbxTipoE.MaxLength = 30;
            this.CbxTipoE.Name = "CbxTipoE";
            this.CbxTipoE.Size = new System.Drawing.Size(140, 21);
            this.CbxTipoE.TabIndex = 2;
            this.CbxTipoE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CbxTipoE_KeyPress);
            this.CbxTipoE.MouseHover += new System.EventHandler(this.CbxTipoE_MouseHover);
            // 
            // LbTipoE
            // 
            this.LbTipoE.AutoSize = true;
            this.LbTipoE.BackColor = System.Drawing.Color.Transparent;
            this.LbTipoE.ForeColor = System.Drawing.Color.White;
            this.LbTipoE.Location = new System.Drawing.Point(16, 181);
            this.LbTipoE.Name = "LbTipoE";
            this.LbTipoE.Size = new System.Drawing.Size(98, 13);
            this.LbTipoE.TabIndex = 13;
            this.LbTipoE.Text = "Tipo De Empleado:";
            // 
            // TxtNombreE
            // 
            this.TxtNombreE.Location = new System.Drawing.Point(120, 141);
            this.TxtNombreE.MaxLength = 50;
            this.TxtNombreE.Name = "TxtNombreE";
            this.TxtNombreE.Size = new System.Drawing.Size(228, 20);
            this.TxtNombreE.TabIndex = 1;
            this.TxtNombreE.TextChanged += new System.EventHandler(this.TxtNombreE_TextChanged);
            this.TxtNombreE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombreE_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(64, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nombre: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(409, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 46);
            this.label1.TabIndex = 22;
            this.label1.Text = "Registrar\r\nEmpleados";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(27, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Clave Empleado:";
            // 
            // TxtCEmpleado
            // 
            this.TxtCEmpleado.Location = new System.Drawing.Point(120, 216);
            this.TxtCEmpleado.MaxLength = 6;
            this.TxtCEmpleado.Name = "TxtCEmpleado";
            this.TxtCEmpleado.Size = new System.Drawing.Size(100, 20);
            this.TxtCEmpleado.TabIndex = 3;
            this.TxtCEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCEmpleado_KeyPress);
            // 
            // lblBaja
            // 
            this.lblBaja.AutoSize = true;
            this.lblBaja.BackColor = System.Drawing.Color.Transparent;
            this.lblBaja.ForeColor = System.Drawing.Color.Red;
            this.lblBaja.Location = new System.Drawing.Point(117, 326);
            this.lblBaja.Name = "lblBaja";
            this.lblBaja.Size = new System.Drawing.Size(123, 13);
            this.lblBaja.TabIndex = 24;
            this.lblBaja.Text = "Esta contraseña es debil";
            this.lblBaja.Visible = false;
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.BackColor = System.Drawing.Color.Transparent;
            this.lblMedia.ForeColor = System.Drawing.Color.Orange;
            this.lblMedia.Location = new System.Drawing.Point(117, 326);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(148, 13);
            this.lblMedia.TabIndex = 25;
            this.lblMedia.Text = "Esta contraseña es aceptable";
            this.lblMedia.Visible = false;
            // 
            // lblSegura
            // 
            this.lblSegura.AutoSize = true;
            this.lblSegura.BackColor = System.Drawing.Color.Transparent;
            this.lblSegura.ForeColor = System.Drawing.Color.Lime;
            this.lblSegura.Location = new System.Drawing.Point(117, 326);
            this.lblSegura.Name = "lblSegura";
            this.lblSegura.Size = new System.Drawing.Size(133, 13);
            this.lblSegura.TabIndex = 26;
            this.lblSegura.Text = "Esta contraseña es segura";
            this.lblSegura.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Tecnocom_Wolf.Properties.Resources._11_Senal_de_peligro_indeterminado;
            this.pictureBox1.Location = new System.Drawing.Point(379, 141);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Tecnocom_Wolf.Properties.Resources._11_Senal_de_peligro_indeterminado;
            this.pictureBox2.Location = new System.Drawing.Point(288, 181);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Tecnocom_Wolf.Properties.Resources._11_Senal_de_peligro_indeterminado;
            this.pictureBox3.Location = new System.Drawing.Point(243, 216);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(22, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 31;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::Tecnocom_Wolf.Properties.Resources._11_Senal_de_peligro_indeterminado;
            this.pictureBox4.Location = new System.Drawing.Point(243, 253);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(22, 20);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 32;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Visible = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::Tecnocom_Wolf.Properties.Resources._11_Senal_de_peligro_indeterminado;
            this.pictureBox5.Location = new System.Drawing.Point(243, 290);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(22, 20);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 33;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Visible = false;
            // 
            // RegistrarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tecnocom_Wolf.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(545, 393);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblSegura);
            this.Controls.Add(this.lblMedia);
            this.Controls.Add(this.lblBaja);
            this.Controls.Add(this.TxtCEmpleado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.Registrar);
            this.Controls.Add(this.TxtContraseña);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtIDUsuaro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CbxTipoE);
            this.Controls.Add(this.LbTipoE);
            this.Controls.Add(this.TxtNombreE);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistrarEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrarEmpleado";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegistrarEmpleado_FormClosing);
            this.Load += new System.EventHandler(this.RegistrarEmpleado_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RegistrarEmpleado_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button Registrar;
        private System.Windows.Forms.TextBox TxtContraseña;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtIDUsuaro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CbxTipoE;
        private System.Windows.Forms.Label LbTipoE;
        private System.Windows.Forms.TextBox TxtNombreE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtCEmpleado;
        private System.Windows.Forms.Label lblBaja;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.Label lblSegura;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}