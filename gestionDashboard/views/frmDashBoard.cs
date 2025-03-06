using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestion.Model;
using System.Windows.Forms.DataVisualization.Charting;

namespace gestionDashboard.views
{
    public partial class frmDashBoard : Form
    {
        BdLocationContext db = new BdLocationContext();
        public frmDashBoard()
        {
            InitializeComponent();
            lbNbrAppartement.Text = db.appartements.Count().ToString();
            lblProprietaires.Text = db.proprietaires.Count().ToString();
            lblLocations.Text = db.locations.Count().ToString();
            LoadChart();
        }

        private void frmDashBoard_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void lbNbrAppartement_Click(object sender, EventArgs e)
        {

        }

        private void LoadChart()
        {
            // Nettoyer les séries et zones existantes
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();
            chart1.Legends.Clear();

            // Ajouter une zone de tracé
            ChartArea chartArea = new ChartArea();
            chart1.ChartAreas.Add(chartArea);

            // Créer une légende
            Legend legend = new Legend
            {
                Docking = Docking.Top,
                ForeColor = System.Drawing.Color.White
            };
            chart1.Legends.Add(legend);

            // Créer une série de données
            Series series = new Series
            {
                Name = "Statistiques",
                ChartType = SeriesChartType.Column
            };

            // Ajouter les valeurs avec des couleurs personnalisées
            series.Points.Add(new DataPoint(0, db.appartements.Count()) { Color = System.Drawing.Color.FromArgb(0, 146, 249), AxisLabel = "Appartements" });
            series.Points.Add(new DataPoint(1, db.proprietaires.Count()) { Color = System.Drawing.Color.FromArgb(50, 226, 178), AxisLabel = "Propriétaires" });
            series.Points.Add(new DataPoint(2, db.locations.Count()) { Color = System.Drawing.Color.FromArgb(138, 43, 226), AxisLabel = "Locations" });

            // Ajouter la série au graphique
            chart1.Series.Add(series);

            // Personnalisation du graphique
            chart1.ChartAreas[0].BackColor = System.Drawing.Color.White; // Fond blanc
            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chart1.ChartAreas[0].AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chart1.ChartAreas[0].AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
        }

    }
}
