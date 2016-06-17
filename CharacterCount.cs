using System;
					
public class CharacterCount
{
	public static void Main() {
		CharacterCount greet = new CharacterCount();
		
		Console.WriteLine("What is the input string?");
		string str = Console.ReadLine();
		while (str.Length == 0) {
			Console.WriteLine("You entered an empty string. What is the input string?");
			str = Console.ReadLine();
		}
		int numChars = str.Length;
		
		Console.WriteLine(str + " has " + numChars + " characters.");
	}
}