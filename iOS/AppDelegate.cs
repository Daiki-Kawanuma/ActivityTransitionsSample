using System;
using System.Collections.Generic;
using System.Linq;
using DLToolkit.Forms.Controls;
using Foundation;
using UIKit;

namespace ActivityTransitionSample.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init();
			FlowListView.Init();

			LoadApplication(new App());

			return base.FinishedLaunching(app, options);
		}
	}
}
