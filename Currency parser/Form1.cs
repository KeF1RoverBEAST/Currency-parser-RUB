using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Currency_parser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            refresh();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        void refresh()
        {
            try
            {
                System.Net.WebClient WC = new System.Net.WebClient();
                //([0-9]+\.[0-9]+)
                string usd = "USD: " + System.Text.RegularExpressions.Regex.Match(
                    WC.DownloadString("https://www.sberometer.ru/cbr/"),
                    @"<span class=""bcsblock__value"" id=""bcs_usd_sell"">([0-9]+\,[0-9]+)</span>").Groups[1].Value;
                string eur = " EUR: " + System.Text.RegularExpressions.Regex.Match(
                WC.DownloadString("https://www.sberometer.ru/cbr/"),
                @"<span class=""bcsblock__value"" id=""bcs_eur_sell"">([0-9]+\,[0-9]+)</span>").Groups[1].Value;
                NI_icon.Text = usd + eur;
            }
            catch { }
        }
        private void refreshToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void authorSiteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Process.Start("http://kef1r.ru");
        }
    }
}
