using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace _331YektaAL2.DönemPerformans
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public static Form1 frm1 = new Form1();
        public void listele()
        {
            SQLiteConnection baglanti = new SQLiteConnection("Data Source=C:\\Users\\Yekta\\source\\repos\\331YektaAL2.DönemPerformans\\bin\\Debug\\CafeRestorant.db;version=3");
            baglanti.Open();
            SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT * FROM Bilgi", baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds, "Bilgi");
            dataGridView1.DataSource = ds.Tables["Bilgi"];
            baglanti.Close();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SQLiteConnection baglanti = new SQLiteConnection("Data Source=C:\\Users\\Yekta\\source\\repos\\331YektaAL2.DönemPerformans\\bin\\Debug\\CafeRestorant.db;version=3");
            baglanti.Open();
            SQLiteCommand komut = new SQLiteCommand();
            komut.Connection = baglanti;
            komut.CommandText = "DELETE FROM Bilgi WHERE MusNo='" + textBox6.Text + "'";
            komut.ExecuteNonQuery();
            baglanti.Close();
            textBox6.Clear();
            listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLiteConnection baglanti = new SQLiteConnection("Data Source=C:\\Users\\Yekta\\source\\repos\\331YektaAL2.DönemPerformans\\bin\\Debug\\CafeRestorant.db;version=3");
            baglanti.Open();
            SQLiteCommand komut = new SQLiteCommand();
            komut.Connection = baglanti;
            komut.CommandText = "INSERT INTO Bilgi(MasaNo,Icecek,Yiyecek,Tatli,Hesap) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();            
            komut.ExecuteNonQuery();
            baglanti.Close();
            listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            SQLiteConnection baglanti = new SQLiteConnection("Data Source=C:\\Users\\Yekta\\source\\repos\\331YektaAL2.DönemPerformans\\bin\\Debug\\CafeRestorant.db;version=3");
            baglanti.Open();
            SQLiteCommand komut = new SQLiteCommand();komut.Connection = baglanti;
            komut.CommandText ="UPDATE Bilgi SET MasaNo='" + textBox1.Text + "',Icecek ='" + textBox2.Text + "',Yiyecek='" + textBox3.Text + "',Tatli='" + textBox4.Text + "',Hesap='" + textBox5.Text + "' " + "WHERE MusNo='" + textBox6.Text + "'";
            komut.ExecuteNonQuery();
            baglanti.Close();
            listele();
        }
    }
}
