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
    public partial class Typelist : Form
    {
        private smamController smamControl;
        private string naamType;

        public Typelist(string naamtype)
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(248, 248, 248);
            setbackground();
            AddFonts();
            CenterToScreen(); //Form in het midden zetten
            smamControl = new smamController();
            this.naamType = naamtype;
        }
        private void setbackground()
        {
            foreach (Control item in this.Controls)
            {
                item.BackColor = Color.FromArgb(248, 248, 248); 
            }
        }

        private void Typelist_Load(object sender, EventArgs e)
        {
            this.Text = smamControl.GetTypeName(naamType);
            labelTitle.Text = smamControl.GetTypeName(naamType);
            foreach (string item in smamControl.GetArticleTitles(naamType))
            {
                listBox1.Items.Add(item);
            }
            listBox1.Sorted = true;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Drukte backbutton in");
            this.Hide();
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                string articlename = listBox1.SelectedItem.ToString();
                this.Hide();
                smamControl.openArtikel(articlename);
                this.Show();
            }
            catch (Exception exception)
            {
                ExceptionToText ex = new ExceptionToText(exception.ToString());
            }
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
                c.Font = new Font(p.Families[0], 10, FontStyle.Regular);
            }
            labelTitle.Font = new Font(p.Families[1], 12, FontStyle.Regular);
        }

    }
}
