using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lelab.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]

    public class Article
    {
        public String Nom { get; set; }
        public String Prix { get; set; }
        public String Description { get; set; }

    }

    
    public partial class ListePage : ContentPage
	{
        List<Article> articles;
		public ListePage ()
		{
			InitializeComponent ();

            articles = new List<Article>();
            articles.Add(new Article { Nom = "lait", Prix = "4€", Description = "demi-écrémé" });
            articles.Add(new Article { Nom = "chocolat", Prix = "2.5€", Description = "70% cacao" });
            articles.Add(new Article { Nom = "pain", Prix = "2€", Description = "baguette" });
            articles.Add(new Article { Nom = "beurre", Prix = "1.2€", Description = "sans matière grasse" });

            myListView.ItemsSource = articles;
            myListView.ItemSelected += (sender, e) =>
            {
                Article item = myListView.SelectedItem as Article;

                if (myListView.SelectedItem != null)
                {
                    DisplayAlert(item.Nom, item.Description, "OK");
                    myListView.SelectedItem = null;
                }
            };

        }
	}
}