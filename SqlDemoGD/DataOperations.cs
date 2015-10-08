using System;
using System.IO;
using SQLite;
using System.Data;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SqlDemoGD
{
	public class DataOperations
	{
		string DBPath { get; set; }

		public DataOperations (string dbPath)
		{
			DBPath = Path.Combine (System.Environment.GetFolderPath (System.Environment.SpecialFolder.Personal), dbPath);
		}



		/// <summary>
		/// Creates the DB for EmployeeInfo.
		/// </summary>
		public void CreateDB() {

			if (File.Exists(DBPath))
				File.Delete(DBPath);
			
			using (var conn = new SQLite.SQLiteConnection (DBPath)) {

				conn.CreateTable<EmployeeInfo> ();
			}
		}


		/// <summary>
		/// Inserts the employee.
		/// </summary>
		/// <param name="employee">Employee record to insert.</param>
		public void InsertEmployee(EmployeeInfo employee) {

			using (var conn = new SQLite.SQLiteConnection (DBPath)) {
				conn.Insert (employee);
			}
		}


		public ObservableCollection<EmployeeInfo> GetEmployees() {
			ObservableCollection<EmployeeInfo> rows;

			if (File.Exists (DBPath)) {
				using (var conn = new SQLite.SQLiteConnection (DBPath)) {
					
					var results = conn.Table<EmployeeInfo> ().Take (50);

					rows = new ObservableCollection<EmployeeInfo> ();
					foreach (var r in results) {
						rows.Add (r);
					}

					return rows;
				}
			} else {
				return null;
			}

		}

	}
}

