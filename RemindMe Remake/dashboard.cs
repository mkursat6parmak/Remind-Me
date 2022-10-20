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

namespace RemindMe_Remake
{
    public partial class dashboard : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn (int nLeftRect, int nTopRect,int nRightRect,int nBottomRect,int nWidthEllipse,int nHeightEllipse);
        public dashboard()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav2.Height = btnDashboard.Height;
            pnlNav2.Top = btnDashboard.Top;
            pnlNav2.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pnlNav2.Height = btnDashboard.Height;
            pnlNav2.Top = btnDashboard.Top;
            pnlNav2.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
        }

        private void btnFilm_Click(object sender, EventArgs e)
        {
            pnlNav2.Height = btnFilm.Height;
            pnlNav2.Top = btnFilm.Top;
            pnlNav2.Left = btnFilm.Left;
            btnFilm.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnDizi_Click(object sender, EventArgs e)
        {
            pnlNav2.Height = btnDizi.Height;
            pnlNav2.Top = btnDizi.Top;
            pnlNav2.Left = btnDizi.Left;
            btnDizi.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnNot_Click(object sender, EventArgs e)
        {
            pnlNav2.Height = btnNot.Height;
            pnlNav2.Top = btnNot.Top;
            pnlNav2.Left = btnNot.Left;
            btnNot.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnTakvim_Click(object sender, EventArgs e)
        {
            pnlNav2.Height = btnTakvim.Height;
            pnlNav2.Top = btnTakvim.Top;
            pnlNav2.Left = btnTakvim.Left;
            btnTakvim.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnDashboard_Leave(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnFilm_Leave(object sender, EventArgs e)
        {
            btnFilm.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnDizi_Leave(object sender, EventArgs e)
        {
            btnDizi.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnNot_Leave(object sender, EventArgs e)
        {
            btnNot.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnTakvim_Leave(object sender, EventArgs e)
        {
            btnTakvim.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
