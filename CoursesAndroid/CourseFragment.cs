
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using CoursesLibrary;
using Android.Support.V4.App;

namespace CoursesAndroid
{
	public class CourseFragment : Fragment
	{

		TextView titleLabel;
		TextView subtitleLabel;
		ImageView image;

		public Course Course{ get; set;}

		public override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			// Create your fragment here
		}

		public override View OnCreateView (LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			View rootView = inflater.Inflate (Resource.Layout.CourseFragment, container, false);

			titleLabel = rootView.FindViewById<TextView> (Resource.Id.titleLabel);

			subtitleLabel = rootView.FindViewById<TextView> (Resource.Id.subTitleLabel);

			image = rootView.FindViewById<ImageView> (Resource.Id.photoView);

			titleLabel.Text = Course.Title;
			subtitleLabel.Text = Course.Description;


			return rootView;

		}
	}
}

