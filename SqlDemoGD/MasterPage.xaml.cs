using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SqlDemoGD
{
	public partial class MasterPage : ContentPage
	{

		public MasterPage ()
		{
			InitializeComponent ();

			btnCreate.Clicked += (object sender, EventArgs e) => {
				var dataOps = new DataOperations(App.DBPath);
				dataOps.CreateDB();
			};

			btnQuery.Clicked += (object sender, EventArgs e) => {
				var dataOps = new DataOperations(App.DBPath);
				var rows = dataOps.GetEmployees();

				App.EmployeeInfoData = rows;
			};

			btnInsert.Clicked += (object sender, EventArgs e) => {

				var dataOps = new DataOperations(App.DBPath);

				var emp = new EmployeeInfo() {
					FullName = "Fiona Glade",
					SSN = "AB827323B",
					Salary = "£85,000",
					DOB = "08/01/1966",
					HireDate = "03/05/2012",
					StreetAddress = "1410 Oak St",
					City = "Pleasantown",
					State = "TX",
					PostalCode = "55511"
				};		

				dataOps.InsertEmployee(emp);

				emp = new EmployeeInfo() {
					FullName = "Chuck Chuckaroo",
					SSN = "AB882152C",
					Salary = "£78,000",
					DOB = "02/18/1971",
					HireDate = "11/22/2014",
					StreetAddress = "5744 Crossroads Blvd",
					City = "Bourbon",
					State = "KY",
					PostalCode = "27181"
				};		

				dataOps.InsertEmployee(emp);

				emp = new EmployeeInfo() {
					FullName = "Ben Benson",
					SSN = "AB928227C",
					Salary = "£39,500",
					DOB = "11/03/1980",
					HireDate = "11/22/2014",
					StreetAddress = "5744 Crossroads Blvd",
					City = "Bourbon",
					State = "KY",
					PostalCode = "27181"
				};		

				dataOps.InsertEmployee(emp);

				emp = new EmployeeInfo() {
					FullName = "Daniel Dapper",
					SSN = "AB011920A",
					Salary = "£101,000",
					DOB = "10/15/1978",
					HireDate = "01/20/2015",
					StreetAddress = "Seven Turns Highway",
					City = "Birmingham",
					State = "AL",
					PostalCode = "22313"
				};		

				dataOps.InsertEmployee(emp);

				emp = new EmployeeInfo() {
					FullName = "Erwin Eckert",
					SSN = "AB828880C",
					Salary = "£95,000",
					DOB = "10/12/1981",
					HireDate = "03/22/2013",
					StreetAddress = "33 Friar Court",
					City = "Nottingham",
					State = "VA",
					PostalCode = "28272"
				};		

				dataOps.InsertEmployee(emp);
			};
		}
	}
}

