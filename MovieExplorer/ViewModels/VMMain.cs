using System;
using System.Windows.Input;
using MovieExplorer.ViewModels.Base;
using MovieExplorer.Services;
using System.Collections.ObjectModel;
using Windows.System.Profile;
using Windows.UI.ViewManagement;

namespace MovieExplorer.ViewModels
{
    public class VMMain : VMBase
    {
        #region Properties

        private INavigationService navigationService;
		public ObservableCollection<MEItemFilm> MovieCollection { get; set; }
		public ObservableCollection<MEItemTVShow> TVShowCollection { get; set; }

        private bool progressBarEnabled;
        public bool ProgressBarEnabled
        {
            get
            {
                return progressBarEnabled;
            }
            set
            {
                progressBarEnabled = value;
                RaisePropertyChanged("ProgressBarEnabled");
            }
        }

		#region Movie

		private string movie;
        public string Movie
        {
            get
            {
                return movie;
            }

            set
            {
                movie = value;
                RaisePropertyChanged("Movie");
                setMovieCommand.Value.RaiseCanExecuteChanged(this);
            }
        }

		public string NumResultsMovies
        {
            get
            {
                if (!string.IsNullOrEmpty(movie))
                {
                    return string.Format("{1} Movies that mach with '{0}'", movie, MovieCollection.Count);
                }

                return "No results";
            }
        }

		#endregion

		#region TVShow

		private string tvShow;
		public string TVShow
		{
			get
			{
				return tvShow;
			}

			set
			{
				tvShow = value;
				RaisePropertyChanged("TVShow");
				setMovieCommand.Value.RaiseCanExecuteChanged(this);
			}
		}

		public string NumResultsTVShows
		{
			get
			{
				if (!string.IsNullOrEmpty(tvShow))
				{
					return string.Format("{1} TV Shows that mach with '{0}'", tvShow, TVShowCollection.Count);
				}

				return "No results";
			}
		}

		#endregion

		#endregion

		public VMMain(INavigationService navServ)
        {

            navigationService = navServ;
			MovieCollection = new ObservableCollection<MEItemFilm>();
			TVShowCollection = new ObservableCollection<MEItemTVShow>();

            //LoadMovies("Star Wars");
			LoadTVShows("Breaking Bad");
			InitializeCommands();
		}

		#region StatusBar
		public async void showStatusBar()
		{
			AnalyticsVersionInfo ai = AnalyticsInfo.VersionInfo;
			string systemFamily = ai.DeviceFamily;

			if (systemFamily == "Windows.Mobile")
			{
				StatusBar statusBar = Windows.UI.ViewManagement.StatusBar.GetForCurrentView();
				await statusBar.ProgressIndicator.ShowAsync();
			}
		}

		public async void hideStatusBar()
		{
			AnalyticsVersionInfo ai = AnalyticsInfo.VersionInfo;
			string systemFamily = ai.DeviceFamily;

			if (systemFamily == "Windows.Mobile")
			{
				StatusBar statusBar = Windows.UI.ViewManagement.StatusBar.GetForCurrentView();
				await statusBar.ProgressIndicator.HideAsync();
			}
		}
		#endregion

		#region WebServices

		#region Movie Web Service
		async void LoadMovies(string movieTitle)
        {
			ProgressBarEnabled = true;
			MovieCollection.Clear();

			var client = new ServiceReferenceFilmSearch.WSFilmSearchPortTypeClient();
			ServiceReferenceFilmSearch.SearchMoviesByNameResponse result =
				await client.SearchMoviesByNameAsync(movieTitle);

			foreach (var film in result.@return)
			{
				this.MovieCollection.Add(new MEItemFilm()
				{
					Id = film.Id,
					Title = film.Title,
					Description = film.Description,
					Year = film.Year,
					Poster = film.Poster
				});
			}

			ProgressBarEnabled = false;
			UpdateAll();
			clearMovieCommand.Value.RaiseCanExecuteChanged(this);
        }
		#endregion

		#region TVShows Web Service

		async void LoadTVShows(string showTitle)
		{
			ProgressBarEnabled = true;
			TVShowCollection.Clear();

			var client = new ServiceReferenceTVShowSearch.WSTvSearchPortTypeClient();
			ServiceReferenceTVShowSearch.SearchTvByNameResponse result =
				await client.SearchTvByNameAsync(showTitle);

			foreach (var tvshow in result.@return)
			{
				this.TVShowCollection.Add(new MEItemTVShow()
				{
					Id = tvshow.Id,
					Title = tvshow.Title,
					Rate = (double)tvshow.Rate/2,
					Year = tvshow.Year,
					Poster = tvshow.Poster
				});
			}
			ProgressBarEnabled = false;
			UpdateAll();
			clearTVShowCommand.Value.RaiseCanExecuteChanged(this);
		}

		#endregion

		#endregion

