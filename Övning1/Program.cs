namespace Övning1
{
	internal class Program
	{

		static List<Personel> personels = new List<Personel>();
		static void Main(string[] args)
		{
			bool addPersonel = true;

			while (addPersonel)
			{
				addPersonel = MainMenu();
				
			}

		}
		private static bool MainMenu()
		{
			Console.WriteLine("List of employees");
			Console.WriteLine("1) Add employees");
			Console.WriteLine("2) Show employees");
			Console.WriteLine("0) Exit");

			string result = Console.ReadLine();
			if (result == "1")
			{
				personels.Add(AddPersonel());
				return true;
			}
			else if (result == "2")
			{
				ShowEmployees(personels);
				return true;
			}
			else
			{
                Console.WriteLine("Have a nice day!");
				return false;
			}
		}

		private static void ShowEmployees(List<Personel> personels)
		{

			foreach (Personel personel in personels)
			{
                Console.WriteLine($"First name: {personel.firstName}, " +
					$"Last name {personel.lastName} " +
					$"salary: {personel.perSal}");
            }
			

		}

		private static Personel AddPersonel()
		{
			Personel personel = new Personel();
            Console.WriteLine("Enter your first name");
            personel.firstName = Console.ReadLine();
            Console.WriteLine("Enter your last name");
            personel.lastName = Console.ReadLine();
            Console.WriteLine("Enter your salary");
			personel.perSal = Console.ReadLine();

			return personel;

			
		}
	}
}