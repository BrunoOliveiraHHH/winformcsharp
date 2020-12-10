using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace OiniciodofimV2Data
{
    public class DurabilidadeData
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["OiniciodofimV2.Properties.Settings.o_inicio_do_fim_v2ConnectionString"].ConnectionString;

        SqlConnection con = new SqlConnection(connectionString);

        public DurabilidadeData() { }

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
    }
}
