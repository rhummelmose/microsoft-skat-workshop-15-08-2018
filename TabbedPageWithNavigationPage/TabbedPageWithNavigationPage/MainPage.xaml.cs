using Xamarin.Forms;

namespace TabbedPageWithNavigationPage
{
	public partial class MainPage : TabbedPage
	{
		public MainPage ()
		{
			InitializeComponent ();

            var commonPageIcon = "schedule.png";

            var scheduleNavigationPage = new NavigationPage(new SchedulePage());
            scheduleNavigationPage.Icon = commonPageIcon;
            scheduleNavigationPage.Title = "Schedule";

            var countriesNavigationPage = new NavigationPage(new CountriesPage());
            countriesNavigationPage.Icon = commonPageIcon;
            countriesNavigationPage.Title = "Countries";

            Children.Add(new TodayPage());
            Children.Add(scheduleNavigationPage);
            Children.Add(new SettingsPage());
            Children.Add(countriesNavigationPage);
        }
	}
}

