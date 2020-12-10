using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace OiniciodofimV2Data
{
    public class ArmasData
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["OiniciodofimV2.Properties.Settings.o_inicio_do_fim_v2ConnectionString"].ConnectionString; 
        SqlConnection con = new SqlConnection(connectionString);

        public ArmasData() { }

        public void carregarComboBoxMunicao(ComboBox cbxMunicao)
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

        public void adicionarArma(string nome, string custoString, string peso, string dano, string tipoDeDano, string propriedade, string observacao, string municaoString)
        {
            con.Open();
            int custo = Int32.Parse(custoString);
            int municao = Int32.Parse(municaoString);
            String query = "EXECUTE [dbo].[adiciona_arma] '" + nome + "'," + custo + ",'" + dano + "','" + tipoDeDano + "','" + peso + "','" + propriedade + "'," + municao + ",'" + observacao + "'";

            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.ExecuteNonQuery();
            con.Close();
           
        }

        public DataTable pesquisarArma(string id_arma)
        {
            con.Open();

            String query = "";

            if (id_arma == "")
            {
                query = "EXECUTE [dbo].[consulta_arma_municao]";
            }
            else
            {
                query = "EXECUTE [dbo].[ler_arma_por_id] " + id_arma;
            }
            SqlDataAdapter sqda = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand(query, con);
            sqda.SelectCommand = cmd;
            DataTable dt = new DataTable();
            sqda.Fill(dt);            
            con.Close();

            return dt;

        }

        public void excluirArma(string id_arma)
        {
            con.Open();
            String query = "EXECUTE [dbo].[excluir_arma_por_id] " + id_arma;

            SqlDataAdapter sqda = new SqlDataAdapter(query, con);
            sqda.SelectCommand.ExecuteNonQuery();
            con.Close();
        }
    }
}
