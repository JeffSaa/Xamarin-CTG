using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace PostsDemo.Droid
{
	[Activity (Label = "PostsDemo.Android", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.goBtn);
			
			button.Click += delegate {
                var posts_activity = new Intent(this, typeof(Posts));
                posts_activity.PutExtra("UserName", FindViewById<EditText>(Resource.Id.userName).Text);
                StartActivity(posts_activity);
            };
		}

	}
}


