namespace Bisiklet_Paylasim_Sistemi_VTYSPROJE
{
    partial class Form2Istasyonlar
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
            this.txtStationName = new System.Windows.Forms.TextBox();
            this.StationGuncelle = new System.Windows.Forms.Button();
            this.StationSil = new System.Windows.Forms.Button();
            this.StationEkle = new System.Windows.Forms.Button();
            this.txtStationId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.StationListele = new System.Windows.Forms.Button();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CapacityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CapacityNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1033, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Istasyon Ad:";
            // 
            // txtStationName
            // 
            this.txtStationName.Location = new System.Drawing.Point(1118, 176);
            this.txtStationName.Name = "txtStationName";
            this.txtStationName.Size = new System.Drawing.Size(144, 22);
            this.txtStationName.TabIndex = 18;
            // 
            // StationGuncelle
            // 
            this.StationGuncelle.Location = new System.Drawing.Point(1280, 397);
            this.StationGuncelle.Name = "StationGuncelle";
            this.StationGuncelle.Size = new System.Drawing.Size(195, 79);
            this.StationGuncelle.TabIndex = 16;
            this.StationGuncelle.Text = "Güncelle";
            this.StationGuncelle.UseVisualStyleBackColor = true;
            this.StationGuncelle.Click += new System.EventHandler(this.StationGuncelle_Click);
            // 
            // StationSil
            // 
            this.StationSil.Location = new System.Drawing.Point(1280, 287);
            this.StationSil.Name = "StationSil";
            this.StationSil.Size = new System.Drawing.Size(195, 70);
            this.StationSil.TabIndex = 15;
            this.StationSil.Text = "Sil";
            this.StationSil.UseVisualStyleBackColor = true;
            this.StationSil.Click += new System.EventHandler(this.StationSil_Click);
            // 
            // StationEkle
            // 
            this.StationEkle.Location = new System.Drawing.Point(1280, 176);
            this.StationEkle.Name = "StationEkle";
            this.StationEkle.Size = new System.Drawing.Size(195, 72);
            this.StationEkle.TabIndex = 14;
            this.StationEkle.Text = "Ekle";
            this.StationEkle.UseVisualStyleBackColor = true;
            this.StationEkle.Click += new System.EventHandler(this.StationEkle_Click);
            // 
            // txtStationId
            // 
            this.txtStationId.Location = new System.Drawing.Point(1118, 64);
            this.txtStationId.Name = "txtStationId";
            this.txtStationId.Size = new System.Drawing.Size(144, 22);
            this.txtStationId.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1038, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Istasyon Id:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(980, 556);
            this.dataGridView1.TabIndex = 11;
            // 
            // StationListele
            // 
            this.StationListele.Location = new System.Drawing.Point(1280, 67);
            this.StationListele.Name = "StationListele";
            this.StationListele.Size = new System.Drawing.Size(195, 72);
            this.StationListele.TabIndex = 10;
            this.StationListele.Text = "Listele";
            this.StationListele.UseVisualStyleBackColor = true;
            this.StationListele.Click += new System.EventHandler(this.StationListele_Click);
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(1118, 414);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(144, 22);
            this.txtLocation.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1049, 420);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Konum:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1049, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Kapasite:";
            // 
            // CapacityNumericUpDown
            // 
            this.CapacityNumericUpDown.Location = new System.Drawing.Point(1118, 287);
            this.CapacityNumericUpDown.Name = "CapacityNumericUpDown";
            this.CapacityNumericUpDown.Size = new System.Drawing.Size(144, 22);
            this.CapacityNumericUpDown.TabIndex = 24;
            // 
            // Form2Istasyonlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1504, 614);
            this.Controls.Add(this.CapacityNumericUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtStationName);
            this.Controls.Add(this.StationGuncelle);
            this.Controls.Add(this.StationSil);
            this.Controls.Add(this.StationEkle);
            this.Controls.Add(this.txtStationId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.StationListele);
            this.Name = "Form2Istasyonlar";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CapacityNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStationName;
        private System.Windows.Forms.Button StationGuncelle;
        private System.Windows.Forms.Button StationSil;
        private System.Windows.Forms.Button StationEkle;
        private System.Windows.Forms.TextBox txtStationId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button StationListele;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown CapacityNumericUpDown;
    }
}