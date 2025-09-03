using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExpenseWatchUI.Models
{
	public class Transaction
	{
		public string InvOrExp { get; set; }
		public string VendorName { get; set; }
		public string EmployeeName { get; set; }
		public string StartDate { get; set; }
		public string EndDate { get; set; }
		public string InvoiceNumber { get; set; }
	}
}