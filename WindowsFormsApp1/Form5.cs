using System;
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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1gecis = new Form1();
            this.Hide();
            form1gecis.ShowDialog();
            this.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'market_otomasyonDataSet7.urunekle' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.urunekleTableAdapter.Fill(this.market_otomasyonDataSet7.urunekle);

        }
    }
}
