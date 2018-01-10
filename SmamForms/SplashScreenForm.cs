using SmamForms.Properties;
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
using System.Drawing.Text;

namespace SmamForms
{
    public partial class SplashScreenForm : Form
    {
        private Timer time;
        public SplashScreenForm()
        {
            
            InitializeComponent();
            CenterToScreen();
            designing();
            time = new Timer();
            //if (Debugger.IsAttached)
            //{
            //   Settings.Default.Reset();
            //}
            checkStart();
      
        }
        private void checkStart()
        {
            if (Properties.Settings.Default.hasStarted == "1") //als settings bestaan
            {
                time.Enabled = true;
                time.Interval = 750;
                time.Tick += Timer_Tick;
            }
            else
            {
                buttonNext.Visible = true;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            time.Enabled = false;
            homePage home = new homePage();
            
            home.Show();
            this.Hide();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            startSettings start = new startSettings();
            this.Hide();            
            start.Show();
        }
        private void designing()
        {
            pictureBoxlogo.Parent = pictureBox1;
            pictureBoxlogo.BackColor = Color.Transparent;
            pictureBoxlogo.Location = new Point(101, 235);
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
                c.Font = new Font(p.Families[0], 9, FontStyle.Regular);
            }
        }

        private void SplashScreenForm_Load(object sender, EventArgs e)
        {
            AddFonts();
        }
    }
}
