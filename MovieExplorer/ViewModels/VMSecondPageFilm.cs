using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MovieExplorer.Services;
using MovieExplorer.ViewModels.Base;
using MovieExplorer.ServiceReferenceFilmInfo;
using System.Collections.ObjectModel;

namespace MovieExplorer.ViewModels
{
	public class VMSecondPageFilm : VMBase
	{
		private MEItemFilm film;
		
		private INavigationService navigationService;
		private Lazy<DelegateCommand<string>> goBack;

		public ObservableCollection<MECast> CastCollection { get; set; }
		public ObservableCollection<MECrew> CrewCollection { get; set; }

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

		public MEItemFilm Film
		{
			get
			{
				return film;
			}
			set
			{
				film = value;
				UpdateAll();
				LoadFilm(film.Id);
			}
		}

		public VMSecondPageFilm(INavigationService param)
		{
			navigationService = param;

			CastCollection = new ObservableCollection<MECast>();
			CrewCollection = new ObservableCollection<MECrew>();

			InitializeCommands();
		}

		#region IMDB Web Service
		async void LoadFilm(int id)
		{
			ProgressBarEnabled = true;
			CastCollection.Clear();
			CrewCollection.Clear();

			var client = new ServiceReferenceFilmInfo.WSFilmInfoPortTypeClient();
			ServiceReferenceFilmInfo.GetMovieDataByIdResponse result =
				await client.GetMovieDataByIdAsync(id);

			FilmInfo filmInfoResponse = result.@return;

			film.Id = filmInfoResponse.Id;
			film.Title = filmInfoResponse.Title;
			film.Description = filmInfoResponse.Description;
			film.Year = filmInfoResponse.Year;
			film.Poster = filmInfoResponse.Poster;
			film.Background = filmInfoResponse.Background;
			film.Summary = filmInfoResponse.Summary;
			film.Director = filmInfoResponse.Director;
			film.Rate = (double) filmInfoResponse.Rate;

			foreach (var crew in filmInfoResponse.Crew)
			{
				this.CrewCollection.Add(new MECrew()
				{
					Name = crew.Name,
					Department = crew.Department,
					Job = crew.Job,
					Picture = crew.Picture
				});

			}

			foreach (var cast in filmInfoResponse.Cast)
			{
				this.CastCollection.Add(new MECast()
				{
					Name = cast.Name,
					Character = cast.Character,
					Picture = cast.Picture
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
