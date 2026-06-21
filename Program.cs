using System;


	class Program {

		static void Main() {
			
			string? login;
			string? fA;
			string? pass = "";


	Console.WriteLine("***Checking...");
	System.Threading.Thread.Sleep(200);
		Console.WriteLine("***Booting...");
	System.Threading.Thread.Sleep(2000);
		Console.WriteLine("***Done");
	Console.WriteLine("Please create the user");
		login = Console.ReadLine();
	Console.WriteLine("Add a password? Y/N");
		fA = Console.ReadLine()?.ToLower();
			if (fA == "y") {
			Console.WriteLine("Write the pass");
				pass = Console.ReadLine();
				Console.WriteLine("Creating done");
			}
			else 
				Console.WriteLine("Creating done");
			
	Console.WriteLine("Please login: ");
	string? logon = Console.ReadLine();
		
		while (logon != login) {
			System.Threading.Thread.Sleep(400);
				Console.WriteLine("Please try again");
				logon = Console.ReadLine();
				}

	switch(fA) {			
	case "y":
	Console.WriteLine("Write the password: ");
	string? poss = Console.ReadLine();
		
	while(poss != pass) {
		Console.WriteLine("Try again");
		poss = Console.ReadLine();
	}
		break;
	default:
		Console.WriteLine("You haven't a passwd");
		break;

	}
	Console.WriteLine("Welcome to TestOS");
		}

	}
