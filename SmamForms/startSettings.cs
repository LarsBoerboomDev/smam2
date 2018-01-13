using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Drawing.Text;

namespace SmamForms
{
    public partial class startSettings : Form
    {
        public startSettings()
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
            designing();
            //label1.Left = (this.ClientSize.Width - label1.Width) / 2;
        }
        private void designing()//zorgt ervoor dat de label transperant zijn
        {
            pictureBoxlogo.Parent = pictureBox1;
            pictureBoxlogo.BackColor = Color.Transparent;
            pictureBoxlogo.Location = new Point(89, 38);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveUserSettings save = new saveUserSettings();
            bool isFilledIn = true;
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    if (string.IsNullOrEmpty(((TextBox)item).Text)) {
                        isFilledIn = false;
                    }
                }
            }
            if (isFilledIn == false)//als er iets niet is ingevuld geeft die een error message
            {
                MessageBox.Show("Niet alle velden zijn ingevuld");
            }
            else//anders slaat die alle ingevulde informatie op in de userSettings en gaat door naar de homepagina
            {
                save.saveUser(textBoxName.Text, textBoxCity.Text, textBoxStreet.Text, textBoxSchool.Text, textBoxOpleiding.Text, Convert.ToString(numericUpDown1.Value));
                Properties.Settings.Default.hasStarted = 1.ToString();
                save.isInstalled();
                homePage home = new homePage();
                home.Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void emptyTextBox(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text == "Hoe heet je?" || (sender as TextBox).Text == "In welke plaats woon je?" || (sender as TextBox).Text == "In welke straat woon je?" || (sender as TextBox).Text == "Op welke school studeer je momenteel?" || (sender as TextBox).Text == "Welke opleiding volg je?") //als er een standaard tekst in staat
            {
                (sender as TextBox).Clear(); //maak de textbox leeg bij een klik
            }
        }

        private void textBoxHuur_Click(object sender, EventArgs e)
        {
            pictureBoxlogo.Focus();
        }
    }
}
