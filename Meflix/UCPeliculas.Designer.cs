namespace Meflix
{
    partial class UCPeliculas
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCPeliculas));
            this.pbPortada = new System.Windows.Forms.PictureBox();
            this.labelGenero = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelDuracion = new System.Windows.Forms.Label();
            this.labelCalificacion = new System.Windows.Forms.Label();
            this.txtSinopsis = new System.Windows.Forms.TextBox();
            this.btmPlay = new System.Windows.Forms.Button();
            this.btmReanudarPlay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbPortada)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPortada
            // 
            this.pbPortada.Image = ((System.Drawing.Image)(resources.GetObject("pbPortada.Image")));
            this.pbPortada.Location = new System.Drawing.Point(20, 22);
            this.pbPortada.Name = "pbPortada";
            this.pbPortada.Size = new System.Drawing.Size(114, 156);
            this.pbPortada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPortada.TabIndex = 0;
            this.pbPortada.TabStop = false;
            // 
            // labelGenero
            // 
            this.labelGenero.AutoSize = true;
            this.labelGenero.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGenero.Location = new System.Drawing.Point(144, 84);
            this.labelGenero.Name = "labelGenero";
            this.labelGenero.Size = new System.Drawing.Size(51, 17);
            this.labelGenero.TabIndex = 1;
            this.labelGenero.Text = "Género";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYear.Location = new System.Drawing.Point(201, 84);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(31, 17);
            this.labelYear.TabIndex = 2;
            this.labelYear.Text = "Año";
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(140, 21);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(64, 25);
            this.labelTitulo.TabIndex = 3;
            this.labelTitulo.Text = "Título";
            // 
            // labelDuracion
            // 
            this.labelDuracion.AutoSize = true;
            this.labelDuracion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDuracion.Location = new System.Drawing.Point(238, 84);
            this.labelDuracion.Name = "labelDuracion";
            this.labelDuracion.Size = new System.Drawing.Size(60, 17);
            this.labelDuracion.TabIndex = 4;
            this.labelDuracion.Text = "Duracion";
            // 
            // labelCalificacion
            // 
            this.labelCalificacion.AutoSize = true;
            this.labelCalificacion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCalificacion.Location = new System.Drawing.Point(144, 56);
            this.labelCalificacion.Name = "labelCalificacion";
            this.labelCalificacion.Size = new System.Drawing.Size(99, 17);
            this.labelCalificacion.TabIndex = 5;
            this.labelCalificacion.Text = "Calificación: 5/5";
            // 
            // txtSinopsis
            // 
            this.txtSinopsis.BackColor = System.Drawing.SystemColors.Control;
            this.txtSinopsis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSinopsis.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSinopsis.Location = new System.Drawing.Point(147, 104);
            this.txtSinopsis.Multiline = true;
            this.txtSinopsis.Name = "txtSinopsis";
            this.txtSinopsis.Size = new System.Drawing.Size(389, 73);
            this.txtSinopsis.TabIndex = 6;
            this.txtSinopsis.Text = "Aquí va la sinópsis";
            // 
            // btmPlay
            // 
            this.btmPlay.FlatAppearance.BorderSize = 0;
            this.btmPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmPlay.Image = ((System.Drawing.Image)(resources.GetObject("btmPlay.Image")));
            this.btmPlay.Location = new System.Drawing.Point(478, 22);
            this.btmPlay.Name = "btmPlay";
            this.btmPlay.Size = new System.Drawing.Size(47, 41);
            this.btmPlay.TabIndex = 7;
            this.btmPlay.UseVisualStyleBackColor = true;
            // 
            // btmReanudarPlay
            // 
            this.btmReanudarPlay.FlatAppearance.BorderSize = 0;
            this.btmReanudarPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmReanudarPlay.Image = ((System.Drawing.Image)(resources.GetObject("btmReanudarPlay.Image")));
            this.btmReanudarPlay.Location = new System.Drawing.Point(478, 60);
            this.btmReanudarPlay.Name = "btmReanudarPlay";
            this.btmReanudarPlay.Size = new System.Drawing.Size(47, 41);
            this.btmReanudarPlay.TabIndex = 8;
            this.btmReanudarPlay.UseVisualStyleBackColor = true;
            // 
            // UCPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btmReanudarPlay);
            this.Controls.Add(this.btmPlay);
            this.Controls.Add(this.txtSinopsis);
            this.Controls.Add(this.labelCalificacion);
            this.Controls.Add(this.labelDuracion);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.labelGenero);
            this.Controls.Add(this.pbPortada);
            this.Name = "UCPeliculas";
            this.Size = new System.Drawing.Size(550, 200);
            ((System.ComponentModel.ISupportInitialize)(this.pbPortada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPortada;
        private System.Windows.Forms.Label labelGenero;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelDuracion;
        private System.Windows.Forms.Label labelCalificacion;
        private System.Windows.Forms.TextBox txtSinopsis;
        private System.Windows.Forms.Button btmPlay;
        private System.Windows.Forms.Button btmReanudarPlay;
    }
}
