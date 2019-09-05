namespace InstaladorAutomatico.View
{
    partial class ProgressoInstalacao
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
            this.lblInstalacao = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // lblInstalacao
            // 
            this.lblInstalacao.AutoSize = true;
            this.lblInstalacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstalacao.Location = new System.Drawing.Point(12, 9);
            this.lblInstalacao.Name = "lblInstalacao";
            this.lblInstalacao.Size = new System.Drawing.Size(85, 17);
            this.lblInstalacao.TabIndex = 0;
            this.lblInstalacao.Text = "Instalando...";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 33);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(182, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // ProgressoInstalacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 68);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblInstalacao);
            this.Name = "ProgressoInstalacao";
            this.Text = "ProgressoInstalacao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstalacao;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}