namespace InstaladorAutomatico.View
{
    partial class Gerenciar_Programas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBxNomePrograma = new System.Windows.Forms.TextBox();
            this.txtBxCaminhoPrograma = new System.Windows.Forms.TextBox();
            this.btnCaminhoPrograma = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.rdoBtn32bits = new System.Windows.Forms.RadioButton();
            this.rdoBtn64bits = new System.Windows.Forms.RadioButton();
            this.txtBxArg = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importarXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.programaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.programaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do programa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Arquitetura:";
            // 
            // txtBxNomePrograma
            // 
            this.txtBxNomePrograma.Location = new System.Drawing.Point(170, 24);
            this.txtBxNomePrograma.Name = "txtBxNomePrograma";
            this.txtBxNomePrograma.Size = new System.Drawing.Size(244, 20);
            this.txtBxNomePrograma.TabIndex = 2;
            this.txtBxNomePrograma.TextChanged += new System.EventHandler(this.TxtBxNomePrograma_TextChanged);
            // 
            // txtBxCaminhoPrograma
            // 
            this.txtBxCaminhoPrograma.Location = new System.Drawing.Point(170, 50);
            this.txtBxCaminhoPrograma.Name = "txtBxCaminhoPrograma";
            this.txtBxCaminhoPrograma.Size = new System.Drawing.Size(205, 20);
            this.txtBxCaminhoPrograma.TabIndex = 3;
            this.txtBxCaminhoPrograma.TextChanged += new System.EventHandler(this.TxtBxCaminhoPrograma_TextChanged);
            // 
            // btnCaminhoPrograma
            // 
            this.btnCaminhoPrograma.Location = new System.Drawing.Point(381, 49);
            this.btnCaminhoPrograma.Name = "btnCaminhoPrograma";
            this.btnCaminhoPrograma.Size = new System.Drawing.Size(33, 21);
            this.btnCaminhoPrograma.TabIndex = 4;
            this.btnCaminhoPrograma.Text = "...";
            this.btnCaminhoPrograma.UseVisualStyleBackColor = true;
            this.btnCaminhoPrograma.Click += new System.EventHandler(this.BtnCaminhoPrograma_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFechar.AutoSize = true;
            this.btnFechar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(284, 103);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(62, 27);
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
            this.btnLimpar.Location = new System.Drawing.Point(352, 103);
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
            this.label3.Location = new System.Drawing.Point(12, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Caminho:";
            // 
            // rdoBtn32bits
            // 
            this.rdoBtn32bits.AutoSize = true;
            this.rdoBtn32bits.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBtn32bits.Location = new System.Drawing.Point(100, 100);
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
            this.rdoBtn64bits.Location = new System.Drawing.Point(175, 100);
            this.rdoBtn64bits.Name = "rdoBtn64bits";
            this.rdoBtn64bits.Size = new System.Drawing.Size(69, 21);
            this.rdoBtn64bits.TabIndex = 9;
            this.rdoBtn64bits.TabStop = true;
            this.rdoBtn64bits.Text = "64-bits";
            this.rdoBtn64bits.UseVisualStyleBackColor = true;
            this.rdoBtn64bits.CheckedChanged += new System.EventHandler(this.RdoBtn64bits_CheckedChanged);
            // 
            // txtBxArg
            // 
            this.txtBxArg.Location = new System.Drawing.Point(170, 76);
            this.txtBxArg.Name = "txtBxArg";
            this.txtBxArg.Size = new System.Drawing.Size(244, 20);
            this.txtBxArg.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Argumentos:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(425, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvarToolStripMenuItem,
            this.salvarComoToolStripMenuItem,
            this.importarXMLToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.salvarToolStripMenuItem.Text = "Salvar";
            this.salvarToolStripMenuItem.Click += new System.EventHandler(this.SalvarToolStripMenuItem_Click);
            // 
            // salvarComoToolStripMenuItem
            // 
            this.salvarComoToolStripMenuItem.Name = "salvarComoToolStripMenuItem";
            this.salvarComoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.salvarComoToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.salvarComoToolStripMenuItem.Text = "Salvar Como";
            this.salvarComoToolStripMenuItem.Click += new System.EventHandler(this.SalvarComoToolStripMenuItem_Click);
            // 
            // importarXMLToolStripMenuItem
            // 
            this.importarXMLToolStripMenuItem.Name = "importarXMLToolStripMenuItem";
            this.importarXMLToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.importarXMLToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.importarXMLToolStripMenuItem.Text = "Importar XML";
            // 
            // programaBindingSource2
            // 
            this.programaBindingSource2.DataSource = typeof(InstaladorAutomatico.Model.Programa);
            // 
            // programaBindingSource
            // 
            this.programaBindingSource.DataSource = typeof(InstaladorAutomatico.Model.Programa);
            // 
            // programaBindingSource1
            // 
            this.programaBindingSource1.DataSource = typeof(InstaladorAutomatico.Model.Programa);
            // 
            // Gerenciar_Programas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 142);
            this.Controls.Add(this.txtBxArg);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rdoBtn64bits);
            this.Controls.Add(this.rdoBtn32bits);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnCaminhoPrograma);
            this.Controls.Add(this.txtBxCaminhoPrograma);
            this.Controls.Add(this.txtBxNomePrograma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Gerenciar_Programas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gerenciar Programa";
            this.Shown += new System.EventHandler(this.Gerenciar_Programas_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programaBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programaBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBxNomePrograma;
        private System.Windows.Forms.TextBox txtBxCaminhoPrograma;
        private System.Windows.Forms.Button btnCaminhoPrograma;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdoBtn32bits;
        private System.Windows.Forms.RadioButton rdoBtn64bits;
        private System.Windows.Forms.TextBox txtBxArg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarComoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importarXMLToolStripMenuItem;
        private System.Windows.Forms.BindingSource programaBindingSource;
        private System.Windows.Forms.BindingSource programaBindingSource1;
        private System.Windows.Forms.BindingSource programaBindingSource2;
    }
}