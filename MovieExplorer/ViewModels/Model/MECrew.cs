using MovieExplorer.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieExplorer.ViewModels
{
	public class MECrew : VMBase
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

		private string department;
		public string Department
		{
			get
			{
				return department;
			}
			set
			{
				if (value != department)
				{
					department = value;
					RaisePropertyChanged("Department");
				}
			}
		}

		private string job;
		public string Job
		{
			get
			{
				return job;
			}
			set
			{
				if (value != job)
				{
					job = value;
					RaisePropertyChanged("Job");
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
