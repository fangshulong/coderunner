using System;

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

public class Circle : Shape { 
    private double radius; 
    public Circle( string color, double radius ) : base( color ) { 
        this.radius = radius; 
    } 
    public override double getArea( ) { 
        return System.Math.PI * radius * radius; 
    } 
} 

public class Square : Shape { 
    private double sideLen; 
    public Square( string color, double sideLen ) : base( color ) { 
        this.sideLen = sideLen; 
    } 
    public override double getArea( ) { 
        return sideLen * sideLen; 
    } 
} 

/*
public class Rectangle : Shape {
	//请完善这一个
}
*/

class Program
{
	static void Main(string[] args)
	{
		Shape myCircle = new Circle( "orange", 3 );   
		System.Console.WriteLine( "圆的颜色是:" + myCircle.getColor( ) + "\n"
		+ "它的面积是:" + myCircle.getArea( ) + "." );
		 
		System.Console.WriteLine("\n----------------------------\n");
		Shape mySquare = new Square( "green", 4 );
		System.Console.WriteLine( "正方形的颜色是:" + mySquare.getColor( ) + "\n"
		+ "它的面积是:" + mySquare.getArea( ) + "." ); 
		
		//请参照上面的两个例子，完成这个长方形
	}
}