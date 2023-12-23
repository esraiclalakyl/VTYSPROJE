using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bisiklet_Paylasim_Sistemi_VTYSPROJE
{
    public partial class Form1Kullanicilar : Form
    {
        public Form1Kullanicilar()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost;" +
           " port=5432; Database= VTYSPROJE; user ID=postgres; password=667887");

        private void UsersListele_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from users";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void UsersEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("insert into users (userid, firstname, lastname, phone, address, usertype) values" +
                "(@p1,@p2,@3,@p4,@p5,@p6)", baglanti);
            komut1.Parameters.AddWithValue("@p1",int.Parse(txtuserId.Text));
            komut1.Parameters.AddWithValue("@p2",txtUserAd.Text);
            komut1.Parameters.AddWithValue("@p3",txtUserSoyad.Text);
            komut1.Parameters.AddWithValue("@p4",txtUserTel.Text);
            komut1.Parameters.AddWithValue("@p5",txtUserAdres.Text);
            komut1.Parameters.AddWithValue("@p6",UserTypeComboBox.SelectedItem.ToString());
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kullanıcı ekleme işlemi başarılı bir şekilde gerçekleşti.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1Kullanıcılar_Load(object sender, EventArgs e)
        {
            UserTypeComboBox.Items.Add("Regular");
            UserTypeComboBox.Items.Add("Premium");
            UserTypeComboBox.SelectedIndex = 0; // 0: Regular, 1: Premium
        }

        private void UsersSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("delete from users where userid = @p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", int.Parse(txtuserId.Text));
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kullanıcı silme işlemi başarılı bir şekilde gerçekleşti.", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
        }

        private void UsersGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut3 = new NpgsqlCommand("update users set firstname=@p1, lastname=@p2, phone=@p3, address=@p4, usertype=@p5 where userid=@p6", baglanti);
            
            komut3.Parameters.AddWithValue("@p1", txtUserAd.Text);
            komut3.Parameters.AddWithValue("@p2", txtUserSoyad.Text);
            komut3.Parameters.AddWithValue("@p3", txtUserTel.Text);
            komut3.Parameters.AddWithValue("@p4", txtUserAdres.Text);
            komut3.Parameters.AddWithValue("@p5", UserTypeComboBox.SelectedItem.ToString());
            komut3.Parameters.AddWithValue("@p6", int.Parse(txtuserId.Text));
            komut3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kullanıcı güncelleme işlemi başarılı bir şekilde gerçekleşti.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
