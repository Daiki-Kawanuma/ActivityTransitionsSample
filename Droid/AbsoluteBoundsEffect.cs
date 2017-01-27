using System;
using ActivityTransitionSample.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ResolutionGroupName("Santea")]
[assembly: ExportEffect(typeof(ViewAbsoluteBoundsEffect), "ViewAbsoluteBoundsEffect")]

namespace ActivityTransitionSample.Droid
{
    public class ViewAbsoluteBoundsEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            try
            {
                Control.LayoutChange += (sender, e) => { UpdateAbsoluteBounds(); };

                UpdateAbsoluteBounds();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot set property on attached control. Error: ", ex.Message);
            }
        }

        protected override void OnDetached()
        {
        }

        private void UpdateAbsoluteBounds()
        {
            var position = new int[2];
            Control.GetLocationInWindow(position);

            var activity = Forms.Context as FormsAppCompatActivity;
            var density = activity.Resources.DisplayMetrics.Density;

            AbsoluteBoundsEffect.SetAbsoluteBounds(Element,
                new Rectangle((int) (position[0] / density + 0.5f),
                    (int) (position[1] / density + 0.5f),
                    (int) (Control.Width / density + 0.5f),
                    (int) (Control.Height / density + 0.5f)));
        }
    }
}