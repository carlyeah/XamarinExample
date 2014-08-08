using System;

namespace CoursesLibrary
{
	public class CourseCategory
	{
		public String Title{ get; internal set;}

		public String Description{get; internal set;}

		public override string ToString ()
		{
			return Title;
		}
	}
}

