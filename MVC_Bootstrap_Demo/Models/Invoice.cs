using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Bootstrap_Demo.Models
{
  public class InvoiceViewModel
  {
    public List<Invoice> Invoices { get; set; }
    public decimal TotalDue { get; set; }
    public int OpenInvoices { get; set; }
    public int OpenSalesOrders { get; set; }
    public decimal TotalCredits { get; set; }
    public bool AutoPay { get; set; }
  }

  public class Invoice
  {
    public string InvoiceNumber { get; set; }
    [DisplayFormat(DataFormatString = "{0:MM/dd/yy}")]
    public DateTime InvoiceDate { get; set; }
    [DisplayFormat(DataFormatString = "{0:MM/dd/yy}")]
    public DateTime DueDate { get; set; }
    public Decimal Total { get; set; }
    public Decimal AmountDue { get; set; }
    public string Terms { get; set; }
    public string Description { get; set; }
    public string PONumber { get; set; }
    public bool Active { get; set; }
  }
}
