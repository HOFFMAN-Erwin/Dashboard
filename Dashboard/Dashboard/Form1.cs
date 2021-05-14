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

namespace Dashboard
{
    public partial class Form1 : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(

            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );
        
        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = BtnDashboard.Height;
            pnlNav.Top = BtnDashboard.Top;
            pnlNav.Left = BtnDashboard.Left;
            BtnDashboard.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            pnlNav.Height = BtnDashboard.Height;
            pnlNav.Top = BtnDashboard.Top;
            pnlNav.Left = BtnDashboard.Left;
            BtnDashboard.BackColor = Color.FromArgb(46, 51, 73);

        }

        private void BtnAnalytics_Click(object sender, EventArgs e)
        {
            pnlNav.Height = BtnAnalytics.Height;
            pnlNav.Top = BtnAnalytics.Top;
            BtnAnalytics.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void BtnCalendar_Click(object sender, EventArgs e)
        {
            pnlNav.Height = BtnCalendar.Height;
            pnlNav.Top = BtnCalendar.Top;
            BtnCalendar.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void BtnContact_Click(object sender, EventArgs e)
        {
            pnlNav.Height = BtnContact.Height;
            pnlNav.Top = BtnContact.Top;
            BtnContact.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            pnlNav.Height = BtnSettings.Height;
            pnlNav.Top = BtnSettings.Top;
            BtnSettings.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void BtnDashboard_Leave(object sender, EventArgs e)
        {
            BtnDashboard.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void BtnAnalytics_Leave(object sender, EventArgs e)
        {
            BtnAnalytics.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void BtnCalendar_Leave(object sender, EventArgs e)
        {
            BtnCalendar.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void BtnContact_Leave(object sender, EventArgs e)
        {
            BtnContact.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void BtnSettings_Leave(object sender, EventArgs e)
        {
            BtnSettings.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
