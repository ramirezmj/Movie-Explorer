using MovieExplorer.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieExplorer.ViewModels.Model
{
	public class METVShowSeason : VMBase
	{
		private int number;
		public int Number
		{
			get
			{
				return number;
			}
			set
			{
				if (value != number)
				{
					number = value;
					RaisePropertyChanged("Number");
				}
			}
		}

		private string airDate;
		public string AirDate
		{
			get
			{
				return airDate;
			}
			set
			{
				if (value != airDate)
				{
					airDate = value;
					RaisePropertyChanged("AirDate");
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
	}
}
