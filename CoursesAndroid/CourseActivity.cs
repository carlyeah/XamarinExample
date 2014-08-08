
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Support.V4.App;
using CoursesLibrary;
using Android.Support.V4.View;

namespace CoursesAndroid
{
	[Activity (Label = "Course Activity")]
	public class CourseActivity : FragmentActivity
	{
		CourseManager courseManager;
		CoursePagerAdapter coursePagerAdapter;
		ViewPager viewPager;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.CourseActivity);

			courseManager = new CourseManager ();

			coursePagerAdapter = new CoursePagerAdapter (SupportFragmentManager,courseManager);

			viewPager = FindViewById<ViewPager> (Resource.Id.coursePager);
			viewPager.Adapter = coursePagerAdapter;
	    }
	}
}

