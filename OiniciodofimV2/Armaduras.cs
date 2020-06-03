using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OiniciodofimV2
{
    public partial class Armaduras : Form
    {
        public Armaduras()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {

        }

        private void Armaduras_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'o_inicio_do_fim_v2DataSet.consulta_armadura_durabilidade' table. You can move, or remove it, as needed.
            this.consulta_armadura_durabilidadeTableAdapter.Fill(this.o_inicio_do_fim_v2DataSet.consulta_armadura_durabilidade);
            // TODO: This line of code loads data into the 'o_inicio_do_fim_v2DataSet.consulta_armadura_durabilidade' table. You can move, or remove it, as needed.
            this.consulta_armadura_durabilidadeTableAdapter.Fill(this.o_inicio_do_fim_v2DataSet.consulta_armadura_durabilidade);

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }
    }
}
