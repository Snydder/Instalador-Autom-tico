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
            this.components = new System.ComponentModel.Container();
            this.BtnMarcaDesmarca = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeProgramasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verificarWindowsUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verificarInstalaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCopiarArquivos = new System.Windows.Forms.Button();
            this.gpBx = new System.Windows.Forms.GroupBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnAtualizarDataGrid = new System.Windows.Forms.Button();
            this.GradeDeDados = new System.Windows.Forms.DataGridView();
            this.programaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.programaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.iDProgramaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeProgramaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caminhoIconeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diretorioProgramaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arquiteturaProgramaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Selecionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.gpBx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GradeDeDados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programaBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnMarcaDesmarca
            // 
            this.BtnMarcaDesmarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMarcaDesmarca.Location = new System.Drawing.Point(651, 46);
            this.BtnMarcaDesmarca.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnMarcaDesmarca.Name = "BtnMarcaDesmarca";
            this.BtnMarcaDesmarca.Size = new System.Drawing.Size(188, 46);
            this.BtnMarcaDesmarca.TabIndex = 6;
            this.BtnMarcaDesmarca.Text = "Marcar Tudo";
            this.BtnMarcaDesmarca.UseVisualStyleBackColor = true;
            this.BtnMarcaDesmarca.Click += new System.EventHandler(this.BtnMarcaDesmarca_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.AutoSize = true;
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.Location = new System.Drawing.Point(651, 102);
            this.btnIniciar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(188, 54);
            this.btnIniciar.TabIndex = 8;
            this.btnIniciar.Text = "Instalar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnInstlr_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1294, 35);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaDeProgramasToolStripMenuItem,
            this.verificarWindowsUpdateToolStripMenuItem,
            this.verificarInstalaçõesToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(91, 29);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // listaDeProgramasToolStripMenuItem
            // 
            this.listaDeProgramasToolStripMenuItem.Name = "listaDeProgramasToolStripMenuItem";
            this.listaDeProgramasToolStripMenuItem.Size = new System.Drawing.Size(318, 34);
            this.listaDeProgramasToolStripMenuItem.Text = "Gerenciar Programas";
            this.listaDeProgramasToolStripMenuItem.Click += new System.EventHandler(this.ListaDeProgramasToolStripMenuItem_Click);
            // 
            // verificarWindowsUpdateToolStripMenuItem
            // 
            this.verificarWindowsUpdateToolStripMenuItem.Name = "verificarWindowsUpdateToolStripMenuItem";
            this.verificarWindowsUpdateToolStripMenuItem.Size = new System.Drawing.Size(318, 34);
            this.verificarWindowsUpdateToolStripMenuItem.Text = "Verificar Windows Update";
            // 
            // verificarInstalaçõesToolStripMenuItem
            // 
            this.verificarInstalaçõesToolStripMenuItem.Name = "verificarInstalaçõesToolStripMenuItem";
            this.verificarInstalaçõesToolStripMenuItem.Size = new System.Drawing.Size(318, 34);
            this.verificarInstalaçõesToolStripMenuItem.Text = "Verificar Instalações";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(318, 34);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.SairToolStripMenuItem_Click);
            // 
            // btnCopiarArquivos
            // 
            this.btnCopiarArquivos.AutoSize = true;
            this.btnCopiarArquivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopiarArquivos.Location = new System.Drawing.Point(454, 102);
            this.btnCopiarArquivos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCopiarArquivos.Name = "btnCopiarArquivos";
            this.btnCopiarArquivos.Size = new System.Drawing.Size(243, 54);
            this.btnCopiarArquivos.TabIndex = 4;
            this.btnCopiarArquivos.Text = "Copiar Arquivos";
            this.btnCopiarArquivos.UseVisualStyleBackColor = true;
            // 
            // gpBx
            // 
            this.gpBx.Controls.Add(this.btnSair);
            this.gpBx.Controls.Add(this.btnIniciar);
            this.gpBx.Controls.Add(this.BtnMarcaDesmarca);
            this.gpBx.Controls.Add(this.btnCopiarArquivos);
            this.gpBx.Controls.Add(this.btnAtualizarDataGrid);
            this.gpBx.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gpBx.Location = new System.Drawing.Point(0, 366);
            this.gpBx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpBx.Name = "gpBx";
            this.gpBx.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpBx.Size = new System.Drawing.Size(1294, 197);
            this.gpBx.TabIndex = 25;
            this.gpBx.TabStop = false;
            this.gpBx.Text = "Ações";
            // 
            // btnSair
            // 
            this.btnSair.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(1150, 142);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(126, 46);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.BtnSair_Click_1);
            // 
            // btnAtualizarDataGrid
            // 
            this.btnAtualizarDataGrid.AutoSize = true;
            this.btnAtualizarDataGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizarDataGrid.Location = new System.Drawing.Point(454, 46);
            this.btnAtualizarDataGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAtualizarDataGrid.Name = "btnAtualizarDataGrid";
            this.btnAtualizarDataGrid.Size = new System.Drawing.Size(188, 54);
            this.btnAtualizarDataGrid.TabIndex = 7;
            this.btnAtualizarDataGrid.Text = "Regarregar";
            this.btnAtualizarDataGrid.UseVisualStyleBackColor = true;
            this.btnAtualizarDataGrid.Click += new System.EventHandler(this.BtnAtualizarDataGrid_Click);
            // 
            // GradeDeDados
            // 
            this.GradeDeDados.AutoGenerateColumns = false;
            this.GradeDeDados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GradeDeDados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.GradeDeDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GradeDeDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDProgramaDataGridViewTextBoxColumn,
            this.nomeProgramaDataGridViewTextBoxColumn,
            this.caminhoIconeDataGridViewTextBoxColumn,
            this.diretorioProgramaDataGridViewTextBoxColumn,
            this.arquiteturaProgramaDataGridViewTextBoxColumn,
            this.Selecionar});
            this.GradeDeDados.DataSource = this.programaBindingSource1;
            this.GradeDeDados.Dock = System.Windows.Forms.DockStyle.Top;
            this.GradeDeDados.Location = new System.Drawing.Point(0, 35);
            this.GradeDeDados.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GradeDeDados.Name = "GradeDeDados";
            this.GradeDeDados.RowHeadersWidth = 62;
            this.GradeDeDados.Size = new System.Drawing.Size(1294, 340);
            this.GradeDeDados.TabIndex = 24;
            // 
            // programaBindingSource1
            // 
            this.programaBindingSource1.DataSource = typeof(InstaladorAutomatico.Model.Programa);
            // 
            // programaBindingSource2
            // 
            this.programaBindingSource2.DataSource = typeof(InstaladorAutomatico.Model.Programa);
            // 
            // iDProgramaDataGridViewTextBoxColumn
            // 
            this.iDProgramaDataGridViewTextBoxColumn.DataPropertyName = "IDPrograma";
            this.iDProgramaDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDProgramaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDProgramaDataGridViewTextBoxColumn.Name = "iDProgramaDataGridViewTextBoxColumn";
            // 
            // nomeProgramaDataGridViewTextBoxColumn
            // 
            this.nomeProgramaDataGridViewTextBoxColumn.DataPropertyName = "nomePrograma";
            this.nomeProgramaDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeProgramaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nomeProgramaDataGridViewTextBoxColumn.Name = "nomeProgramaDataGridViewTextBoxColumn";
            // 
            // caminhoIconeDataGridViewTextBoxColumn
            // 
            this.caminhoIconeDataGridViewTextBoxColumn.DataPropertyName = "caminhoIcone";
            this.caminhoIconeDataGridViewTextBoxColumn.HeaderText = "Ícone";
            this.caminhoIconeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.caminhoIconeDataGridViewTextBoxColumn.Name = "caminhoIconeDataGridViewTextBoxColumn";
            // 
            // diretorioProgramaDataGridViewTextBoxColumn
            // 
            this.diretorioProgramaDataGridViewTextBoxColumn.DataPropertyName = "diretorioPrograma";
            this.diretorioProgramaDataGridViewTextBoxColumn.HeaderText = "Diretório";
            this.diretorioProgramaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.diretorioProgramaDataGridViewTextBoxColumn.Name = "diretorioProgramaDataGridViewTextBoxColumn";
            // 
            // arquiteturaProgramaDataGridViewTextBoxColumn
            // 
            this.arquiteturaProgramaDataGridViewTextBoxColumn.DataPropertyName = "arquiteturaPrograma";
            this.arquiteturaProgramaDataGridViewTextBoxColumn.HeaderText = "Arquitetura";
            this.arquiteturaProgramaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.arquiteturaProgramaDataGridViewTextBoxColumn.Name = "arquiteturaProgramaDataGridViewTextBoxColumn";
            // 
            // Selecionar
            // 
            this.Selecionar.HeaderText = "Selecionar";
            this.Selecionar.MinimumWidth = 8;
            this.Selecionar.Name = "Selecionar";
            this.Selecionar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 563);
            this.Controls.Add(this.gpBx);
            this.Controls.Add(this.GradeDeDados);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Instalador";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gpBx.ResumeLayout(false);
            this.gpBx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GradeDeDados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programaBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnMarcaDesmarca;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeProgramasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verificarWindowsUpdateToolStripMenuItem;
        private System.Windows.Forms.Button btnCopiarArquivos;
        private System.Windows.Forms.ToolStripMenuItem verificarInstalaçõesToolStripMenuItem;
        private System.Windows.Forms.BindingSource programaBindingSource1;
        private System.Windows.Forms.BindingSource programaBindingSource2;
        private System.Windows.Forms.GroupBox gpBx;
        private System.Windows.Forms.DataGridView GradeDeDados;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Button btnAtualizarDataGrid;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDProgramaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProgramaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn caminhoIconeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diretorioProgramaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arquiteturaProgramaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selecionar;
    }
}

