using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using OiniciodofimV2Data;

namespace OiniciodofimV2
{
    public partial class Armas : Form
    {
        ArmasData data = new ArmasData();

        public Armas()
        {
            InitializeComponent();
        }

        private void JanelaArma_Load(object sender, EventArgs e)
        {
            this.consulta_arma_municaoTableAdapter.Fill(this.o_inicio_do_fim_v2DataSet2.consulta_arma_municao);
            
            data.carregarComboBoxMunicao(cbxMunicao);

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            data.adicionarArma(txtNome.Text.ToString(), txtCusto.Text.ToString(), txtPeso.Text.ToString(), txtDano.Text.ToString(),
                txtTipoDeDano.Text.ToString(), txtPropriedades.Text.ToString(), txtObservacao.Text.ToString(), cbxMunicao.SelectedValue.ToString());
            
            this.consulta_arma_municaoTableAdapter.Fill(this.o_inicio_do_fim_v2DataSet2.consulta_arma_municao);
            
            MessageBox.Show("Dados Inseridos!");  
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = data.pesquisarArma(txtIdArma.Text.ToString());
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {           
            this.Hide();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            data.excluirArma(txtIdArma.Text.ToString());

            this.consulta_arma_municaoTableAdapter.Fill(this.o_inicio_do_fim_v2DataSet2.consulta_arma_municao);

            MessageBox.Show("Dados Excluidos!");
        }
    }
}
