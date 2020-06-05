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
    public partial class Armaduras : Form
    {
        ArmadurasData data = new ArmadurasData();

        public Armaduras()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Armaduras_Load(object sender, EventArgs e)
        {
            this.consulta_armadura_durabilidadeTableAdapter.Fill(this.o_inicio_do_fim_v2DataSet.consulta_armadura_durabilidade);
            data.carregarComboBoxDurabilidades(cbxDurabilidade);
            data.carregarComboBoxTipoArmadura(cbxTipoArmadura);
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            data.adicionarArmadura(txtNome.Text.ToString(), cbxTipoArmadura.SelectedValue.ToString(), txtCusto.Text.ToString(),
                txtCa.Text.ToString(), txtFurtv.Text.ToString(), txtForca.Text.ToString(), txtPeso.Text.ToString(),
                txtObservacao.Text.ToString(), cbxDurabilidade.SelectedValue.ToString());

            this.consulta_armadura_durabilidadeTableAdapter.Fill(this.o_inicio_do_fim_v2DataSet.consulta_armadura_durabilidade);

            MessageBox.Show("Dados Inseridos!");
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = data.pesquisarArmadura(txtIdArmadura.Text.ToString());
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            data.excluirArmadura(txtIdArmadura.Text.ToString());

            this.consulta_armadura_durabilidadeTableAdapter.Fill(this.o_inicio_do_fim_v2DataSet.consulta_armadura_durabilidade);

            MessageBox.Show("Dados Excluidos!");
        }
    }
}
