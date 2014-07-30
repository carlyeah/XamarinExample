using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using CoursesLibrary;

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
		CourseManager courseManager;

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

			courseManager = new CourseManager ();
			courseManager.MoveFirst ();

		}

		void buttonPrev_Click(object sender, EventArgs e)
		{
			courseManager.MovePrev ();
			UpdateUI ();

		}

		void buttonNext_Click(object sender, EventArgs e)
		{
			courseManager.MoveNext ();
			UpdateUI ();

		}

		private void UpdateUI()
		{

			titleLabel.Text = courseManager.Current.Title;
			subtitleLabel.Text = courseManager.Current.Description;
		}
	}
}


