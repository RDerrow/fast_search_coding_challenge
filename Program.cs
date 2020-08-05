using System;
using System.IO;
using System.Collections.Generic;


namespace fast_search_code_challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var transactionReader = new StreamReader("./SampleData/sample_transaction_data.csv")) {
                var transactionDictionary = new Dictionary<Guid, List<Transaction>>();

                while(!transactionReader.EndOfStream) {
                    var line = transactionReader.ReadLine();

                    // Generate transaction from csv line
                    var transaction = Transaction.FromCsv(line);

                    // Add transaction to dictionary
                    if (transactionDictionary.ContainsKey(transaction.customerId)) {
                        transactionDictionary[transaction.customerId].Add(transaction);
                    } else {
                        transactionDictionary.Add(transaction.customerId, new List<Transaction> {transaction});
                    }
                }


                using (var customerReader = new StreamReader("./SampleData/sample_customer_data.csv")) {
                    var customers = new List<Customer>();
                    while (!customerReader.EndOfStream) {
                        var line = customerReader.ReadLine();

                        customers.Add(Customer.FromCsv(line));
                    }

                    customers.ForEach(c => {
                        if (transactionDictionary.ContainsKey(c.id)) {
                            c.points = PointCalculator.calculatePoints(transactionDictionary[c.id]);
                        } else {
                            Console.WriteLine($"*** Customer id: {c.id} does have any transactions");
                        }

                        Console.WriteLine(c);
                    });
                }
            }
        }
    }
}
