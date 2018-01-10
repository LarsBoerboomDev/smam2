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
            AddFonts();
            designing();
            //label1.Left = (this.ClientSize.Width - label1.Width) / 2;
        }
        private void designing()
        {

            pictureBoxlogo.Parent = pictureBox1;
            pictureBoxlogo.BackColor = Color.Transparent;
            pictureBoxlogo.Location = new Point(89, 38);
            label2.Parent = pictureBox1;
            label2.Location = new Point(12, 236);
            label3.Parent = pictureBox1;
            label3.Location = new Point(12, 291);
            label4.Parent = pictureBox1;
            label4.Location = new Point(12, 348);
            label5.Parent = pictureBox1;
            label5.Location = new Point(12, 408);
            label6.Parent = pictureBox1;
            label6.Location = new Point(12, 466);
            label7.Parent = pictureBox1;
            label7.Location = new Point(12, 523);

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
    }
}
