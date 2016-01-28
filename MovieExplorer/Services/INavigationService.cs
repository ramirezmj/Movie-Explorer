using MovieExplorer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieExplorer.Services
{
	public interface INavigationService
	{
		// Films
		void NavigateToSecondPage(MEItemFilm film);
		// TV Shows
		void NavigateToSecondPageTVShows(MEItemTVShow tvshow);
		// Common
		void GoBack();
	}
}
