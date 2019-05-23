namespace Meflix
{
    partial class MetflixPantallaPrincipal
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
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MetflixPantallaPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btmPeliculas = new System.Windows.Forms.Button();
            this.btmCerrarSesion = new System.Windows.Forms.Button();
            this.btmConfiguracion = new System.Windows.Forms.Button();
            this.btmBuscar = new System.Windows.Forms.Button();
            this.btmAgregar = new System.Windows.Forms.Button();
            this.btmInicio = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelForms = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(70, 34);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(84, 30);
            label1.TabIndex = 1;
            label1.Text = "Métflix";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btmPeliculas);
            this.panel1.Controls.Add(this.btmCerrarSesion);
            this.panel1.Controls.Add(this.btmConfiguracion);
            this.panel1.Controls.Add(this.btmBuscar);
            this.panel1.Controls.Add(this.btmAgregar);
            this.panel1.Controls.Add(this.btmInicio);
            this.panel1.Controls.Add(label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(181, 561);
            this.panel1.TabIndex = 0;
            // 
            // btmPeliculas
            // 
            this.btmPeliculas.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btmPeliculas.FlatAppearance.BorderSize = 0;
            this.btmPeliculas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmPeliculas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmPeliculas.Image = ((System.Drawing.Image)(resources.GetObject("btmPeliculas.Image")));
            this.btmPeliculas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btmPeliculas.Location = new System.Drawing.Point(3, 131);
            this.btmPeliculas.Name = "btmPeliculas";
            this.btmPeliculas.Size = new System.Drawing.Size(175, 42);
            this.btmPeliculas.TabIndex = 7;
            this.btmPeliculas.Text = "              Películas";
            this.btmPeliculas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btmPeliculas.UseVisualStyleBackColor = true;
            this.btmPeliculas.Click += new System.EventHandler(this.btmPeliculas_Click);
            // 
            // btmCerrarSesion
            // 
            this.btmCerrarSesion.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btmCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btmCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmCerrarSesion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmCerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("btmCerrarSesion.Image")));
            this.btmCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btmCerrarSesion.Location = new System.Drawing.Point(3, 507);
            this.btmCerrarSesion.Name = "btmCerrarSesion";
            this.btmCerrarSesion.Size = new System.Drawing.Size(175, 42);
            this.btmCerrarSesion.TabIndex = 6;
            this.btmCerrarSesion.Text = "             Cerrar sesión ";
            this.btmCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btmCerrarSesion.UseVisualStyleBackColor = true;
            this.btmCerrarSesion.Click += new System.EventHandler(this.btmCerrarSesion_Click);
            // 
            // btmConfiguracion
            // 
            this.btmConfiguracion.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btmConfiguracion.FlatAppearance.BorderSize = 0;
            this.btmConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmConfiguracion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmConfiguracion.Image = ((System.Drawing.Image)(resources.GetObject("btmConfiguracion.Image")));
            this.btmConfiguracion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btmConfiguracion.Location = new System.Drawing.Point(3, 275);
            this.btmConfiguracion.Name = "btmConfiguracion";
            this.btmConfiguracion.Size = new System.Drawing.Size(175, 42);
            this.btmConfiguracion.TabIndex = 5;
            this.btmConfiguracion.Text = "              Configuración";
            this.btmConfiguracion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btmConfiguracion.UseVisualStyleBackColor = true;
            // 
            // btmBuscar
            // 
            this.btmBuscar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btmBuscar.FlatAppearance.BorderSize = 0;
            this.btmBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmBuscar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btmBuscar.Image")));
            this.btmBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btmBuscar.Location = new System.Drawing.Point(3, 179);
            this.btmBuscar.Name = "btmBuscar";
            this.btmBuscar.Size = new System.Drawing.Size(175, 42);
            this.btmBuscar.TabIndex = 4;
            this.btmBuscar.Text = "              Buscar";
            this.btmBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btmBuscar.UseVisualStyleBackColor = true;
            this.btmBuscar.Click += new System.EventHandler(this.btmBuscar_Click);
            // 
            // btmAgregar
            // 
            this.btmAgregar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btmAgregar.FlatAppearance.BorderSize = 0;
            this.btmAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmAgregar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btmAgregar.Image")));
            this.btmAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btmAgregar.Location = new System.Drawing.Point(3, 227);
            this.btmAgregar.Name = "btmAgregar";
            this.btmAgregar.Size = new System.Drawing.Size(175, 42);
            this.btmAgregar.TabIndex = 3;
            this.btmAgregar.Text = "              Agregar";
            this.btmAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btmAgregar.UseVisualStyleBackColor = true;
            // 
            // btmInicio
            // 
            this.btmInicio.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btmInicio.FlatAppearance.BorderSize = 0;
            this.btmInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmInicio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmInicio.Image = ((System.Drawing.Image)(resources.GetObject("btmInicio.Image")));
            this.btmInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btmInicio.Location = new System.Drawing.Point(3, 83);
            this.btmInicio.Name = "btmInicio";
            this.btmInicio.Size = new System.Drawing.Size(175, 42);
            this.btmInicio.TabIndex = 2;
            this.btmInicio.Text = "              Inicio";
            this.btmInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btmInicio.UseVisualStyleBackColor = true;
            this.btmInicio.Click += new System.EventHandler(this.btmInicio_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelForms
            // 
            this.panelForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForms.Location = new System.Drawing.Point(181, 0);
            this.panelForms.Name = "panelForms";
            this.panelForms.Size = new System.Drawing.Size(603, 561);
            this.panelForms.TabIndex = 1;
            // 
            // MetflixPantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panelForms);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MetflixPantallaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Métflix";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MetflixPantallaPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.MetflixPantallaPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btmAgregar;
        private System.Windows.Forms.Button btmInicio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btmPeliculas;
        private System.Windows.Forms.Button btmCerrarSesion;
        private System.Windows.Forms.Button btmConfiguracion;
        private System.Windows.Forms.Button btmBuscar;
        private System.Windows.Forms.Panel panelForms;
    }
}