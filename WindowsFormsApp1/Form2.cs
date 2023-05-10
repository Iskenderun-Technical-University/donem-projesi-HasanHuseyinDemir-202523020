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
    public partial class Form2 : Form
    {
        Class1 market_otomasyon=new Class1();
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1gecis=new Form1();
            this.Hide();

            form1gecis.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cumle = "insert into urunekle(urunadi,urunkodu,urunaliş,urunsatiş) values(@urunadi,@urunkodu,@urunaliş,@urunsatiş)";
            SqlCommand komut2 = new SqlCommand();

            komut2.Parameters.AddWithValue("@urunadi", txtad.Text);
            komut2.Parameters.AddWithValue("@urunkodu", txtkod.Text);
            komut2.Parameters.AddWithValue("@urunaliş", txtaliş.Text);
            komut2.Parameters.AddWithValue("@urunsatiş", txtsatiş.Text);
            market_otomasyon.ekle_sil_güncelle(komut2,cumle);
            foreach (Control item in Controls) if (item is TextBox) item.Text="";

        }
    }
}
