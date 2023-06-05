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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-260HDTK;Initial Catalog=market_otomasyon;Integrated Security=True");
        DataSet daset = new DataSet();
        private void sepetlistele()
        {
            SqlDataAdapter adtr = new SqlDataAdapter("select *from Sepet", baglanti);
            adtr.Fill(daset, "Sepet");
            dataGridView1.DataSource = daset.Tables["Sepet"];
            baglanti.Close();
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            this.Hide();
            form5.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.ShowDialog();
        }
        private void hesapla()
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select sum(toplamfiyati) from Sepet", baglanti);
                lblGenelToplam.Text=komut.ExecuteScalar()+"TL";
                baglanti.Close() ;
            }
            catch (Exception)
            {

            }   
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'market_otomasyonDataSet6.Sepet' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.sepetTableAdapter1.Fill(this.market_otomasyonDataSet6.Sepet);
            // TODO: Bu kod satırı 'market_otomasyonDataSet5.Sepet' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.sepetTableAdapter.Fill(this.market_otomasyonDataSet5.Sepet);
            sepetlistele();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
            urunler urunler = new urunler();
            this.Hide();
            urunler.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            this.Hide();
            form3.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            this.Hide();
            form4.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Temizle();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from urunekle where urunkodu like '"+textBox1.Text+"'", baglanti);
            SqlDataReader read = komut.ExecuteReader();

            while (read.Read())
            {
                textBox3.Text=read["urunadi"].ToString();
                textBox4.Text=read["urunsatiş"].ToString();
            }
            baglanti.Close();
        }

        private void Temizle()
        {
            if (textBox1.Text=="")
            {
                foreach (Control item in groupBox1.Controls)
                {
                    if (item is TextBox)
                    {
                        if (item != textBox2)
                        {
                            item.Text="";
                        }
                    }




                }
            }
        }
        bool durum;
        private void kodkontrol()
        {
            durum=true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from Sepet", baglanti);
            SqlDataReader read =komut.ExecuteReader();
            while (read.Read())
            {
                if (textBox1.Text==read["urunkodu"].ToString())
                {
                    durum= false;
                }
            }
            baglanti.Close() ;
        }
        private void button9_Click(object sender, EventArgs e)
        {
             kodkontrol();
            if (durum==true)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into Sepet(urunkodu,urunadi,urunmiktar,satişfiyati,toplamfiyati) values(@urunkodu,@urunadi,@urunmiktar,@satişfiyati,@toplamfiyati)", baglanti);
                komut.Parameters.AddWithValue("@urunkodu", textBox1.Text);
                komut.Parameters.AddWithValue("@urunadi", textBox3.Text);
                komut.Parameters.AddWithValue("@urunmiktar", int.Parse(textBox2.Text));
                komut.Parameters.AddWithValue("@satişfiyati", double.Parse(textBox4.Text));
                komut.Parameters.AddWithValue("@toplamfiyati", double.Parse(textBox5.Text));
                komut.ExecuteNonQuery();
                baglanti.Close();

            }
            else
            {

                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("update Sepet set urunmiktar=urunmiktar +'"+int.Parse(textBox2.Text)+"'where urunkodu='"+(textBox1.Text)+"'", baglanti);
                komut2.ExecuteNonQuery();

                SqlCommand komut3 = new SqlCommand("update Sepet set toplamfiyati=urunmiktar*satişfiyati where urunkodu='"+(textBox1.Text)+"'", baglanti);

                komut3.ExecuteNonQuery();
                
            }


            textBox2.Text="1";
            daset.Tables["Sepet"].Clear();
            sepetlistele();
            hesapla();

            if (textBox1.Text=="")
            {
                foreach (Control item in groupBox1.Controls)
                {
                    if (item is TextBox)
                    {
                        if (item != textBox2)
                        {
                            item.Text="";
                        }
                    }




                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox5.Text=(double.Parse(textBox2.Text) * double.Parse(textBox4.Text)).ToString();
            }
            catch (Exception)
            {

                
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox5.Text=(double.Parse(textBox2.Text) * double.Parse(textBox4.Text)).ToString();
            }
            catch (Exception)
            {

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from Sepet where urunkodu='"+dataGridView1.CurrentRow.Cells["urunkodu"].Value.ToString()+"'",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün Sepetten Çıkarıldı");
            daset.Tables["Sepet"].Clear();

            sepetlistele();
            hesapla();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from Sepet " ,baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Satış İptal Edildi");
            daset.Tables["Sepet"].Clear();
            sepetlistele();
            hesapla();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            for(int i=0;i<dataGridView1.Rows.Count-1;i++)
            {
                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("update urunekle set urunmiktar=urunmiktar -'"+int.Parse(dataGridView1.Rows[i].Cells["urunmiktar"].Value.ToString())+"'where urunkodu='"+dataGridView1.Rows[i].Cells["urunkodu"].Value.ToString()+"'", baglanti);
                komut2.ExecuteNonQuery();
                baglanti.Close();

            }
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from Sepet ", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["Sepet"].Clear();
            sepetlistele();
            hesapla();
        }
    }
    }

