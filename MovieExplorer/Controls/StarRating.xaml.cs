using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace MovieExplorer.Controls
{
	public sealed partial class StarRating : UserControl
	{

		public static readonly DependencyProperty RateProperty =
		DependencyProperty.Register("Rate", typeof(double), typeof(StarRating),
				 new PropertyMetadata(0.0, new PropertyChangedCallback(OnRateChanged)));


		public double Rate
		{
			get { return (double)GetValue(RateProperty); }
			set { SetValue(RateProperty, value); }
		}

		private static void OnRateChanged(DependencyObject obj, DependencyPropertyChangedEventArgs e)
		{
			var uc = obj as StarRating;
			if (uc != null && e.NewValue != e.OldValue)
			{
				double value = Convert.ToDouble(e.NewValue);

				uc.star_1.Fill = new SolidColorBrush(Colors.Gray);
				uc.star_2.Fill = new SolidColorBrush(Colors.Gray);
				uc.star_3.Fill = new SolidColorBrush(Colors.Gray);
				uc.star_4.Fill = new SolidColorBrush(Colors.Gray);
				uc.star_5.Fill = new SolidColorBrush(Colors.Gray);

				if (value == 0) return;

				double floorValue = Math.Floor(value);
				double realPart = value - floorValue;

				LinearGradientBrush gradient = new LinearGradientBrush();
				gradient.StartPoint = new Point(0.5, 0);
				gradient.EndPoint = new Point(1, 0);

				GradientStop first = new GradientStop();
				first.Color = Colors.Yellow;
				first.Offset = realPart;

				GradientStop second = new GradientStop();
				second.Color = Colors.Gray;
				second.Offset = realPart;

				gradient.GradientStops.Add(first);
				gradient.GradientStops.Add(second);

				if (value > 0 && value < 1)
				{
					uc.star_1.Fill = gradient;
					return;
				}

				if (value > 1 && value < 2)
				{
					uc.star_1.Fill = new SolidColorBrush(Colors.Yellow);
					uc.star_2.Fill = gradient;
					return;
				}

				if (value > 2 && value < 3)
				{
					uc.star_1.Fill = new SolidColorBrush(Colors.Yellow);
					uc.star_2.Fill = new SolidColorBrush(Colors.Yellow);
					uc.star_3.Fill = gradient;
					return;
				}

				if (value > 3 && value < 4)
				{
					uc.star_1.Fill = new SolidColorBrush(Colors.Yellow);
					uc.star_2.Fill = new SolidColorBrush(Colors.Yellow);
					uc.star_3.Fill = new SolidColorBrush(Colors.Yellow);
					uc.star_4.Fill = gradient;
					return;
				}

				if (value > 4 && value < 5)
				{
					uc.star_1.Fill = new SolidColorBrush(Colors.Yellow);
					uc.star_2.Fill = new SolidColorBrush(Colors.Yellow);
					uc.star_3.Fill = new SolidColorBrush(Colors.Yellow);
					uc.star_4.Fill = new SolidColorBrush(Colors.Yellow);
					uc.star_5.Fill = gradient;
					return;
				}
				else {
					uc.star_1.Fill = new SolidColorBrush(Colors.Yellow);
					uc.star_2.Fill = new SolidColorBrush(Colors.Yellow);
					uc.star_3.Fill = new SolidColorBrush(Colors.Yellow);
					uc.star_4.Fill = new SolidColorBrush(Colors.Yellow);
					uc.star_5.Fill = new SolidColorBrush(Colors.Yellow);
				}
			}
		}

		public StarRating()
		{
			this.InitializeComponent();
		}
	}
}
