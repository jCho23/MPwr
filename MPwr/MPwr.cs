using System;
using Xamarin.Forms;

namespace MPwr
{
	public class App : Application
	{

		public App()
		{
			var feedPage = new FeedPage();
				
			MainPage = new NavigationPage(feedPage)
			{
				BarTextColor = Color.White,
				BarBackgroundColor = Color.FromHex("6CD0EF")
				   };
		}

	protected override void OnStart()
	{
		// Handle when your app starts
	}

	protected override void OnSleep()
	{
		// Handle when your app sleeps
	}

	protected override void OnResume()
	{
		// Handle when your app resumes
	}
}
}

