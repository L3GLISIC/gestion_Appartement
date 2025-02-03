using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using gestionDashboard.views;

namespace gestionDashboard
{
    public partial class frmGestion : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect, // x-coordinate of upper-left corner
            int nTopRect, // y-coordinate of upper-left corner
            int nRightRect, // x-coordinate of lower-right corner
            int nBottomRect, // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        public frmGestion()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);
            this.IsMdiContainer = true;
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            this.pnlInterface.Controls.Clear();
            frmDashBoard frm = new frmDashBoard()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
            };

            frm.FormBorderStyle = FormBorderStyle.None;
            this.pnlInterface.Controls.Add(frm);
            frm.Show();

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);

            this.pnlInterface.Controls.Clear();
            frmDashBoard frm = new frmDashBoard()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
            };

            frm.FormBorderStyle = FormBorderStyle.None;
            this.pnlInterface.Controls.Add(frm);
            frm.Show();

        }

        private void btnProprietaire_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnProprietaire.Height;
            pnlNav.Top = btnProprietaire.Top;
            pnlNav.Left = btnProprietaire.Left;
            btnProprietaire.BackColor = Color.FromArgb(46, 51, 73);
            btnDashboard.BackColor = Color.FromArgb(24, 30, 54);

            this.pnlInterface.Controls.Clear();
            frmProprietaire frm = new frmProprietaire()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
            };

            frm.FormBorderStyle = FormBorderStyle.None;
            this.pnlInterface.Controls.Add(frm);
            frm.Show();


        }

        private void btnAppartement_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnAppartement.Height;
            pnlNav.Top = btnAppartement.Top;
            pnlNav.Left = btnAppartement.Left;
            btnAppartement.BackColor = Color.FromArgb(46, 51, 73);
            btnDashboard.BackColor = Color.FromArgb(24, 30, 54);

            this.pnlInterface.Controls.Clear();
            frmAppartement frm = new frmAppartement()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
            };

            frm.FormBorderStyle = FormBorderStyle.None;
            this.pnlInterface.Controls.Add(frm);
            frm.Show();
        }

        private void btnLocation_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnLocation.Height;
            pnlNav.Top = btnLocation.Top;
            pnlNav.Left = btnLocation.Left;
            btnLocation.BackColor = Color.FromArgb(46, 51, 73);
            btnDashboard.BackColor = Color.FromArgb(24, 30, 54);

            this.pnlInterface.Controls.Clear();
            frmLocation frm = new frmLocation()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
            };

            frm.FormBorderStyle = FormBorderStyle.None;
            this.pnlInterface.Controls.Add(frm);
            frm.Show();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnSettings.Height;
            pnlNav.Top = btnSettings.Top;
            pnlNav.Left = btnSettings.Left;
            btnSettings.BackColor = Color.FromArgb(46, 51, 73);
            btnDashboard.BackColor = Color.FromArgb(24, 30, 54);

            this.pnlInterface.Controls.Clear();
            frmSettings frm = new frmSettings()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
            };

            frm.FormBorderStyle = FormBorderStyle.None;
            this.pnlInterface.Controls.Add(frm);
            frm.Show();
        }

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDashboard_Leave(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnAppartement_Leave(object sender, EventArgs e)
        {
            btnAppartement.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnProprietaire_Leave(object sender, EventArgs e)
        {
            btnProprietaire.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnLocation_Leave(object sender, EventArgs e)
        {
            btnLocation.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnSettings_Leave(object sender, EventArgs e)
        {
            btnSettings.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
