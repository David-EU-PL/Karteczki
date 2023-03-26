namespace Karteczki
{
   partial class Form1
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
            this.components = new System.ComponentModel.Container();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nowaKartkaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuńKartkęToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pokażNagłówekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schowajNagłówekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.czcionkaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kolorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.przezroczystośćToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.zawszeNaWierzchuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.przesuńTekstDoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lewejStronyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centrumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prawejStronyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamknijProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.przeczytajNaGłosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.przeczytajNaGłosWybranyTekatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otwórzPlikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszPlikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(235)))), ((int)(((byte)(110)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.richTextBox1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBox1.Location = new System.Drawing.Point(9, 53);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(268, 203);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nowaKartkaToolStripMenuItem,
            this.otwórzPlikToolStripMenuItem,
            this.zapiszPlikToolStripMenuItem,
            this.pokażNagłówekToolStripMenuItem,
            this.schowajNagłówekToolStripMenuItem,
            this.usuńKartkęToolStripMenuItem,
            this.czcionkaToolStripMenuItem,
            this.kolorToolStripMenuItem,
            this.przezroczystośćToolStripMenuItem,
            this.przesuńTekstDoToolStripMenuItem,
            this.przeczytajNaGłosToolStripMenuItem,
            this.przeczytajNaGłosWybranyTekatToolStripMenuItem,
            this.zawszeNaWierzchuToolStripMenuItem,
            this.oProgramieToolStripMenuItem,
            this.zamknijProgramToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(245, 356);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // nowaKartkaToolStripMenuItem
            // 
            this.nowaKartkaToolStripMenuItem.Name = "nowaKartkaToolStripMenuItem";
            this.nowaKartkaToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.nowaKartkaToolStripMenuItem.Text = "Nowa kartka";
            this.nowaKartkaToolStripMenuItem.Click += new System.EventHandler(this.nowaKartkaToolStripMenuItem_Click);
            // 
            // usuńKartkęToolStripMenuItem
            // 
            this.usuńKartkęToolStripMenuItem.Name = "usuńKartkęToolStripMenuItem";
            this.usuńKartkęToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.usuńKartkęToolStripMenuItem.Text = "Usuń kartkę";
            this.usuńKartkęToolStripMenuItem.Click += new System.EventHandler(this.usuńKartkęToolStripMenuItem_Click);
            // 
            // pokażNagłówekToolStripMenuItem
            // 
            this.pokażNagłówekToolStripMenuItem.Name = "pokażNagłówekToolStripMenuItem";
            this.pokażNagłówekToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.pokażNagłówekToolStripMenuItem.Text = "Pokaż nagłówek";
            this.pokażNagłówekToolStripMenuItem.Click += new System.EventHandler(this.pokażNagłówekToolStripMenuItem_Click);
            // 
            // schowajNagłówekToolStripMenuItem
            // 
            this.schowajNagłówekToolStripMenuItem.Name = "schowajNagłówekToolStripMenuItem";
            this.schowajNagłówekToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.schowajNagłówekToolStripMenuItem.Text = "Schowaj nagłówek";
            this.schowajNagłówekToolStripMenuItem.Click += new System.EventHandler(this.schowajNagłówekToolStripMenuItem_Click);
            // 
            // czcionkaToolStripMenuItem
            // 
            this.czcionkaToolStripMenuItem.Name = "czcionkaToolStripMenuItem";
            this.czcionkaToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.czcionkaToolStripMenuItem.Text = "Czcionka";
            this.czcionkaToolStripMenuItem.Click += new System.EventHandler(this.czcionkaToolStripMenuItem_Click);
            // 
            // kolorToolStripMenuItem
            // 
            this.kolorToolStripMenuItem.Name = "kolorToolStripMenuItem";
            this.kolorToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.kolorToolStripMenuItem.Text = "Kolor";
            this.kolorToolStripMenuItem.Click += new System.EventHandler(this.kolorToolStripMenuItem_Click);
            // 
            // oProgramieToolStripMenuItem
            // 
            this.oProgramieToolStripMenuItem.Name = "oProgramieToolStripMenuItem";
            this.oProgramieToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.oProgramieToolStripMenuItem.Text = "O programie";
            this.oProgramieToolStripMenuItem.Click += new System.EventHandler(this.oProgramieToolStripMenuItem_Click);
            // 
            // przezroczystośćToolStripMenuItem
            // 
            this.przezroczystośćToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.przezroczystośćToolStripMenuItem.Name = "przezroczystośćToolStripMenuItem";
            this.przezroczystośćToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.przezroczystośćToolStripMenuItem.Text = "Przezroczystość";
            this.przezroczystośćToolStripMenuItem.Click += new System.EventHandler(this.przezroczystośćToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = "0%";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem3.Text = "30%";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem4.Text = "70%";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // zawszeNaWierzchuToolStripMenuItem
            // 
            this.zawszeNaWierzchuToolStripMenuItem.Name = "zawszeNaWierzchuToolStripMenuItem";
            this.zawszeNaWierzchuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zawszeNaWierzchuToolStripMenuItem.Text = "Zawsze na wierzchu";
            this.zawszeNaWierzchuToolStripMenuItem.Click += new System.EventHandler(this.zawszeNaWierzchuToolStripMenuItem_Click);
            // 
            // przesuńTekstDoToolStripMenuItem
            // 
            this.przesuńTekstDoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lewejStronyToolStripMenuItem,
            this.centrumToolStripMenuItem,
            this.prawejStronyToolStripMenuItem});
            this.przesuńTekstDoToolStripMenuItem.Name = "przesuńTekstDoToolStripMenuItem";
            this.przesuńTekstDoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.przesuńTekstDoToolStripMenuItem.Text = "Przesuń tekst do";
            // 
            // lewejStronyToolStripMenuItem
            // 
            this.lewejStronyToolStripMenuItem.Name = "lewejStronyToolStripMenuItem";
            this.lewejStronyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lewejStronyToolStripMenuItem.Text = "Lewej strony";
            this.lewejStronyToolStripMenuItem.Click += new System.EventHandler(this.lewejStronyToolStripMenuItem_Click);
            // 
            // centrumToolStripMenuItem
            // 
            this.centrumToolStripMenuItem.Name = "centrumToolStripMenuItem";
            this.centrumToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.centrumToolStripMenuItem.Text = "Środka";
            this.centrumToolStripMenuItem.Click += new System.EventHandler(this.centrumToolStripMenuItem_Click);
            // 
            // prawejStronyToolStripMenuItem
            // 
            this.prawejStronyToolStripMenuItem.Name = "prawejStronyToolStripMenuItem";
            this.prawejStronyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.prawejStronyToolStripMenuItem.Text = "Prawej strony";
            this.prawejStronyToolStripMenuItem.Click += new System.EventHandler(this.prawejStronyToolStripMenuItem_Click);
            // 
            // zamknijProgramToolStripMenuItem
            // 
            this.zamknijProgramToolStripMenuItem.Name = "zamknijProgramToolStripMenuItem";
            this.zamknijProgramToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zamknijProgramToolStripMenuItem.Text = "Zamknij program";
            this.zamknijProgramToolStripMenuItem.Click += new System.EventHandler(this.zamknijProgramToolStripMenuItem_Click);
            // 
            // przeczytajNaGłosToolStripMenuItem
            // 
            this.przeczytajNaGłosToolStripMenuItem.Name = "przeczytajNaGłosToolStripMenuItem";
            this.przeczytajNaGłosToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.przeczytajNaGłosToolStripMenuItem.Text = "Przeczytaj na głos cały tekst";
            this.przeczytajNaGłosToolStripMenuItem.Click += new System.EventHandler(this.przeczytajNaGłosToolStripMenuItem_Click);
            // 
            // przeczytajNaGłosWybranyTekatToolStripMenuItem
            // 
            this.przeczytajNaGłosWybranyTekatToolStripMenuItem.Name = "przeczytajNaGłosWybranyTekatToolStripMenuItem";
            this.przeczytajNaGłosWybranyTekatToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.przeczytajNaGłosWybranyTekatToolStripMenuItem.Text = "Przeczytaj na głos wybrany tekat";
            this.przeczytajNaGłosWybranyTekatToolStripMenuItem.Click += new System.EventHandler(this.przeczytajNaGłosWybranyTekatToolStripMenuItem_Click);
            // 
            // otwórzPlikToolStripMenuItem
            // 
            this.otwórzPlikToolStripMenuItem.Name = "otwórzPlikToolStripMenuItem";
            this.otwórzPlikToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.otwórzPlikToolStripMenuItem.Text = "Otwórz plik";
            this.otwórzPlikToolStripMenuItem.Click += new System.EventHandler(this.otwórzPlikToolStripMenuItem_Click);
            // 
            // zapiszPlikToolStripMenuItem
            // 
            this.zapiszPlikToolStripMenuItem.Name = "zapiszPlikToolStripMenuItem";
            this.zapiszPlikToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.zapiszPlikToolStripMenuItem.Text = "Zapisz plik";
            this.zapiszPlikToolStripMenuItem.Click += new System.EventHandler(this.zapiszPlikToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Karteczki.Properties.Resources.NotatkiTlo;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.richTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "Karteczki";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.RichTextBox richTextBox1;
      private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
      private System.Windows.Forms.ToolStripMenuItem nowaKartkaToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem usuńKartkęToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem pokażNagłówekToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem schowajNagłówekToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem czcionkaToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem kolorToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem oProgramieToolStripMenuItem;
      private System.Windows.Forms.FontDialog fontDialog1;
      private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem przezroczystośćToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem zawszeNaWierzchuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem przesuńTekstDoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lewejStronyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem centrumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prawejStronyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zamknijProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem przeczytajNaGłosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem przeczytajNaGłosWybranyTekatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otwórzPlikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszPlikToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

