using System;
					
public class RectangleArea
{
	public static void Main() {
		RectangleArea calculator = new RectangleArea();
		
		Console.WriteLine("What is the length of the room in feet?");
		string lengthEntry = Console.ReadLine();
		double length;
		while (!double.TryParse(lengthEntry, out length) || length <= 0) {
			Console.WriteLine("Must be greater than 0. Enter length: ");
			lengthEntry = Console.ReadLine();
		}
		
		Console.WriteLine("What is the width of the room in feet? ");
		string widthEntry = Console.ReadLine();
		double width;
		while (!double.TryParse(widthEntry, out width) || width <= 0){
			Console.WriteLine("Must be greater than 0. Enter width: ");
			widthEntry = Console.ReadLine();
		}
		
		Console.WriteLine("You entered dimensions of " + length + " feet by " + width + " feet.");
		Console.WriteLine("The area is \n" + calculator.areaInFeet(length, width) + " square feet \n" + calculator.areaInMeters(length, width) + " square meters");
	}
	
	public double areaInFeet(double length, double width) {
		return length * width;	
	}
	
	public double areaInMeters(double length, double width) {
		return length * width * 0.09290304;
	}
}