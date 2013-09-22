using System;

namespace Shape
{
	public class Circle : Shape { 
		private double radius; 
		public Circle( string color, double radius ) : base( color ) { 
			this.radius = radius; 
		} 
		public override double getArea( ) { 
			return System.Math.PI * radius * radius; 
		} 
	} 
}

