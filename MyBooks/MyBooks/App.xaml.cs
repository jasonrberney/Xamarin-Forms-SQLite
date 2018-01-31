using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Windows.Storage;
using Xamarin.Forms;

namespace MyBooks
{
	public partial class App : Application
	{
        public static string DB_PATH = string.Empty;
		public App ()
		{
			InitializeComponent();

            string fileName = "books_db.sqlite";
            string fileLocation = Path.Combine(ApplicationData.Current.LocalFolder.Path, fileName);
            DB_PATH = fileLocation;

            MainPage = new NavigationPage(new MainPage());
		}

        public App(string DB_PATH)
        {
            InitializeComponent();

            DB_PATH = DB_PATH;

            MainPage = new NavigationPage(new MainPage());
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
