using System;
					
public class MadLibs
{
	public static void Main() {
		MadLibs greet = new MadLibs();
		
		Console.WriteLine("Enter a noun:");
		string noun = Console.ReadLine();
		
		Console.WriteLine("Enter a verb: ");
		string verb = Console.ReadLine();
		
		Console.WriteLine("Enter an adjective: ");
		string adj = Console.ReadLine();
		
		Console.WriteLine("Enter an adverb: ");
		string adv = Console.ReadLine();
		
		Console.WriteLine("Do you " + verb + " you " + adj + " " + noun + " " + adv + "? That's hilarious!");
	}
}