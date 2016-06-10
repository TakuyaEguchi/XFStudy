using System;

using Xamarin.Forms;

namespace XFScreenTransition
{
	public class App : Application
	{
		public App()
		{
			MainPage = GetMainPage();
		}

		public static Page GetMainPage()
		{

			var datePicker = new DatePicker { };

			var button = new Button
			{
				Text = "Enter"
			};
			// The root page of your application
			var page = new ContentPage
			{

				Title = "ScreenTransition",
				Content = new StackLayout
				{
					Children = {
						datePicker,
						button
					},
					VerticalOptions = LayoutOptions.Center,
					HorizontalOptions = LayoutOptions.Center
				}
			};

			var navPage = new NavigationPage(page);

			button.Clicked += (sender, e) =>
			{
				navPage.Navigation.PushAsync(App.GetSecondPage(datePicker.Date));
			};

			return navPage;
		}

		public static Page GetSecondPage(DateTime selectedDate)
		{
			return new ContentPage
			{
				Content = new Label
				{
					Text = selectedDate.ToString(),
					VerticalOptions = LayoutOptions.CenterAndExpand,
					HorizontalOptions = LayoutOptions.CenterAndExpand,
				},
				BackgroundColor = Color.Yellow
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

