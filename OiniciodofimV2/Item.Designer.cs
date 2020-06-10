namespace OiniciodofimV2
{
    partial class Item
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Item));
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.txtIdItem = new System.Windows.Forms.TextBox();
            this.lblIdArma = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.cbxDurabilidade = new System.Windows.Forms.ComboBox();
            this.lblDurabilidade = new System.Windows.Forms.Label();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lblCusto = new System.Windows.Forms.Label();
            this.BoxMenuArma = new System.Windows.Forms.GroupBox();
            this.txtCusto = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.consultaitemdurabilidadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.o_inicio_do_fim_v2DataSet1 = new OiniciodofimV2.o_inicio_do_fim_v2DataSet1();
            this.consulta_item_durabilidadeTableAdapter = new OiniciodofimV2.o_inicio_do_fim_v2DataSet1TableAdapters.consulta_item_durabilidadeTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeitemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custoitemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesoitemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoitemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusdurabilidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BoxMenuArma.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaitemdurabilidadeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.o_inicio_do_fim_v2DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(104, 144);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(100, 20);
            this.txtPeso.TabIndex = 20;
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.Location = new System.Drawing.Point(35, 142);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(60, 22);
            this.lblPeso.TabIndex = 19;
            this.lblPeso.Text = "Peso:";
            // 
            // txtIdItem
            // 
            this.txtIdItem.Location = new System.Drawing.Point(103, 27);
            this.txtIdItem.Name = "txtIdItem";
            this.txtIdItem.Size = new System.Drawing.Size(100, 20);
            this.txtIdItem.TabIndex = 17;
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
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(379, 69);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(335, 95);
            this.txtDescricao.TabIndex = 15;
            this.txtDescricao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnVoltar.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(85, 49);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(135, 45);
            this.btnVoltar.TabIndex = 17;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(268, 64);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(105, 22);
            this.lblDescricao.TabIndex = 14;
            this.lblDescricao.Text = "Descrição:";
            // 
            // cbxDurabilidade
            // 
            this.cbxDurabilidade.FormattingEnabled = true;
            this.cbxDurabilidade.Location = new System.Drawing.Point(379, 26);
            this.cbxDurabilidade.Name = "cbxDurabilidade";
            this.cbxDurabilidade.Size = new System.Drawing.Size(335, 21);
            this.cbxDurabilidade.TabIndex = 13;
            // 
            // lblDurabilidade
            // 
            this.lblDurabilidade.AutoSize = true;
            this.lblDurabilidade.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDurabilidade.Location = new System.Drawing.Point(241, 27);
            this.lblDurabilidade.Name = "lblDurabilidade";
            this.lblDurabilidade.Size = new System.Drawing.Size(132, 22);
            this.lblDurabilidade.TabIndex = 12;
            this.lblDurabilidade.Text = "Durabilidade:";
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnInserir.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.Location = new System.Drawing.Point(668, 257);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(113, 23);
            this.btnInserir.TabIndex = 14;
            this.btnInserir.Text = "Adicionar";
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnPesquisar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(892, 257);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(113, 23);
            this.btnPesquisar.TabIndex = 15;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // lblCusto
            // 
            this.lblCusto.AutoSize = true;
            this.lblCusto.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusto.Location = new System.Drawing.Point(26, 103);
            this.lblCusto.Name = "lblCusto";
            this.lblCusto.Size = new System.Drawing.Size(69, 22);
            this.lblCusto.TabIndex = 4;
            this.lblCusto.Text = "Custo:";
            // 
            // BoxMenuArma
            // 
            this.BoxMenuArma.Controls.Add(this.txtCusto);
            this.BoxMenuArma.Controls.Add(this.txtPeso);
            this.BoxMenuArma.Controls.Add(this.lblPeso);
            this.BoxMenuArma.Controls.Add(this.txtIdItem);
            this.BoxMenuArma.Controls.Add(this.lblIdArma);
            this.BoxMenuArma.Controls.Add(this.txtDescricao);
            this.BoxMenuArma.Controls.Add(this.lblDescricao);
            this.BoxMenuArma.Controls.Add(this.cbxDurabilidade);
            this.BoxMenuArma.Controls.Add(this.lblDurabilidade);
            this.BoxMenuArma.Controls.Add(this.lblCusto);
            this.BoxMenuArma.Controls.Add(this.txtNome);
            this.BoxMenuArma.Controls.Add(this.lblNome);
            this.BoxMenuArma.Location = new System.Drawing.Point(557, 49);
            this.BoxMenuArma.Name = "BoxMenuArma";
            this.BoxMenuArma.Size = new System.Drawing.Size(745, 200);
            this.BoxMenuArma.TabIndex = 13;
            this.BoxMenuArma.TabStop = false;
            // 
            // txtCusto
            // 
            this.txtCusto.Location = new System.Drawing.Point(104, 106);
            this.txtCusto.Name = "txtCusto";
            this.txtCusto.Size = new System.Drawing.Size(100, 20);
            this.txtCusto.TabIndex = 21;
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
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnExcluir.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(1115, 257);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(113, 23);
            this.btnExcluir.TabIndex = 16;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nomeitemDataGridViewTextBoxColumn,
            this.custoitemDataGridViewTextBoxColumn,
            this.pesoitemDataGridViewTextBoxColumn,
            this.descricaoitemDataGridViewTextBoxColumn,
            this.statusdurabilidadeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.consultaitemdurabilidadeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(342, 307);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Size = new System.Drawing.Size(1358, 298);
            this.dataGridView1.TabIndex = 18;
            // 
            // consultaitemdurabilidadeBindingSource
            // 
            this.consultaitemdurabilidadeBindingSource.DataMember = "consulta_item_durabilidade";
            this.consultaitemdurabilidadeBindingSource.DataSource = this.o_inicio_do_fim_v2DataSet1;
            // 
            // o_inicio_do_fim_v2DataSet1
            // 
            this.o_inicio_do_fim_v2DataSet1.DataSetName = "o_inicio_do_fim_v2DataSet1";
            this.o_inicio_do_fim_v2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // consulta_item_durabilidadeTableAdapter
            // 
            this.consulta_item_durabilidadeTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeitemDataGridViewTextBoxColumn
            // 
            this.nomeitemDataGridViewTextBoxColumn.DataPropertyName = "nome_item";
            this.nomeitemDataGridViewTextBoxColumn.HeaderText = "nome_item";
            this.nomeitemDataGridViewTextBoxColumn.Name = "nomeitemDataGridViewTextBoxColumn";
            this.nomeitemDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeitemDataGridViewTextBoxColumn.Width = 150;
            // 
            // custoitemDataGridViewTextBoxColumn
            // 
            this.custoitemDataGridViewTextBoxColumn.DataPropertyName = "custo_item";
            this.custoitemDataGridViewTextBoxColumn.HeaderText = "custo_item";
            this.custoitemDataGridViewTextBoxColumn.Name = "custoitemDataGridViewTextBoxColumn";
            this.custoitemDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pesoitemDataGridViewTextBoxColumn
            // 
            this.pesoitemDataGridViewTextBoxColumn.DataPropertyName = "peso_item";
            this.pesoitemDataGridViewTextBoxColumn.HeaderText = "peso_item";
            this.pesoitemDataGridViewTextBoxColumn.Name = "pesoitemDataGridViewTextBoxColumn";
            this.pesoitemDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descricaoitemDataGridViewTextBoxColumn
            // 
            this.descricaoitemDataGridViewTextBoxColumn.DataPropertyName = "descricao_item";
            this.descricaoitemDataGridViewTextBoxColumn.HeaderText = "descricao_item";
            this.descricaoitemDataGridViewTextBoxColumn.Name = "descricaoitemDataGridViewTextBoxColumn";
            this.descricaoitemDataGridViewTextBoxColumn.ReadOnly = true;
            this.descricaoitemDataGridViewTextBoxColumn.Width = 650;
            // 
            // statusdurabilidadeDataGridViewTextBoxColumn
            // 
            this.statusdurabilidadeDataGridViewTextBoxColumn.DataPropertyName = "status_durabilidade";
            this.statusdurabilidadeDataGridViewTextBoxColumn.HeaderText = "status_durabilidade";
            this.statusdurabilidadeDataGridViewTextBoxColumn.Name = "statusdurabilidadeDataGridViewTextBoxColumn";
            this.statusdurabilidadeDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusdurabilidadeDataGridViewTextBoxColumn.Width = 125;
            // 
            // Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1853, 844);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.BoxMenuArma);
            this.Controls.Add(this.btnExcluir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Item";
            this.Text = "Item";
            this.Load += new System.EventHandler(this.Item_Load);
            this.BoxMenuArma.ResumeLayout(false);
            this.BoxMenuArma.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaitemdurabilidadeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.o_inicio_do_fim_v2DataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.TextBox txtIdItem;
        private System.Windows.Forms.Label lblIdArma;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.ComboBox cbxDurabilidade;
        private System.Windows.Forms.Label lblDurabilidade;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label lblCusto;
        private System.Windows.Forms.GroupBox BoxMenuArma;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.TextBox txtCusto;
        private System.Windows.Forms.DataGridView dataGridView1;
        private o_inicio_do_fim_v2DataSet1 o_inicio_do_fim_v2DataSet1;
        private System.Windows.Forms.BindingSource consultaitemdurabilidadeBindingSource;
        private o_inicio_do_fim_v2DataSet1TableAdapters.consulta_item_durabilidadeTableAdapter consulta_item_durabilidadeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeitemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custoitemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesoitemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoitemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusdurabilidadeDataGridViewTextBoxColumn;
    }
}