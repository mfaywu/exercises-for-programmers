using System;
					
public class TipCalculator
{
	public static void Main() {
		TipCalculator calc = new TipCalculator();
		
		Console.WriteLine("What is the bill amount?");
		string billEntry = Console.ReadLine();
		Decimal billAmount;
		while (!Decimal.TryParse(billEntry, out billAmount) || (Decimal.Round(billAmount, 2) != billAmount)) {
			Console.WriteLine("Enter a valid bill amount.");
			billEntry = Console.ReadLine();
		}
		
		Console.WriteLine("What is the tip rate?");
		string tipEntry = Console.ReadLine();
		Decimal tipRate;
		while (!Decimal.TryParse(tipEntry, out tipRate) || (Decimal.Round(tipRate, 2) != tipRate)) {
			Console.WriteLine("Enter a valid tip rate.");
			tipEntry = Console.ReadLine();
		}
		
		Decimal tip = calc.CalculateTip(billAmount, tipRate);
		Console.WriteLine("Your tip is: " + tip);
		Decimal total = tip + billAmount;
		Console.WriteLine("Your total is: " + total);
	}
	
    public decimal CalculateTip(decimal billAmount, decimal tipRate)
    {
		tipRate = tipRate / 100;
		if (Decimal.Compare(billAmount, 0) <= 0 || Decimal.Compare(tipRate, 0) <= 0 || Decimal.Compare(tipRate, 1) >= 0) {
			return -1;
		}
		decimal tip = Decimal.Round(billAmount * (tipRate / 100), 2);
        return tip;
    }
}