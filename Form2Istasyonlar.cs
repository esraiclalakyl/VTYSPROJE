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
    public partial class Form2Istasyonlar : Form
    {
        public Form2Istasyonlar()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost;" +
          " port=5432; Database= VTYSPROJE; user ID=postgres; password=667887");


        private void StationListele_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from bike_stations";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void StationEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("insert into bike_stations (stationid, stationname, capacity, location) values" +
                "(@p1,@p2,@3,@p4)", baglanti);
            komut1.Parameters.AddWithValue("@p1", int.Parse(txtStationId.Text));
            komut1.Parameters.AddWithValue("@p2", txtStationName.Text);
            komut1.Parameters.AddWithValue("@p3", int.Parse(CapacityNumericUpDown.Value.ToString()));
            komut1.Parameters.AddWithValue("@p4", txtLocation.Text);           
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("İstasyon ekleme işlemi başarılı bir şekilde gerçekleşti.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void StationSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("delete from bike_stations where stationid = @p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", int.Parse(txtStationId.Text));
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("İstasyon silme işlemi başarılı bir şekilde gerçekleşti.", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
        }

        private void StationGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut3 = new NpgsqlCommand("update bike_stations set stationname=@p1, capacity=@p2, location=@p3 where stationid=@p4", baglanti);

            komut3.Parameters.AddWithValue("@p1", txtStationName.Text);
            komut3.Parameters.AddWithValue("@p2", int.Parse(CapacityNumericUpDown.Value.ToString()));
            komut3.Parameters.AddWithValue("@p3", txtLocation.Text);
            komut3.Parameters.AddWithValue("@p4", int.Parse(txtStationId.Text));
            komut3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("İstasyon güncelleme işlemi başarılı bir şekilde gerçekleşti.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
