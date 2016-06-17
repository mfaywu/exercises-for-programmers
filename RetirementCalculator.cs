using System;
					
public class RetirementCalculator
{
	public static void Main() {
		RetirementCalculator calculator = new RetirementCalculator();
		
		Console.WriteLine("What is your current age?");
		string ageEntry = Console.ReadLine();
		int age;
		while (!int.TryParse(ageEntry, out age) || age < 0) {
			Console.WriteLine("Must be integer greater than 0. Enter age: ");
			ageEntry = Console.ReadLine();
		}
		
		Console.WriteLine("At what age would you like to retire? ");
		string retireEntry = Console.ReadLine();
		int retireAge;
		while (!int.TryParse(retireEntry, out retireAge) || retireAge <= 0) {
			Console.WriteLine("Must be integer greater than 0. Enter age to retire: ");
			retireEntry = Console.ReadLine();
		}
		int yearsLeft = calculator.subtract(retireAge, age);
		if (yearsLeft <= 0) {
			Console.WriteLine("You can already retire.");
		}
		else {
			Console.WriteLine("You have " + yearsLeft + " years left until you can retire.");
			Console.WriteLine("It's " + DateTime.Now.Year + ", so you can retire in " + calculator.add(DateTime.Now.Year, yearsLeft));
	
		}
	}
	
	public int add(int first, int second) {
		return first + second;
	}
	
	public int subtract(int first, int second) {
		return first - second;
	}
}