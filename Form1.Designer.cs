namespace BulanikMantik
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.trackHassaslik = new System.Windows.Forms.TrackBar();
            this.trackMiktar = new System.Windows.Forms.TrackBar();
            this.trackKirlilik = new System.Windows.Forms.TrackBar();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lblDonusHizi = new System.Windows.Forms.Label();
            this.lblSure = new System.Windows.Forms.Label();
            this.lblDeterjan = new System.Windows.Forms.Label();
            this.chartCikislar = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxKurallar = new System.Windows.Forms.ListBox();
            this.lblHassaslikDeger = new System.Windows.Forms.Label();
            this.lblMiktarDeger = new System.Windows.Forms.Label();
            this.lblKirlilikDeger = new System.Windows.Forms.Label();
            this.chartHassaslik = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartMiktar = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartKirlilik = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.trackHassaslik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackMiktar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackKirlilik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCikislar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartHassaslik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMiktar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartKirlilik)).BeginInit();
            this.SuspendLayout();
            // 
            // trackHassaslik
            // 
            this.trackHassaslik.Location = new System.Drawing.Point(12, 35);
            this.trackHassaslik.Maximum = 1000;
            this.trackHassaslik.Name = "trackHassaslik";
            this.trackHassaslik.Size = new System.Drawing.Size(250, 56);
            this.trackHassaslik.TabIndex = 0;
            this.trackHassaslik.TickFrequency = 50;
            this.trackHassaslik.Scroll += new System.EventHandler(this.trackHassaslik_Scroll);
            // 
            // trackMiktar
            // 
            this.trackMiktar.Location = new System.Drawing.Point(18, 255);
            this.trackMiktar.Maximum = 1000;
            this.trackMiktar.Name = "trackMiktar";
            this.trackMiktar.Size = new System.Drawing.Size(250, 56);
            this.trackMiktar.TabIndex = 1;
            this.trackMiktar.TickFrequency = 50;
            this.trackMiktar.Scroll += new System.EventHandler(this.trackMiktar_Scroll);
            // 
            // trackKirlilik
            // 
            this.trackKirlilik.Location = new System.Drawing.Point(400, 318);
            this.trackKirlilik.Maximum = 1000;
            this.trackKirlilik.Name = "trackKirlilik";
            this.trackKirlilik.Size = new System.Drawing.Size(250, 56);
            this.trackKirlilik.TabIndex = 2;
            this.trackKirlilik.TickFrequency = 50;
            this.trackKirlilik.Scroll += new System.EventHandler(this.trackKirlilik_Scroll);
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(18, 464);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(149, 30);
            this.btnHesapla.TabIndex = 3;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // lblDonusHizi
            // 
            this.lblDonusHizi.AutoSize = true;
            this.lblDonusHizi.Location = new System.Drawing.Point(12, 519);
            this.lblDonusHizi.Name = "lblDonusHizi";
            this.lblDonusHizi.Size = new System.Drawing.Size(77, 16);
            this.lblDonusHizi.TabIndex = 4;
            this.lblDonusHizi.Text = "Dönüş Hızı: ";
            this.lblDonusHizi.Click += new System.EventHandler(this.lblDonusHizi_Click);
            // 
            // lblSure
            // 
            this.lblSure.AutoSize = true;
            this.lblSure.Location = new System.Drawing.Point(12, 539);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(41, 16);
            this.lblSure.TabIndex = 5;
            this.lblSure.Text = "Süre: ";
            this.lblSure.Click += new System.EventHandler(this.lblSure_Click);
            // 
            // lblDeterjan
            // 
            this.lblDeterjan.AutoSize = true;
            this.lblDeterjan.Location = new System.Drawing.Point(12, 559);
            this.lblDeterjan.Name = "lblDeterjan";
            this.lblDeterjan.Size = new System.Drawing.Size(64, 16);
            this.lblDeterjan.TabIndex = 6;
            this.lblDeterjan.Text = "Deterjan: ";
            this.lblDeterjan.Click += new System.EventHandler(this.lblDeterjan_Click);
            // 
            // chartCikislar
            // 
            chartArea1.Name = "ChartArea1";
            this.chartCikislar.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartCikislar.Legends.Add(legend1);
            this.chartCikislar.Location = new System.Drawing.Point(389, 13);
            this.chartCikislar.Name = "chartCikislar";
            this.chartCikislar.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            this.chartCikislar.Size = new System.Drawing.Size(522, 273);
            this.chartCikislar.TabIndex = 7;
            this.chartCikislar.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Hassaslık";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Miktar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(405, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Kirlilik";
            // 
            // listBoxKurallar
            // 
            this.listBoxKurallar.FormattingEnabled = true;
            this.listBoxKurallar.ItemHeight = 16;
            this.listBoxKurallar.Location = new System.Drawing.Point(219, 500);
            this.listBoxKurallar.Name = "listBoxKurallar";
            this.listBoxKurallar.Size = new System.Drawing.Size(802, 116);
            this.listBoxKurallar.TabIndex = 11;
            this.listBoxKurallar.SelectedIndexChanged += new System.EventHandler(this.listBoxKurallar_SelectedIndexChanged);
            // 
            // lblHassaslikDeger
            // 
            this.lblHassaslikDeger.AutoSize = true;
            this.lblHassaslikDeger.Location = new System.Drawing.Point(270, 50);
            this.lblHassaslikDeger.Name = "lblHassaslikDeger";
            this.lblHassaslikDeger.Size = new System.Drawing.Size(97, 16);
            this.lblHassaslikDeger.TabIndex = 12;
            this.lblHassaslikDeger.Text = "Hassaslık: 0.00";
            // 
            // lblMiktarDeger
            // 
            this.lblMiktarDeger.AutoSize = true;
            this.lblMiktarDeger.Location = new System.Drawing.Point(276, 270);
            this.lblMiktarDeger.Name = "lblMiktarDeger";
            this.lblMiktarDeger.Size = new System.Drawing.Size(73, 16);
            this.lblMiktarDeger.TabIndex = 13;
            this.lblMiktarDeger.Text = "Miktar: 0.00";
            // 
            // lblKirlilikDeger
            // 
            this.lblKirlilikDeger.AutoSize = true;
            this.lblKirlilikDeger.Location = new System.Drawing.Point(658, 333);
            this.lblKirlilikDeger.Name = "lblKirlilikDeger";
            this.lblKirlilikDeger.Size = new System.Drawing.Size(71, 16);
            this.lblKirlilikDeger.TabIndex = 14;
            this.lblKirlilikDeger.Text = "Kirlilik: 0.00";
            // 
            // chartHassaslik
            // 
            chartArea2.Name = "ChartArea1";
            this.chartHassaslik.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartHassaslik.Legends.Add(legend2);
            this.chartHassaslik.Location = new System.Drawing.Point(18, 79);
            this.chartHassaslik.Name = "chartHassaslik";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartHassaslik.Series.Add(series1);
            this.chartHassaslik.Size = new System.Drawing.Size(349, 123);
            this.chartHassaslik.TabIndex = 15;
            this.chartHassaslik.Text = "chart1";
            // 
            // chartMiktar
            // 
            chartArea3.Name = "ChartArea1";
            this.chartMiktar.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartMiktar.Legends.Add(legend3);
            this.chartMiktar.Location = new System.Drawing.Point(18, 314);
            this.chartMiktar.Name = "chartMiktar";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartMiktar.Series.Add(series2);
            this.chartMiktar.Size = new System.Drawing.Size(332, 134);
            this.chartMiktar.TabIndex = 16;
            this.chartMiktar.Text = "chart2";
            // 
            // chartKirlilik
            // 
            chartArea4.Name = "ChartArea1";
            this.chartKirlilik.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartKirlilik.Legends.Add(legend4);
            this.chartKirlilik.Location = new System.Drawing.Point(408, 352);
            this.chartKirlilik.Name = "chartKirlilik";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartKirlilik.Series.Add(series3);
            this.chartKirlilik.Size = new System.Drawing.Size(344, 132);
            this.chartKirlilik.TabIndex = 17;
            this.chartKirlilik.Text = "chart3";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1033, 639);
            this.Controls.Add(this.chartKirlilik);
            this.Controls.Add(this.chartMiktar);
            this.Controls.Add(this.chartHassaslik);
            this.Controls.Add(this.lblKirlilikDeger);
            this.Controls.Add(this.lblMiktarDeger);
            this.Controls.Add(this.lblHassaslikDeger);
            this.Controls.Add(this.listBoxKurallar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartCikislar);
            this.Controls.Add(this.lblDeterjan);
            this.Controls.Add(this.lblSure);
            this.Controls.Add(this.lblDonusHizi);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.trackKirlilik);
            this.Controls.Add(this.trackMiktar);
            this.Controls.Add(this.trackHassaslik);
            this.Name = "Form1";
            this.Text = "Bulanık Mantık Çamaşır Makinesi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackHassaslik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackMiktar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackKirlilik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCikislar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartHassaslik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMiktar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartKirlilik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackHassaslik;
        private System.Windows.Forms.TrackBar trackMiktar;
        private System.Windows.Forms.TrackBar trackKirlilik;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label lblDonusHizi;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.Label lblDeterjan;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCikislar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxKurallar;
        private System.Windows.Forms.Label lblHassaslikDeger;
        private System.Windows.Forms.Label lblMiktarDeger;
        private System.Windows.Forms.Label lblKirlilikDeger;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartHassaslik;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMiktar;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartKirlilik;
    }
}
