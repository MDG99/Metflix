namespace Meflix
{
    partial class MetflixReproducir
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bttnpp = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.bttnstop = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.BackgroundImage = global::Meflix.Properties.Resources.metflix;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Help;
            this.pictureBox1.Location = new System.Drawing.Point(50, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(499, 418);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bttnpp
            // 
            this.bttnpp.BackColor = System.Drawing.Color.White;
            this.bttnpp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnpp.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.bttnpp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnpp.Location = new System.Drawing.Point(20, 485);
            this.bttnpp.Name = "bttnpp";
            this.bttnpp.Size = new System.Drawing.Size(75, 42);
            this.bttnpp.TabIndex = 1;
            this.bttnpp.Text = "Play";
            this.bttnpp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttnpp.UseVisualStyleBackColor = false;
            this.bttnpp.Click += new System.EventHandler(this.bttnpp_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.progressBar1.BackColor = System.Drawing.Color.White;
            this.progressBar1.Cursor = System.Windows.Forms.Cursors.Default;
            this.progressBar1.ForeColor = System.Drawing.Color.DarkRed;
            this.progressBar1.Location = new System.Drawing.Point(249, 500);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(300, 20);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 2;
            // 
            // bttnstop
            // 
            this.bttnstop.BackColor = System.Drawing.Color.White;
            this.bttnstop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnstop.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.bttnstop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnstop.Location = new System.Drawing.Point(101, 491);
            this.bttnstop.Name = "bttnstop";
            this.bttnstop.Size = new System.Drawing.Size(92, 32);
            this.bttnstop.TabIndex = 3;
            this.bttnstop.Text = "Detener";
            this.bttnstop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttnstop.UseVisualStyleBackColor = false;
            this.bttnstop.Click += new System.EventHandler(this.bttnstop_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(245, 523);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Iniciando";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(389, 523);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "minutos restantes";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Visible = false;
            // 
            // MetflixReproducir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(599, 543);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttnstop);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.bttnpp);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MetflixReproducir";
            this.Text = "MetflixReproducir";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bttnpp;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button bttnstop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}