		#region Commands

		private Lazy<DelegateCommand<string>> setMovieCommand;
		private Lazy<DelegateCommand<string>> clearMovieCommand;
		private Lazy<DelegateCommand<string>> favoriteMovieCommand;

		private Lazy<DelegateCommand<string>> setTVShowCommand;
		private Lazy<DelegateCommand<string>> clearTVShowCommand;
		private Lazy<DelegateCommand<string>> favoriteTVShowCommand;

		#region Movie Command Getter/Setters
		public ICommand SetMovieCommand
        {
            get
            {
                return setMovieCommand.Value;
            }
        }

		public ICommand ClearMovieCommand
		{
			get
			{
				return clearMovieCommand.Value;
			}
		}

		public ICommand FavoriteMovieCommand
		{
			get
			{
				return favoriteMovieCommand.Value;
			}
		}
		#endregion

		#region TVShows Command Getter/Setters
		public ICommand SetTVShowCommand
		{
			get
			{
				return setTVShowCommand.Value;
			}
		}

		public ICommand ClearTVShowCommand
		{
			get
			{
				return clearTVShowCommand.Value;
			}
		}

		public ICommand FavoriteTVShowCommand
		{
			get
			{
				return favoriteTVShowCommand.Value;
			}
		}
		#endregion



		private void InitializeCommands()
        {
            setMovieCommand = new Lazy<DelegateCommand<string>>(
                () => new DelegateCommand<string>(SetMovieCommandExecute,
                                                  SetMovieCommandCanExecute));
			clearMovieCommand = new Lazy<DelegateCommand<string>>(
				() => new DelegateCommand<string>(ClearMovieCommandExecute,
									  ClearMovieCommandCanExecute));

			favoriteMovieCommand = new Lazy<DelegateCommand<string>>(
				() => new DelegateCommand<string>(FavoriteMovieCommandExecute,
						  FavoriteMovieCommandCanExecute));

			setTVShowCommand = new Lazy<DelegateCommand<string>>(
				() => new DelegateCommand<string>(SetTVShowCommandExecute,
									  SetTVShowCommandCanExecute));
			clearTVShowCommand = new Lazy<DelegateCommand<string>>(
				() => new DelegateCommand<string>(ClearTVShowCommandExecute,
						  ClearTVShowCommandCanExecute));

			favoriteTVShowCommand = new Lazy<DelegateCommand<string>>(
				() => new DelegateCommand<string>(FavoriteTVShowCommandExecute,
						  FavoriteTVShowCommandCanExecute));

		}

		#region Movie Command Methods

		public void SetMovieCommandExecute(string param)
        {
            LoadMovies(param);
        }

		public bool SetMovieCommandCanExecute(object param)
        {
            return !string.IsNullOrEmpty(movie); 
        }

		public bool FavoriteMovieCommandCanExecute(object param)
		{
			return true;
		}

		public void FavoriteMovieCommandExecute(string param)
		{
			Movie = param;
			RaisePropertyChanged("Movie");
			LoadMovies(param);

		}

		public void ClearMovieCommandExecute(string param)
		{
			MovieCollection.Clear();
			RaisePropertyChanged("MovieCollection");
			RaisePropertyChanged("NumResultsMovies");
			clearMovieCommand.Value.RaiseCanExecuteChanged(this);
		}

		public bool ClearMovieCommandCanExecute(object param)
		{
			bool hasContent= false;
			if( MovieCollection.Count > 0)
			{
				hasContent = true;
			} 
			return hasContent;
		}
		#endregion

		#region TVShows Command Methods

		public void SetTVShowCommandExecute(string param)
		{
			LoadTVShows(param);
		}

		public bool SetTVShowCommandCanExecute(object param)
		{
			return !string.IsNullOrEmpty(tvShow);
		}

		public bool FavoriteTVShowCommandCanExecute(object param)
		{
			return true;
		}

		public void FavoriteTVShowCommandExecute(string param)
		{
			TVShow = param;
			RaisePropertyChanged("TVShow");
			LoadTVShows(param);
		}

		public void ClearTVShowCommandExecute(string param)
		{
			TVShowCollection.Clear();
			UpdateAll();
			clearMovieCommand.Value.RaiseCanExecuteChanged(this);
		}

		public bool ClearTVShowCommandCanExecute(object param)
		{
			bool hasContent = false;
			if (TVShowCollection.Count > 0)
			{
				hasContent = true;
			}
			return hasContent;
		}

		#endregion

		#endregion

		#region Callbacks

		internal void didClickMovie(MEItemFilm sender)
		{
			if (sender != null)
			{
				navigationService.NavigateToSecondPage(sender);

			}
		}

		internal void didClickTVShow(MEItemTVShow sender)
		{
			if (sender != null)
			{
				navigationService.NavigateToSecondPageTVShows(sender);
			}
		}

		#endregion
	}
}
