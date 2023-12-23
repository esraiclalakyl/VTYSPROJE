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

namespace Bisiklet_Paylasim_Sistemi_VTYSPROJE
{
    public partial class Form3Bisikletler : Form
    {
        public Form3Bisikletler()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost;" +
       " port=5432; Database= VTYSPROJE; user ID=postgres; password=667887");



        private void BikesListele_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from bikes";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void BikesEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("insert into bikes (bikeid, stationid, biketypeid, status) values" +
                "(@p1,@p2,@3,@p4)", baglanti);
            komut1.Parameters.AddWithValue("@p1", int.Parse(txtBikeId.Text.ToString()));
            komut1.Parameters.AddWithValue("@p2", int.Parse(StationIdComboBox.SelectedValue.ToString()));
            komut1.Parameters.AddWithValue("@p3", int.Parse(BikeTypeIdComboBox.SelectedValue.ToString()));
            komut1.Parameters.AddWithValue("@p4", BikeStatusComboBox.SelectedItem.ToString());
          
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Bisiklet ekleme işlemi başarılı bir şekilde gerçekleşti.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form3Bisikletler_Load(object sender, EventArgs e)
        {

            baglanti.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from bike_stations", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            StationIdComboBox.DisplayMember = "stationname";
            StationIdComboBox.ValueMember = "stationid";
            StationIdComboBox.DataSource = dt;


            BikeStatusComboBox.Items.Add("Kullanılamaz");
            BikeStatusComboBox.Items.Add("Kullanımda");
            BikeStatusComboBox.Items.Add("Kullanılabilir");
            BikeStatusComboBox.SelectedIndex = 0;

            da = new NpgsqlDataAdapter("select * from biketypes", baglanti);
            dt = new DataTable();
            da.Fill(dt);
            BikeTypeIdComboBox.DisplayMember = "typename";
            BikeTypeIdComboBox.ValueMember = "biketypeid";
            BikeTypeIdComboBox.DataSource = dt;

            baglanti.Close();
           



        }

        private void BikesSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("delete from bikes where bikeid = @p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", int.Parse(txtBikeId.Text));
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Bisiklet silme işlemi başarılı bir şekilde gerçekleşti.", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
        }

        private void BikesGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut3 = new NpgsqlCommand("update bikes set stationid=@p1, biketypeid=@p2, status=@p3 where bikeid=@p4", baglanti);                        
            komut3.Parameters.AddWithValue("@p1", int.Parse(StationIdComboBox.SelectedValue.ToString()));
            komut3.Parameters.AddWithValue("@p2", int.Parse(BikeTypeIdComboBox.SelectedValue.ToString()));
            komut3.Parameters.AddWithValue("@p3", BikeStatusComboBox.SelectedItem.ToString());
            komut3.Parameters.AddWithValue("@p4", int.Parse(txtBikeId.Text.ToString()));
            komut3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Bisiklet güncelleme işlemi başarılı bir şekilde gerçekleşti.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
