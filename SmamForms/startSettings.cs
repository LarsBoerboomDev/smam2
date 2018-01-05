using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmamForms
{
    public partial class startSettings : Form
    {
        public startSettings()
        {
            InitializeComponent();
            CenterToScreen();
            label1.Left = (this.ClientSize.Width - label1.Width) / 2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveUserSettings save = new saveUserSettings();
            bool isFilledIn = true;
            foreach (Control item in this.Controls)
            {
                if(item is TextBox)
                {
                    if(string.IsNullOrEmpty(((TextBox)item).Text)){
                        isFilledIn = false;
                    }
                }
            }
            if(isFilledIn == false)
            {
                MessageBox.Show("Niet alle velden zijn ingevuld");
            }
            else
            {
                save.saveUser(textBoxName.Text, textBoxCity.Text, textBoxStreet.Text, textBoxSchool.Text, textBoxOpleiding.Text, textBoxHuur.Text);
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
    }
}
