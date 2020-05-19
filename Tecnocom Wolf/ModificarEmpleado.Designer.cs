namespace Tecnocom_Wolf
{
    partial class ModificarEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarEmpleado));
            this.BtnModificar = new System.Windows.Forms.Button();
            this.TxtContraseñas = new System.Windows.Forms.TextBox();
            this.LbContraseña = new System.Windows.Forms.Label();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.LbUser = new System.Windows.Forms.Label();
            this.CbxTipo = new System.Windows.Forms.ComboBox();
            this.LbTipo = new System.Windows.Forms.Label();
            this.CbxNombres = new System.Windows.Forms.ComboBox();
            this.LbNombreEmpleado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCEmpleado = new System.Windows.Forms.TextBox();
            this.RbNombre = new System.Windows.Forms.RadioButton();
            this.RbClave = new System.Windows.Forms.RadioButton();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.CbxClave = new System.Windows.Forms.ComboBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.lblSegura = new System.Windows.Forms.Label();
            this.lblMedia = new System.Windows.Forms.Label();
            this.lblBaja = new System.Windows.Forms.Label();
            this.BtnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnModificar
            // 
            this.BtnModificar.ForeColor = System.Drawing.Color.Black;
            this.BtnModificar.Location = new System.Drawing.Point(54, 439);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(75, 23);
            this.BtnModificar.TabIndex = 9;
            this.BtnModificar.Text = "Actualizar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // TxtContraseñas
            // 
            this.TxtContraseñas.Location = new System.Drawing.Point(121, 353);
            this.TxtContraseñas.MaxLength = 30;
            this.TxtContraseñas.Name = "TxtContraseñas";
            this.TxtContraseñas.PasswordChar = '*';
            this.TxtContraseñas.Size = new System.Drawing.Size(122, 20);
            this.TxtContraseñas.TabIndex = 8;
            this.TxtContraseñas.TextChanged += new System.EventHandler(this.TxtContraseñas_TextChanged);
            // 
            // LbContraseña
            // 
            this.LbContraseña.AutoSize = true;
            this.LbContraseña.BackColor = System.Drawing.Color.Transparent;
            this.LbContraseña.Location = new System.Drawing.Point(51, 360);
            this.LbContraseña.Name = "LbContraseña";
            this.LbContraseña.Size = new System.Drawing.Size(64, 13);
            this.LbContraseña.TabIndex = 17;
            this.LbContraseña.Text = "Contraseña:";
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Location = new System.Drawing.Point(121, 311);
            this.TxtUsuario.MaxLength = 30;
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(122, 20);
            this.TxtUsuario.TabIndex = 7;
            // 
            // LbUser
            // 
            this.LbUser.AutoSize = true;
            this.LbUser.BackColor = System.Drawing.Color.Transparent;
            this.LbUser.Location = new System.Drawing.Point(69, 318);
            this.LbUser.Name = "LbUser";
            this.LbUser.Size = new System.Drawing.Size(46, 13);
            this.LbUser.TabIndex = 15;
            this.LbUser.Text = "Usuario:";
            // 
            // CbxTipo
            // 
            this.CbxTipo.FormattingEnabled = true;
            this.CbxTipo.Items.AddRange(new object[] {
            "ADMINISTRADOR",
            "ESTANDAR"});
            this.CbxTipo.Location = new System.Drawing.Point(121, 223);
            this.CbxTipo.MaxLength = 30;
            this.CbxTipo.Name = "CbxTipo";
            this.CbxTipo.Size = new System.Drawing.Size(121, 21);
            this.CbxTipo.TabIndex = 5;
            this.CbxTipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CbxTipo_KeyPress);
            // 
            // LbTipo
            // 
            this.LbTipo.AutoSize = true;
            this.LbTipo.BackColor = System.Drawing.Color.Transparent;
            this.LbTipo.Location = new System.Drawing.Point(35, 231);
            this.LbTipo.Name = "LbTipo";
            this.LbTipo.Size = new System.Drawing.Size(81, 13);
            this.LbTipo.TabIndex = 13;
            this.LbTipo.Text = "Tipo Empleado:";
            // 
            // CbxNombres
            // 
            this.CbxNombres.FormattingEnabled = true;
            this.CbxNombres.Location = new System.Drawing.Point(38, 140);
            this.CbxNombres.Name = "CbxNombres";
            this.CbxNombres.Size = new System.Drawing.Size(161, 21);
            this.CbxNombres.TabIndex = 2;
            this.CbxNombres.SelectedIndexChanged += new System.EventHandler(this.CbxNombres_SelectedIndexChanged);
            this.CbxNombres.TextChanged += new System.EventHandler(this.CbxNombres_TextChanged);
            this.CbxNombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CbxNombres_KeyPress);
            // 
            // LbNombreEmpleado
            // 
            this.LbNombreEmpleado.AutoSize = true;
            this.LbNombreEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.LbNombreEmpleado.Location = new System.Drawing.Point(69, 183);
            this.LbNombreEmpleado.Name = "LbNombreEmpleado";
            this.LbNombreEmpleado.Size = new System.Drawing.Size(47, 13);
            this.LbNombreEmpleado.TabIndex = 11;
            this.LbNombreEmpleado.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(348, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 46);
            this.label1.TabIndex = 22;
            this.label1.Text = "Modificar\r\nEmpleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(28, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Clave Empleado:";
            // 
            // TxtCEmpleado
            // 
            this.TxtCEmpleado.Enabled = false;
            this.TxtCEmpleado.Location = new System.Drawing.Point(122, 267);
            this.TxtCEmpleado.MaxLength = 6;
            this.TxtCEmpleado.Name = "TxtCEmpleado";
            this.TxtCEmpleado.Size = new System.Drawing.Size(121, 20);
            this.TxtCEmpleado.TabIndex = 6;
            this.TxtCEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCEmpleado_KeyPress);
            // 
            // RbNombre
            // 
            this.RbNombre.AutoSize = true;
            this.RbNombre.BackColor = System.Drawing.Color.Transparent;
            this.RbNombre.Location = new System.Drawing.Point(81, 117);
            this.RbNombre.Name = "RbNombre";
            this.RbNombre.Size = new System.Drawing.Size(62, 17);
            this.RbNombre.TabIndex = 1;
            this.RbNombre.TabStop = true;
            this.RbNombre.Text = "Nombre";
            this.RbNombre.UseVisualStyleBackColor = false;
            this.RbNombre.CheckedChanged += new System.EventHandler(this.RbNombre_CheckedChanged);
            // 
            // RbClave
            // 
            this.RbClave.AutoSize = true;
            this.RbClave.BackColor = System.Drawing.Color.Transparent;
            this.RbClave.Location = new System.Drawing.Point(262, 117);
            this.RbClave.Name = "RbClave";
            this.RbClave.Size = new System.Drawing.Size(52, 17);
            this.RbClave.TabIndex = 39;
            this.RbClave.TabStop = true;
            this.RbClave.Text = "Clave";
            this.RbClave.UseVisualStyleBackColor = false;
            this.RbClave.CheckedChanged += new System.EventHandler(this.RbClave_CheckedChanged);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(122, 180);
            this.TxtNombre.MaxLength = 50;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(209, 20);
            this.TxtNombre.TabIndex = 4;
            this.TxtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombre_KeyPress);
            // 
            // CbxClave
            // 
            this.CbxClave.FormattingEnabled = true;
            this.CbxClave.Location = new System.Drawing.Point(217, 140);
            this.CbxClave.Name = "CbxClave";
            this.CbxClave.Size = new System.Drawing.Size(161, 21);
            this.CbxClave.TabIndex = 3;
            this.CbxClave.SelectedIndexChanged += new System.EventHandler(this.CbxClave_SelectedIndexChanged);
            this.CbxClave.TextChanged += new System.EventHandler(this.CbxClave_TextChanged);
            this.CbxClave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CbxClave_KeyPress);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::Tecnocom_Wolf.Properties.Resources._11_Senal_de_peligro_indeterminado;
            this.pictureBox5.Location = new System.Drawing.Point(267, 353);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(22, 20);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 48;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::Tecnocom_Wolf.Properties.Resources._11_Senal_de_peligro_indeterminado;
            this.pictureBox4.Location = new System.Drawing.Point(267, 311);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(22, 20);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 47;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Tecnocom_Wolf.Properties.Resources._11_Senal_de_peligro_indeterminado;
            this.pictureBox3.Location = new System.Drawing.Point(267, 267);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(22, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 46;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Tecnocom_Wolf.Properties.Resources._11_Senal_de_peligro_indeterminado;
            this.pictureBox2.Location = new System.Drawing.Point(267, 224);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 45;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Tecnocom_Wolf.Properties.Resources._11_Senal_de_peligro_indeterminado;
            this.pictureBox1.Location = new System.Drawing.Point(352, 180);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.ForeColor = System.Drawing.Color.Black;
            this.BtnLimpiar.Location = new System.Drawing.Point(267, 439);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.BtnLimpiar.TabIndex = 49;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // lblSegura
            // 
            this.lblSegura.AutoSize = true;
            this.lblSegura.BackColor = System.Drawing.Color.Transparent;
            this.lblSegura.ForeColor = System.Drawing.Color.Lime;
            this.lblSegura.Location = new System.Drawing.Point(110, 399);
            this.lblSegura.Name = "lblSegura";
            this.lblSegura.Size = new System.Drawing.Size(133, 13);
            this.lblSegura.TabIndex = 52;
            this.lblSegura.Text = "Esta contraseña es segura";
            this.lblSegura.Visible = false;
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.BackColor = System.Drawing.Color.Transparent;
            this.lblMedia.ForeColor = System.Drawing.Color.Orange;
            this.lblMedia.Location = new System.Drawing.Point(110, 399);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(148, 13);
            this.lblMedia.TabIndex = 51;
            this.lblMedia.Text = "Esta contraseña es aceptable";
            this.lblMedia.Visible = false;
            // 
            // lblBaja
            // 
            this.lblBaja.AutoSize = true;
            this.lblBaja.BackColor = System.Drawing.Color.Transparent;
            this.lblBaja.ForeColor = System.Drawing.Color.Red;
            this.lblBaja.Location = new System.Drawing.Point(110, 399);
            this.lblBaja.Name = "lblBaja";
            this.lblBaja.Size = new System.Drawing.Size(123, 13);
            this.lblBaja.TabIndex = 50;
            this.lblBaja.Text = "Esta contraseña es debil";
            this.lblBaja.Visible = false;
            // 
            // BtnVolver
            // 
            this.BtnVolver.ForeColor = System.Drawing.Color.Black;
            this.BtnVolver.Location = new System.Drawing.Point(372, 462);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(75, 23);
            this.BtnVolver.TabIndex = 53;
            this.BtnVolver.Text = "Volver";
            this.BtnVolver.UseVisualStyleBackColor = true;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // ModificarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tecnocom_Wolf.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(448, 487);
            this.Controls.Add(this.BtnVolver);
            this.Controls.Add(this.lblSegura);
            this.Controls.Add(this.lblMedia);
            this.Controls.Add(this.lblBaja);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CbxClave);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.RbClave);
            this.Controls.Add(this.RbNombre);
            this.Controls.Add(this.TxtCEmpleado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.TxtContraseñas);
            this.Controls.Add(this.LbContraseña);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.LbUser);
            this.Controls.Add(this.CbxTipo);
            this.Controls.Add(this.LbTipo);
            this.Controls.Add(this.CbxNombres);
            this.Controls.Add(this.LbNombreEmpleado);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModificarEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModificarEmpleado";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ModificarEmpleado_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ModificarEmpleado_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.TextBox TxtContraseñas;
        private System.Windows.Forms.Label LbContraseña;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.Label LbUser;
        private System.Windows.Forms.ComboBox CbxTipo;
        private System.Windows.Forms.Label LbTipo;
        private System.Windows.Forms.ComboBox CbxNombres;
        private System.Windows.Forms.Label LbNombreEmpleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtCEmpleado;
        private System.Windows.Forms.RadioButton RbNombre;
        private System.Windows.Forms.RadioButton RbClave;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.ComboBox CbxClave;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Label lblSegura;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.Label lblBaja;
        private System.Windows.Forms.Button BtnVolver;
    }
}