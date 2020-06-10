using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OiniciodofimV2Data
{
    public class ItensData
    {
        SqlConnection con = new SqlConnection(@"Data Source=NOTE-1322;Initial Catalog=o_inicio_do_fim_v2;Persist Security Info=True;User ID=dev_user;Password=devUser@450");

        public ItensData() { }

        public void carregarComboBoxDurabilidades(ComboBox cbxDurabilidade)
        {
            con.Open();
            DataSet ds = new DataSet();

            String query = "EXECUTE [dbo].[listar_durabilidades]";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(ds);
            cbxDurabilidade.DisplayMember = "descricao";
            cbxDurabilidade.ValueMember = "id_durabilidade";
            cbxDurabilidade.DataSource = ds.Tables[0];
            con.Close();
        }

        public void adicionarItem(string nome, string custoString, string peso, string descricao, string durabilidadeString)
        {
            con.Open();
            int custo = Int32.Parse(custoString);
            int durabilidade = Int32.Parse(durabilidadeString);
            String query = "EXECUTE [dbo].[adicionar_item] '" + nome + "'," + custo + ",'" + peso + "'," + durabilidade + ",'" + descricao + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.ExecuteNonQuery();
            con.Close();

        }

        public DataTable pesquisarItem(string id_item)
        {
            con.Open();

            String query = "";
            DataTable dt = new DataTable();

            if (id_item == "")
            {
                query = "EXECUTE [dbo].[consulta_item_durabilidade]";
            }
            else
            {
                query = "EXECUTE [dbo].[ler_item_por_id] " + Int32.Parse(id_item);
            }
            SqlDataAdapter sqda = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand(query, con);
            sqda.SelectCommand = cmd;
            sqda.Fill(dt);
            con.Close();

            return dt;

        }

        public void excluirItem(string id_item)
        {
            con.Open();
            String query = "EXECUTE [dbo].[excluir_item_por_id] " + Int32.Parse(id_item);

            SqlDataAdapter sqda = new SqlDataAdapter(query, con);
            sqda.SelectCommand.ExecuteNonQuery();
            con.Close();
        }
    }
}
