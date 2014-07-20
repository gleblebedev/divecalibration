using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace VrCalibration
{
	public partial class MainPage : PhoneApplicationPage
	{
		public MainPage()
		{
			InitializeComponent();
			Microsoft.Phone.Shell.PhoneApplicationService.Current.UserIdleDetectionMode = IdleDetectionMode.Enabled;
		}

		private void StartCalibration(object sender, RoutedEventArgs e)
		{
			NavigationService.Navigate(new Uri("/GamePage.xaml", UriKind.Relative));
		}
	}
}