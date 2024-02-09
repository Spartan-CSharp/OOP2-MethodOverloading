namespace MethodOverload
{
	public class EmployeeModel
	{
		public string FirstName
		{
			get; set;
		}

		public string LastName
		{
			get; set;
		}

		public string Email
		{
			get; set;
		}

		public decimal Salary
		{
			get; set;
		}

		public string FullName
		{
			get
			{
				return $"{FirstName} {LastName}";
			}
		}

		public EmployeeModel()
		{
		}

		public EmployeeModel(string firstName, string lastName)
		{
			FirstName = firstName;
			LastName = lastName;
		}

		public EmployeeModel(string firstName, string lastName, string email)
		{
			FirstName = firstName;
			LastName = lastName;
			Email = email;
		}

		public EmployeeModel(string firstName, string lastName, decimal salary)
		{
			FirstName = firstName;
			LastName = lastName;
			Salary = salary;
		}
	}
}
