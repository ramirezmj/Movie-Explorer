using MovieExplorer.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieExplorer.ViewModels.Model
{
	public class METVShowCreators : VMBase
	{
		private string name;
		public string Name
		{
			get
			{
				return name;
			}
			set
			{
				if (value != name)
				{
					name = value;
					RaisePropertyChanged("Name");
				}
			}
		}

		private string picture;
		public string Picture
		{
			get
			{
				return picture;
			}
			set
			{
				if (value != picture)
				{
					picture = value;
					RaisePropertyChanged("Picture");
				}
			}
		}

	}
}
