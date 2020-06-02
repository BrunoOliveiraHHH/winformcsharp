﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Media;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OiniciodofimV2
{
    public partial class Window : Form
    {
        public Window()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            playSimpleSound();
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void title_Click(object sender, EventArgs e) { }

        private void btnArma_Click(object sender, EventArgs e)
        {
            abreJanelaArma();
        }

        private void playSimpleSound()
        {
            SoundPlayer backgroundSound = new SoundPlayer(@"C:\Users\PMRecife\Documents\visual studio 2010\Projects\OiniciodofimV2\OiniciodofimV2\assets\sound-background.wav");
            backgroundSound.Play();
        }

        private void abreJanelaArma()
        {
            Armas janelaArma = new Armas();
            janelaArma.Show();
        }
    }
}
