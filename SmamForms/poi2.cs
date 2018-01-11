using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using CefSharp;
using CefSharp.WinForms;

namespace SmamForms
{
    public partial class poi2 : Form
    {
        private ChromiumWebBrowser chromeBrowser;
        private string city;

        public poi2()
        {
            InitializeComponent();
            CenterToScreen();
            try
            {
                AddFonts();
            }
            catch (Exception exception)
            {
                ExceptionToText ex = new ExceptionToText(exception.ToString());
            }
            setbackground();
            saveUserSettings settings = new saveUserSettings();
            city = settings.getCity();
            InitializeChromium();
        }

        private void AddFonts()
        {
            string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
            Console.WriteLine(RunningPath);
            PrivateFontCollection p = new PrivateFontCollection();
            p.AddFontFile(RunningPath + @"Reitam.otf");
            p.AddFontFile(RunningPath + @"Lato.ttf");
            foreach (Control c in Controls)
            {
                c.Font = new Font(p.Families[0], 12, FontStyle.Regular);
                if (c == comboBox1)
                {
                    c.Font = new Font(p.Families[0], 10, FontStyle.Regular);
                }
            }
        }

        private void setbackground()
        {
            this.BackColor = Color.FromArgb(248, 248, 248);
            foreach (Control item in Controls)
            {
                item.ForeColor = Color.FromArgb(248, 248, 248);
            }
            comboBox1.BackColor = Color.White;
            comboBox1.ForeColor = Color.Black;
            comboBox1.SelectedIndex = 0;
        }
        public void InitializeChromium()
        {
            
            CefSettings settings = new CefSettings();
            settings.UserAgent = "Mozilla/5.0 (iPhone; CPU iPhone OS 6_0 like Mac OS X) AppleWebKit/536.26 (KHTML, like Gecko) Version/6.0 Mobile/10A5376e Safari/8536.25";//regel die ervoor zorgt dat websites onze browser als telefoon zien
            
            if (Cef.IsInitialized) { } else
            {
                Cef.Initialize(settings);
            }
            
            
            string url = "https://www.google.nl/maps/search/" + city + "+"  + comboBox1.SelectedItem;//de url waar de browser naar toe moet gaan 
            chromeBrowser = new ChromiumWebBrowser(url);
            //chromeBrowser = new ChromiumWebBrowser("https://www.google.nl/maps/search/oss+jumbo/@51.7496951,5.4861731,13z/data=!3m1!4b1");
            


            
            panel1.Controls.Add(chromeBrowser);//voegt de browser toe aan de panel
            
            chromeBrowser.Dock = DockStyle.Fill;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            InitializeChromium();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
