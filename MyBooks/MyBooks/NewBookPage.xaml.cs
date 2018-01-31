using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyBooks
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NewBookPage : ContentPage
	{
		public NewBookPage ()
		{
			InitializeComponent ();
		}

        
        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Success", "We have handled the click event", "Thank you");
        }
    }
}