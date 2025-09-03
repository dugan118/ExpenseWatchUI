using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExpenseWatchUI.Models
{
	public class FormModel
	{
		//[Required]
		[Display(Name = "Invoice or Expense:")]
		public string InvOrExp { get; set; }

		[Display(Name = "Vendor Name:")]
		public string VendorName { get; set; }

		[Display(Name = "Employee Name:")]
		public string EmployeeName { get; set; }

		[Display(Name = "Start Date (optional):")]
		public string StartDate { get; set; }

		[Display(Name = "End Date (optional):")]
		public string EndDate { get; set; }

		[Display(Name = "Invoice Number (optional):")]
		public string InvoiceNumber { get; set; }
	}
}