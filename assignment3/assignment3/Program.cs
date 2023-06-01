using System;

namespace CreditBureauApp
{
    public delegate void CreditEvent(string message);

    class Customer
    {
        public string Name { get; set; }
        public double Principal { get; set; }
        public double Rate { get; set; }
        public double Time { get; set; }
        public double Inflation { get; set; }

        public event CreditEvent Successful;
        public event CreditEvent Unsuccessful;

        public void CalculateSimpleInterest()
        {
            double simpleInterest = Principal * Time * Rate;
            Successful?.Invoke($"Simple Interest for {Name}: {simpleInterest}");
        }

        public void CalculateCompoundInterest()
        {
            double compoundInterest = Principal * Time * Rate / 100;
            Successful?.Invoke($"Compound Interest for {Name}: {compoundInterest}");
        }

        public void CalculateRealInterest()
        {
            double realInterest = Rate - Inflation;
            Successful?.Invoke($"Real Interest for {Name}: {realInterest}");
        }

        public void PerformCreditAssessment()
        {
            CalculateSimpleInterest();
            CalculateCompoundInterest();
            CalculateRealInterest();
        }

        public void NotifyDisqualification()
        {
            Unsuccessful?.Invoke($"Disqualified: {Name}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an array of customers
            Customer[][] customers = new Customer[1][]
            {
              new Customer[]
                {
                    new Customer
                    {
                        Name = "John",
                        Principal = 5000,
                        Rate = 5,
                        Time = 2,
                        Inflation = 1
                    },
                    new Customer
                    {
                        Name = "Sarah",
                        Principal = 10000,
                        Rate = 7,
                        Time = 3,
                        Inflation = 2
                    }
                }

            };

            // Subscribe to events for each customer
            foreach (Customer[] customerGroup in customers)
            {
                foreach (Customer customer in customerGroup)
                {
                    customer.Successful += HandleSuccessfulCreditEvent;
                    customer.Unsuccessful += HandleUnsuccessfulCreditEvent;
                }
            }

            // Perform credit assessment for each customer
            foreach (Customer[] customerGroup in customers)
            {
                foreach (Customer customer in customerGroup)
                {
                    customer.PerformCreditAssessment();
                }
            }

            // Simulate disqualification for a customer
            customers[0][1].NotifyDisqualification();

            Console.ReadLine();
        }

        static void HandleSuccessfulCreditEvent(string message)
        {
            Console.WriteLine("Credit Assessment Successful:");
            Console.WriteLine(message);
            Console.WriteLine();
        }

        static void HandleUnsuccessfulCreditEvent(string message)
        {
            Console.WriteLine("Credit Assessment Unsuccessful:");
            Console.WriteLine(message);
            Console.WriteLine();
        }
    }
}
