﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karteczki
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      private void schowajNagłówekToolStripMenuItem_Click(object sender, EventArgs e)
      {
         FormBorderStyle = FormBorderStyle.None;
      }

      private void pokażNagłówekToolStripMenuItem_Click(object sender, EventArgs e)
      {
         FormBorderStyle = FormBorderStyle.FixedToolWindow;
      }

      private void nowaKartkaToolStripMenuItem_Click(object sender, EventArgs e)
      {
         new Form1().Show();
      }

      private void usuńKartkęToolStripMenuItem_Click(object sender, EventArgs e)
      {
         Close();
      }

      private void oProgramieToolStripMenuItem_Click(object sender, EventArgs e)
      {
         MessageBox.Show("Program wykonał: \n\n\t Dawid Płatek \n\n\t www.CoderAcademy.pl");
      }

      private void czcionkaToolStripMenuItem_Click(object sender, EventArgs e)
      {
         fontDialog1.ShowDialog();
         richTextBox1.SelectionFont = fontDialog1.Font;
      }

      private void kolorToolStripMenuItem_Click(object sender, EventArgs e)
      {
         colorDialog1.ShowDialog();
         richTextBox1.SelectionColor = colorDialog1.Color;
      }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Opacity = 1;
        }

        private void przezroczystośćToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Opacity = 0.7;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Opacity = 0.3;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void zawszeNaWierzchuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TopMost = !TopMost;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lewejStronyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void centrumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void prawejStronyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void zamknijProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void przeczytajNaGłosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new System.Speech.Synthesis.SpeechSynthesizer().Speak(richTextBox1.Text);   
        }

        private void przeczytajNaGłosWybranyTekatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new System.Speech.Synthesis.SpeechSynthesizer().Speak(richTextBox1.SelectedText);
        }
    }
}
