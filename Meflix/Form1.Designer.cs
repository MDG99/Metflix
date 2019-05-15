namespace Meflix
{
    partial class InicioSesión
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
            TransControl_src.TransparentControl transparentControl1;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.PictureBox pictureBox1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioSesión));
            this.txtCrearCuenta = new System.Windows.Forms.Label();
            this.btmIniciarSesión = new System.Windows.Forms.Button();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            transparentControl1 = new TransControl_src.TransparentControl();
            label1 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            transparentControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // transparentControl1
            // 
            transparentControl1.Controls.Add(this.txtCrearCuenta);
            transparentControl1.Controls.Add(label1);
            transparentControl1.Controls.Add(this.btmIniciarSesión);
            transparentControl1.Controls.Add(this.txtContraseña);
            transparentControl1.Controls.Add(this.txtUsuario);
            transparentControl1.Controls.Add(pictureBox1);
            transparentControl1.Location = new System.Drawing.Point(275, 100);
            transparentControl1.MinimumSize = new System.Drawing.Size(100, 75);
            transparentControl1.Name = "transparentControl1";
            transparentControl1.Opacity = 0.8D;
            transparentControl1.Size = new System.Drawing.Size(250, 325);
            transparentControl1.TabIndex = 0;
            transparentControl1.Text = "transparentControl1";
            transparentControl1.Transparent = true;
            transparentControl1.TransparentColor = System.Drawing.SystemColors.Desktop;
            transparentControl1.Click += new System.EventHandler(this.txtCrearCuenta_Click);
            // 
            // txtCrearCuenta
            // 
            this.txtCrearCuenta.AutoSize = true;
            this.txtCrearCuenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtCrearCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCrearCuenta.ForeColor = System.Drawing.SystemColors.Control;
            this.txtCrearCuenta.Location = new System.Drawing.Point(124, 299);
            this.txtCrearCuenta.Name = "txtCrearCuenta";
            this.txtCrearCuenta.Size = new System.Drawing.Size(98, 13);
            this.txtCrearCuenta.TabIndex = 5;
            this.txtCrearCuenta.Text = "Crear cuenta ahora";
            this.txtCrearCuenta.Click += new System.EventHandler(this.txtContraseña_TextChanged);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            label1.Location = new System.Drawing.Point(19, 299);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(99, 13);
            label1.TabIndex = 4;
            label1.Text = "¿Nuevo en Métflix?";
            // 
            // btmIniciarSesión
            // 
            this.btmIniciarSesión.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(9)))), ((int)(((byte)(11)))));
            this.btmIniciarSesión.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btmIniciarSesión.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(9)))), ((int)(((byte)(11)))));
            this.btmIniciarSesión.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmIniciarSesión.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmIniciarSesión.ForeColor = System.Drawing.SystemColors.Control;
            this.btmIniciarSesión.Location = new System.Drawing.Point(20, 185);
            this.btmIniciarSesión.Name = "btmIniciarSesión";
            this.btmIniciarSesión.Size = new System.Drawing.Size(209, 35);
            this.btmIniciarSesión.TabIndex = 3;
            this.btmIniciarSesión.Text = "Iniciar sesión";
            this.btmIniciarSesión.UseVisualStyleBackColor = false;
            this.btmIniciarSesión.Click += new System.EventHandler(this.btmIniciarSesión_Click);
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContraseña.Font = new System.Drawing.Font("Open Sans Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtContraseña.Location = new System.Drawing.Point(22, 140);
            this.txtContraseña.MaxLength = 16;
            this.txtContraseña.Multiline = true;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(208, 29);
            this.txtContraseña.TabIndex = 2;
            this.txtContraseña.Text = "Contraseña";
            this.txtContraseña.TextChanged += new System.EventHandler(this.txtContraseña_TextChanged);
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuario.Font = new System.Drawing.Font("Open Sans Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtUsuario.Location = new System.Drawing.Point(22, 84);
            this.txtUsuario.Multiline = true;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(208, 29);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.Text = "Usuario";
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // pictureBox1
            // 
            pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            pictureBox1.Location = new System.Drawing.Point(22, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(208, 34);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // InicioSesión
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(transparentControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "InicioSesión";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Métflix.- Inicio de sesión";
            transparentControl1.ResumeLayout(false);
            transparentControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label txtCrearCuenta;
        private System.Windows.Forms.Button btmIniciarSesión;
    }
}

