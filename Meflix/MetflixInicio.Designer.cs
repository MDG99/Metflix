namespace Meflix
{
    partial class MetflixInicio
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.NoResultados = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Películas vistas recientemente";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel1.Controls.Add(this.NoResultados);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(27, 50);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(561, 482);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // NoResultados
            // 
            this.NoResultados.AutoSize = true;
            this.NoResultados.Enabled = false;
            this.NoResultados.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoResultados.ForeColor = System.Drawing.Color.Red;
            this.NoResultados.Location = new System.Drawing.Point(3, 0);
            this.NoResultados.Name = "NoResultados";
            this.NoResultados.Size = new System.Drawing.Size(395, 30);
            this.NoResultados.TabIndex = 33;
            this.NoResultados.Text = "No tiene películas vistas recientemente";
            this.NoResultados.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NoResultados.Visible = false;
            // 
            // MetflixInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 543);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MetflixInicio";
            this.RightToLeftLayout = true;
            this.Text = "MetflixInicio";
            this.Load += new System.EventHandler(this.MetflixInicio_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label NoResultados;
    }
}