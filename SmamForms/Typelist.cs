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

    }
}
