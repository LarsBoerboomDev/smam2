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

namespace SmamForms
{
    public partial class settingsEdit : Form
    {
        smamController smam;
        saveUserSettings settings;
        public settingsEdit()
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
            smam = new smamController();
            getSettings();
            labelTitel.Left = (this.ClientSize.Width - labelTitel.Width) / 2;
        }
        private void setbackground()
        {
            this.BackColor = Color.FromArgb(248, 248, 248);
            foreach (Control item in this.Controls)
            {
                if (item is Label)
                {
                    item.BackColor = Color.Transparent;
                }
                if (item is TextBox || item is NumericUpDown || item.Name == "buttonSave")
                {
                    item.BackColor = Color.White;
                }
                else
                {
                    item.BackColor = Color.FromArgb(248, 248, 248);
                }
            }
        }
        private void getSettings()
        {
            settings = new saveUserSettings();
            userSetting userSettings = settings.getSettings();
            textBoxName.Text = userSettings.Name;
            numericUpDown1.Value = Convert.ToDecimal(userSettings.RentDay);
            textBoxCity.Text = userSettings.City;
            textBoxOpleiding.Text = userSettings.Education;
            textBoxSchool.Text = userSettings.School;
            textBoxStreet.Text = userSettings.Street;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            bool isFilledIn = true;
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    if (string.IsNullOrEmpty(((TextBox)item).Text))
                    {
                        isFilledIn = false;
                    }
                }
            }
            if (isFilledIn == false)
            {
                MessageBox.Show("Niet alle velden zijn ingevuld");
            }
            else
            {
                settings.saveUser(textBoxName.Text, textBoxCity.Text, textBoxStreet.Text, textBoxSchool.Text, textBoxOpleiding.Text, numericUpDown1.Value.ToString());
                this.Close();
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Drukte backbutton in");
            this.Hide();
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
            labelTitel.Font = new Font(p.Families[1], 12, FontStyle.Regular);
        }


    }
}
