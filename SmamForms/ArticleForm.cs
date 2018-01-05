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
            this.articleName = articlename;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Drukte backbutton in");
            this.Hide();
        }

        private void ArticleForm_Load(object sender, EventArgs e)
        {
            labelTitelArticle.Text = articleName;
            labelTitelArticle.Left = (this.ClientSize.Width - labelTitelArticle.Width) / 2;
            txtArticleText.Text = smamControl.GetArticleText(articleName); //test
            string articleID = smamControl.GetArticleID(articleName);
            foreach (string URL in smamControl.GetImageURL(articleID))
            {
                Image image = new Image(URL); //nieuw object aanmaken
                Console.WriteLine(URL); //debuggen
                PictureBox p = new PictureBox(); //nieuwe picturebox maken
                p.Size = new System.Drawing.Size(75, 75); //formaat instellen
                p.Location = new System.Drawing.Point(252, 52 + 81 * i); //locatie instellen
                Console.WriteLine(p.Location.ToString()); //debuggen
                this.Controls.Add(p); //toevoegen aan form
                p.Load(URL); //link laden
                i++; //voor locatie picturebox
            }
            foreach (Control c in Controls)
            {
                if (c is PictureBox)
                {
                    txtArticleText.Width = 234;
                    break;
                }
                else
                {
                    txtArticleText.Width = 315;
                }
            }
        }

        private void txtArticleText_MouseDown(object sender, MouseEventArgs e)
        {
            labelTitelArticle.Focus(); //focussen op een label zorgt ervoor dat er geen knipperende cursor is
        }
    }
}
