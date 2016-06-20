using System;
					
public class PaintCalculator
{
	public static void Main() {
		PaintCalculator calculator = new PaintCalculator();
		
		Console.WriteLine("Choose type of room: \n(0) rectangle \n(1) round");
		string typeEntry = Console.ReadLine();
		int type;
		while (!int.TryParse(typeEntry, out type) || (type < 0 || type > 1)) {
			Console.WriteLine("Must be 0 or 1. Enter choice: ");
			typeEntry = Console.ReadLine();
		}
		
		double area = 0.0;
		switch(type) {
			case 0:
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
		
				area = length * width;
				break;
			case 1:
				Console.WriteLine("What is the radius of the room in feet?");
				string radiusEntry = Console.ReadLine();
				double radius;
				while (!double.TryParse(radiusEntry, out radius) || radius <= 0) {
					Console.WriteLine("Must be greater than 0. Enter length: ");
					radiusEntry = Console.ReadLine();
				}
			
				area = Math.PI * radius * radius;
				break;
			default: 
				break;
			
		}
		Console.WriteLine("You will need to purchase " + calculator.gallons(area) + " gallons of paint to cover " + area + " square feet.");
	}
	
	public double gallons(double area) {
		int gallonsNeeded = (int)area / 350 + ((area % 350 != 0) ? 1 : 0);
		return gallonsNeeded;
	}
}