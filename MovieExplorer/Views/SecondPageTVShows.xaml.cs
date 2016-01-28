using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System.Profile;
using Windows.UI;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace MovieExplorer.Views
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class SecondPageTVShows : Page
	{
		public SecondPageTVShows()
		{
			this.InitializeComponent();

			AnalyticsVersionInfo ai = AnalyticsInfo.VersionInfo;
			string systemFamily = ai.DeviceFamily;

			if (systemFamily == "Windows.Mobile")
			{
				StatusBar statusBar = Windows.UI.ViewManagement.StatusBar.GetForCurrentView();
				statusBar.BackgroundColor = Colors.Black;
				statusBar.ForegroundColor = Colors.White;
				statusBar.BackgroundOpacity = 100;
			}

		}
	}
}
