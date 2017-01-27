using System;
using Xamarin.Forms;

namespace ActivityTransitionSample
{
	public static class AbsoluteBoundsEffect
	{
		public static readonly BindableProperty AbsoluteBoundsProperty =
			BindableProperty.CreateAttached("AbsoluteBounds", typeof(Rectangle), typeof(AbsoluteBoundsEffect), new Rectangle(0, 0, 0, 0));

		public static Rectangle GetAbsoluteBounds(BindableObject view)
		{
			return (Rectangle)view.GetValue(AbsoluteBoundsProperty);
		}

		public static void SetAbsoluteBounds(BindableObject view, Rectangle value)
		{
			view.SetValue(AbsoluteBoundsProperty, value);
		}
	}

	class ViewAbsoluteBoundsEffect : RoutingEffect
	{
		public ViewAbsoluteBoundsEffect() : base("Santea.ViewAbsoluteBoundsEffect")
		{
			
		}
	}
}
