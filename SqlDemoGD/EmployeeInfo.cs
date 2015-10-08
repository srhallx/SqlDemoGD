using System;
using System.Data;
using SQLite;

namespace SqlDemoGD
{
	public class EmployeeInfo
	{
		[PrimaryKey, AutoIncrement]
		public int ID { get; set; }
		public string FullName { get; set; }
		public string SSN { get; set; }
		public string Salary { get; set; }
		public string DOB { get; set; }
		public string HireDate { get; set; }
		public string StreetAddress { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public string Country { get; set; }
		public string PostalCode { get; set; }

	}
}

