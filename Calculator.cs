using System;
					
public class Calculator
{
	public static void Main() {
		Calculator calculator = new Calculator();
		
		Console.WriteLine("Enter first number:");
		string numEntry = Console.ReadLine();
		int numOne;
		while (!int.TryParse(numEntry, out numOne) || numOne < 0) {
			Console.WriteLine("Must be integer greater than or equal to 0. Enter first number: ");
			numEntry = Console.ReadLine();
		}
		
		Console.WriteLine("Enter second number: ");
		numEntry = Console.ReadLine();
		int numTwo;
		while (!int.TryParse(numEntry, out numTwo) || numTwo <= 0) {
			Console.WriteLine("Must be integer greater than 0. Enter second number: ");
			numEntry = Console.ReadLine();
		}
		
		Console.WriteLine(numOne + " + " + numTwo + " = " + calculator.add(numOne, numTwo));
		Console.WriteLine(numOne + " - " + numTwo + " = " + calculator.subtract(numOne, numTwo));
		Console.WriteLine(numOne + " * " + numTwo + " = " + calculator.multiply(numOne, numTwo));
		Console.WriteLine(numOne + " / " + numTwo + " = " + calculator.divide(numOne, numTwo));
	}
	
	public int add(int first, int second) {
		return first + second;
	}
	
	public int subtract(int first, int second) {
		return first - second;
	}
	
	public int multiply(int first, int second) {
		return first * second;
	}
	
	public int? divide(int first, int second) {
		if (second == 0) {
			return null;
		}
		return first / second;
	}
}