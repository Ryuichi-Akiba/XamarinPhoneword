using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Phoneword
{
	public class App : Application
	{
		public App()
		{
			MainPage = new Phoneword.MainPage();
		}

		protected override void OnStart()
		{
			// Handle when your app starts
			MobileCenter.Start("ios=382f03d4-54a6-49a8-bdd5-6bb71c135583;" +
			                   "android=ccda5d9f-c301-4902-ad8b-bff6e59824cf;",
				   typeof(Analytics), typeof(Crashes));
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