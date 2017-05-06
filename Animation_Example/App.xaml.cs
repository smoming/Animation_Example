using Xamarin.Forms;

namespace Animation_Example
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			//MainPage = new Animation_ExamplePage();
			MainPage = new NavigationPage(new Index());
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
