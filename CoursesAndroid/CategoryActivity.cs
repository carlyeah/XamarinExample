﻿
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

using CoursesLibrary;

namespace CoursesAndroid
{
	[Activity (Label = "Courses", MainLauncher = true, Icon = "@drawable/icon")]

	public class CategoryActivity : ListActivity
	{
		CourseCategoryManager courseCategoryManager;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			courseCategoryManager = new CourseCategoryManager ();

			ListAdapter = new CourseCategoryManagerAdapter (this, Android.Resource.Layout.SimpleListItem1, courseCategoryManager);


		}
	}
}

