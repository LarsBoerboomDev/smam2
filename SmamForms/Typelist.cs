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
            CenterToScreen(); //Form in het midden zetten
            smamControl = new smamController();
            this.naamType = naamtype;
            setbackground();
            loadBG();
            try
            {
                AddFonts();
            }
            catch (Exception exception)
            {
                ExceptionToText ex = new ExceptionToText(exception.ToString());
            }
        }
        private void setbackground()
        {
            this.BackColor = Color.FromArgb(248, 248, 248);
            foreach (Control item in this.Controls)
            {
                item.BackColor = Color.FromArgb(248, 248, 248); 
            }
        }

        private void Typelist_Load(object sender, EventArgs e)//laat alle artikelen in van een type die mee komt via de constructor
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

        private void listBox1_DoubleClick(object sender, EventArgs e)//als je dubbelklikt gaat die door naar het geklikte artikel
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
                ExceptionToText ex = new ExceptionToText(exception.ToString());//als er iets fout is schrijft die in het log bestand via ExceptionToText klasse
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

        private void loadBG()
        {
            string articleID = smamControl.GetArticleIDFromType(smamControl.GetTypeName(naamType));
            Console.WriteLine(smamControl.GetBackgroundURL(articleID));
            try
            {
                pictureBox1.Load(smamControl.GetBackgroundURL(articleID));
                foreach (Control item in this.Controls)
                {
                    if (item.Name != "labelTitelArticle" && item.Name != "buttonBack")
                    {
                        item.BackColor = Color.FromArgb(248, 248, 248);
                    }
                    labelTitle.Parent = pictureBox1;
                    labelTitle.BackColor = Color.Transparent;
                    labelTitle.ForeColor = Color.White;
                    buttonBack.Parent = pictureBox1;
                    buttonBack.BackColor = Color.Transparent;
                    buttonBack.BringToFront();
                    labelTitle.BringToFront();
                }
            }
            catch (Exception exception)
            {
                labelTitle.ForeColor = Color.Black;
                foreach (Control item in this.Controls)
                {
                    if (item.Name != "buttonBack")
                    {
                        item.BackColor = Color.FromArgb(248, 248, 248);
                    }

                }
                buttonBack.BringToFront();
                ExceptionToText ex = new ExceptionToText(exception.ToString());
            }
            labelTitle.Focus(); //focussen op een label zorgt ervoor dat er geen knipperende cursor is
        }

    }
}
