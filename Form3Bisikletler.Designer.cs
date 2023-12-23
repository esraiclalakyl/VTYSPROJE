namespace Bisiklet_Paylasim_Sistemi_VTYSPROJE
{
    partial class Form3Bisikletler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.BikesGuncelle = new System.Windows.Forms.Button();
            this.BikesSil = new System.Windows.Forms.Button();
            this.BikesEkle = new System.Windows.Forms.Button();
            this.txtBikeId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BikesListele = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.StationIdComboBox = new System.Windows.Forms.ComboBox();
            this.BikeTypeIdComboBox = new System.Windows.Forms.ComboBox();
            this.BikeStatusComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(898, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Istasyon Id:";
            // 
            // BikesGuncelle
            // 
            this.BikesGuncelle.Location = new System.Drawing.Point(1170, 366);
            this.BikesGuncelle.Name = "BikesGuncelle";
            this.BikesGuncelle.Size = new System.Drawing.Size(196, 69);
            this.BikesGuncelle.TabIndex = 16;
            this.BikesGuncelle.Text = "Güncelle";
            this.BikesGuncelle.UseVisualStyleBackColor = true;
            this.BikesGuncelle.Click += new System.EventHandler(this.BikesGuncelle_Click);
            // 
            // BikesSil
            // 
            this.BikesSil.Location = new System.Drawing.Point(1170, 260);
            this.BikesSil.Name = "BikesSil";
            this.BikesSil.Size = new System.Drawing.Size(196, 74);
            this.BikesSil.TabIndex = 15;
            this.BikesSil.Text = "Sil";
            this.BikesSil.UseVisualStyleBackColor = true;
            this.BikesSil.Click += new System.EventHandler(this.BikesSil_Click);
            // 
            // BikesEkle
            // 
            this.BikesEkle.Location = new System.Drawing.Point(1170, 163);
            this.BikesEkle.Name = "BikesEkle";
            this.BikesEkle.Size = new System.Drawing.Size(196, 75);
            this.BikesEkle.TabIndex = 14;
            this.BikesEkle.Text = "Ekle";
            this.BikesEkle.UseVisualStyleBackColor = true;
            this.BikesEkle.Click += new System.EventHandler(this.BikesEkle_Click);
            // 
            // txtBikeId
            // 
            this.txtBikeId.Location = new System.Drawing.Point(982, 57);
            this.txtBikeId.Name = "txtBikeId";
            this.txtBikeId.Size = new System.Drawing.Size(144, 22);
            this.txtBikeId.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(890, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Bisiklet Id:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(852, 509);
            this.dataGridView1.TabIndex = 11;
            // 
            // BikesListele
            // 
            this.BikesListele.Location = new System.Drawing.Point(1170, 57);
            this.BikesListele.Name = "BikesListele";
            this.BikesListele.Size = new System.Drawing.Size(196, 76);
            this.BikesListele.TabIndex = 10;
            this.BikesListele.Text = "Listele";
            this.BikesListele.UseVisualStyleBackColor = true;
            this.BikesListele.Click += new System.EventHandler(this.BikesListele_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(889, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Bisiklet Tipi Id:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(898, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Durumu:";
            // 
            // StationIdComboBox
            // 
            this.StationIdComboBox.FormattingEnabled = true;
            this.StationIdComboBox.Location = new System.Drawing.Point(982, 163);
            this.StationIdComboBox.Name = "StationIdComboBox";
            this.StationIdComboBox.Size = new System.Drawing.Size(144, 24);
            this.StationIdComboBox.TabIndex = 24;
            // 
            // BikeTypeIdComboBox
            // 
            this.BikeTypeIdComboBox.FormattingEnabled = true;
            this.BikeTypeIdComboBox.Location = new System.Drawing.Point(982, 260);
            this.BikeTypeIdComboBox.Name = "BikeTypeIdComboBox";
            this.BikeTypeIdComboBox.Size = new System.Drawing.Size(144, 24);
            this.BikeTypeIdComboBox.TabIndex = 25;
            // 
            // BikeStatusComboBox
            // 
            this.BikeStatusComboBox.FormattingEnabled = true;
            this.BikeStatusComboBox.Location = new System.Drawing.Point(982, 366);
            this.BikeStatusComboBox.Name = "BikeStatusComboBox";
            this.BikeStatusComboBox.Size = new System.Drawing.Size(144, 24);
            this.BikeStatusComboBox.TabIndex = 26;
            // 
            // Form3Bisikletler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 570);
            this.Controls.Add(this.BikeStatusComboBox);
            this.Controls.Add(this.BikeTypeIdComboBox);
            this.Controls.Add(this.StationIdComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BikesGuncelle);
            this.Controls.Add(this.BikesSil);
            this.Controls.Add(this.BikesEkle);
            this.Controls.Add(this.txtBikeId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BikesListele);
            this.Name = "Form3Bisikletler";
            this.Text = "Form3Bisikletler";
            this.Load += new System.EventHandler(this.Form3Bisikletler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BikesGuncelle;
        private System.Windows.Forms.Button BikesSil;
        private System.Windows.Forms.Button BikesEkle;
        private System.Windows.Forms.TextBox txtBikeId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BikesListele;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox StationIdComboBox;
        private System.Windows.Forms.ComboBox BikeTypeIdComboBox;
        private System.Windows.Forms.ComboBox BikeStatusComboBox;
    }
}