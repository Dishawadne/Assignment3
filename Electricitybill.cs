using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Electricitybill
    {

        public void display()
        {
            Console.Write(" Customer ID: ");
            int customerID = Convert.ToInt32(Console.ReadLine());

            Console.Write("name of the customer: ");
            string customerName = Console.ReadLine();

            Console.Write("unit consumed by the customer: ");
            int units = Convert.ToInt32(Console.ReadLine());

            double charge = 0;
            double surcharge = 0;
            double netAmount = 0;

            if (units <= 199)
            {
                charge = units * 1.20;
            }
            else if (units >= 200 && units < 400)
            {
                charge = units * 1.50;
            }
            else if (units >= 400 && units < 600)
            {
                charge = units * 1.80;
            }
            else if (units >= 600)
            {
                charge = units * 2.00;
            }

            if (charge > 400)
            {
                surcharge = charge * 0.15;
            }

            netAmount = charge + surcharge;

            if (netAmount < 100)
            {
                netAmount = 100;
            }

            Console.WriteLine("Customer IDNO : " + customerID);
            Console.WriteLine("Customer Name : " + customerName);
            Console.WriteLine("Unit Consumed : " + units);
            Console.WriteLine("Amount Charges @Rs. " + charge);
            Console.WriteLine("Surcharge Amount : " + surcharge);
            Console.WriteLine("Net Amount Paid By the Customer : " + netAmount);


        }
    }
}
