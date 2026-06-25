using System;


	class Program {

		static void Main() {
			
			string? login;
			string? fA;
			string? pass = "";
			Random rf = new Random();
			Random rs = new Random();
			short tf = Convert.ToInt16(rf.Next(200, 2000));
			short ts = Convert.ToInt16(rs.Next(300, 5000));

	Console.WriteLine("***Checking...");
	System.Threading.Thread.Sleep(tf);
		Console.WriteLine("***Booting...");
	System.Threading.Thread.Sleep(tf);
		Console.WriteLine("***Done");
		while(true) {
	Console.WriteLine("****Please create the user");
		login = Console.ReadLine();
		if (!string.IsNullOrWhiteSpace(login)) 
			break;
	Console.WriteLine("Error: This field must not be empty");
	}
		while(true){
	Console.WriteLine("****Add a password? Y/N");
		fA = Console.ReadLine()?.ToLower();
		if (!string.IsNullOrWhiteSpace(fA))
			break;
	Console.WriteLine("Error: This field must not be empty");
		}
			if (fA == "y") {
				while(true) {
			Console.WriteLine("****Write the pass");
				pass = Console.ReadLine();
				if (!string.IsNullOrWhiteSpace(pass))
					break;
			Console.WriteLine("Error: This field must not be empty");
				}
				Console.WriteLine("****Creating done");
			}
			else 
				Console.WriteLine("****Creating done");
			
	Console.WriteLine("****Please login: ");
	string? logon = Console.ReadLine();
		
		while (logon != login) {
			System.Threading.Thread.Sleep(400);
				Console.WriteLine("Error: Please try again");
				logon = Console.ReadLine();
				}

	switch(fA) {			
	case "y":
	Console.WriteLine("***Write the password: ");
	string? poss = Console.ReadLine();
		
	while(poss != pass) {
		Console.WriteLine("Error: Try again");
		poss = Console.ReadLine();
	}
		break;
	default:
		Console.WriteLine("****You haven't a passwd");
		break;

	}
	Console.WriteLine("*****Welcome to TestOS");
		}

	}
