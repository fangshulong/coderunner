using System;

class Line 
{
	private int start = 0;
	private int end = 0;
	private int length = 0;	
	
	public Line() 
	{
		System.Console.WriteLine("我是一个空的初始化函数\n");
	}
	
	public Line(int start, int end) 
	{
		this.start = start;
		this.end = end;
	}
	
	public void setStart(int value) 
	{
		this.start = value;
	}
	
	public void setEnd(int value) 
	{
		this.end = value;
	}
	
	public int getLength() 
	{
		return 	length;
	}
	
	public int countLength() 
	{
		return end - start;
	} 
}

class Program
{	
	public int sumTwoOpt(int opt1, int opt2) {
		return opt1+opt2;
	}
	
	public static int sumThreeOpt(int opt1, int opt2, int opt3) {
		return opt1+opt2+opt3;
	}
	
	static void Main(string[] args)
	{
		Program program1 = new Program();
		int sum = program1.sumTwoOpt(1, 2);
		System.Console.WriteLine( "两个数的和："+sum);
		
		int sum2 = sumThreeOpt(2, 3, 4);
		System.Console.WriteLine( "三个数的和："+sum2); 
		
		//----------------------分割线-----------------------
		System.Console.WriteLine( "-----------------------"); 
		Line line = new Line();
		line.setStart(5);
		line.setEnd(10);
		int length = line.countLength();
		System.Console.WriteLine("这条线路的长度："+length);
		
		Line line2 = new Line(1, 9);
		System.Console.WriteLine("这条线路的长度："+line2.countLength());
		System.Console.WriteLine("打印出这个对象："+line2);
	}
}