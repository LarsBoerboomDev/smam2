using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmamForms
{   
    class smamController
    {
        dbConnection dbconn;
        private Article article;

        internal dbConnection Dbconn { get => dbconn; private set => dbconn = value; }
        internal Article Article { get => article; private set => article = value; }

        public smamController()
        {
            Dbconn = new dbConnection();
            Article = new Article();
        }
        public Hint getHint()
        {
            return Dbconn.getHint();
        }
        public List<string> getGroceryTypes()
        {
            return Dbconn.getGroceryTypes();
        }
        public List<string> getGroceryProducts(string Type)
        {
            return Dbconn.getGroceryProducts(Type);
        }
        
        public string GetArticleText(string articlename)
        {
            article.SetArticleDesc(Dbconn.GetArticleText(articlename));
            return Article.Description;
        }

        //lijst van strings terugsturen naar form met alle titels

        public List<string> GetArticleTitles(string type) //alle titels ophalen
        {
            return Dbconn.GetArticleTitles(type); //returned de list
        }

        public void openArtikel(string articlename) //één artikel openen
        {
            article.SetArticleName(articlename);
            ArticleForm articleForm = new ArticleForm(article.Name);
            articleForm.ShowDialog();
            articleForm = null;
        }

        public void openTypelist(string type)
        {
            Typelist typelist = new Typelist(type);
            typelist.ShowDialog();
            typelist = null;
        }

        public string GetTypeName(string type)
        {
            return Dbconn.GetTypeName(type);
        }

        public List<String> GetImageURL(string articleID)
        {
            return Dbconn.GetImageURL(articleID);
        }

        public string GetArticleID(string articlename)
        {
            return Dbconn.GetArticleID(articlename);
        }

        public override string ToString()
        {
            //toString methode voor een methode
            return Dbconn.ToString();
        }
    }
}
