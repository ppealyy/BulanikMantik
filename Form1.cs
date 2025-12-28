using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BulanikMantik.Models;

namespace BulanikMantik
{
    public partial class Form1 : Form
    {
        private FuzzyInferenceSystem fuzzySystem;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fuzzySystem = FuzzyInitializer.CreateSystem();
            UpdateTrackBarLabels();
            DrawInputMembershipFunctions(); // Giriş grafikleri çiz
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            var inputs = new Dictionary<string, double>
            {
                ["Hassaslik"] = trackHassaslik.Value / 100.0,
                ["Miktar"] = trackMiktar.Value / 100.0,
                ["Kirlilik"] = trackKirlilik.Value / 100.0
            };

            var results = fuzzySystem.Evaluate(inputs);

            lblDonusHizi.Text = $"Dönüş Hızı: {results["DonusHizi"]:0.00}";
            lblSure.Text = $"Süre: {results["Sure"]:0.00}";
            lblDeterjan.Text = $"Deterjan: {results["Deterjan"]:0.00} gr";

            DrawChart(results);

            listBoxKurallar.Items.Clear();
            var triggeredRules = fuzzySystem.GetTriggeredRules(inputs);
            foreach (var ruleText in triggeredRules)
            {
                listBoxKurallar.Items.Add(ruleText);
            }
        }

        private void DrawChart(Dictionary<string, double> results)
        {
            chartCikislar.Series.Clear();
            chartCikislar.Titles.Clear();

            chartCikislar.Titles.Add("Çıkış Sonuçları");

            var series = chartCikislar.Series.Add("Değerler");
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            series.Points.AddXY("Dönüş Hızı", results["DonusHizi"]);
            series.Points.AddXY("Süre", results["Sure"]);
            series.Points.AddXY("Deterjan", results["Deterjan"]);
        }

        private void listBoxKurallar_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void trackHassaslik_Scroll(object sender, EventArgs e)
        {
            lblHassaslikDeger.Text = $"Hassaslık: {trackHassaslik.Value / 100.0:0.00}";
            DrawInputMembershipFunctions();
        }

        private void trackMiktar_Scroll(object sender, EventArgs e)
        {
            lblMiktarDeger.Text = $"Miktar: {trackMiktar.Value / 100.0:0.00}";
            DrawInputMembershipFunctions();
        }

        private void trackKirlilik_Scroll(object sender, EventArgs e)
        {
            lblKirlilikDeger.Text = $"Kirlilik: {trackKirlilik.Value / 100.0:0.00}";
            DrawInputMembershipFunctions();
        }

        private void UpdateTrackBarLabels()
        {
            trackHassaslik_Scroll(null, null);
            trackMiktar_Scroll(null, null);
            trackKirlilik_Scroll(null, null);
        }

        private void DrawInputMembershipFunctions()
        {
            DrawMembership(chartHassaslik, fuzzySystem.Inputs["Hassaslik"], trackHassaslik.Value / 100.0);
            DrawMembership(chartMiktar, fuzzySystem.Inputs["Miktar"], trackMiktar.Value / 100.0);
            DrawMembership(chartKirlilik, fuzzySystem.Inputs["Kirlilik"], trackKirlilik.Value / 100.0);
        }

        private void DrawMembership(System.Windows.Forms.DataVisualization.Charting.Chart chart, FuzzyVariable variable, double value)
        {
            chart.Series.Clear();
            chart.ChartAreas[0].AxisX.Minimum = 0;
            chart.ChartAreas[0].AxisX.Maximum = 10;
            chart.ChartAreas[0].AxisY.Minimum = 0;
            chart.ChartAreas[0].AxisY.Maximum = 1.1;

            foreach (var set in variable.Sets)
            {
                var series = chart.Series.Add(set.Name);
                series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

                if (set.Type == "triangle")
                {
                    series.Points.AddXY(set.Points[0], 0);
                    series.Points.AddXY(set.Points[1], 1);
                    series.Points.AddXY(set.Points[2], 0);
                }
                else if (set.Type == "trapezoid")
                {
                    series.Points.AddXY(set.Points[0], 0);
                    series.Points.AddXY(set.Points[1], 1);
                    series.Points.AddXY(set.Points[2], 1);
                    series.Points.AddXY(set.Points[3], 0);
                }
            }

            var valueSeries = chart.Series.Add("SeçilenDeğer");
            valueSeries.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            valueSeries.Color = System.Drawing.Color.Red;
            valueSeries.BorderWidth = 2;
            valueSeries.Points.AddXY(value, 0);
            valueSeries.Points.AddXY(value, 1);
        }

        private void lblDonusHizi_Click(object sender, EventArgs e)
        {

        }

        private void lblSure_Click(object sender, EventArgs e)
        {

        }

        private void lblDeterjan_Click(object sender, EventArgs e)
        {

        }
    }
}
