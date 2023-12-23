namespace Bisiklet_Paylasim_Sistemi_VTYSPROJE
{
    partial class Form1Kullanicilar
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserAd = new System.Windows.Forms.TextBox();
            this.UsersGuncelle = new System.Windows.Forms.Button();
            this.UsersSil = new System.Windows.Forms.Button();
            this.UsersEkle = new System.Windows.Forms.Button();
            this.txtuserId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.UsersListele = new System.Windows.Forms.Button();
            this.txtUserTel = new System.Windows.Forms.TextBox();
            this.txtUserSoyad = new System.Windows.Forms.TextBox();
            this.txtUserAdres = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.UserTypeComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(934, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "User Ad:";
            // 
            // txtUserAd
            // 
            this.txtUserAd.Location = new System.Drawing.Point(1023, 100);
            this.txtUserAd.Name = "txtUserAd";
            this.txtUserAd.Size = new System.Drawing.Size(144, 22);
            this.txtUserAd.TabIndex = 18;
            // 
            // UsersGuncelle
            // 
            this.UsersGuncelle.Location = new System.Drawing.Point(1214, 376);
            this.UsersGuncelle.Name = "UsersGuncelle";
            this.UsersGuncelle.Size = new System.Drawing.Size(237, 81);
            this.UsersGuncelle.TabIndex = 16;
            this.UsersGuncelle.Text = "Güncelle";
            this.UsersGuncelle.UseVisualStyleBackColor = true;
            this.UsersGuncelle.Click += new System.EventHandler(this.UsersGuncelle_Click);
            // 
            // UsersSil
            // 
            this.UsersSil.Location = new System.Drawing.Point(1214, 263);
            this.UsersSil.Name = "UsersSil";
            this.UsersSil.Size = new System.Drawing.Size(237, 75);
            this.UsersSil.TabIndex = 15;
            this.UsersSil.Text = "Sil";
            this.UsersSil.UseVisualStyleBackColor = true;
            this.UsersSil.Click += new System.EventHandler(this.UsersSil_Click);
            // 
            // UsersEkle
            // 
            this.UsersEkle.Location = new System.Drawing.Point(1214, 154);
            this.UsersEkle.Name = "UsersEkle";
            this.UsersEkle.Size = new System.Drawing.Size(237, 71);
            this.UsersEkle.TabIndex = 14;
            this.UsersEkle.Text = "Ekle";
            this.UsersEkle.UseVisualStyleBackColor = true;
            this.UsersEkle.Click += new System.EventHandler(this.UsersEkle_Click);
            // 
            // txtuserId
            // 
            this.txtuserId.Location = new System.Drawing.Point(1022, 50);
            this.txtuserId.Name = "txtuserId";
            this.txtuserId.Size = new System.Drawing.Size(144, 22);
            this.txtuserId.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(934, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "User Id:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(896, 556);
            this.dataGridView1.TabIndex = 11;
            // 
            // UsersListele
            // 
            this.UsersListele.Location = new System.Drawing.Point(1214, 40);
            this.UsersListele.Name = "UsersListele";
            this.UsersListele.Size = new System.Drawing.Size(237, 76);
            this.UsersListele.TabIndex = 10;
            this.UsersListele.Text = "Listele";
            this.UsersListele.UseVisualStyleBackColor = true;
            this.UsersListele.Click += new System.EventHandler(this.UsersListele_Click);
            // 
            // txtUserTel
            // 
            this.txtUserTel.Location = new System.Drawing.Point(1023, 204);
            this.txtUserTel.Name = "txtUserTel";
            this.txtUserTel.Size = new System.Drawing.Size(144, 22);
            this.txtUserTel.TabIndex = 21;
            // 
            // txtUserSoyad
            // 
            this.txtUserSoyad.Location = new System.Drawing.Point(1022, 154);
            this.txtUserSoyad.Name = "txtUserSoyad";
            this.txtUserSoyad.Size = new System.Drawing.Size(144, 22);
            this.txtUserSoyad.TabIndex = 20;
            // 
            // txtUserAdres
            // 
            this.txtUserAdres.Location = new System.Drawing.Point(1022, 257);
            this.txtUserAdres.Name = "txtUserAdres";
            this.txtUserAdres.Size = new System.Drawing.Size(144, 22);
            this.txtUserAdres.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(934, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "User Soyad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(934, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "User Tel :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(934, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "User Adres:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(934, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 16);
            this.label6.TabIndex = 27;
            this.label6.Text = "User Type :";
            // 
            // UserTypeComboBox
            // 
            this.UserTypeComboBox.FormattingEnabled = true;
            this.UserTypeComboBox.Location = new System.Drawing.Point(1022, 305);
            this.UserTypeComboBox.Name = "UserTypeComboBox";
            this.UserTypeComboBox.Size = new System.Drawing.Size(144, 24);
            this.UserTypeComboBox.TabIndex = 28;
            // 
            // Form1Kullanıcılar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1483, 577);
            this.Controls.Add(this.UserTypeComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUserAdres);
            this.Controls.Add(this.txtUserTel);
            this.Controls.Add(this.txtUserSoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUserAd);
            this.Controls.Add(this.UsersGuncelle);
            this.Controls.Add(this.UsersSil);
            this.Controls.Add(this.UsersEkle);
            this.Controls.Add(this.txtuserId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.UsersListele);
            this.Name = "Form1Kullanıcılar";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1Kullanıcılar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserAd;
        private System.Windows.Forms.Button UsersGuncelle;
        private System.Windows.Forms.Button UsersSil;
        private System.Windows.Forms.Button UsersEkle;
        private System.Windows.Forms.TextBox txtuserId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button UsersListele;
        private System.Windows.Forms.TextBox txtUserTel;
        private System.Windows.Forms.TextBox txtUserSoyad;
        private System.Windows.Forms.TextBox txtUserAdres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox UserTypeComboBox;
    }
}

