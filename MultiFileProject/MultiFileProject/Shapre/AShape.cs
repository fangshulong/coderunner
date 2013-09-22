using System;

namespace Shape.Father
{
	public abstract class Shape { 
		protected string color; 
		public Shape( string color ) { 
			this.color = color; 
		} 
		public string getColor( ) { 
			return color; 
		} 
		public abstract double getArea( ); 
	}
}

