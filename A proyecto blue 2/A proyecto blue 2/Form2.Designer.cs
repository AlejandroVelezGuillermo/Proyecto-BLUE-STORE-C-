namespace A_proyecto_blue_2
{
    partial class Form2
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsuarioRegister = new System.Windows.Forms.TextBox();
            this.txtContraseñaRegister = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(353, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(441, 39);
            this.label2.TabIndex = 4;
            this.label2.Text = "REGISTRO BLUE STORE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(391, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 52);
            this.label1.TabIndex = 3;
            this.label1.Text = "BIENVENIDO AL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(368, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(407, 50);
            this.label3.TabIndex = 7;
            this.label3.Text = "Por favor ingrese los siguientes datos\r\npara poder crear su cuenta de BLUE STORE." +
    "";
            // 
            // txtUsuarioRegister
            // 
            this.txtUsuarioRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(14)))), ((int)(((byte)(166)))));
            this.txtUsuarioRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioRegister.ForeColor = System.Drawing.Color.White;
            this.txtUsuarioRegister.Location = new System.Drawing.Point(404, 244);
            this.txtUsuarioRegister.Name = "txtUsuarioRegister";
            this.txtUsuarioRegister.Size = new System.Drawing.Size(357, 22);
            this.txtUsuarioRegister.TabIndex = 8;
            this.txtUsuarioRegister.Text = " Usuario Nuevo";
            this.txtUsuarioRegister.Enter += new System.EventHandler(this.txtUsuarioRegister_Enter);
            this.txtUsuarioRegister.Leave += new System.EventHandler(this.txtUsuarioRegister_Leave);
            // 
            // txtContraseñaRegister
            // 
            this.txtContraseñaRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(14)))), ((int)(((byte)(166)))));
            this.txtContraseñaRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseñaRegister.ForeColor = System.Drawing.Color.White;
            this.txtContraseñaRegister.Location = new System.Drawing.Point(404, 275);
            this.txtContraseñaRegister.Name = "txtContraseñaRegister";
            this.txtContraseñaRegister.Size = new System.Drawing.Size(357, 22);
            this.txtContraseñaRegister.TabIndex = 9;
            this.txtContraseñaRegister.Text = " Contraseña Nueva";
            this.txtContraseñaRegister.Enter += new System.EventHandler(this.txtContraseñaRegister_Enter);
            this.txtContraseñaRegister.Leave += new System.EventHandler(this.txtContraseñaRegister_Leave);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(404, 323);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(117, 23);
            this.btnRegistrar.TabIndex = 10;
            this.btnRegistrar.Text = "REGISTRAR";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(644, 323);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(117, 23);
            this.btnAtras.TabIndex = 11;
            this.btnAtras.Text = "ATRAS";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::A_proyecto_blue_2.Properties.Resources.bloquear;
            this.pictureBox3.Location = new System.Drawing.Point(373, 272);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::A_proyecto_blue_2.Properties.Resources.persona;
            this.pictureBox2.Location = new System.Drawing.Point(373, 241);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::A_proyecto_blue_2.Properties.Resources.astronauta;
            this.pictureBox1.Location = new System.Drawing.Point(-3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(346, 451);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(14)))), ((int)(((byte)(166)))));
            this.ClientSize = new System.Drawing.Size(848, 450);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtContraseñaRegister);
            this.Controls.Add(this.txtUsuarioRegister);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsuarioRegister;
        private System.Windows.Forms.TextBox txtContraseñaRegister;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnAtras;
    }
}