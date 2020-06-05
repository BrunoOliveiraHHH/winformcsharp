namespace OiniciodofimV2
{
    partial class Armaduras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Armaduras));
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.cbxDurabilidade = new System.Windows.Forms.ComboBox();
            this.lblDurabilidade = new System.Windows.Forms.Label();
            this.txtFurtv = new System.Windows.Forms.TextBox();
            this.txtIdArmadura = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblIdArma = new System.Windows.Forms.Label();
            this.txtForca = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.txtCa = new System.Windows.Forms.TextBox();
            this.BoxMenuArma = new System.Windows.Forms.GroupBox();
            this.cbxTipoArmadura = new System.Windows.Forms.ComboBox();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.lblForça = new System.Windows.Forms.Label();
            this.lblFurtv = new System.Windows.Forms.Label();
            this.lblCa = new System.Windows.Forms.Label();
            this.txtCusto = new System.Windows.Forms.TextBox();
            this.lblCusto = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomearmaduraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoarmaduraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custoarmaduraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caarmaduraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.furtvarmaduraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forcaarmaduraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesoarmaduraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacaoarmaduraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusdurabilidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consultaarmaduradurabilidadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.o_inicio_do_fim_v2DataSet = new OiniciodofimV2.o_inicio_do_fim_v2DataSet();
            this.consulta_armadura_durabilidadeTableAdapter = new OiniciodofimV2.o_inicio_do_fim_v2DataSetTableAdapters.consulta_armadura_durabilidadeTableAdapter();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.BoxMenuArma.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaarmaduradurabilidadeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.o_inicio_do_fim_v2DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(506, 123);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(215, 41);
            this.txtObservacao.TabIndex = 15;
            this.txtObservacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbxDurabilidade
            // 
            this.cbxDurabilidade.FormattingEnabled = true;
            this.cbxDurabilidade.Location = new System.Drawing.Point(506, 51);
            this.cbxDurabilidade.Name = "cbxDurabilidade";
            this.cbxDurabilidade.Size = new System.Drawing.Size(215, 21);
            this.cbxDurabilidade.TabIndex = 13;
            // 
            // lblDurabilidade
            // 
            this.lblDurabilidade.AutoSize = true;
            this.lblDurabilidade.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDurabilidade.Location = new System.Drawing.Point(502, 26);
            this.lblDurabilidade.Name = "lblDurabilidade";
            this.lblDurabilidade.Size = new System.Drawing.Size(132, 22);
            this.lblDurabilidade.TabIndex = 12;
            this.lblDurabilidade.Text = "Durabilidade:";
            // 
            // txtFurtv
            // 
            this.txtFurtv.Location = new System.Drawing.Point(373, 64);
            this.txtFurtv.Name = "txtFurtv";
            this.txtFurtv.Size = new System.Drawing.Size(100, 20);
            this.txtFurtv.TabIndex = 10;
            // 
            // txtIdArmadura
            // 
            this.txtIdArmadura.Location = new System.Drawing.Point(103, 27);
            this.txtIdArmadura.Name = "txtIdArmadura";
            this.txtIdArmadura.Size = new System.Drawing.Size(100, 20);
            this.txtIdArmadura.TabIndex = 17;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnVoltar.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(52, 37);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(135, 45);
            this.btnVoltar.TabIndex = 12;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblIdArma
            // 
            this.lblIdArma.AutoSize = true;
            this.lblIdArma.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdArma.Location = new System.Drawing.Point(55, 28);
            this.lblIdArma.Name = "lblIdArma";
            this.lblIdArma.Size = new System.Drawing.Size(40, 22);
            this.lblIdArma.TabIndex = 16;
            this.lblIdArma.Text = "ID:";
            // 
            // txtForca
            // 
            this.txtForca.Location = new System.Drawing.Point(373, 109);
            this.txtForca.Name = "txtForca";
            this.txtForca.Size = new System.Drawing.Size(100, 20);
            this.txtForca.TabIndex = 11;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnExcluir.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(873, 271);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(113, 23);
            this.btnExcluir.TabIndex = 11;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // txtCa
            // 
            this.txtCa.Location = new System.Drawing.Point(373, 31);
            this.txtCa.Name = "txtCa";
            this.txtCa.Size = new System.Drawing.Size(100, 20);
            this.txtCa.TabIndex = 9;
            // 
            // BoxMenuArma
            // 
            this.BoxMenuArma.Controls.Add(this.txtPeso);
            this.BoxMenuArma.Controls.Add(this.lblPeso);
            this.BoxMenuArma.Controls.Add(this.cbxTipoArmadura);
            this.BoxMenuArma.Controls.Add(this.txtIdArmadura);
            this.BoxMenuArma.Controls.Add(this.lblIdArma);
            this.BoxMenuArma.Controls.Add(this.txtObservacao);
            this.BoxMenuArma.Controls.Add(this.lblObservacao);
            this.BoxMenuArma.Controls.Add(this.cbxDurabilidade);
            this.BoxMenuArma.Controls.Add(this.lblDurabilidade);
            this.BoxMenuArma.Controls.Add(this.txtForca);
            this.BoxMenuArma.Controls.Add(this.txtFurtv);
            this.BoxMenuArma.Controls.Add(this.txtCa);
            this.BoxMenuArma.Controls.Add(this.lblForça);
            this.BoxMenuArma.Controls.Add(this.lblFurtv);
            this.BoxMenuArma.Controls.Add(this.lblCa);
            this.BoxMenuArma.Controls.Add(this.txtCusto);
            this.BoxMenuArma.Controls.Add(this.lblCusto);
            this.BoxMenuArma.Controls.Add(this.lblTipo);
            this.BoxMenuArma.Controls.Add(this.txtNome);
            this.BoxMenuArma.Controls.Add(this.lblNome);
            this.BoxMenuArma.Location = new System.Drawing.Point(367, 37);
            this.BoxMenuArma.Name = "BoxMenuArma";
            this.BoxMenuArma.Size = new System.Drawing.Size(745, 200);
            this.BoxMenuArma.TabIndex = 7;
            this.BoxMenuArma.TabStop = false;
            // 
            // cbxTipoArmadura
            // 
            this.cbxTipoArmadura.FormattingEnabled = true;
            this.cbxTipoArmadura.Location = new System.Drawing.Point(104, 102);
            this.cbxTipoArmadura.Name = "cbxTipoArmadura";
            this.cbxTipoArmadura.Size = new System.Drawing.Size(101, 21);
            this.cbxTipoArmadura.TabIndex = 18;
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacao.Location = new System.Drawing.Point(502, 86);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(133, 22);
            this.lblObservacao.TabIndex = 14;
            this.lblObservacao.Text = "Observações:";
            // 
            // lblForça
            // 
            this.lblForça.AutoSize = true;
            this.lblForça.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForça.Location = new System.Drawing.Point(293, 101);
            this.lblForça.Name = "lblForça";
            this.lblForça.Size = new System.Drawing.Size(67, 22);
            this.lblForça.TabIndex = 8;
            this.lblForça.Text = "Força:";
            // 
            // lblFurtv
            // 
            this.lblFurtv.AutoSize = true;
            this.lblFurtv.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFurtv.Location = new System.Drawing.Point(241, 64);
            this.lblFurtv.Name = "lblFurtv";
            this.lblFurtv.Size = new System.Drawing.Size(119, 22);
            this.lblFurtv.TabIndex = 7;
            this.lblFurtv.Text = "Furtividade:";
            // 
            // lblCa
            // 
            this.lblCa.AutoSize = true;
            this.lblCa.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCa.Location = new System.Drawing.Point(317, 28);
            this.lblCa.Name = "lblCa";
            this.lblCa.Size = new System.Drawing.Size(43, 22);
            this.lblCa.TabIndex = 6;
            this.lblCa.Text = "CA:";
            // 
            // txtCusto
            // 
            this.txtCusto.Location = new System.Drawing.Point(104, 144);
            this.txtCusto.Name = "txtCusto";
            this.txtCusto.Size = new System.Drawing.Size(100, 20);
            this.txtCusto.TabIndex = 5;
            // 
            // lblCusto
            // 
            this.lblCusto.AutoSize = true;
            this.lblCusto.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusto.Location = new System.Drawing.Point(26, 140);
            this.lblCusto.Name = "lblCusto";
            this.lblCusto.Size = new System.Drawing.Size(69, 22);
            this.lblCusto.TabIndex = 4;
            this.lblCusto.Text = "Custo:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(39, 101);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(56, 22);
            this.lblTipo.TabIndex = 2;
            this.lblTipo.Text = "Tipo:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(104, 66);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(24, 64);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(71, 22);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnInserir.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.Location = new System.Drawing.Point(426, 271);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(113, 23);
            this.btnInserir.TabIndex = 8;
            this.btnInserir.Text = "Adicionar";
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnPesquisar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(650, 271);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(113, 23);
            this.btnPesquisar.TabIndex = 9;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nomearmaduraDataGridViewTextBoxColumn,
            this.tipoarmaduraDataGridViewTextBoxColumn,
            this.custoarmaduraDataGridViewTextBoxColumn,
            this.caarmaduraDataGridViewTextBoxColumn,
            this.furtvarmaduraDataGridViewTextBoxColumn,
            this.forcaarmaduraDataGridViewTextBoxColumn,
            this.pesoarmaduraDataGridViewTextBoxColumn,
            this.observacaoarmaduraDataGridViewTextBoxColumn,
            this.statusdurabilidadeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.consultaarmaduradurabilidadeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(231, 331);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Gray;
            this.dataGridView1.Size = new System.Drawing.Size(1049, 357);
            this.dataGridView1.TabIndex = 10;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomearmaduraDataGridViewTextBoxColumn
            // 
            this.nomearmaduraDataGridViewTextBoxColumn.DataPropertyName = "nome_armadura";
            this.nomearmaduraDataGridViewTextBoxColumn.HeaderText = "nome_armadura";
            this.nomearmaduraDataGridViewTextBoxColumn.Name = "nomearmaduraDataGridViewTextBoxColumn";
            this.nomearmaduraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoarmaduraDataGridViewTextBoxColumn
            // 
            this.tipoarmaduraDataGridViewTextBoxColumn.DataPropertyName = "tipo_armadura";
            this.tipoarmaduraDataGridViewTextBoxColumn.HeaderText = "tipo_armadura";
            this.tipoarmaduraDataGridViewTextBoxColumn.Name = "tipoarmaduraDataGridViewTextBoxColumn";
            this.tipoarmaduraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // custoarmaduraDataGridViewTextBoxColumn
            // 
            this.custoarmaduraDataGridViewTextBoxColumn.DataPropertyName = "custo_armadura";
            this.custoarmaduraDataGridViewTextBoxColumn.HeaderText = "custo_armadura";
            this.custoarmaduraDataGridViewTextBoxColumn.Name = "custoarmaduraDataGridViewTextBoxColumn";
            this.custoarmaduraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // caarmaduraDataGridViewTextBoxColumn
            // 
            this.caarmaduraDataGridViewTextBoxColumn.DataPropertyName = "ca_armadura";
            this.caarmaduraDataGridViewTextBoxColumn.HeaderText = "ca_armadura";
            this.caarmaduraDataGridViewTextBoxColumn.Name = "caarmaduraDataGridViewTextBoxColumn";
            this.caarmaduraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // furtvarmaduraDataGridViewTextBoxColumn
            // 
            this.furtvarmaduraDataGridViewTextBoxColumn.DataPropertyName = "furtv_armadura";
            this.furtvarmaduraDataGridViewTextBoxColumn.HeaderText = "furtv_armadura";
            this.furtvarmaduraDataGridViewTextBoxColumn.Name = "furtvarmaduraDataGridViewTextBoxColumn";
            this.furtvarmaduraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // forcaarmaduraDataGridViewTextBoxColumn
            // 
            this.forcaarmaduraDataGridViewTextBoxColumn.DataPropertyName = "forca_armadura";
            this.forcaarmaduraDataGridViewTextBoxColumn.HeaderText = "forca_armadura";
            this.forcaarmaduraDataGridViewTextBoxColumn.Name = "forcaarmaduraDataGridViewTextBoxColumn";
            this.forcaarmaduraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pesoarmaduraDataGridViewTextBoxColumn
            // 
            this.pesoarmaduraDataGridViewTextBoxColumn.DataPropertyName = "peso_armadura";
            this.pesoarmaduraDataGridViewTextBoxColumn.HeaderText = "peso_armadura";
            this.pesoarmaduraDataGridViewTextBoxColumn.Name = "pesoarmaduraDataGridViewTextBoxColumn";
            this.pesoarmaduraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // observacaoarmaduraDataGridViewTextBoxColumn
            // 
            this.observacaoarmaduraDataGridViewTextBoxColumn.DataPropertyName = "observacao_armadura";
            this.observacaoarmaduraDataGridViewTextBoxColumn.HeaderText = "observacao_armadura";
            this.observacaoarmaduraDataGridViewTextBoxColumn.Name = "observacaoarmaduraDataGridViewTextBoxColumn";
            this.observacaoarmaduraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusdurabilidadeDataGridViewTextBoxColumn
            // 
            this.statusdurabilidadeDataGridViewTextBoxColumn.DataPropertyName = "status_durabilidade";
            this.statusdurabilidadeDataGridViewTextBoxColumn.HeaderText = "status_durabilidade";
            this.statusdurabilidadeDataGridViewTextBoxColumn.Name = "statusdurabilidadeDataGridViewTextBoxColumn";
            this.statusdurabilidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // consultaarmaduradurabilidadeBindingSource
            // 
            this.consultaarmaduradurabilidadeBindingSource.DataMember = "consulta_armadura_durabilidade";
            this.consultaarmaduradurabilidadeBindingSource.DataSource = this.o_inicio_do_fim_v2DataSet;
            // 
            // o_inicio_do_fim_v2DataSet
            // 
            this.o_inicio_do_fim_v2DataSet.DataSetName = "o_inicio_do_fim_v2DataSet";
            this.o_inicio_do_fim_v2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // consulta_armadura_durabilidadeTableAdapter
            // 
            this.consulta_armadura_durabilidadeTableAdapter.ClearBeforeFill = true;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(373, 145);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(100, 20);
            this.txtPeso.TabIndex = 20;
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.Location = new System.Drawing.Point(300, 140);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(60, 22);
            this.lblPeso.TabIndex = 19;
            this.lblPeso.Text = "Peso:";
            // 
            // Armaduras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.BoxMenuArma);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Armaduras";
            this.Text = "Armaduras";
            this.Load += new System.EventHandler(this.Armaduras_Load);
            this.BoxMenuArma.ResumeLayout(false);
            this.BoxMenuArma.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaarmaduradurabilidadeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.o_inicio_do_fim_v2DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.ComboBox cbxDurabilidade;
        private System.Windows.Forms.Label lblDurabilidade;
        private System.Windows.Forms.TextBox txtFurtv;
        private System.Windows.Forms.TextBox txtIdArmadura;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblIdArma;
        private System.Windows.Forms.TextBox txtForca;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.TextBox txtCa;
        private System.Windows.Forms.GroupBox BoxMenuArma;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.Label lblForça;
        private System.Windows.Forms.Label lblFurtv;
        private System.Windows.Forms.Label lblCa;
        private System.Windows.Forms.TextBox txtCusto;
        private System.Windows.Forms.Label lblCusto;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private o_inicio_do_fim_v2DataSet o_inicio_do_fim_v2DataSet;
        private System.Windows.Forms.BindingSource consultaarmaduradurabilidadeBindingSource;
        private o_inicio_do_fim_v2DataSetTableAdapters.consulta_armadura_durabilidadeTableAdapter consulta_armadura_durabilidadeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomearmaduraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoarmaduraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custoarmaduraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn caarmaduraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn furtvarmaduraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn forcaarmaduraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesoarmaduraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacaoarmaduraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusdurabilidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cbxTipoArmadura;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label lblPeso;
    }
}