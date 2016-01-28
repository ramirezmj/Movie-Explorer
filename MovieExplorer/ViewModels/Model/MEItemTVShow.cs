using MovieExplorer.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieExplorer.ViewModels
{
	public class MEItemTVShow : VMBase
	{
		private int id;
		public int Id
		{
			get
			{
				return id;
			}
			set
			{
				if (value != id)
				{
					id = value;
					RaisePropertyChanged("Id");
				}
			}
		}

		private string title;
		public string Title
		{
			get
			{
				return title;
			}
			set
			{
				if (value != title)
				{
					title = value;
					RaisePropertyChanged("Title");
				}
			}
		}

		private double rate;
		public double Rate
		{
			get
			{
				return rate;
			}
			set
			{
				if (value != rate)
				{
					rate = value;
					RaisePropertyChanged("Rate");
				}
			}
		}

		private int year;
		public int Year
		{
			get
			{
				return year;
			}
			set
			{
				if (value != year)
				{
					year = value;
					RaisePropertyChanged("Year");
				}
			}
		}

		private string poster;
		public string Poster
		{
			get
			{
				return poster;
			}
			set
			{
				if (value != poster)
				{
					poster = value;
					RaisePropertyChanged("Poster");
				}
			}
		}

		public string TitleAndDate
		{
			get
			{
				return string.Format("{0} ({1})", Title, Year.ToString());
			}
		}

		private string background;
		public string Background
		{
			get
			{
				return background;
			}

			set
			{
				if (value != background)
				{
					background = value;
					RaisePropertyChanged("Background");
				}

			}
		}

		private string summary;
		public string Summary
		{
			get
			{
				return summary;
			}

			set
			{
				if (value != summary)
				{
					summary = value;
					RaisePropertyChanged("Summary");
				}

			}
		}

		private string status;
		public string Status
		{
			get
			{
				return status;
			}

			set
			{
				if (value != status)
				{
					status = value;
					RaisePropertyChanged("Status");
				}

			}
		}

		private int numEpisodes;
		public int NumEpisodes
		{
			get
			{
				return numEpisodes;
			}

			set
			{
				if (value != numEpisodes)
				{
					numEpisodes = value;
					RaisePropertyChanged("NumEpisodes");
				}

			}
		}

		private int numSeasons;
		public int NumSeasons
		{
			get
			{
				return numSeasons;
			}

			set
			{
				if (value != numSeasons)
				{
					numSeasons = value;
					RaisePropertyChanged("NumSeasons");
				}

			}
		}

	}
}
