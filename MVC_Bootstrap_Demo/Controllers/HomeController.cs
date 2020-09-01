using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC_Bootstrap_Demo.Models;

namespace MVC_Bootstrap_Demo.Controllers
{
  public class HomeController : Controller
  {
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
      _logger = logger;
    }

    public IActionResult Index()
    {
      List<Invoice> invoices = new List<Invoice>();
      invoices.Add(new Invoice() { InvoiceNumber = "234239", InvoiceDate = new DateTime(18, 10, 30), DueDate = new DateTime(18, 10, 30), Total = 100, AmountDue = 100, Terms = "Discount of $100.00 if paid by 5/2/2020", Description = "Lorem impsum Csharp Developero", PONumber = "239482", Active = false });
      invoices.Add(new Invoice() { InvoiceNumber = "234239", InvoiceDate = new DateTime(18, 10, 30), DueDate = new DateTime(18, 10, 30), Total = 100, AmountDue = 100, Terms = "Discount of $100.00 if paid by 5/2/2020", Description = "Lorem impsum Csharp Developero", PONumber = "239567", Active = false });
      invoices.Add(new Invoice() { InvoiceNumber = "234239", InvoiceDate = new DateTime(18, 10, 30), DueDate = new DateTime(18, 10, 30), Total = 100, AmountDue = 100, Terms = "Discount of $100.00 if paid by 5/2/2020", Description = "Lorem impsum Csharp Developero", PONumber = "239454", Active = false });
      invoices.Add(new Invoice() { InvoiceNumber = "234239", InvoiceDate = new DateTime(18, 10, 30), DueDate = new DateTime(18, 10, 30), Total = 100, AmountDue = 100, Terms = "Discount of $100.00 if paid by 5/2/2020", Description = "Lorem impsum Csharp Developero", PONumber = "239454", Active = true });
      invoices.Add(new Invoice() { InvoiceNumber = "234239", InvoiceDate = new DateTime(18, 10, 30), DueDate = new DateTime(18, 10, 30), Total = 100, AmountDue = 100, Terms = "Discount of $100.00 if paid by 5/2/2020", Description = "Lorem impsum Csharp Developero", PONumber = "239345", Active = true });

      InvoiceViewModel ivm = new InvoiceViewModel();
      ivm.Invoices = invoices;
      ivm.OpenInvoices = invoices.Count(w => w.Active);
      ivm.TotalDue = invoices.Where(w => !w.Active).Sum(w => w.AmountDue);

      return View(ivm);
    }

    public IActionResult Privacy()
    {
      return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
      return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
  }
}
