using MovieExplorer.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MovieExplorer
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

		private void LVF_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			((ViewModels.VMMain)this.DataContext).didClickMovie
							((ViewModels.MEItemFilm)this.LVF.SelectedItem);
		}

		private void LVFTVShows_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
				((ViewModels.VMMain)this.DataContext).didClickTVShow
								((ViewModels.MEItemTVShow)this.LVFTVShows.SelectedItem);
		}

		private void Pivot_PivotItemLoaded(Pivot sender, PivotItemEventArgs args)
		{
			if (args.Item.Header.ToString().Equals("Movies"))
			{
				changeCommandBarButtonsVisibility(true);
			} else
			{
				changeCommandBarButtonsVisibility(false);
			}
		}

		private void changeCommandBarButtonsVisibility(bool visible)
		{
			if (visible.Equals(true))
			{
				Movie1.Visibility = Visibility.Visible;
				Movie2.Visibility = Visibility.Visible;
				Movie3.Visibility = Visibility.Visible;
				Movie4.Visibility = Visibility.Visible;
				Movie5.Visibility = Visibility.Visible;
				ClearMovie.Visibility = Visibility.Visible;

				TVShow1.Visibility = Visibility.Collapsed;
				TVShow2.Visibility = Visibility.Collapsed;
				TVShow3.Visibility = Visibility.Collapsed;
				TVShow4.Visibility = Visibility.Collapsed;
				TVShow5.Visibility = Visibility.Collapsed;
				ClearTVShow.Visibility = Visibility.Collapsed;
			} else
			{
				Movie1.Visibility = Visibility.Collapsed;
				Movie2.Visibility = Visibility.Collapsed;
				Movie3.Visibility = Visibility.Collapsed;
				Movie4.Visibility = Visibility.Collapsed;
				Movie5.Visibility = Visibility.Collapsed;
				ClearMovie.Visibility = Visibility.Collapsed;

				TVShow1.Visibility = Visibility.Visible;
				TVShow2.Visibility = Visibility.Visible;
				TVShow3.Visibility = Visibility.Visible;
				TVShow4.Visibility = Visibility.Visible;
				TVShow5.Visibility = Visibility.Visible;
				ClearTVShow.Visibility = Visibility.Visible;
			}
		}
	}
}
