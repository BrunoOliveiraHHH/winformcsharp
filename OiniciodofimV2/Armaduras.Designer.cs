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
            this.cbxMunicao = new System.Windows.Forms.ComboBox();
            this.lblMunicao = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtIdArma = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblIdArma = new System.Windows.Forms.Label();
            this.txtPropriedades = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.txtTipoDeDano = new System.Windows.Forms.TextBox();
            this.BoxMenuArma = new System.Windows.Forms.GroupBox();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.lblPropriedades = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblTipoDeDano = new System.Windows.Forms.Label();
            this.txtDano = new System.Windows.Forms.TextBox();
            this.lblDano = new System.Windows.Forms.Label();
            this.txtCusto = new System.Windows.Forms.TextBox();
            this.lblCusto = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.o_inicio_do_fim_v2DataSet = new OiniciodofimV2.o_inicio_do_fim_v2DataSet();
            this.consultaarmaduradurabilidadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consulta_armadura_durabilidadeTableAdapter = new OiniciodofimV2.o_inicio_do_fim_v2DataSetTableAdapters.consulta_armadura_durabilidadeTableAdapter();
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
            this.BoxMenuArma.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.o_inicio_do_fim_v2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaarmaduradurabilidadeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(506, 92);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(215, 37);
            this.txtObservacao.TabIndex = 15;
            this.txtObservacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbxMunicao
            // 
            this.cbxMunicao.FormattingEnabled = true;
            this.cbxMunicao.Location = new System.Drawing.Point(600, 26);
            this.cbxMunicao.Name = "cbxMunicao";
            this.cbxMunicao.Size = new System.Drawing.Size(121, 21);
            this.cbxMunicao.TabIndex = 13;
            this.cbxMunicao.SelectedIndexChanged += new System.EventHandler(this.cbxMunicao_SelectedIndexChanged);
            // 
            // lblMunicao
            // 
            this.lblMunicao.AutoSize = true;
            this.lblMunicao.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMunicao.Location = new System.Drawing.Point(502, 26);
            this.lblMunicao.Name = "lblMunicao";
            this.lblMunicao.Size = new System.Drawing.Size(91, 22);
            this.lblMunicao.TabIndex = 12;
            this.lblMunicao.Text = "Munição:";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(373, 69);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(100, 20);
            this.txtPeso.TabIndex = 10;
            // 
            // txtIdArma
            // 
            this.txtIdArma.Location = new System.Drawing.Point(103, 27);
            this.txtIdArma.Name = "txtIdArma";
            this.txtIdArma.Size = new System.Drawing.Size(100, 20);
            this.txtIdArma.TabIndex = 17;
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
            // txtPropriedades
            // 
            this.txtPropriedades.Location = new System.Drawing.Point(373, 109);
            this.txtPropriedades.Name = "txtPropriedades";
            this.txtPropriedades.Size = new System.Drawing.Size(100, 20);
            this.txtPropriedades.TabIndex = 11;
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
            // txtTipoDeDano
            // 
            this.txtTipoDeDano.Location = new System.Drawing.Point(373, 28);
            this.txtTipoDeDano.Name = "txtTipoDeDano";
            this.txtTipoDeDano.Size = new System.Drawing.Size(100, 20);
            this.txtTipoDeDano.TabIndex = 9;
            // 
            // BoxMenuArma
            // 
            this.BoxMenuArma.Controls.Add(this.txtIdArma);
            this.BoxMenuArma.Controls.Add(this.lblIdArma);
            this.BoxMenuArma.Controls.Add(this.txtObservacao);
            this.BoxMenuArma.Controls.Add(this.lblObservacao);
            this.BoxMenuArma.Controls.Add(this.cbxMunicao);
            this.BoxMenuArma.Controls.Add(this.lblMunicao);
            this.BoxMenuArma.Controls.Add(this.txtPropriedades);
            this.BoxMenuArma.Controls.Add(this.txtPeso);
            this.BoxMenuArma.Controls.Add(this.txtTipoDeDano);
            this.BoxMenuArma.Controls.Add(this.lblPropriedades);
            this.BoxMenuArma.Controls.Add(this.lblPeso);
            this.BoxMenuArma.Controls.Add(this.lblTipoDeDano);
            this.BoxMenuArma.Controls.Add(this.txtDano);
            this.BoxMenuArma.Controls.Add(this.lblDano);
            this.BoxMenuArma.Controls.Add(this.txtCusto);
            this.BoxMenuArma.Controls.Add(this.lblCusto);
            this.BoxMenuArma.Controls.Add(this.txtNome);
            this.BoxMenuArma.Controls.Add(this.lblNome);
            this.BoxMenuArma.Location = new System.Drawing.Point(367, 37);
            this.BoxMenuArma.Name = "BoxMenuArma";
            this.BoxMenuArma.Size = new System.Drawing.Size(745, 200);
            this.BoxMenuArma.TabIndex = 7;
            this.BoxMenuArma.TabStop = false;
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacao.Location = new System.Drawing.Point(502, 66);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(133, 22);
            this.lblObservacao.TabIndex = 14;
            this.lblObservacao.Text = "Observações:";
            // 
            // lblPropriedades
            // 
            this.lblPropriedades.AutoSize = true;
            this.lblPropriedades.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPropriedades.Location = new System.Drawing.Point(231, 106);
            this.lblPropriedades.Name = "lblPropriedades";
            this.lblPropriedades.Size = new System.Drawing.Size(136, 22);
            this.lblPropriedades.TabIndex = 8;
            this.lblPropriedades.Text = "Propriedades:";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.Location = new System.Drawing.Point(307, 66);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(60, 22);
            this.lblPeso.TabIndex = 7;
            this.lblPeso.Text = "Peso:";
            // 
            // lblTipoDeDano
            // 
            this.lblTipoDeDano.AutoSize = true;
            this.lblTipoDeDano.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDeDano.Location = new System.Drawing.Point(230, 26);
            this.lblTipoDeDano.Name = "lblTipoDeDano";
            this.lblTipoDeDano.Size = new System.Drawing.Size(137, 22);
            this.lblTipoDeDano.TabIndex = 6;
            this.lblTipoDeDano.Text = "Tipo de Dano:";
            // 
            // txtDano
            // 
            this.txtDano.Location = new System.Drawing.Point(104, 144);
            this.txtDano.Name = "txtDano";
            this.txtDano.Size = new System.Drawing.Size(100, 20);
            this.txtDano.TabIndex = 5;
            // 
            // lblDano
            // 
            this.lblDano.AutoSize = true;
            this.lblDano.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDano.Location = new System.Drawing.Point(30, 142);
            this.lblDano.Name = "lblDano";
            this.lblDano.Size = new System.Drawing.Size(65, 22);
            this.lblDano.TabIndex = 4;
            this.lblDano.Text = "Dano:";
            // 
            // txtCusto
            // 
            this.txtCusto.Location = new System.Drawing.Point(104, 106);
            this.txtCusto.Name = "txtCusto";
            this.txtCusto.Size = new System.Drawing.Size(100, 20);
            this.txtCusto.TabIndex = 3;
            // 
            // lblCusto
            // 
            this.lblCusto.AutoSize = true;
            this.lblCusto.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusto.Location = new System.Drawing.Point(30, 106);
            this.lblCusto.Name = "lblCusto";
            this.lblCusto.Size = new System.Drawing.Size(68, 22);
            this.lblCusto.TabIndex = 2;
            this.lblCusto.Text = "Preço:";
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
            this.lblNome.Location = new System.Drawing.Point(30, 63);
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
            // o_inicio_do_fim_v2DataSet
            // 
            this.o_inicio_do_fim_v2DataSet.DataSetName = "o_inicio_do_fim_v2DataSet";
            this.o_inicio_do_fim_v2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // consultaarmaduradurabilidadeBindingSource
            // 
            this.consultaarmaduradurabilidadeBindingSource.DataMember = "consulta_armadura_durabilidade";
            this.consultaarmaduradurabilidadeBindingSource.DataSource = this.o_inicio_do_fim_v2DataSet;
            // 
            // consulta_armadura_durabilidadeTableAdapter
            // 
            this.consulta_armadura_durabilidadeTableAdapter.ClearBeforeFill = true;
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
            // Armaduras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1450, 756);
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
            ((System.ComponentModel.ISupportInitialize)(this.o_inicio_do_fim_v2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaarmaduradurabilidadeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.ComboBox cbxMunicao;
        private System.Windows.Forms.Label lblMunicao;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtIdArma;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblIdArma;
        private System.Windows.Forms.TextBox txtPropriedades;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.TextBox txtTipoDeDano;
        private System.Windows.Forms.GroupBox BoxMenuArma;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.Label lblPropriedades;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblTipoDeDano;
        private System.Windows.Forms.TextBox txtDano;
        private System.Windows.Forms.Label lblDano;
        private System.Windows.Forms.TextBox txtCusto;
        private System.Windows.Forms.Label lblCusto;
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
    }
}