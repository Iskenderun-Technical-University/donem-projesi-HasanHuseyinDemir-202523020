using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        Class1 marketotomasyon = new Class1();

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'market_otomasyonDataSet3.urunekle' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.urunekleTableAdapter1.Fill(this.market_otomasyonDataSet3.urunekle);
            // TODO: Bu kod satırı 'market_otomasyonDataSet.urunekle' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.urunekleTableAdapter.Fill(this.market_otomasyonDataSet.urunekle);
            Yenilelistele();
        }
        private void Yenilelistele()
        {
            string cümle = "select *from urunekle";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource=marketotomasyon.listele(adtr2, cümle);
            dataGridView1.Columns[0].HeaderText="URUN ADİ";
            dataGridView1.Columns[1].HeaderText="URUN KODU";
            dataGridView1.Columns[2].HeaderText="URUN SATİŞ FİYATİ";

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
