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
    public class ArmadurasData
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["OiniciodofimV2.Properties.Settings.o_inicio_do_fim_v2ConnectionString"].ConnectionString;
        SqlConnection con = new SqlConnection(connectionString);

        public ArmadurasData() { }

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

        public void carregarComboBoxTipoArmadura(ComboBox cbxTipoArmadura)
        {
            con.Open();
            DataSet ds = new DataSet();

            String query = "EXECUTE [dbo].[listar_tipo_armadura]";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(ds);
            cbxTipoArmadura.DisplayMember = "nome";
            cbxTipoArmadura.ValueMember = "id_tipo_armadura";
            cbxTipoArmadura.DataSource = ds.Tables[0];
            con.Close();
        }

        public void adicionarArmadura(string nome, string tipoString, string custoString, string ca, string furtv, string forca, string peso, string observacao, string durabilidadeString)
        {
            con.Open();
            int tipo = Int32.Parse(tipoString);
            int custo = Int32.Parse(custoString);
            int durabilidade = Int32.Parse(durabilidadeString);
            String query = "EXECUTE [dbo].[adiciona_armadura] '" + nome + "'," + tipo + "," + custo + ",'" + ca + "','" + furtv + "','" + forca + "','" + peso + "'," + durabilidade + ",'"+ observacao +"'";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.ExecuteNonQuery();
            con.Close();

        }

        public DataTable pesquisarArmadura(string id_armadura)
        {
            con.Open();

            String query = "";
            DataTable dt = new DataTable();

            if (id_armadura == "")
            {
                query = "EXECUTE [dbo].[consulta_armadura_durabilidade]";
            }
            else
            {
                query = "EXECUTE [dbo].[ler_armadura_por_id] " + Int32.Parse(id_armadura);
            }
            SqlDataAdapter sqda = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand(query, con);
            sqda.SelectCommand = cmd;            
            sqda.Fill(dt);
            con.Close();

            return dt;

        }

        public void excluirArmadura(string id_armadura)
        {
            con.Open();
            String query = "EXECUTE [dbo].[excluir_armadura_por_id] " + id_armadura;

            SqlDataAdapter sqda = new SqlDataAdapter(query, con);
            sqda.SelectCommand.ExecuteNonQuery();
            con.Close();
        }
    }
}
