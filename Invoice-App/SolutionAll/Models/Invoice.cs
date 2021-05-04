using System;

namespace Models
{
    public class Invoice
    {
        public CompanyEnum Company { get; set; }
        public int Amount { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime InvoiceIssued { get; set; }
        public bool InvoiceStatus { get; set; }

        public Invoice(CompanyEnum company, int amount,  DateTime dueDate, DateTime invoiceIssued, bool invoiceStatus)
        {
            Company = company;
            Amount = amount;
            DueDate = dueDate;
            InvoiceIssued = invoiceIssued;
            InvoiceStatus = invoiceStatus;
        }
    }
}
