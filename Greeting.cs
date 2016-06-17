using System;
					
public class Greeting
{
	public static void Main() {
		Greeting greet = new Greeting();
		
		Console.WriteLine("What is your name?");
		
		Console.WriteLine("Hello, " + Console.ReadLine() + ", nice to meet you!");
	}
}