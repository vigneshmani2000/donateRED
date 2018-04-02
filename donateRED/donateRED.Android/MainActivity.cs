using System;
using Android.Gms.Common;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Firebase.Iid;
using Firebase.Messaging;
using donateRed.Common.Services;

namespace donateRED.Droid
{
	[Activity (Label = "donateRED", Icon = "@drawable/icon", Theme= "@style/Quicktheme.Splash",
        MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
	{

        const string TAG = "MainActivity";
        protected override void OnCreate (Bundle bundle)
		{
			TabLayoutResource = Resource.Layout.Tabbar;
			ToolbarResource = Resource.Layout.Toolbar;

            base.Window.RequestFeature(WindowFeatures.ActionBar);
            // Name of the MainActivity theme you had there before.
            // Or you can use global::Android.Resource.Style.ThemeHoloLight
            base.SetTheme(Resource.Style.MainTheme);

            base.OnCreate (bundle);

			global::Xamarin.Forms.Forms.Init (this, bundle);
			LoadApplication (new donateRed.Common.App());

            //FirebaseMessaging.Instance.SubscribeToTopic(CloudMessagingTopics.Blood);
        }
	}
}

