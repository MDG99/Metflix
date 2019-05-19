namespace Meflix
{
    partial class Metflix
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Metflix));
            this.lstbPeliculasVistas = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btmReproducir = new System.Windows.Forms.Button();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.txtSinopsis = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.txtCalificacion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TituloPeliculas = new System.Windows.Forms.Label();
            this.pbPortada = new System.Windows.Forms.PictureBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPortada)).BeginInit();
            this.SuspendLayout();
            // 
            // lstbPeliculasVistas
            // 
            this.lstbPeliculasVistas.FormattingEnabled = true;
            this.lstbPeliculasVistas.Location = new System.Drawing.Point(12, 415);
            this.lstbPeliculasVistas.Name = "lstbPeliculasVistas";
            this.lstbPeliculasVistas.Size = new System.Drawing.Size(818, 264);
            this.lstbPeliculasVistas.TabIndex = 0;
            this.lstbPeliculasVistas.SelectedIndexChanged += new System.EventHandler(this.lstbPeliculasVistas_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btmReproducir);
            this.panel1.Controls.Add(this.txtGenero);
            this.panel1.Controls.Add(this.txtSinopsis);
            this.panel1.Controls.Add(this.txtYear);
            this.panel1.Controls.Add(this.txtDuracion);
            this.panel1.Controls.Add(this.txtCalificacion);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.TituloPeliculas);
            this.panel1.Controls.Add(this.pbPortada);
            this.panel1.Location = new System.Drawing.Point(896, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 621);
            this.panel1.TabIndex = 1;
            // 
            // btmReproducir
            // 
            this.btmReproducir.Location = new System.Drawing.Point(100, 547);
            this.btmReproducir.Name = "btmReproducir";
            this.btmReproducir.Size = new System.Drawing.Size(249, 49);
            this.btmReproducir.TabIndex = 19;
            this.btmReproducir.Text = "button2";
            this.btmReproducir.UseVisualStyleBackColor = true;
            this.btmReproducir.Visible = false;
            // 
            // txtGenero
            // 
            this.txtGenero.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenero.Location = new System.Drawing.Point(319, 382);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(86, 29);
            this.txtGenero.TabIndex = 18;
            // 
            // txtSinopsis
            // 
            this.txtSinopsis.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSinopsis.Location = new System.Drawing.Point(131, 424);
            this.txtSinopsis.Multiline = true;
            this.txtSinopsis.Name = "txtSinopsis";
            this.txtSinopsis.Size = new System.Drawing.Size(299, 89);
            this.txtSinopsis.TabIndex = 17;
            // 
            // txtYear
            // 
            this.txtYear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear.Location = new System.Drawing.Point(135, 382);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(86, 29);
            this.txtYear.TabIndex = 16;
            // 
            // txtDuracion
            // 
            this.txtDuracion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuracion.Location = new System.Drawing.Point(227, 382);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(86, 29);
            this.txtDuracion.TabIndex = 15;
            // 
            // txtCalificacion
            // 
            this.txtCalificacion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalificacion.Location = new System.Drawing.Point(43, 382);
            this.txtCalificacion.Name = "txtCalificacion";
            this.txtCalificacion.Size = new System.Drawing.Size(86, 29);
            this.txtCalificacion.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(54, 424);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "Sinópsis:";
            // 
            // TituloPeliculas
            // 
            this.TituloPeliculas.AutoSize = true;
            this.TituloPeliculas.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloPeliculas.Location = new System.Drawing.Point(41, 23);
            this.TituloPeliculas.Name = "TituloPeliculas";
            this.TituloPeliculas.Size = new System.Drawing.Size(366, 37);
            this.TituloPeliculas.TabIndex = 11;
            this.TituloPeliculas.Text = "Películas vistas recientemente";
            this.TituloPeliculas.Visible = false;
            // 
            // pbPortada
            // 
            this.pbPortada.Location = new System.Drawing.Point(99, 63);
            this.pbPortada.Name = "pbPortada";
            this.pbPortada.Size = new System.Drawing.Size(250, 300);
            this.pbPortada.TabIndex = 0;
            this.pbPortada.TabStop = false;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(12, 182);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(817, 158);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(30, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(431, 29);
            this.textBox1.TabIndex = 3;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(65, 66);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(65, 101);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 17);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(294, 66);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(80, 17);
            this.checkBox3.TabIndex = 6;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(294, 101);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(80, 17);
            this.checkBox4.TabIndex = 7;
            this.checkBox4.Text = "checkBox4";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(546, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 28);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 37);
            this.label1.TabIndex = 9;
            this.label1.Text = "Películas vistas recientemente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(334, 37);
            this.label2.TabIndex = 10;
            this.label2.Text = "Resultados de la búsqueda";
            // 
            // Metflix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lstbPeliculasVistas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Metflix";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Métflix";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPortada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstbPeliculasVistas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbPortada;
        private System.Windows.Forms.Label TituloPeliculas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btmReproducir;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.TextBox txtSinopsis;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.TextBox txtCalificacion;
    }
}