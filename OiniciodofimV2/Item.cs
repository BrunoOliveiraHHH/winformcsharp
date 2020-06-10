using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OiniciodofimV2Data;

namespace OiniciodofimV2
{
    public partial class Item : Form
    {
        ItensData data = new ItensData();

        public Item()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Item_Load(object sender, EventArgs e)
        {
            this.consulta_item_durabilidadeTableAdapter.Fill(this.o_inicio_do_fim_v2DataSet1.consulta_item_durabilidade);
            data.carregarComboBoxDurabilidades(cbxDurabilidade);

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
           dataGridView1.DataSource = data.pesquisarItem(txtIdItem.Text.ToString());
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            data.adicionarItem(txtNome.Text.ToString(), txtCusto.Text.ToString(), txtPeso.Text.ToString(), txtDescricao.Text.ToString(), cbxDurabilidade.SelectedValue.ToString());
            this.consulta_item_durabilidadeTableAdapter.Fill(this.o_inicio_do_fim_v2DataSet1.consulta_item_durabilidade);
            MessageBox.Show("Dados Inseridos");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            data.excluirItem(txtIdItem.Text.ToString());
            this.consulta_item_durabilidadeTableAdapter.Fill(this.o_inicio_do_fim_v2DataSet1.consulta_item_durabilidade);
            MessageBox.Show("Dados Excluidos");
        }

    }
}
