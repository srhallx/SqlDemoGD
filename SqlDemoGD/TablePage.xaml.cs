using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SqlDemoGD
{
	public partial class TablePage : ContentPage
	{
		

		public TablePage ()
		{
			InitializeComponent ();


				
		}

		protected override void OnAppearing ()
		{
			base.OnAppearing ();

			dbTable.ItemsSource = App.EmployeeInfoData;
		}

	}
}

