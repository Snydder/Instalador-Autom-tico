namespace InstaladorAutomatico
{
    partial class Principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnMarcaDesmarca = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeProgramasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoProgramaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarArquivoDeConfiguraçãoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.verificarWindowsUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSair = new System.Windows.Forms.Button();
            this.chkBxRdmn = new System.Windows.Forms.CheckBox();
            this.chkBxWnRr = new System.Windows.Forms.CheckBox();
            this.chkBxKspsk = new System.Windows.Forms.CheckBox();
            this.chkBxCClnr = new System.Windows.Forms.CheckBox();
            this.chkBxGglChrm = new System.Windows.Forms.CheckBox();
            this.chkBxCtPDF = new System.Windows.Forms.CheckBox();
            this.tblPnlOrganiza = new System.Windows.Forms.TableLayoutPanel();
            this.chkBxAtlzJv = new System.Windows.Forms.CheckBox();
            this.chkBxLbrOffc = new System.Windows.Forms.CheckBox();
            this.chkBxAmmyy = new System.Windows.Forms.CheckBox();
            this.chkBxUltraVNC = new System.Windows.Forms.CheckBox();
            this.chkBxThndbrd = new System.Windows.Forms.CheckBox();
            this.chkbxTmVwr = new System.Windows.Forms.CheckBox();
            this.btnCopiarArquivos = new System.Windows.Forms.Button();
            this.verificarInstalaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.tblPnlOrganiza.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnMarcaDesmarca
            // 
            this.BtnMarcaDesmarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMarcaDesmarca.Location = new System.Drawing.Point(0, 294);
            this.BtnMarcaDesmarca.Name = "BtnMarcaDesmarca";
            this.BtnMarcaDesmarca.Size = new System.Drawing.Size(125, 30);
            this.BtnMarcaDesmarca.TabIndex = 6;
            this.BtnMarcaDesmarca.Text = "Marcar Tudo";
            this.BtnMarcaDesmarca.UseVisualStyleBackColor = true;
            this.BtnMarcaDesmarca.Click += new System.EventHandler(this.BtnMarcaDesmarca_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.AutoSize = true;
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.Location = new System.Drawing.Point(131, 328);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(166, 30);
            this.btnIniciar.TabIndex = 8;
            this.btnIniciar.Text = "Instalar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnInstlr_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(302, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaDeProgramasToolStripMenuItem,
            this.verificarWindowsUpdateToolStripMenuItem,
            this.verificarInstalaçõesToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // listaDeProgramasToolStripMenuItem
            // 
            this.listaDeProgramasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoProgramaToolStripMenuItem1,
            this.alterarArquivoDeConfiguraçãoToolStripMenuItem1});
            this.listaDeProgramasToolStripMenuItem.Name = "listaDeProgramasToolStripMenuItem";
            this.listaDeProgramasToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.listaDeProgramasToolStripMenuItem.Text = "Lista de Programas ";
            // 
            // novoProgramaToolStripMenuItem1
            // 
            this.novoProgramaToolStripMenuItem1.Name = "novoProgramaToolStripMenuItem1";
            this.novoProgramaToolStripMenuItem1.Size = new System.Drawing.Size(245, 22);
            this.novoProgramaToolStripMenuItem1.Text = "Novo Programa";
            this.novoProgramaToolStripMenuItem1.Click += new System.EventHandler(this.NovoProgramaToolStripMenuItem1_Click);
            // 
            // alterarArquivoDeConfiguraçãoToolStripMenuItem1
            // 
            this.alterarArquivoDeConfiguraçãoToolStripMenuItem1.Name = "alterarArquivoDeConfiguraçãoToolStripMenuItem1";
            this.alterarArquivoDeConfiguraçãoToolStripMenuItem1.Size = new System.Drawing.Size(245, 22);
            this.alterarArquivoDeConfiguraçãoToolStripMenuItem1.Text = "Alterar Arquivo de Configuração";
            this.alterarArquivoDeConfiguraçãoToolStripMenuItem1.Click += new System.EventHandler(this.AlterarArquivoDeConfiguraçãoToolStripMenuItem1_Click);
            // 
            // verificarWindowsUpdateToolStripMenuItem
            // 
            this.verificarWindowsUpdateToolStripMenuItem.Name = "verificarWindowsUpdateToolStripMenuItem";
            this.verificarWindowsUpdateToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.verificarWindowsUpdateToolStripMenuItem.Text = "Verificar Windows Update";
            // 
            // btnSair
            // 
            this.btnSair.AutoSize = true;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(0, 328);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(125, 30);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // chkBxRdmn
            // 
            this.chkBxRdmn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkBxRdmn.AutoSize = true;
            this.chkBxRdmn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBxRdmn.Location = new System.Drawing.Point(11, 183);
            this.chkBxRdmn.Margin = new System.Windows.Forms.Padding(8);
            this.chkBxRdmn.Name = "chkBxRdmn";
            this.chkBxRdmn.Size = new System.Drawing.Size(83, 24);
            this.chkBxRdmn.TabIndex = 4;
            this.chkBxRdmn.Text = "Radmin";
            this.chkBxRdmn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkBxRdmn.UseVisualStyleBackColor = true;
            // 
            // chkBxWnRr
            // 
            this.chkBxWnRr.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkBxWnRr.AutoSize = true;
            this.chkBxWnRr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBxWnRr.Location = new System.Drawing.Point(170, 226);
            this.chkBxWnRr.Margin = new System.Windows.Forms.Padding(8);
            this.chkBxWnRr.Name = "chkBxWnRr";
            this.chkBxWnRr.Size = new System.Drawing.Size(81, 24);
            this.chkBxWnRr.TabIndex = 3;
            this.chkBxWnRr.Text = "WinRar";
            this.chkBxWnRr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkBxWnRr.UseVisualStyleBackColor = true;
            // 
            // chkBxKspsk
            // 
            this.chkBxKspsk.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkBxKspsk.AutoSize = true;
            this.chkBxKspsk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBxKspsk.Location = new System.Drawing.Point(11, 54);
            this.chkBxKspsk.Margin = new System.Windows.Forms.Padding(8);
            this.chkBxKspsk.Name = "chkBxKspsk";
            this.chkBxKspsk.Size = new System.Drawing.Size(101, 24);
            this.chkBxKspsk.TabIndex = 9;
            this.chkBxKspsk.Text = "Kaspersky";
            this.chkBxKspsk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkBxKspsk.UseVisualStyleBackColor = true;
            // 
            // chkBxCClnr
            // 
            this.chkBxCClnr.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkBxCClnr.AutoSize = true;
            this.chkBxCClnr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBxCClnr.Location = new System.Drawing.Point(170, 54);
            this.chkBxCClnr.Margin = new System.Windows.Forms.Padding(8);
            this.chkBxCClnr.Name = "chkBxCClnr";
            this.chkBxCClnr.Size = new System.Drawing.Size(94, 24);
            this.chkBxCClnr.TabIndex = 11;
            this.chkBxCClnr.Text = "CCleaner";
            this.chkBxCClnr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkBxCClnr.UseVisualStyleBackColor = true;
            // 
            // chkBxGglChrm
            // 
            this.chkBxGglChrm.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkBxGglChrm.AutoSize = true;
            this.chkBxGglChrm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBxGglChrm.Location = new System.Drawing.Point(11, 140);
            this.chkBxGglChrm.Margin = new System.Windows.Forms.Padding(8);
            this.chkBxGglChrm.Name = "chkBxGglChrm";
            this.chkBxGglChrm.Size = new System.Drawing.Size(140, 24);
            this.chkBxGglChrm.TabIndex = 6;
            this.chkBxGglChrm.Text = "Google Chrome";
            this.chkBxGglChrm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkBxGglChrm.UseVisualStyleBackColor = true;
            // 
            // chkBxCtPDF
            // 
            this.chkBxCtPDF.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkBxCtPDF.AutoSize = true;
            this.chkBxCtPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBxCtPDF.Location = new System.Drawing.Point(170, 97);
            this.chkBxCtPDF.Margin = new System.Windows.Forms.Padding(8);
            this.chkBxCtPDF.Name = "chkBxCtPDF";
            this.chkBxCtPDF.Size = new System.Drawing.Size(94, 24);
            this.chkBxCtPDF.TabIndex = 1;
            this.chkBxCtPDF.Text = "CutePDF";
            this.chkBxCtPDF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkBxCtPDF.UseVisualStyleBackColor = true;
            // 
            // tblPnlOrganiza
            // 
            this.tblPnlOrganiza.AutoSize = true;
            this.tblPnlOrganiza.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblPnlOrganiza.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tblPnlOrganiza.ColumnCount = 2;
            this.tblPnlOrganiza.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblPnlOrganiza.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblPnlOrganiza.Controls.Add(this.chkBxAtlzJv, 0, 5);
            this.tblPnlOrganiza.Controls.Add(this.chkBxRdmn, 0, 4);
            this.tblPnlOrganiza.Controls.Add(this.chkBxGglChrm, 0, 3);
            this.tblPnlOrganiza.Controls.Add(this.chkBxLbrOffc, 0, 2);
            this.tblPnlOrganiza.Controls.Add(this.chkBxKspsk, 0, 1);
            this.tblPnlOrganiza.Controls.Add(this.chkBxAmmyy, 0, 0);
            this.tblPnlOrganiza.Controls.Add(this.chkBxWnRr, 2, 5);
            this.tblPnlOrganiza.Controls.Add(this.chkBxUltraVNC, 2, 4);
            this.tblPnlOrganiza.Controls.Add(this.chkBxThndbrd, 2, 3);
            this.tblPnlOrganiza.Controls.Add(this.chkBxCtPDF, 2, 2);
            this.tblPnlOrganiza.Controls.Add(this.chkbxTmVwr, 2, 0);
            this.tblPnlOrganiza.Controls.Add(this.chkBxCClnr, 2, 1);
            this.tblPnlOrganiza.Location = new System.Drawing.Point(0, 26);
            this.tblPnlOrganiza.Name = "tblPnlOrganiza";
            this.tblPnlOrganiza.RowCount = 6;
            this.tblPnlOrganiza.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblPnlOrganiza.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblPnlOrganiza.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblPnlOrganiza.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblPnlOrganiza.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblPnlOrganiza.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblPnlOrganiza.Size = new System.Drawing.Size(297, 261);
            this.tblPnlOrganiza.TabIndex = 23;
            // 
            // chkBxAtlzJv
            // 
            this.chkBxAtlzJv.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkBxAtlzJv.AutoSize = true;
            this.chkBxAtlzJv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBxAtlzJv.Location = new System.Drawing.Point(11, 226);
            this.chkBxAtlzJv.Margin = new System.Windows.Forms.Padding(8);
            this.chkBxAtlzJv.Name = "chkBxAtlzJv";
            this.chkBxAtlzJv.Size = new System.Drawing.Size(127, 24);
            this.chkBxAtlzJv.TabIndex = 13;
            this.chkBxAtlzJv.Text = "Atualizar Java";
            this.chkBxAtlzJv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkBxAtlzJv.UseVisualStyleBackColor = true;
            // 
            // chkBxLbrOffc
            // 
            this.chkBxLbrOffc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkBxLbrOffc.AutoSize = true;
            this.chkBxLbrOffc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBxLbrOffc.Location = new System.Drawing.Point(11, 97);
            this.chkBxLbrOffc.Margin = new System.Windows.Forms.Padding(8);
            this.chkBxLbrOffc.Name = "chkBxLbrOffc";
            this.chkBxLbrOffc.Size = new System.Drawing.Size(109, 24);
            this.chkBxLbrOffc.TabIndex = 14;
            this.chkBxLbrOffc.Text = "Libre Office";
            this.chkBxLbrOffc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkBxLbrOffc.UseVisualStyleBackColor = true;
            // 
            // chkBxAmmyy
            // 
            this.chkBxAmmyy.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkBxAmmyy.AutoSize = true;
            this.chkBxAmmyy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBxAmmyy.Location = new System.Drawing.Point(11, 11);
            this.chkBxAmmyy.Margin = new System.Windows.Forms.Padding(8);
            this.chkBxAmmyy.Name = "chkBxAmmyy";
            this.chkBxAmmyy.Size = new System.Drawing.Size(79, 24);
            this.chkBxAmmyy.TabIndex = 7;
            this.chkBxAmmyy.Text = "Ammyy";
            this.chkBxAmmyy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkBxAmmyy.UseVisualStyleBackColor = true;
            // 
            // chkBxUltraVNC
            // 
            this.chkBxUltraVNC.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkBxUltraVNC.AutoSize = true;
            this.chkBxUltraVNC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBxUltraVNC.Location = new System.Drawing.Point(170, 183);
            this.chkBxUltraVNC.Margin = new System.Windows.Forms.Padding(8);
            this.chkBxUltraVNC.Name = "chkBxUltraVNC";
            this.chkBxUltraVNC.Size = new System.Drawing.Size(95, 24);
            this.chkBxUltraVNC.TabIndex = 2;
            this.chkBxUltraVNC.Text = "UltraVNC";
            this.chkBxUltraVNC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkBxUltraVNC.UseVisualStyleBackColor = true;
            // 
            // chkBxThndbrd
            // 
            this.chkBxThndbrd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkBxThndbrd.AutoSize = true;
            this.chkBxThndbrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBxThndbrd.Location = new System.Drawing.Point(170, 140);
            this.chkBxThndbrd.Margin = new System.Windows.Forms.Padding(8);
            this.chkBxThndbrd.Name = "chkBxThndbrd";
            this.chkBxThndbrd.Size = new System.Drawing.Size(113, 24);
            this.chkBxThndbrd.TabIndex = 8;
            this.chkBxThndbrd.Text = "Thunderbird";
            this.chkBxThndbrd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkBxThndbrd.UseVisualStyleBackColor = true;
            // 
            // chkbxTmVwr
            // 
            this.chkbxTmVwr.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkbxTmVwr.AutoSize = true;
            this.chkbxTmVwr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxTmVwr.Location = new System.Drawing.Point(170, 11);
            this.chkbxTmVwr.Margin = new System.Windows.Forms.Padding(8);
            this.chkbxTmVwr.Name = "chkbxTmVwr";
            this.chkbxTmVwr.Size = new System.Drawing.Size(116, 24);
            this.chkbxTmVwr.TabIndex = 16;
            this.chkbxTmVwr.Text = "TeamViewer";
            this.chkbxTmVwr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkbxTmVwr.UseVisualStyleBackColor = true;
            // 
            // btnCopiarArquivos
            // 
            this.btnCopiarArquivos.AutoSize = true;
            this.btnCopiarArquivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopiarArquivos.Location = new System.Drawing.Point(131, 294);
            this.btnCopiarArquivos.Name = "btnCopiarArquivos";
            this.btnCopiarArquivos.Size = new System.Drawing.Size(166, 30);
            this.btnCopiarArquivos.TabIndex = 4;
            this.btnCopiarArquivos.Text = "Copiar Arquivos";
            this.btnCopiarArquivos.UseVisualStyleBackColor = true;
            // 
            // verificarInstalaçõesToolStripMenuItem
            // 
            this.verificarInstalaçõesToolStripMenuItem.Name = "verificarInstalaçõesToolStripMenuItem";
            this.verificarInstalaçõesToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.verificarInstalaçõesToolStripMenuItem.Text = "Verificar Instalações";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 360);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCopiarArquivos);
            this.Controls.Add(this.BtnMarcaDesmarca);
            this.Controls.Add(this.tblPnlOrganiza);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Instalador";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tblPnlOrganiza.ResumeLayout(false);
            this.tblPnlOrganiza.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnMarcaDesmarca;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeProgramasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoProgramaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem alterarArquivoDeConfiguraçãoToolStripMenuItem1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.CheckBox chkBxRdmn;
        private System.Windows.Forms.CheckBox chkBxWnRr;
        private System.Windows.Forms.CheckBox chkBxGglChrm;
        private System.Windows.Forms.CheckBox chkBxCClnr;
        private System.Windows.Forms.CheckBox chkBxKspsk;
        private System.Windows.Forms.CheckBox chkBxCtPDF;
        private System.Windows.Forms.TableLayoutPanel tblPnlOrganiza;
        private System.Windows.Forms.CheckBox chkBxAtlzJv;
        private System.Windows.Forms.CheckBox chkBxLbrOffc;
        private System.Windows.Forms.CheckBox chkbxTmVwr;
        private System.Windows.Forms.CheckBox chkBxThndbrd;
        private System.Windows.Forms.CheckBox chkBxUltraVNC;
        private System.Windows.Forms.CheckBox chkBxAmmyy;
        private System.Windows.Forms.ToolStripMenuItem verificarWindowsUpdateToolStripMenuItem;
        private System.Windows.Forms.Button btnCopiarArquivos;
        private System.Windows.Forms.ToolStripMenuItem verificarInstalaçõesToolStripMenuItem;
    }
}

