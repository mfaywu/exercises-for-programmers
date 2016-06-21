using System;
using System.Collections;
					
public class SelfCheckout
{
	public static void Main() {
		SelfCheckout calculator = new SelfCheckout();
		
		ArrayList priceOfItems = new ArrayList();
		ArrayList quantityOfItems = new ArrayList();
		
		Console.WriteLine("Enter price of item or ENTER if you have no more items.");
		string priceEntry = Console.ReadLine();
		decimal price;
		while (priceEntry != "") {
			while (!decimal.TryParse(priceEntry, out price) || price <= 0 || (Decimal.Round(price, 2) != price)) {
				Console.WriteLine("Must be a valid price greater than 0. Enter price of item: ");
				priceEntry = Console.ReadLine();
			}
			
			Console.WriteLine("Enter quantity of item: ");
			string quantityEntry = Console.ReadLine();
			int quantity;
			while (!int.TryParse(quantityEntry, out quantity) || quantity <= 0) {
				Console.WriteLine("Must be greater than 0. Enter quantity of item: ");
				quantityEntry = Console.ReadLine();
			}
			
			priceOfItems.Add(price);
			quantityOfItems.Add(quantity);
			
			Console.WriteLine("Enter price of item or ENTER if you have no more items.");
			priceEntry = Console.ReadLine();
		}
		if (priceOfItems.Count != quantityOfItems.Count) {
			Console.WriteLine("Error");
			return;
		}
		decimal subtotal = calculator.subtotal(priceOfItems, quantityOfItems);
		Console.WriteLine("Subtotal: " + Decimal.Round(subtotal, 2));
		decimal tax = subtotal * (decimal)0.055;
		Console.WriteLine("Tax: " + Decimal.Round(tax, 2));
		Console.WriteLine("Total: " + Decimal.Round((tax + subtotal), 2));
	}
	
	public decimal subtotal (ArrayList prices, ArrayList quantities) {
		decimal sum = 0;
		for (int idx = 0; idx < prices.Count; idx++) {
			decimal price = (decimal)prices[idx];
			int quantity = (int)quantities[idx];
			sum += (price * quantity);
		}
		return sum;
	}
}