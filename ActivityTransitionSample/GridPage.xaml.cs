using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Input;
using Xamarin.Forms;

namespace ActivityTransitionSample
{
	public partial class GridPage : ContentPage
	{
		public IList<ImageModel> ImageModels { get; set; }

	    public GridPage()
		{
			InitializeComponent();
			ImageModels = ImageModel.GenerateList();
			BindingContext = this;
		}

		public void OnImageClicked(object sender, EventArgs e)
		{
			Debug.WriteLine("OnImageClicked ...");
			var image = sender as Image;
			//image.Effects.Add(new ViewAbsoluteBoundsEffect());
			Navigation.PushAsync(new DetailPage(image));
		}
	}
}