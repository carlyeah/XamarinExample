using System;
using Android.Support.V4.App;
using CoursesLibrary;

namespace CoursesAndroid
{
	class CoursePagerAdapter : FragmentStatePagerAdapter
	{
		public CoursePagerAdapter(FragmentManager fm, CourseManager courseManager) : base(fm)
		{
			this.courseManager = courseManager;
		}

		CourseManager courseManager;

		public override Fragment GetItem (int position)
		{
			courseManager.MoveTo (position);
			CourseFragment courseFragment = new CourseFragment ();
			courseFragment.Course = courseManager.Current;

			return courseFragment;
		}

		public override int Count {
			get {
				return courseManager.Length;
			}
		}

	}
}

