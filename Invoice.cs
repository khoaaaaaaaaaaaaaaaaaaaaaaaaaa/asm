using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asm2
{
    public class Invoice
    {
        List<Invoice> invoices = new List<Invoice>();
        public string customerCode { get; set; }
        public string customerName { get; set; }
        public string customerType { get; set; }
        public int numberOfPeople { get; set; }
        public int lastMonthNumber { get; set; }
        public int thisMonthNUmber { get; set; }
        public int month { get; set; }
        public double subTotal { get; set; }
        public double envFee { get; set; }
        public double VATFee { get; set; }
        public double total { get; set; }

        public Invoice() 
        {

        }
        public Invoice(string customerCode, string customerName, string customerType, int numberOfPeople,
            int lastMonthNumber, int thisMonthNumber, int month, double subTotal, double envFee, double vATFee, double total)
        {
            this.customerCode = customerCode;
            this.customerName = customerName;
            this.customerType = customerType;
            this.numberOfPeople = numberOfPeople;
            this.lastMonthNumber = lastMonthNumber;
            this.thisMonthNUmber = thisMonthNUmber;
            this.month = month;
            this.subTotal = subTotal;
            this.envFee = envFee;
            VATFee = vATFee;
            this.total = total;
        }
        private static List<Invoice> Invoices = new List<Invoice>();
        public List<Invoice> GetListInvoices()
        {

            return Invoices;
        }


        public void AddInvoice(string customerCode, string customerName, string customerType,
            int numberOfPeoplle, int lastMonthNumber, int thisMonthNumber, int month, double subTotal,
            double envFee, double vATFee, double total)
        {
            Invoice invoice = new Invoice(customerCode, customerName, customerType, numberOfPeoplle,
                lastMonthNumber, thisMonthNumber, month, subTotal, envFee,  vATFee, total);
            Invoices.Add(invoice);
        }
    }
}