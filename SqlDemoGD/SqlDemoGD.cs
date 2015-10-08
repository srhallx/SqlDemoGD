using System;

using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace SqlDemoGD
{
	public class App : Application
	{
		public static string DBPath { get; set; }
		static ObservableCollection<EmployeeInfo> employeeInfoData;
		public static ObservableCollection<EmployeeInfo> EmployeeInfoData { get { return employeeInfoData; } set { employeeInfoData = value; } }

		public App ()
		{

			EmployeeInfoData = new ObservableCollection<EmployeeInfo> ();

			MainPage = new MasterDetailPage () {
				Title = "Menu",
				Master = new MasterPage (),
				Detail = new NavigationPage( new TablePage ())
			};
				
			DBPath = "employeelist.db";

			var dataOps = new DataOperations (DBPath);
			EmployeeInfoData = dataOps.GetEmployees ();

		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

