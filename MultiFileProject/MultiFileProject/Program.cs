using System;
using Shape;

namespace MultiFileProject
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Circle circle = new Circle ("White", 10);
			//下面这两行，有什么区别
			Console.WriteLine ("Circle area = " + circle.getArea());
			System.Console.WriteLine ("Circle area = " + circle.getArea());
		}
	}
}
