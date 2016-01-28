using MovieExplorer.ServiceReferenceTVShowInfo;
using MovieExplorer.Services;
using MovieExplorer.ViewModels.Base;
using MovieExplorer.ViewModels.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.System.Profile;
using Windows.UI.ViewManagement;

namespace MovieExplorer.ViewModels
{
	public class VMSecondPageTVShow : VMBase
	{
		private MEItemTVShow tvShow;

		private INavigationService navigationService;
		private Lazy<DelegateCommand<string>> goBack;

		public ObservableCollection<MECast> CastCollection { get; set; }
		public ObservableCollection<MECrew> CrewCollection { get; set; }
		public ObservableCollection<METVShowSeason> SeasonCollection { get; set; }
		public ObservableCollection<METVShowCreators> CreatorsCollection { get; set; }

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

		public MEItemTVShow TVShow
		{
			get
			{
				return tvShow;
			}
			set
			{
				tvShow = value;
				UpdateAll();
				LoadFilm(tvShow.Id);
			}
		}

		public VMSecondPageTVShow(INavigationService param)
		{
			navigationService = param;

			CastCollection     = new ObservableCollection<MECast>();
			CrewCollection	   = new ObservableCollection<MECrew>();
			SeasonCollection   = new ObservableCollection<METVShowSeason>();
			CreatorsCollection = new ObservableCollection<METVShowCreators>();

			InitializeCommands();
			showProgressBar();
		}

		public async void showProgressBar()
		{
			AnalyticsVersionInfo ai = AnalyticsInfo.VersionInfo;
			string systemFamily = ai.DeviceFamily;

			if (systemFamily == "Windows.Mobile")
			{
				StatusBar statusBar = Windows.UI.ViewManagement.StatusBar.GetForCurrentView();
				await statusBar.ProgressIndicator.ShowAsync();
			}
		}

		#region TV Shows Web Service
		async void LoadFilm(int id)
		{
			ProgressBarEnabled = true;

			CastCollection.Clear();
			CrewCollection.Clear();
			SeasonCollection.Clear();
			CreatorsCollection.Clear();

			var client = new ServiceReferenceTVShowInfo.WSTvInfoPortTypeClient();
			ServiceReferenceTVShowInfo.GetTvShowDataByIdResponse result =
				await client.GetTvShowDataByIdAsync(id);

			TvShowInfo tvShowInfoResponse = result.@return;

			tvShow.Id = tvShowInfoResponse.Id;
			tvShow.Title = tvShowInfoResponse.Title;
			tvShow.Summary = tvShowInfoResponse.Summary;
			tvShow.Background = tvShowInfoResponse.Background;
			tvShow.Rate = (double)tvShowInfoResponse.Rate/2;
			tvShow.Poster = tvShowInfoResponse.Poster;
			tvShow.Status = tvShowInfoResponse.Status;
			tvShow.NumEpisodes = tvShowInfoResponse.NumEpisodes;
			tvShow.NumSeasons = tvShowInfoResponse.NumSeasons;

			foreach (var crew in tvShowInfoResponse.Crew)
			{
				this.CrewCollection.Add(new MECrew()
				{
					Name = crew.Name,
					Department = crew.Department,
					Job = crew.Job,
					Picture = crew.Picture
				});

			}

			foreach (var cast in tvShowInfoResponse.Cast)
			{
				this.CastCollection.Add(new MECast()
				{
					Name = cast.Name,
					Character = cast.Character,
					Picture = cast.Picture
				});
			}

			foreach (var creator in tvShowInfoResponse.Creators)
			{
				this.CreatorsCollection.Add(new METVShowCreators()
				{
					Name = creator.Name,
					Picture = creator.Picture
				});
			}

			foreach (var season in tvShowInfoResponse.Seasons)
			{
				this.SeasonCollection.Add(new METVShowSeason()
				{
					Number = season.Number,
					AirDate = season.AirDate,
					Poster = season.Poster
				});
			}

			UpdateAll();
			ProgressBarEnabled = false;
		}
		#endregion

		#region Commands
		public ICommand GoBackCommand
		{
			get { return goBack.Value; }
		}

		private void InitializeCommands()
		{
			goBack = new Lazy<DelegateCommand<string>>(
				() => new DelegateCommand<string>(GoBackCommandExecute,
													GoBackCommandCanExecute));
		}
		public void GoBackCommandExecute(string param)
		{
			navigationService.GoBack();
		}
		public bool GoBackCommandCanExecute(string param)
		{
			return true;
		}
		#endregion
	}
}
