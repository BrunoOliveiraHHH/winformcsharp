using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Media;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace OiniciodofimV2
{
    public partial class Window : Form
    {
        private static string value = ConfigurationManager.AppSettings["musicaFundo"];

        public Window()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            playSimpleSound();
        }

        private void btnArma_Click(object sender, EventArgs e)
        {
            Armas janelaArma = new Armas();
            janelaArma.Show();
        }

        private void playSimpleSound()
        {
            
            SoundPlayer backgroundSound = new SoundPlayer(value);
            backgroundSound.Play();
        }

        private void btn_armadura_Click(object sender, EventArgs e)
        {
            Armaduras janelaArmaduras = new Armaduras();
            janelaArmaduras.Show();
        }

        private void btn_item_Click(object sender, EventArgs e)
        {
            Item janelaItem = new Item();
            janelaItem.Show();
        }

        private void btnFechar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
