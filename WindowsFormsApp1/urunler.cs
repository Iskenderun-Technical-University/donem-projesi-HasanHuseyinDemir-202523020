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
    public partial class urunler : Form
    {
        Class1 marketotomasyon=new Class1 ();
        public urunler()
        {
            InitializeComponent();
        }

        private void urunler_Load(object sender, EventArgs e)
        {
            Yenilelistele();
        }

        private void Yenilelistele()
        {
            string cümle = "select *from urunekle";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource=marketotomasyon.listele(adtr2, cümle);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form1gecis = new Form1();
            this.Hide();
            form1gecis.ShowDialog();
            this.Close();
        }
    }
}
