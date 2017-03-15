using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using FFImageLoading.Forms.Touch;
using UIKit;

namespace MPwr.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init();

#if ENABLE_TEST_CLOUD
			Xamarin.Calabash.Start();
#endif

			App.ScreenWidth = (double)UIScreen.MainScreen.Bounds.Width;
			App.ScreenHeight = (double)UIScreen.MainScreen.Bounds.Height;

			CachedImageRenderer.Init();

			LoadApplication(new App());

			return base.FinishedLaunching(app, options);
		}
	}
}

