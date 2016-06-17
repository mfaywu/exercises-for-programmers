using System;
					
public class Quote
{
	public static void Main() {
		Quote greet = new Quote();
		
		Console.WriteLine("What is the quote?");
		string quote = Console.ReadLine();
		
		Console.WriteLine("Who said it?");
		string author = Console.ReadLine();
		
		Console.WriteLine(author + " says, \"" + quote + "\"");
	}
}