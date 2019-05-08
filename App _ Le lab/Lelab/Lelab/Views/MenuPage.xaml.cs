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
	public partial class MenuPage : ContentPage
	{
		public MenuPage ()
		{
			InitializeComponent ();
		}

        private void CounterButton_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new CountPage());
        }

        private void TabsButton_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new TabsPage());
        }

        private void ListButton_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new ListePage());
        }
    }
}