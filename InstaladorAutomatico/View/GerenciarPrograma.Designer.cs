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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gerenciar_Programas));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBxNomePrograma = new System.Windows.Forms.TextBox();
            this.txtBxDiretorioPrograma = new System.Windows.Forms.TextBox();
            this.btnDiretorioPrograma = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.rdoBtn32bits = new System.Windows.Forms.RadioButton();
            this.rdoBtn64bits = new System.Windows.Forms.RadioButton();
            this.txtBxArg = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importarXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerarNovoXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localizarXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarLocalUACToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarLocalPastaTIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCaminhoIcone = new System.Windows.Forms.Button();
            this.txtBxCaminhoIcone = new System.Windows.Forms.TextBox();
            this.gpBxEditar = new System.Windows.Forms.GroupBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnDescerLista = new System.Windows.Forms.Button();
            this.btnSubirLista = new System.Windows.Forms.Button();
            this.btnAdiciona = new System.Windows.Forms.Button();
            this.GradeDeDadosXML = new System.Windows.Forms.DataGridView();
            this.programaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDProgramaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeProgramaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diretorioProgramaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arquiteturaProgramaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.gpBxEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GradeDeDadosXML)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do programa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Arquitetura:";
            // 
            // txtBxNomePrograma
            // 
            this.txtBxNomePrograma.Location = new System.Drawing.Point(170, 25);
            this.txtBxNomePrograma.Name = "txtBxNomePrograma";
            this.txtBxNomePrograma.Size = new System.Drawing.Size(244, 20);
            this.txtBxNomePrograma.TabIndex = 2;
            this.txtBxNomePrograma.TextChanged += new System.EventHandler(this.TxtBxNomePrograma_TextChanged);
            // 
            // txtBxDiretorioPrograma
            // 
            this.txtBxDiretorioPrograma.Location = new System.Drawing.Point(170, 51);
            this.txtBxDiretorioPrograma.Name = "txtBxDiretorioPrograma";
            this.txtBxDiretorioPrograma.Size = new System.Drawing.Size(205, 20);
            this.txtBxDiretorioPrograma.TabIndex = 3;
            this.txtBxDiretorioPrograma.TextChanged += new System.EventHandler(this.TxtBxDiretorioPrograma_TextChanged);
            // 
            // btnDiretorioPrograma
            // 
            this.btnDiretorioPrograma.Location = new System.Drawing.Point(381, 50);
            this.btnDiretorioPrograma.Name = "btnDiretorioPrograma";
            this.btnDiretorioPrograma.Size = new System.Drawing.Size(33, 21);
            this.btnDiretorioPrograma.TabIndex = 4;
            this.btnDiretorioPrograma.Text = "...";
            this.btnDiretorioPrograma.UseVisualStyleBackColor = true;
            this.btnDiretorioPrograma.Click += new System.EventHandler(this.BtnDiretorioPrograma_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFechar.AutoSize = true;
            this.btnFechar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(711, 137);
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
            this.btnLimpar.Location = new System.Drawing.Point(12, 137);
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
            this.label3.Location = new System.Drawing.Point(12, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Diretório:";
            // 
            // rdoBtn32bits
            // 
            this.rdoBtn32bits.AutoSize = true;
            this.rdoBtn32bits.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBtn32bits.Location = new System.Drawing.Point(100, 102);
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
            this.rdoBtn64bits.Location = new System.Drawing.Point(175, 102);
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
            this.txtBxArg.Location = new System.Drawing.Point(170, 77);
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
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(785, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvarComoToolStripMenuItem,
            this.importarXMLToolStripMenuItem,
            this.gerarNovoXMLToolStripMenuItem,
            this.localizarXMLToolStripMenuItem,
            this.alterarLocalUACToolStripMenuItem,
            this.alterarLocalPastaTIToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 22);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // salvarComoToolStripMenuItem
            // 
            this.salvarComoToolStripMenuItem.Name = "salvarComoToolStripMenuItem";
            this.salvarComoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.salvarComoToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.salvarComoToolStripMenuItem.Text = "Salvar Como";
            this.salvarComoToolStripMenuItem.Click += new System.EventHandler(this.salvarComoToolStripMenuItem_Click);
            // 
            // importarXMLToolStripMenuItem
            // 
            this.importarXMLToolStripMenuItem.Name = "importarXMLToolStripMenuItem";
            this.importarXMLToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.importarXMLToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.importarXMLToolStripMenuItem.Text = "Importar XML";
            this.importarXMLToolStripMenuItem.Click += new System.EventHandler(this.importarXMLToolStripMenuItem_Click);
            // 
            // gerarNovoXMLToolStripMenuItem
            // 
            this.gerarNovoXMLToolStripMenuItem.Name = "gerarNovoXMLToolStripMenuItem";
            this.gerarNovoXMLToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.gerarNovoXMLToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.gerarNovoXMLToolStripMenuItem.Text = "Gerar Novo XML";
            this.gerarNovoXMLToolStripMenuItem.Click += new System.EventHandler(this.gerarNovoXMLToolStripMenuItem_Click);
            // 
            // localizarXMLToolStripMenuItem
            // 
            this.localizarXMLToolStripMenuItem.Name = "localizarXMLToolStripMenuItem";
            this.localizarXMLToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.localizarXMLToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.localizarXMLToolStripMenuItem.Text = "Localizar XML";
            this.localizarXMLToolStripMenuItem.Click += new System.EventHandler(this.localizarXMLToolStripMenuItem_Click);
            // 
            // alterarLocalUACToolStripMenuItem
            // 
            this.alterarLocalUACToolStripMenuItem.Name = "alterarLocalUACToolStripMenuItem";
            this.alterarLocalUACToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.alterarLocalUACToolStripMenuItem.Text = "Alterar Local UAC";
            this.alterarLocalUACToolStripMenuItem.Click += new System.EventHandler(this.alterarLocalUACToolStripMenuItem_Click);
            // 
            // alterarLocalPastaTIToolStripMenuItem
            // 
            this.alterarLocalPastaTIToolStripMenuItem.Name = "alterarLocalPastaTIToolStripMenuItem";
            this.alterarLocalPastaTIToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.alterarLocalPastaTIToolStripMenuItem.Text = "Alterar Local Pasta TI";
            this.alterarLocalPastaTIToolStripMenuItem.Click += new System.EventHandler(this.alterarLocalPastaTIToolStripMenuItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(541, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Caminho do Ícone:";
            this.label4.Visible = false;
            // 
            // btnCaminhoIcone
            // 
            this.btnCaminhoIcone.Location = new System.Drawing.Point(682, 53);
            this.btnCaminhoIcone.Name = "btnCaminhoIcone";
            this.btnCaminhoIcone.Size = new System.Drawing.Size(33, 21);
            this.btnCaminhoIcone.TabIndex = 20;
            this.btnCaminhoIcone.Text = "...";
            this.btnCaminhoIcone.UseVisualStyleBackColor = true;
            this.btnCaminhoIcone.Visible = false;
            this.btnCaminhoIcone.Click += new System.EventHandler(this.BtnCaminhoIcone_Click);
            // 
            // txtBxCaminhoIcone
            // 
            this.txtBxCaminhoIcone.Location = new System.Drawing.Point(544, 75);
            this.txtBxCaminhoIcone.Name = "txtBxCaminhoIcone";
            this.txtBxCaminhoIcone.Size = new System.Drawing.Size(205, 20);
            this.txtBxCaminhoIcone.TabIndex = 19;
            this.txtBxCaminhoIcone.Visible = false;
            // 
            // gpBxEditar
            // 
            this.gpBxEditar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gpBxEditar.Controls.Add(this.btnRemover);
            this.gpBxEditar.Controls.Add(this.btnDescerLista);
            this.gpBxEditar.Controls.Add(this.btnSubirLista);
            this.gpBxEditar.Controls.Add(this.btnAdiciona);
            this.gpBxEditar.Controls.Add(this.label1);
            this.gpBxEditar.Controls.Add(this.label4);
            this.gpBxEditar.Controls.Add(this.label2);
            this.gpBxEditar.Controls.Add(this.btnLimpar);
            this.gpBxEditar.Controls.Add(this.btnCaminhoIcone);
            this.gpBxEditar.Controls.Add(this.btnFechar);
            this.gpBxEditar.Controls.Add(this.txtBxNomePrograma);
            this.gpBxEditar.Controls.Add(this.txtBxCaminhoIcone);
            this.gpBxEditar.Controls.Add(this.txtBxDiretorioPrograma);
            this.gpBxEditar.Controls.Add(this.btnDiretorioPrograma);
            this.gpBxEditar.Controls.Add(this.label3);
            this.gpBxEditar.Controls.Add(this.rdoBtn32bits);
            this.gpBxEditar.Controls.Add(this.txtBxArg);
            this.gpBxEditar.Controls.Add(this.rdoBtn64bits);
            this.gpBxEditar.Controls.Add(this.label6);
            this.gpBxEditar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpBxEditar.Location = new System.Drawing.Point(0, 272);
            this.gpBxEditar.Name = "gpBxEditar";
            this.gpBxEditar.Size = new System.Drawing.Size(785, 175);
            this.gpBxEditar.TabIndex = 21;
            this.gpBxEditar.TabStop = false;
            this.gpBxEditar.Text = "Editar";
            // 
            // btnRemover
            // 
            this.btnRemover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemover.AutoSize = true;
            this.btnRemover.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.Location = new System.Drawing.Point(162, 137);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 27);
            this.btnRemover.TabIndex = 24;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnDescerLista
            // 
            this.btnDescerLista.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDescerLista.AutoSize = true;
            this.btnDescerLista.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDescerLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescerLista.Location = new System.Drawing.Point(243, 137);
            this.btnDescerLista.Name = "btnDescerLista";
            this.btnDescerLista.Size = new System.Drawing.Size(25, 27);
            this.btnDescerLista.TabIndex = 23;
            this.btnDescerLista.Text = "↓";
            this.btnDescerLista.UseVisualStyleBackColor = true;
            this.btnDescerLista.Click += new System.EventHandler(this.BtnDescerLista_Click);
            // 
            // btnSubirLista
            // 
            this.btnSubirLista.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSubirLista.AutoSize = true;
            this.btnSubirLista.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSubirLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubirLista.Location = new System.Drawing.Point(274, 137);
            this.btnSubirLista.Name = "btnSubirLista";
            this.btnSubirLista.Size = new System.Drawing.Size(25, 27);
            this.btnSubirLista.TabIndex = 22;
            this.btnSubirLista.Text = "↑";
            this.btnSubirLista.UseVisualStyleBackColor = true;
            this.btnSubirLista.Click += new System.EventHandler(this.BtnSubirLista_Click);
            // 
            // btnAdiciona
            // 
            this.btnAdiciona.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdiciona.AutoSize = true;
            this.btnAdiciona.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdiciona.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdiciona.Location = new System.Drawing.Point(79, 137);
            this.btnAdiciona.Name = "btnAdiciona";
            this.btnAdiciona.Size = new System.Drawing.Size(77, 27);
            this.btnAdiciona.TabIndex = 21;
            this.btnAdiciona.Text = "Adicionar";
            this.btnAdiciona.UseVisualStyleBackColor = true;
            this.btnAdiciona.Click += new System.EventHandler(this.BtnAdiciona);
            // 
            // GradeDeDadosXML
            // 
            this.GradeDeDadosXML.AutoGenerateColumns = false;
            this.GradeDeDadosXML.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GradeDeDadosXML.CausesValidation = false;
            this.GradeDeDadosXML.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GradeDeDadosXML.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDProgramaDataGridViewTextBoxColumn,
            this.nomeProgramaDataGridViewTextBoxColumn,
            this.diretorioProgramaDataGridViewTextBoxColumn,
            this.arquiteturaProgramaDataGridViewTextBoxColumn});
            this.GradeDeDadosXML.DataSource = this.programaBindingSource;
            this.GradeDeDadosXML.Dock = System.Windows.Forms.DockStyle.Top;
            this.GradeDeDadosXML.Location = new System.Drawing.Point(0, 24);
            this.GradeDeDadosXML.Name = "GradeDeDadosXML";
            this.GradeDeDadosXML.RowHeadersWidth = 62;
            this.GradeDeDadosXML.Size = new System.Drawing.Size(785, 248);
            this.GradeDeDadosXML.TabIndex = 15;
            this.GradeDeDadosXML.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GradeDeDadosXML_CellClick_1);
            // 
            // programaBindingSource
            // 
            this.programaBindingSource.DataSource = typeof(InstaladorAutomatico.Model.Programa);
            // 
            // iDProgramaDataGridViewTextBoxColumn
            // 
            this.iDProgramaDataGridViewTextBoxColumn.DataPropertyName = "IDPrograma";
            this.iDProgramaDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDProgramaDataGridViewTextBoxColumn.Name = "iDProgramaDataGridViewTextBoxColumn";
            // 
            // nomeProgramaDataGridViewTextBoxColumn
            // 
            this.nomeProgramaDataGridViewTextBoxColumn.DataPropertyName = "nomePrograma";
            this.nomeProgramaDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeProgramaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nomeProgramaDataGridViewTextBoxColumn.Name = "nomeProgramaDataGridViewTextBoxColumn";
            this.nomeProgramaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // diretorioProgramaDataGridViewTextBoxColumn
            // 
            this.diretorioProgramaDataGridViewTextBoxColumn.DataPropertyName = "diretorioPrograma";
            this.diretorioProgramaDataGridViewTextBoxColumn.HeaderText = "Diretório";
            this.diretorioProgramaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.diretorioProgramaDataGridViewTextBoxColumn.Name = "diretorioProgramaDataGridViewTextBoxColumn";
            this.diretorioProgramaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // arquiteturaProgramaDataGridViewTextBoxColumn
            // 
            this.arquiteturaProgramaDataGridViewTextBoxColumn.DataPropertyName = "arquiteturaPrograma";
            this.arquiteturaProgramaDataGridViewTextBoxColumn.HeaderText = "Arquitetura";
            this.arquiteturaProgramaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.arquiteturaProgramaDataGridViewTextBoxColumn.Name = "arquiteturaProgramaDataGridViewTextBoxColumn";
            this.arquiteturaProgramaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Gerenciar_Programas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 447);
            this.Controls.Add(this.gpBxEditar);
            this.Controls.Add(this.GradeDeDadosXML);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Gerenciar_Programas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gerenciar Programa";
            this.Load += new System.EventHandler(this.Gerenciar_Programas_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gpBxEditar.ResumeLayout(false);
            this.gpBxEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GradeDeDadosXML)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBxNomePrograma;
        private System.Windows.Forms.TextBox txtBxDiretorioPrograma;
        private System.Windows.Forms.Button btnDiretorioPrograma;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdoBtn32bits;
        private System.Windows.Forms.RadioButton rdoBtn64bits;
        private System.Windows.Forms.TextBox txtBxArg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarComoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importarXMLToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCaminhoIcone;
        private System.Windows.Forms.TextBox txtBxCaminhoIcone;
        private System.Windows.Forms.GroupBox gpBxEditar;
        private System.Windows.Forms.DataGridView GradeDeDadosXML;
        private System.Windows.Forms.BindingSource programaBindingSource;
        private System.Windows.Forms.ToolStripMenuItem gerarNovoXMLToolStripMenuItem;
        private System.Windows.Forms.Button btnAdiciona;
        private System.Windows.Forms.Button btnSubirLista;
        private System.Windows.Forms.Button btnDescerLista;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.ToolStripMenuItem localizarXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarLocalUACToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarLocalPastaTIToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDProgramaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProgramaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diretorioProgramaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arquiteturaProgramaDataGridViewTextBoxColumn;
    }
}