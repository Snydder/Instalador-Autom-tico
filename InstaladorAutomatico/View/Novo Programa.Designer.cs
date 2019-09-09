namespace InstaladorAutomatico.View
{
    partial class Novo_Programa
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBxNomePrograma = new System.Windows.Forms.TextBox();
            this.txtBxCaminhoPrograma = new System.Windows.Forms.TextBox();
            this.btnCaminhoPrograma = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.rdoBtn32bits = new System.Windows.Forms.RadioButton();
            this.rdoBtn64bits = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBxArg = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do programa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Arquitetura:";
            // 
            // txtBxNomePrograma
            // 
            this.txtBxNomePrograma.Location = new System.Drawing.Point(170, 9);
            this.txtBxNomePrograma.Name = "txtBxNomePrograma";
            this.txtBxNomePrograma.Size = new System.Drawing.Size(132, 20);
            this.txtBxNomePrograma.TabIndex = 2;
            this.txtBxNomePrograma.TextChanged += new System.EventHandler(this.TxtBxNomePrograma_TextChanged);
            // 
            // txtBxCaminhoPrograma
            // 
            this.txtBxCaminhoPrograma.Location = new System.Drawing.Point(170, 35);
            this.txtBxCaminhoPrograma.Name = "txtBxCaminhoPrograma";
            this.txtBxCaminhoPrograma.Size = new System.Drawing.Size(213, 20);
            this.txtBxCaminhoPrograma.TabIndex = 3;
            this.txtBxCaminhoPrograma.TextChanged += new System.EventHandler(this.TxtBxCaminhoPrograma_TextChanged);
            // 
            // btnCaminhoPrograma
            // 
            this.btnCaminhoPrograma.Location = new System.Drawing.Point(389, 36);
            this.btnCaminhoPrograma.Name = "btnCaminhoPrograma";
            this.btnCaminhoPrograma.Size = new System.Drawing.Size(26, 20);
            this.btnCaminhoPrograma.TabIndex = 4;
            this.btnCaminhoPrograma.Text = "...";
            this.btnCaminhoPrograma.UseVisualStyleBackColor = true;
            this.btnCaminhoPrograma.Click += new System.EventHandler(this.BtnCaminhoPrograma_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdicionar.AutoSize = true;
            this.btnAdicionar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(12, 119);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(77, 27);
            this.btnAdicionar.TabIndex = 5;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFechar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(271, 119);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(77, 27);
            this.btnFechar.TabIndex = 6;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLimpar.AutoSize = true;
            this.btnLimpar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(353, 119);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(61, 27);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Caminho do programa:";
            // 
            // rdoBtn32bits
            // 
            this.rdoBtn32bits.AutoSize = true;
            this.rdoBtn32bits.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBtn32bits.Location = new System.Drawing.Point(100, 85);
            this.rdoBtn32bits.Name = "rdoBtn32bits";
            this.rdoBtn32bits.Size = new System.Drawing.Size(69, 21);
            this.rdoBtn32bits.TabIndex = 8;
            this.rdoBtn32bits.TabStop = true;
            this.rdoBtn32bits.Text = "32-bits";
            this.rdoBtn32bits.UseVisualStyleBackColor = true;
            this.rdoBtn32bits.CheckedChanged += new System.EventHandler(this.RdoBtn32bits_CheckedChanged);
            // 
            // rdoBtn64bits
            // 
            this.rdoBtn64bits.AutoSize = true;
            this.rdoBtn64bits.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBtn64bits.Location = new System.Drawing.Point(175, 85);
            this.rdoBtn64bits.Name = "rdoBtn64bits";
            this.rdoBtn64bits.Size = new System.Drawing.Size(69, 21);
            this.rdoBtn64bits.TabIndex = 9;
            this.rdoBtn64bits.TabStop = true;
            this.rdoBtn64bits.Text = "64-bits";
            this.rdoBtn64bits.UseVisualStyleBackColor = true;
            this.rdoBtn64bits.CheckedChanged += new System.EventHandler(this.RdoBtn64bits_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(194, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "label5";
            // 
            // txtBxArg
            // 
            this.txtBxArg.Location = new System.Drawing.Point(170, 61);
            this.txtBxArg.Name = "txtBxArg";
            this.txtBxArg.Size = new System.Drawing.Size(244, 20);
            this.txtBxArg.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Argumentos:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(283, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "label7";
            // 
            // Novo_Programa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 158);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBxArg);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rdoBtn64bits);
            this.Controls.Add(this.rdoBtn32bits);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnCaminhoPrograma);
            this.Controls.Add(this.txtBxCaminhoPrograma);
            this.Controls.Add(this.txtBxNomePrograma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Novo_Programa";
            this.Text = "Novo_Programa";
            this.Load += new System.EventHandler(this.Novo_Programa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBxNomePrograma;
        private System.Windows.Forms.TextBox txtBxCaminhoPrograma;
        private System.Windows.Forms.Button btnCaminhoPrograma;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdoBtn32bits;
        private System.Windows.Forms.RadioButton rdoBtn64bits;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBxArg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}