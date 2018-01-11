using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Text;

namespace SmamForms
{
    public partial class ArticleForm : Form
    {
        private smamController smamControl;
        private string articleName;
        private int i;
            
        public ArticleForm(string articlename) //constructor
        {
            InitializeComponent();
            smamControl = new smamController();
            CenterToScreen(); //Form in het midden zetten
            try
            {
                AddFonts();
            }
            catch (Exception exception)
            {
                ExceptionToText ex = new ExceptionToText(exception.ToString());
            }
            this.articleName = articlename;
            this.BackColor = Color.FromArgb(248, 248, 248);
        }
        
        private void buttonBack_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Drukte backbutton in");
            this.Hide();
        }

        private void ArticleForm_Load(object sender, EventArgs e)
        {
            this.Text = articleName;
            labelTitelArticle.Text = articleName;
            labelTitelArticle.BringToFront();
            labelTitelArticle.Left = (this.ClientSize.Width - labelTitelArticle.Width) / 2;
            txtArticleText.Text = smamControl.GetArticleText(articleName); //test
            string articleID = smamControl.GetArticleID(articleName);
            foreach (string URL in smamControl.GetImageURL(articleID))
            {
                Image image = new Image(URL); //nieuw object aanmaken
                Console.WriteLine(URL); //debuggen
                PictureBox p = new PictureBox(); //nieuwe picturebox maken
                p.Size = new System.Drawing.Size(75, 75); //formaat instellen
                p.Location = new System.Drawing.Point(12 + 120 * i, 524); //locatie instellen
                Console.WriteLine(p.Location.ToString()); //debuggen
                this.Controls.Add(p); //toevoegen aan form
                p.Load(URL); //link laden
                i++; //voor locatie picturebox
            }
            foreach (Control c in Controls)
            {
                if (c is PictureBox && c.Name != "pictureBox1") //zijn er plaatjes bij het artikel
                {
                    txtArticleText.Height = 466;
                    break;
                }
                else
                {
                    txtArticleText.Height = 547;
                }
            }
            loadBG(); //achtergrond laden
        }

        private void loadBG()
        {
            string articleID = smamControl.GetArticleID(articleName);
            try
            {
                pictureBox1.Load(smamControl.GetBackgroundURL(articleID));
                foreach (Control item in this.Controls)
                {
                    if (item.Name != "labelTitelArticle" && item.Name != "buttonBack")
                    {
                        item.BackColor = Color.FromArgb(248, 248, 248);
                    }
                }
            }
            catch (Exception exception)
            {
                labelTitelArticle.ForeColor = Color.Black;
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
            labelTitelArticle.Parent = pictureBox1;
            buttonBack.Parent = pictureBox1;
            labelTitelArticle.Focus(); //focussen op een label zorgt ervoor dat er geen knipperende cursor is
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
            labelTitelArticle.Font = new Font(p.Families[1], 12, FontStyle.Regular);
        }

        private void txtArticleText_MouseDown(object sender, MouseEventArgs e)
        {
            labelTitelArticle.Focus(); //focussen op een label zorgt ervoor dat er geen knipperende cursor is
        }
    }
}
