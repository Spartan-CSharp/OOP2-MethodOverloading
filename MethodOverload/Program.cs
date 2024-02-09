using System;

namespace MethodOverload
{
	internal class Program
	{
		private static void Main()
		{
			EmployeeModel employee1 = new EmployeeModel();
			EmployeeModel employee2 = new EmployeeModel("Tim", "Corey");
			EmployeeModel employee3 = new EmployeeModel("Tim", "Corey", "tim.corey@iamtimcorey.com");
			EmployeeModel employee4 = new EmployeeModel("Tim", "Corey", 60000.00M);

			Console.WriteLine($"{employee1.FullName}\t{employee1.Email}\t{employee1.Salary}");
			Console.WriteLine($"{employee2.FullName}\t{employee2.Email}\t{employee2.Salary}");
			Console.WriteLine($"{employee3.FullName}\t{employee3.Email}\t{employee3.Salary}");
			Console.WriteLine($"{employee4.FullName}\t{employee4.Email}\t{employee4.Salary}");

			_ = Console.ReadLine();
		}
	}
}
