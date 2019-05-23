namespace Meflix
{
    partial class PeliculaEmergente
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
            System.Windows.Forms.Label labelOpiniones;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PeliculaEmergente));
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.pbPortada = new System.Windows.Forms.PictureBox();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelCalificacion = new System.Windows.Forms.Label();
            this.labelGenero = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.txtSinopsis = new System.Windows.Forms.TextBox();
            this.btmOpinion = new System.Windows.Forms.Button();
            this.labelDuracion = new System.Windows.Forms.Label();
            this.labelClasificacion = new System.Windows.Forms.Label();
            this.btmReanudarPlay = new System.Windows.Forms.Button();
            this.btmPlay = new System.Windows.Forms.Button();
            this.btmSalir = new System.Windows.Forms.Button();
            labelOpiniones = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPortada)).BeginInit();
            this.SuspendLayout();
            // 
            // labelOpiniones
            // 
            labelOpiniones.AutoSize = true;
            labelOpiniones.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelOpiniones.Location = new System.Drawing.Point(7, 237);
            labelOpiniones.Name = "labelOpiniones";
            labelOpiniones.Size = new System.Drawing.Size(98, 25);
            labelOpiniones.TabIndex = 7;
            labelOpiniones.Text = "Opiniones";
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 265);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(437, 229);
            this.flowLayoutPanel.TabIndex = 0;
            // 
            // pbPortada
            // 
            this.pbPortada.Location = new System.Drawing.Point(12, 12);
            this.pbPortada.Name = "pbPortada";
            this.pbPortada.Size = new System.Drawing.Size(149, 217);
            this.pbPortada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPortada.TabIndex = 1;
            this.pbPortada.TabStop = false;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(167, 12);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(64, 25);
            this.labelTitulo.TabIndex = 2;
            this.labelTitulo.Text = "Titulo";
            // 
            // labelCalificacion
            // 
            this.labelCalificacion.AutoSize = true;
            this.labelCalificacion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCalificacion.Location = new System.Drawing.Point(178, 46);
            this.labelCalificacion.Name = "labelCalificacion";
            this.labelCalificacion.Size = new System.Drawing.Size(76, 19);
            this.labelCalificacion.TabIndex = 3;
            this.labelCalificacion.Text = "Calificación";
            // 
            // labelGenero
            // 
            this.labelGenero.AutoSize = true;
            this.labelGenero.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGenero.Location = new System.Drawing.Point(178, 74);
            this.labelGenero.Name = "labelGenero";
            this.labelGenero.Size = new System.Drawing.Size(54, 19);
            this.labelGenero.TabIndex = 4;
            this.labelGenero.Text = "Género";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYear.Location = new System.Drawing.Point(257, 74);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(34, 19);
            this.labelYear.TabIndex = 5;
            this.labelYear.Text = "Año";
            // 
            // txtSinopsis
            // 
            this.txtSinopsis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSinopsis.CausesValidation = false;
            this.txtSinopsis.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtSinopsis.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSinopsis.Location = new System.Drawing.Point(175, 96);
            this.txtSinopsis.Multiline = true;
            this.txtSinopsis.Name = "txtSinopsis";
            this.txtSinopsis.ReadOnly = true;
            this.txtSinopsis.Size = new System.Drawing.Size(352, 126);
            this.txtSinopsis.TabIndex = 6;
            // 
            // btmOpinion
            // 
            this.btmOpinion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmOpinion.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmOpinion.Location = new System.Drawing.Point(290, 500);
            this.btmOpinion.Name = "btmOpinion";
            this.btmOpinion.Size = new System.Drawing.Size(147, 28);
            this.btmOpinion.TabIndex = 11;
            this.btmOpinion.Text = "Escribir opinión";
            this.btmOpinion.UseVisualStyleBackColor = true;
            // 
            // labelDuracion
            // 
            this.labelDuracion.AutoSize = true;
            this.labelDuracion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDuracion.Location = new System.Drawing.Point(308, 74);
            this.labelDuracion.Name = "labelDuracion";
            this.labelDuracion.Size = new System.Drawing.Size(64, 19);
            this.labelDuracion.TabIndex = 12;
            this.labelDuracion.Text = "Duración";
            // 
            // labelClasificacion
            // 
            this.labelClasificacion.AutoSize = true;
            this.labelClasificacion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClasificacion.Location = new System.Drawing.Point(389, 74);
            this.labelClasificacion.Name = "labelClasificacion";
            this.labelClasificacion.Size = new System.Drawing.Size(82, 19);
            this.labelClasificacion.TabIndex = 13;
            this.labelClasificacion.Text = "Clasificación";
            // 
            // btmReanudarPlay
            // 
            this.btmReanudarPlay.FlatAppearance.BorderSize = 0;
            this.btmReanudarPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmReanudarPlay.Image = ((System.Drawing.Image)(resources.GetObject("btmReanudarPlay.Image")));
            this.btmReanudarPlay.Location = new System.Drawing.Point(465, 333);
            this.btmReanudarPlay.Name = "btmReanudarPlay";
            this.btmReanudarPlay.Size = new System.Drawing.Size(62, 58);
            this.btmReanudarPlay.TabIndex = 16;
            this.btmReanudarPlay.UseVisualStyleBackColor = true;
            // 
            // btmPlay
            // 
            this.btmPlay.FlatAppearance.BorderSize = 0;
            this.btmPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmPlay.Image = ((System.Drawing.Image)(resources.GetObject("btmPlay.Image")));
            this.btmPlay.Location = new System.Drawing.Point(465, 265);
            this.btmPlay.Name = "btmPlay";
            this.btmPlay.Size = new System.Drawing.Size(62, 62);
            this.btmPlay.TabIndex = 15;
            this.btmPlay.UseVisualStyleBackColor = true;
            // 
            // btmSalir
            // 
            this.btmSalir.FlatAppearance.BorderSize = 0;
            this.btmSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmSalir.Image = ((System.Drawing.Image)(resources.GetObject("btmSalir.Image")));
            this.btmSalir.Location = new System.Drawing.Point(465, 397);
            this.btmSalir.Name = "btmSalir";
            this.btmSalir.Size = new System.Drawing.Size(62, 58);
            this.btmSalir.TabIndex = 17;
            this.btmSalir.UseVisualStyleBackColor = true;
            this.btmSalir.Click += new System.EventHandler(this.btmSalir_Click);
            // 
            // PeliculaEmergente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(544, 540);
            this.ControlBox = false;
            this.Controls.Add(this.btmSalir);
            this.Controls.Add(this.btmReanudarPlay);
            this.Controls.Add(this.btmPlay);
            this.Controls.Add(this.labelClasificacion);
            this.Controls.Add(this.labelDuracion);
            this.Controls.Add(this.btmOpinion);
            this.Controls.Add(labelOpiniones);
            this.Controls.Add(this.txtSinopsis);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.labelGenero);
            this.Controls.Add(this.labelCalificacion);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.pbPortada);
            this.Controls.Add(this.flowLayoutPanel);
            this.Name = "PeliculaEmergente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PeliculaEmergente";
            ((System.ComponentModel.ISupportInitialize)(this.pbPortada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.PictureBox pbPortada;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelCalificacion;
        private System.Windows.Forms.Label labelGenero;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.TextBox txtSinopsis;
        private System.Windows.Forms.Button btmOpinion;
        private System.Windows.Forms.Label labelDuracion;
        private System.Windows.Forms.Label labelClasificacion;
        private System.Windows.Forms.Button btmReanudarPlay;
        private System.Windows.Forms.Button btmPlay;
        private System.Windows.Forms.Button btmSalir;
    }
}