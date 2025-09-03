using ExpenseWatchUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExpenseWatchUI.Controllers
{
	public class HomeController : Controller
	{
		[HttpGet]
		public ActionResult Index()
		{
			return View(new FormModel());
		}

		[HttpPost]
		public JsonResult SubmitForm(FormModel model)
		{
			if (ModelState.IsValid)
			{
				var result = QueryDatabase(model);
				return Json(result);
			}

			Response.StatusCode = 400;
			return Json(new { error = "Invalid input" });
		}

		public List<Transaction> QueryDatabase(FormModel model)
		{
			var result = new List<Transaction>();
			//Temp values,replaced by results from query
			if (model.InvOrExp == "Invoice")
			{
				result.Add(new Transaction { InvOrExp = "Invoice", VendorName = "vName1", EmployeeName = "eName1", StartDate = "1111", EndDate = "1111", InvoiceNumber = "111111" });
				result.Add(new Transaction { InvOrExp = "Invoice", VendorName = "vName2", EmployeeName = "eName2", StartDate = "2222", EndDate = "2222", InvoiceNumber = "222222" });
				result.Add(new Transaction { InvOrExp = "Invoice", VendorName = "vName3", EmployeeName = "eName3", StartDate = "3333", EndDate = "3333", InvoiceNumber = "333333" });
				result.Add(new Transaction { InvOrExp = "Invoice", VendorName = "vName4", EmployeeName = "eName4", StartDate = "4444", EndDate = "4444", InvoiceNumber = "444444" });
				result.Add(new Transaction { InvOrExp = "Invoice", VendorName = "vName5", EmployeeName = "eName5", StartDate = "5555", EndDate = "5555", InvoiceNumber = "555555" });
				result.Add(new Transaction { InvOrExp = "Invoice", VendorName = "vName6", EmployeeName = "eName6", StartDate = "6666", EndDate = "6666", InvoiceNumber = "666666" });
				result.Add(new Transaction { InvOrExp = "Invoice", VendorName = "vName7", EmployeeName = "eName7", StartDate = "7777", EndDate = "7777", InvoiceNumber = "777777" });
			}
			else
			{
				result.Add(new Transaction { InvOrExp = "Expense", VendorName = "vName1", EmployeeName = "eName1", StartDate = "1111", EndDate = "1111", InvoiceNumber = "111111" });
				result.Add(new Transaction { InvOrExp = "Expense", VendorName = "vName2", EmployeeName = "eName2", StartDate = "2222", EndDate = "2222", InvoiceNumber = "222222" });
				result.Add(new Transaction { InvOrExp = "Expense", VendorName = "vName3", EmployeeName = "eName3", StartDate = "3333", EndDate = "3333", InvoiceNumber = "333333" });
				result.Add(new Transaction { InvOrExp = "Expense", VendorName = "vName4", EmployeeName = "eName4", StartDate = "4444", EndDate = "4444", InvoiceNumber = "444444" });
				result.Add(new Transaction { InvOrExp = "Expense", VendorName = "vName5", EmployeeName = "eName5", StartDate = "5555", EndDate = "5555", InvoiceNumber = "555555" });
			}

			return result;
		}
	}
}