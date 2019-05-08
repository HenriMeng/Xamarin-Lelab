using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Core.dll;

namespace Lelab.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CountPage : ContentPage
	{
        int Count = 0;
		public CountPage ()
		{
			InitializeComponent ();
		}

        private void CountButton_Clicked(object sender, EventArgs e)
        {
            Count++;
            Compteur.Text = Count.ToString();         
        }
    }
}