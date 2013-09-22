using System;

namespace Shape.Sub
{
	public class Circle : Shape.Father.Shape { 
		private double radius; 
		public Circle( string color, double radius ) : base( color ) { 
			this.radius = radius; 
		} 
		public override double getArea( ) { 
			return System.Math.PI * radius * radius; 
		} 
	} 
}

