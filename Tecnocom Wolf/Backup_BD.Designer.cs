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
            this.SuspendLayout();
            // 
            // dir_respaldo
            // 
            this.dir_respaldo.Location = new System.Drawing.Point(85, 139);
            this.dir_respaldo.Name = "dir_respaldo";
            this.dir_respaldo.Size = new System.Drawing.Size(264, 20);
            this.dir_respaldo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(17, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Direccion:";
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackgroundImage = global::Tecnocom_Wolf.Properties.Resources.fondoP2;
            this.btn_buscar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_buscar.Location = new System.Drawing.Point(370, 137);
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
            // Backup_BD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Tecnocom_Wolf.Properties.Resources.fondoP2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(473, 299);
            this.Controls.Add(this.btnrespaldo);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dir_respaldo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Backup_BD";
            this.Text = "Respaldo de base de datos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dir_respaldo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnrespaldo;
    }
}