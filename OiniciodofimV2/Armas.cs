using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OiniciodofimV2
{
    public partial class Armas : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=NOTE-1322;Initial Catalog=o_inicio_do_fim_v2;Persist Security Info=True;User ID=dev_user;Password=devUser@450");

        public Armas()
        {
            InitializeComponent();
        }

        private void JanelaArma_Load(object sender, EventArgs e)
        {
            this.consulta_arma_municaoTableAdapter.Fill(this.o_inicio_do_fim_v2DataSet2.consulta_arma_municao);
            cbxMunicao_Load();

        }

        private void cbxMunicao_Load()
        {
            con.Open();
            DataSet ds = new DataSet();

            String query = "EXECUTE [dbo].[listar_nome_id_municao]";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(ds);
            cbxMunicao.DisplayMember = "nome";
            cbxMunicao.ValueMember = "id_municao";
            cbxMunicao.DataSource = ds.Tables[0];

            con.Close();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            con.Open();
            string nome = txtNome.Text;
            int custo = Int32.Parse(txtCusto.Text);
            string peso = txtPeso.Text;
            string dano = txtDano.Text;
            string tipoDeDano = txtTipoDeDano.Text;
            string propriedade = txtPropriedades.Text;
            string observacao = txtObservacao.Text;
            string municaoString = cbxMunicao.SelectedValue.ToString();
            int municao = Int32.Parse(municaoString);
            String query = "EXECUTE [dbo].[adiciona_arma] '"+nome+"',"+custo+",'"+dano+"','"+tipoDeDano+"','"+peso+"','"+propriedade+"',"+municao+",'"+observacao+"'";

            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.ExecuteNonQuery();
            con.Close();

            this.consulta_arma_municaoTableAdapter.Fill(this.o_inicio_do_fim_v2DataSet2.consulta_arma_municao);
            
            MessageBox.Show("Dados Inseridos!");                 
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            con.Open();

            String query = "";
            string id_arma = txtIdArma.Text;

            if (id_arma == "")
            {
                query = "EXECUTE [dbo].[consulta_arma_municao]";
            }
            else
            {
                query = "EXECUTE [dbo].[ler_arma_por_id] " + txtIdArma.Text;
            }
            SqlDataAdapter sqda = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand(query, con);
            sqda.SelectCommand = cmd;
            DataTable dt = new DataTable();
            sqda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();  

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {           
            this.Hide();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "EXECUTE [dbo].[excluir_arma_por_id] " + txtIdArma.Text;

            SqlDataAdapter sqda = new SqlDataAdapter(query, con);
            sqda.SelectCommand.ExecuteNonQuery();
            con.Close();

            this.consulta_arma_municaoTableAdapter.Fill(this.o_inicio_do_fim_v2DataSet2.consulta_arma_municao);
            
            MessageBox.Show("Dados Excluidos!");     
        }
    }
}
