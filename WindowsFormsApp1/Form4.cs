﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'market_otomasyonDataSet4.urunekle' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.urunekleTableAdapter.Fill(this.market_otomasyonDataSet4.urunekle);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1gecis = new Form1();
            this.Hide();
            form1gecis.ShowDialog();
            this.Close();
        }
    }
}
