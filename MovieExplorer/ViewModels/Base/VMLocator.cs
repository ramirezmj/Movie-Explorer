using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieExplorer.Services;

namespace MovieExplorer.ViewModels.Base
{
	public class VMLocator
	{
		private Lazy<VMMain> mainViewModel;
		private Lazy<VMSecondPageFilm> secondPageViewModel;
		private Lazy<VMSecondPageTVShow> secondPageTVShowViewModel;
		private INavigationService navigationService;

		public VMLocator()
		{
			navigationService = new NavigationService();
			mainViewModel = new Lazy<VMMain>(() => new VMMain(navigationService));
			secondPageViewModel = new Lazy<VMSecondPageFilm>(() => new VMSecondPageFilm(navigationService));
			secondPageTVShowViewModel = new Lazy<VMSecondPageTVShow>(() => new VMSecondPageTVShow(navigationService));
		}

		public VMMain MainViewModel
		{
			get
			{
				return mainViewModel.Value;
			}
		}

		public VMSecondPageFilm SecondPageViewModel
		{
			get
			{
				return secondPageViewModel.Value;
			}
		}

		public VMSecondPageTVShow SecondPageTVShowViewModel
		{
			get
			{
				return secondPageTVShowViewModel.Value;
			}
		}
	}
}
