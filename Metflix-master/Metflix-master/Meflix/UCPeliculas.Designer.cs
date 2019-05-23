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
            ((System.ComponentModel.ISupportInitialize)(this.pbPortada)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPortada
            // 
            this.pbPortada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbPortada.Image = ((System.Drawing.Image)(resources.GetObject("pbPortada.Image")));
            this.pbPortada.Location = new System.Drawing.Point(20, 22);
            this.pbPortada.Name = "pbPortada";
            this.pbPortada.Size = new System.Drawing.Size(114, 156);
            this.pbPortada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPortada.TabIndex = 0;
            this.pbPortada.TabStop = false;
            this.pbPortada.Click += new System.EventHandler(this.txtSinopsis_Click);
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
            this.labelGenero.Click += new System.EventHandler(this.txtSinopsis_Click);
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
            this.labelYear.Click += new System.EventHandler(this.txtSinopsis_Click);
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelTitulo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(140, 21);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(64, 25);
            this.labelTitulo.TabIndex = 3;
            this.labelTitulo.Text = "Título";
            this.labelTitulo.Click += new System.EventHandler(this.txtSinopsis_Click);
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
            this.labelDuracion.Click += new System.EventHandler(this.txtSinopsis_Click);
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
            this.labelCalificacion.Click += new System.EventHandler(this.txtSinopsis_Click);
            // 
            // txtSinopsis
            // 
            this.txtSinopsis.BackColor = System.Drawing.SystemColors.Control;
            this.txtSinopsis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSinopsis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtSinopsis.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSinopsis.Location = new System.Drawing.Point(147, 104);
            this.txtSinopsis.Multiline = true;
            this.txtSinopsis.Name = "txtSinopsis";
            this.txtSinopsis.Size = new System.Drawing.Size(389, 73);
            this.txtSinopsis.TabIndex = 6;
            this.txtSinopsis.Text = "Aquí va la sinópsis";
            // 
            // UCPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtSinopsis);
            this.Controls.Add(this.labelCalificacion);
            this.Controls.Add(this.labelDuracion);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.labelGenero);
            this.Controls.Add(this.pbPortada);
            this.Name = "UCPeliculas";
            this.Size = new System.Drawing.Size(550, 200);
            this.Click += new System.EventHandler(this.txtSinopsis_Click);
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
    }
}
