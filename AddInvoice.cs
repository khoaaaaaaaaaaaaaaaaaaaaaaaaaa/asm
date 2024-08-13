using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asm2
{
    public partial class AddInvoice : UserControl
    {
        public Invoice InvoiceManager { get; set; }
        public AddInvoice()
        {
            InitializeComponent();
            customerTypeCombobox.SelectedItem = "Household customer";
            string currentMonth = DateTime.Now.Month.ToString();
            currentMonthCombobox.SelectedItem = currentMonth;
            NumberofpeopleInput.Text = "0";
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }


        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void customerTypeCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string customerType = customerTypeCombobox.SelectedItem.ToString();
            if (customerType == "Household customer")
                NumberofpeopleInput.Enabled = true;
            else
                NumberofpeopleInput.Enabled = false;
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            string messages = "";
            bool isValid = true;


            if (!lastmonthNumberInput.Text.All(char.IsDigit))
            {
                isValid &= false;
                messages += "pls enter last month off number\n";

            }


            if (lastmonthNumberInput.Text == "")
            {
                isValid &= false;
                messages += "pls enter last month off number\n";

            }

            if (!thisMonthNumberInput.Text.All(char.IsDigit))
            {
                isValid = false;
                messages += "pls enter this month off number\n";
            }

            if (thisMonthNumberInput.Text == "")
            {
                isValid &= false;
                messages += "pls enter this month off number\n";

            }

            if (customerTypeCombobox.SelectedItem.ToString() == " Household customer")
            {
                if (NumberofpeopleInput.Text == "" || !NumberofpeopleInput.Text.All(char.IsDigit))
                {
                    isValid &= false;
                    messages += "pls enter valid number of people\n";
                }

            }
            if (customerCodeInput.Text == "")
            {
                isValid = false;
                messages += "pls enter customer code\n";
            }

            if (customerNameInput.Text == "")
            {
                isValid = false;
                messages += "pls enter customer name\n";
            }

            if (customerTypeCombobox.Text == "")
            {
                isValid = false;
                messages += "pls enter customer type\n";
            }


            if (isValid == false)
            {
                MessageBox.Show(messages);
                return;
            }

            string customerCode = customerCodeInput.Text;
            string customerName = customerNameInput.Text;
            string customerType = customerTypeCombobox.SelectedItem.ToString();
            int numberOfPeople = Convert.ToInt32(NumberofpeopleInput.Text);
            int lastMonthNumber = Convert.ToInt32(lastmonthNumberInput.Text);
            int thisMonthNumber = Convert.ToInt32(thisMonthNumberInput.Text);
            int currentMonth = Convert.ToInt32(currentMonthCombobox.SelectedItem);

            int consumption = thisMonthNumber - lastMonthNumber;
            double price = 0;
            double envFee = 0;
            if (customerType == "Household customer")
            {
                decimal consumptionPerPeople = consumption / numberOfPeople;
                if (consumptionPerPeople <= 10)
                {
                    price = 5973;
                    envFee = 597.3;
                }

                if (consumptionPerPeople > 10 && consumptionPerPeople <= 20)
                {
                    price = 7052;
                    envFee = 705.20;
                }

                if (consumptionPerPeople > 20 && consumptionPerPeople <= 30)
                {
                    price = 8699;
                    envFee = 866.90;
                }

                if (consumptionPerPeople > 30)
                {
                    price = 15929;
                    envFee = 1592.90;

                }
                else if (customerType == "Administrative agency, public services")
                {
                    price = 9955;
                    envFee = 995.5;
                }
                else if (customerType == "Production units")
                {
                    price = 11615;
                    envFee = 1161.5;
                }
                else if (customerType == "Business services")
                {
                    price = 22068;
                    envFee = 2206.8;
                }

                double subTotal = price * consumption;
                double VATFee = (subTotal + envFee) * 0.1;
                double total = subTotal + VATFee + VATFee;

                consumptionLabel.Text = consumption.ToString();
                priceLabel.Text = price.ToString();
                subtotalLabel.Text = Math.Round(subTotal).ToString();
                envFeeLabel.Text = envFee.ToString();
                VATLabel.Text = Math.Round(VATFee, 2).ToString();
                totalLabel.Text = Math.Round(total, 2).ToString();

                InvoiceManager.AddInvoice(customerCode, customerName, customerType, numberOfPeople
                      , thisMonthNumber, lastMonthNumber, currentMonth, subTotal, envFee, VATFee, total);



            }
        }
    }
}