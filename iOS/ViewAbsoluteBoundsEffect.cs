using System;
using ActivityTransitionSample.iOS;
using CoreGraphics;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ResolutionGroupName("Santea")]
[assembly: ExportEffect(typeof(ViewAbsoluteBoundsEffect), "ViewAbsoluteBoundsEffect")]
namespace ActivityTransitionSample.iOS
{
	public class ViewAbsoluteBoundsEffect : PlatformEffect
	{
		private IDisposable _observer;

		protected override void OnAttached()
		{
			try
			{
				_observer = Control.AddObserver("Frame", Foundation.NSKeyValueObservingOptions.Initial, (obj) =>
				{
					UpdateAbsoluteBounds();
				});		
				UpdateAbsoluteBounds();
			}
			catch (Exception ex)
			{
				Console.WriteLine("Cannot set property on attached control. Error: ", ex.Message);
			}
		}

		protected override void OnDetached()
		{
			_observer.Dispose();
			_observer = null;
		}

		private void UpdateAbsoluteBounds()
		{
			var point = GetAbsolutePoint(Control);
			Console.WriteLine($"X:{point.X}, Y:{point.Y}");
			AbsoluteBoundsEffect.SetAbsoluteBounds(Element,
												   new Rectangle(point.X, point.Y, Control.Frame.Width, Control.Frame.Height));
		}

		private CGPoint GetAbsolutePoint(UIView view)
		{
			CGPoint point = new CGPoint(view.Frame.X, view.Frame.Y);
			if (view.Superview != null)
			{
				CGPoint addPoint = GetAbsolutePoint(view.Superview);
				point = new CGPoint(point.X + addPoint.X, point.Y + addPoint.Y);
			}

			return point;
		}
	}
}
