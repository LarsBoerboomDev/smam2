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
    public partial class shoppingList : Form
    {
        smamController smam;
        public shoppingList()
        {
            InitializeComponent();
            CenterToScreen();
            AddFonts();
            setbackground();
            smam = new smamController();
            
            fillTypes();
        }
        private void setbackground()
        {
            this.BackColor = Color.FromArgb(248, 248, 248);
            foreach (Control item in this.Controls)
            {
                if (item.Name != "buttonBack")
                {
                    item.BackColor = Color.FromArgb(248, 248, 248);
                }
            }
            comboBoxTypes.BackColor = Color.White;
            comboBoxTypes.ForeColor = Color.Black;
        }
        private void fillTypes()
        {
            foreach (string type in smam.getGroceryTypes())
            {
                comboBoxTypes.Items.Add(type);
            }
            comboBoxTypes.SelectedIndex = 0;
            fillCheckList();
        }
        private void fillCheckList()
        {
            checkedListBoxProducts.Items.Clear();
            foreach (string item in smam.getGroceryProducts(comboBoxTypes.Text))
            {
                checkedListBoxProducts.Items.Add(item);
            }
        }

        private void comboBoxTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkedListBoxProducts.Items.Clear();
            fillCheckList();
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
                c.Font = new Font(p.Families[0], 12, FontStyle.Regular);
            }
        }

    }
}
