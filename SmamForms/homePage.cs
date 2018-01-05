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
    public partial class homePage : Form
    {

        smamController smam;        
        public homePage()
        {
            smam = new smamController();
            InitializeComponent();
            CenterToScreen();
            fillHint();
            labelTipVDDag.Left = (this.ClientSize.Width - labelTipVDDag.Width) / 2;
            labelHint.Left = (this.ClientSize.Width - labelHint.Width) / 2;
        }   

        private void fillHint()
        {
            try
            {
                labelHint.Text = smam.getHint().Body;

            }
            catch (Exception)
            {
                MessageBox.Show("Het is niet gelukt om verbinding te maken met de server. SMAM zal nu sluiten.");
                Application.Exit();
            }
        }

        private void buttonSetting_Click(object sender, EventArgs e)
        {
            this.Hide();
            settingsEdit edit = new settingsEdit();
            edit.ShowDialog();
            edit = null;
            this.Show();
        }

        private void buttonShoppingList_Click(object sender, EventArgs e)
        {
            this.Hide();
            shoppingList shopping = new shoppingList();
            shopping.ShowDialog();
            shopping = null;
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            smam.openTypelist(1.ToString()); //recept
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            smam.openTypelist(3.ToString()); //huishouden
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            poi2 poi = new poi2(); //poi
            poi.ShowDialog();
            poi = null;
            this.Show();
        }

        private void buttonFinancien_Click(object sender, EventArgs e)
        {
            this.Hide();
            smam.openTypelist(2.ToString()); //huishouden
            this.Show();
        }
    }
}
