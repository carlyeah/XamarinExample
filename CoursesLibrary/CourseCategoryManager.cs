using System;

namespace CoursesLibrary
{
	public class CourseCategoryManager
	{
		private readonly CourseCategory[] courseCategory;
		int currentIndex = 0;
		private readonly int lastIndex;

		public CourseCategoryManager()
		{
			courseCategory = InitCategories();
			lastIndex = courseCategory.Length;
		}

		private CourseCategory[] InitCategories()
		{
			var initCategories = new CourseCategory[] {
				new CourseCategory()
				{ 
					Title = "Android",
					Description = "Android Programming Courses",
				},

				new CourseCategory()
				{ 
					Title = "iOS",
					Description = "iOS Programming Courses",
				},
				new CourseCategory()
				{ 
					Title = "Windows Phone",
					Description = "Windows Phone Programming Courses",
				}
			};

			return initCategories;
		}

		public int Length
		{
			get {return courseCategory.Length;}
		}

		public void MoveFirst()
		{
			currentIndex = 0;
		}

		public void MovePrev()
		{
			if (currentIndex > 0) {
				currentIndex--;
			}
		}

		public void MoveNext()
		{
			if (currentIndex < courseCategory.Length - 1) {
				currentIndex++;
			}
		}

		public CourseCategory Current
		{
			get{ return courseCategory [currentIndex]; }
		}

		public Boolean CanMovePrev
		{
			get {return currentIndex > 0;}
		}

		public Boolean CanMoveNext
		{
			get {return currentIndex < lastIndex - 1;}
		}

		public void MoveTo(int position)
		{
			if (position >= 0 && position <= lastIndex) {
				currentIndex = position;
			} else {
				throw new IndexOutOfRangeException(String.Format("{0} is an invalid position. Must be between 0 and {1}", position, lastIndex));
			}

		}
	}
}

