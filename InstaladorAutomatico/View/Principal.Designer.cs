﻿namespace InstaladorAutomatico
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
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCopiarArquivos = new System.Windows.Forms.Button();
            this.gpBx = new System.Windows.Forms.GroupBox();
            this.Selecionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Ícone = new System.Windows.Forms.DataGridViewImageColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GradeDeDados = new System.Windows.Forms.DataGridView();
            this.nomeProgramaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caminhoProgramaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arquiteturaProgramaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.programaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.programaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            this.gpBx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GradeDeDados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnMarcaDesmarca
            // 
            this.BtnMarcaDesmarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMarcaDesmarca.Location = new System.Drawing.Point(434, 30);
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
            this.btnIniciar.Location = new System.Drawing.Point(303, 30);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(125, 30);
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
            this.menuStrip1.Size = new System.Drawing.Size(863, 24);
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
            this.listaDeProgramasToolStripMenuItem.Name = "listaDeProgramasToolStripMenuItem";
            this.listaDeProgramasToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.listaDeProgramasToolStripMenuItem.Text = "Gerenciar Programas";
            this.listaDeProgramasToolStripMenuItem.Click += new System.EventHandler(this.ListaDeProgramasToolStripMenuItem_Click);
            // 
            // verificarWindowsUpdateToolStripMenuItem
            // 
            this.verificarWindowsUpdateToolStripMenuItem.Name = "verificarWindowsUpdateToolStripMenuItem";
            this.verificarWindowsUpdateToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.verificarWindowsUpdateToolStripMenuItem.Text = "Verificar Windows Update";
            // 
            // verificarInstalaçõesToolStripMenuItem
            // 
            this.verificarInstalaçõesToolStripMenuItem.Name = "verificarInstalaçõesToolStripMenuItem";
            this.verificarInstalaçõesToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.verificarInstalaçõesToolStripMenuItem.Text = "Verificar Instalações";
            // 
            // btnSair
            // 
            this.btnSair.AutoSize = true;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(434, 66);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(125, 30);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnCopiarArquivos
            // 
            this.btnCopiarArquivos.AutoSize = true;
            this.btnCopiarArquivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopiarArquivos.Location = new System.Drawing.Point(303, 66);
            this.btnCopiarArquivos.Name = "btnCopiarArquivos";
            this.btnCopiarArquivos.Size = new System.Drawing.Size(125, 30);
            this.btnCopiarArquivos.TabIndex = 4;
            this.btnCopiarArquivos.Text = "Copiar Arquivos";
            this.btnCopiarArquivos.UseVisualStyleBackColor = true;
            // 
            // gpBx
            // 
            this.gpBx.AutoSize = true;
            this.gpBx.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gpBx.Controls.Add(this.btnIniciar);
            this.gpBx.Controls.Add(this.BtnMarcaDesmarca);
            this.gpBx.Controls.Add(this.btnCopiarArquivos);
            this.gpBx.Controls.Add(this.btnSair);
            this.gpBx.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gpBx.Location = new System.Drawing.Point(0, 251);
            this.gpBx.Name = "gpBx";
            this.gpBx.Size = new System.Drawing.Size(863, 115);
            this.gpBx.TabIndex = 25;
            this.gpBx.TabStop = false;
            this.gpBx.Text = "Ações";
            // 
            // Selecionar
            // 
            this.Selecionar.HeaderText = "Selecionar";
            this.Selecionar.Name = "Selecionar";
            this.Selecionar.ReadOnly = true;
            // 
            // Ícone
            // 
            this.Ícone.HeaderText = "Ícone";
            this.Ícone.Name = "Ícone";
            this.Ícone.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // GradeDeDados
            // 
            this.GradeDeDados.AutoGenerateColumns = false;
            this.GradeDeDados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GradeDeDados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.GradeDeDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GradeDeDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Ícone,
            this.nomeProgramaDataGridViewTextBoxColumn,
            this.caminhoProgramaDataGridViewTextBoxColumn,
            this.arquiteturaProgramaDataGridViewTextBoxColumn,
            this.Selecionar});
            this.GradeDeDados.DataSource = this.programaBindingSource;
            this.GradeDeDados.Dock = System.Windows.Forms.DockStyle.Top;
            this.GradeDeDados.Location = new System.Drawing.Point(0, 24);
            this.GradeDeDados.Name = "GradeDeDados";
            this.GradeDeDados.Size = new System.Drawing.Size(863, 221);
            this.GradeDeDados.TabIndex = 24;
            // 
            // nomeProgramaDataGridViewTextBoxColumn
            // 
            this.nomeProgramaDataGridViewTextBoxColumn.DataPropertyName = "nomePrograma";
            this.nomeProgramaDataGridViewTextBoxColumn.HeaderText = "nomePrograma";
            this.nomeProgramaDataGridViewTextBoxColumn.Name = "nomeProgramaDataGridViewTextBoxColumn";
            this.nomeProgramaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // caminhoProgramaDataGridViewTextBoxColumn
            // 
            this.caminhoProgramaDataGridViewTextBoxColumn.DataPropertyName = "caminhoPrograma";
            this.caminhoProgramaDataGridViewTextBoxColumn.HeaderText = "caminhoPrograma";
            this.caminhoProgramaDataGridViewTextBoxColumn.Name = "caminhoProgramaDataGridViewTextBoxColumn";
            this.caminhoProgramaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // arquiteturaProgramaDataGridViewTextBoxColumn
            // 
            this.arquiteturaProgramaDataGridViewTextBoxColumn.DataPropertyName = "arquiteturaPrograma";
            this.arquiteturaProgramaDataGridViewTextBoxColumn.HeaderText = "arquiteturaPrograma";
            this.arquiteturaProgramaDataGridViewTextBoxColumn.Name = "arquiteturaProgramaDataGridViewTextBoxColumn";
            this.arquiteturaProgramaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // programaBindingSource2
            // 
            this.programaBindingSource2.DataSource = typeof(InstaladorAutomatico.Model.Programa);
            // 
            // programaBindingSource1
            // 
            this.programaBindingSource1.DataSource = typeof(InstaladorAutomatico.Model.Programa);
            // 
            // programaBindingSource
            // 
            this.programaBindingSource.DataSource = typeof(InstaladorAutomatico.Model.Programa);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 366);
            this.Controls.Add(this.gpBx);
            this.Controls.Add(this.GradeDeDados);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Instalador";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.MouseEnter += new System.EventHandler(this.Principal_MouseEnter);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gpBx.ResumeLayout(false);
            this.gpBx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GradeDeDados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programaBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnMarcaDesmarca;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeProgramasToolStripMenuItem;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.ToolStripMenuItem verificarWindowsUpdateToolStripMenuItem;
        private System.Windows.Forms.Button btnCopiarArquivos;
        private System.Windows.Forms.ToolStripMenuItem verificarInstalaçõesToolStripMenuItem;
        private System.Windows.Forms.BindingSource programaBindingSource;
        private System.Windows.Forms.BindingSource programaBindingSource1;
        private System.Windows.Forms.BindingSource programaBindingSource2;
        private System.Windows.Forms.GroupBox gpBx;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selecionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn arquiteturaProgramaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn caminhoProgramaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProgramaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn Ícone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridView GradeDeDados;
    }
}

