using System;
					
public class PizzaParty
{
	public static void Main() {
		PizzaParty calculator = new PizzaParty();
		
		Console.WriteLine("How many people?");
		string peopleEntry = Console.ReadLine();
		int people;
		while (!int.TryParse(peopleEntry, out people) || people <= 0) {
			Console.WriteLine("Must be greater than 0. Enter number of people: ");
			peopleEntry = Console.ReadLine();
		}
		
		Console.WriteLine("How many pizzas do you have?");
		string pizzaEntry = Console.ReadLine();
		int pizzas;
		while (!int.TryParse(pizzaEntry, out pizzas) || pizzas < 0) {
			Console.WriteLine("Must be greater than 0. Enter number of pizzas: ");
			pizzaEntry = Console.ReadLine();
		}
		
		Console.WriteLine("How many slices per pizza?");
		string pizzaSlicesEntry = Console.ReadLine();
		int pizzaSlices;
		while (!int.TryParse(pizzaSlicesEntry, out pizzaSlices) || pizzaSlices * pizzas < people) {
			Console.WriteLine("Not enough slices. Enter number of slices per pizza: ");
			pizzaSlicesEntry = Console.ReadLine();
		}
		
		Console.WriteLine(people + " people with " + pizzas + " pizzas.");
		int slicesPerPerson = (pizzas * pizzaSlices) / people;
		
		Console.WriteLine("Each person gets " + slicesPerPerson + " piece" + ((slicesPerPerson > 1) ? "s" : "") + " of pizza.");
		Console.WriteLine("There are " + (pizzas * pizzaSlices - people * slicesPerPerson) + " leftover pieces.");
	}
}