namespace OiniciodofimV2
{
    partial class Armas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Armas));
            this.BoxMenuArma = new System.Windows.Forms.GroupBox();
            this.txtIdArma = new System.Windows.Forms.TextBox();
            this.lblIdArma = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.cbxMunicao = new System.Windows.Forms.ComboBox();
            this.lblMunicao = new System.Windows.Forms.Label();
            this.txtPropriedades = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtTipoDeDano = new System.Windows.Forms.TextBox();
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
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomearmaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custoarmaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.danoarmaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipodedanoarmaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesoarmaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.propriedadearmaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomemunicaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customunicaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calibremunicaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidademunicaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacaomunicaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacaoarmaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consultaarmamunicaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.o_inicio_do_fim_v2DataSet2 = new OiniciodofimV2.o_inicio_do_fim_v2DataSet2();
            this.consulta_arma_municaoTableAdapter = new OiniciodofimV2.o_inicio_do_fim_v2DataSet2TableAdapters.consulta_arma_municaoTableAdapter();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.BoxMenuArma.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaarmamunicaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.o_inicio_do_fim_v2DataSet2)).BeginInit();
            this.SuspendLayout();
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
            this.BoxMenuArma.Location = new System.Drawing.Point(299, 12);
            this.BoxMenuArma.Name = "BoxMenuArma";
            this.BoxMenuArma.Size = new System.Drawing.Size(745, 200);
            this.BoxMenuArma.TabIndex = 0;
            this.BoxMenuArma.TabStop = false;
            // 
            // txtIdArma
            // 
            this.txtIdArma.Location = new System.Drawing.Point(103, 27);
            this.txtIdArma.Name = "txtIdArma";
            this.txtIdArma.Size = new System.Drawing.Size(100, 20);
            this.txtIdArma.TabIndex = 17;
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
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(506, 92);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(215, 37);
            this.txtObservacao.TabIndex = 15;
            this.txtObservacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            // cbxMunicao
            // 
            this.cbxMunicao.FormattingEnabled = true;
            this.cbxMunicao.Location = new System.Drawing.Point(600, 26);
            this.cbxMunicao.Name = "cbxMunicao";
            this.cbxMunicao.Size = new System.Drawing.Size(121, 21);
            this.cbxMunicao.TabIndex = 13;
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
            // txtPropriedades
            // 
            this.txtPropriedades.Location = new System.Drawing.Point(373, 109);
            this.txtPropriedades.Name = "txtPropriedades";
            this.txtPropriedades.Size = new System.Drawing.Size(100, 20);
            this.txtPropriedades.TabIndex = 11;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(373, 69);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(100, 20);
            this.txtPeso.TabIndex = 10;
            // 
            // txtTipoDeDano
            // 
            this.txtTipoDeDano.Location = new System.Drawing.Point(373, 28);
            this.txtTipoDeDano.Name = "txtTipoDeDano";
            this.txtTipoDeDano.Size = new System.Drawing.Size(100, 20);
            this.txtTipoDeDano.TabIndex = 9;
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
            this.btnInserir.Location = new System.Drawing.Point(333, 227);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(113, 23);
            this.btnInserir.TabIndex = 2;
            this.btnInserir.Text = "Adicionar";
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnPesquisar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(575, 227);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(113, 23);
            this.btnPesquisar.TabIndex = 3;
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
            this.nomearmaDataGridViewTextBoxColumn,
            this.custoarmaDataGridViewTextBoxColumn,
            this.danoarmaDataGridViewTextBoxColumn,
            this.tipodedanoarmaDataGridViewTextBoxColumn,
            this.pesoarmaDataGridViewTextBoxColumn,
            this.propriedadearmaDataGridViewTextBoxColumn,
            this.nomemunicaoDataGridViewTextBoxColumn,
            this.customunicaoDataGridViewTextBoxColumn,
            this.calibremunicaoDataGridViewTextBoxColumn,
            this.quantidademunicaoDataGridViewTextBoxColumn,
            this.observacaomunicaoDataGridViewTextBoxColumn,
            this.observacaoarmaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.consultaarmamunicaoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(45, 275);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Gray;
            this.dataGridView1.Size = new System.Drawing.Size(1347, 354);
            this.dataGridView1.TabIndex = 4;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomearmaDataGridViewTextBoxColumn
            // 
            this.nomearmaDataGridViewTextBoxColumn.DataPropertyName = "nome_arma";
            this.nomearmaDataGridViewTextBoxColumn.HeaderText = "nome_arma";
            this.nomearmaDataGridViewTextBoxColumn.Name = "nomearmaDataGridViewTextBoxColumn";
            this.nomearmaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // custoarmaDataGridViewTextBoxColumn
            // 
            this.custoarmaDataGridViewTextBoxColumn.DataPropertyName = "custo_arma";
            this.custoarmaDataGridViewTextBoxColumn.HeaderText = "custo_arma";
            this.custoarmaDataGridViewTextBoxColumn.Name = "custoarmaDataGridViewTextBoxColumn";
            this.custoarmaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // danoarmaDataGridViewTextBoxColumn
            // 
            this.danoarmaDataGridViewTextBoxColumn.DataPropertyName = "dano_arma";
            this.danoarmaDataGridViewTextBoxColumn.HeaderText = "dano_arma";
            this.danoarmaDataGridViewTextBoxColumn.Name = "danoarmaDataGridViewTextBoxColumn";
            this.danoarmaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipodedanoarmaDataGridViewTextBoxColumn
            // 
            this.tipodedanoarmaDataGridViewTextBoxColumn.DataPropertyName = "tipo_de_dano_arma";
            this.tipodedanoarmaDataGridViewTextBoxColumn.HeaderText = "tipo_de_dano_arma";
            this.tipodedanoarmaDataGridViewTextBoxColumn.Name = "tipodedanoarmaDataGridViewTextBoxColumn";
            this.tipodedanoarmaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pesoarmaDataGridViewTextBoxColumn
            // 
            this.pesoarmaDataGridViewTextBoxColumn.DataPropertyName = "peso_arma";
            this.pesoarmaDataGridViewTextBoxColumn.HeaderText = "peso_arma";
            this.pesoarmaDataGridViewTextBoxColumn.Name = "pesoarmaDataGridViewTextBoxColumn";
            this.pesoarmaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // propriedadearmaDataGridViewTextBoxColumn
            // 
            this.propriedadearmaDataGridViewTextBoxColumn.DataPropertyName = "propriedade_arma";
            this.propriedadearmaDataGridViewTextBoxColumn.HeaderText = "propriedade_arma";
            this.propriedadearmaDataGridViewTextBoxColumn.Name = "propriedadearmaDataGridViewTextBoxColumn";
            this.propriedadearmaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomemunicaoDataGridViewTextBoxColumn
            // 
            this.nomemunicaoDataGridViewTextBoxColumn.DataPropertyName = "nome_municao";
            this.nomemunicaoDataGridViewTextBoxColumn.HeaderText = "nome_municao";
            this.nomemunicaoDataGridViewTextBoxColumn.Name = "nomemunicaoDataGridViewTextBoxColumn";
            this.nomemunicaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customunicaoDataGridViewTextBoxColumn
            // 
            this.customunicaoDataGridViewTextBoxColumn.DataPropertyName = "custo_municao";
            this.customunicaoDataGridViewTextBoxColumn.HeaderText = "custo_municao";
            this.customunicaoDataGridViewTextBoxColumn.Name = "customunicaoDataGridViewTextBoxColumn";
            this.customunicaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // calibremunicaoDataGridViewTextBoxColumn
            // 
            this.calibremunicaoDataGridViewTextBoxColumn.DataPropertyName = "calibre_municao";
            this.calibremunicaoDataGridViewTextBoxColumn.HeaderText = "calibre_municao";
            this.calibremunicaoDataGridViewTextBoxColumn.Name = "calibremunicaoDataGridViewTextBoxColumn";
            this.calibremunicaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantidademunicaoDataGridViewTextBoxColumn
            // 
            this.quantidademunicaoDataGridViewTextBoxColumn.DataPropertyName = "quantidade_municao";
            this.quantidademunicaoDataGridViewTextBoxColumn.HeaderText = "quantidade_municao";
            this.quantidademunicaoDataGridViewTextBoxColumn.Name = "quantidademunicaoDataGridViewTextBoxColumn";
            this.quantidademunicaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // observacaomunicaoDataGridViewTextBoxColumn
            // 
            this.observacaomunicaoDataGridViewTextBoxColumn.DataPropertyName = "observacao_municao";
            this.observacaomunicaoDataGridViewTextBoxColumn.HeaderText = "observacao_municao";
            this.observacaomunicaoDataGridViewTextBoxColumn.Name = "observacaomunicaoDataGridViewTextBoxColumn";
            this.observacaomunicaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // observacaoarmaDataGridViewTextBoxColumn
            // 
            this.observacaoarmaDataGridViewTextBoxColumn.DataPropertyName = "observacao_arma";
            this.observacaoarmaDataGridViewTextBoxColumn.HeaderText = "observacao_arma";
            this.observacaoarmaDataGridViewTextBoxColumn.Name = "observacaoarmaDataGridViewTextBoxColumn";
            this.observacaoarmaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // consultaarmamunicaoBindingSource
            // 
            this.consultaarmamunicaoBindingSource.DataMember = "consulta_arma_municao";
            this.consultaarmamunicaoBindingSource.DataSource = this.o_inicio_do_fim_v2DataSet2;
            // 
            // o_inicio_do_fim_v2DataSet2
            // 
            this.o_inicio_do_fim_v2DataSet2.DataSetName = "o_inicio_do_fim_v2DataSet2";
            this.o_inicio_do_fim_v2DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // consulta_arma_municaoTableAdapter
            // 
            this.consulta_arma_municaoTableAdapter.ClearBeforeFill = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnExcluir.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(805, 227);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(113, 23);
            this.btnExcluir.TabIndex = 5;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnVoltar.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(45, 40);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(135, 45);
            this.btnVoltar.TabIndex = 6;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // Armas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1444, 686);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.BoxMenuArma);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Armas";
            this.Text = "Armas";
            this.Load += new System.EventHandler(this.JanelaArma_Load);
            this.BoxMenuArma.ResumeLayout(false);
            this.BoxMenuArma.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaarmamunicaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.o_inicio_do_fim_v2DataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox BoxMenuArma;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCusto;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblTipoDeDano;
        private System.Windows.Forms.TextBox txtDano;
        private System.Windows.Forms.Label lblDano;
        private System.Windows.Forms.TextBox txtCusto;
        private System.Windows.Forms.TextBox txtPropriedades;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtTipoDeDano;
        private System.Windows.Forms.Label lblPropriedades;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.ComboBox cbxMunicao;
        private System.Windows.Forms.Label lblMunicao;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtIdArma;
        private System.Windows.Forms.Label lblIdArma;
        private System.Windows.Forms.DataGridView dataGridView1;
        private o_inicio_do_fim_v2DataSet2 o_inicio_do_fim_v2DataSet2;
        private System.Windows.Forms.BindingSource consultaarmamunicaoBindingSource;
        private o_inicio_do_fim_v2DataSet2TableAdapters.consulta_arma_municaoTableAdapter consulta_arma_municaoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomearmaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custoarmaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn danoarmaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipodedanoarmaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesoarmaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn propriedadearmaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomemunicaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customunicaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn calibremunicaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidademunicaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacaomunicaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacaoarmaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnVoltar;
    }
}