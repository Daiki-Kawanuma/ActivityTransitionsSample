using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ActivityTransitionSample
{
	public partial class DetailPage : ContentPage
	{
		private Image _image;

	    public DetailPage(Image image)
		{
			InitializeComponent();

			_image = image;
			Image.Source = _image.Source;

			/*_image = image;
			Image.Source = _image.Source;
			var rect = (Rectangle)_image.GetValue(AbsoluteBoundsEffect.AbsoluteBoundsProperty);
			//rect.Y -= 60;
			Task.WhenAll(
  				Image.LayoutTo(rect, 0),
				StackLayout.LayoutTo(new Rectangle(0, Height, 0, 0), 0)
			);*/
		}

		protected async override void OnAppearing()
		{
			base.OnAppearing();

			await Task.WhenAll(
  				Image.LayoutTo((Rectangle)_image.GetValue(AbsoluteBoundsEffect.AbsoluteBoundsProperty), 0),
				StackLayout.LayoutTo(new Rectangle(0, Height, 0, 0), 0)
			);
			Image.FadeTo(1.0, 450);
			Image.LayoutTo(new Rectangle(0, 0, Width, 250), 450);
			StackLayout.FadeTo(1.0, 500);
			StackLayout.LayoutTo(new Rectangle(0, 250, Width, Height - 250), 500);

			/*Content.IsVisible = true;
			Image.FadeTo(1.0, 250);
			Image.LayoutTo(new Rectangle(0, 0, Width, 180), 250);
			StackLayout.FadeTo(1.0, 300);
			StackLayout.LayoutTo(new Rectangle(0, 180, Width, Height - 180), 300);*/
		}
	}
}
