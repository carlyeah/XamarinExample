using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace CoursesAndroid
{
	[Activity (Label = "Courses", MainLauncher = true, Icon = "@drawable/icon")]

	public class MainActivity : Activity
	{
		Button buttonPrev;
		Button buttonNext;
		TextView titleLabel;
		TextView subtitleLabel;
		ImageView image;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			buttonPrev = FindViewById<Button> (Resource.Id.prevButton);

			buttonNext = FindViewById<Button> (Resource.Id.nextButton);

			titleLabel = FindViewById<TextView> (Resource.Id.titleLabel);

			subtitleLabel = FindViewById<TextView> (Resource.Id.subTitleLabel);

			image = FindViewById<ImageView> (Resource.Id.photoView);

			buttonPrev.Click += buttonPrev_Click;
			buttonNext.Click += buttonNext_Click;

		}

		void buttonPrev_Click(object sender, EventArgs e)
		{
			titleLabel.Text = "Prev clicked";
		}

		void buttonNext_Click(object sender, EventArgs e)
		{
			titleLabel.Text = "Next clicked";
		}
	}
}


