using System;
using System.Collections.Generic;


/// <summary>
/// The model representing a customer.
/// </summary>
public class Customer {
    
    /// <summary>
    ///  Initialize a new instance of a <cref="Customer">.
    /// </summary>
    public Customer(Guid id, string name, List<Transaction> transactions = null) {
        this.id = id;
        this.name = name;
        this.transactions = transactions;
    }

        /// <summary>
    /// The unique identifier for the customer.
    /// </summary>
    public Guid id;

    /// <summary>
    /// The customer's name.
    /// </summary>
    public string name;

    /// <summary>
    /// A list of transactions the customer has made.
    /// </summary>
    public List<Transaction> transactions;

    /// <summary>
    /// The total number of points the customer has earned.
    /// </summary>
    public int totalPoints;

    /// <summary>
    /// Generate customer from csv line string data
    /// </summary>
    /// <param name="csvLine">The csv line containing customer data</param>
    /// <returns>A <cref="Customer"></returns>
    public static Customer FromCsv(string csvLine) {
        var splitLine = csvLine.Split(',');

        var id = new Guid(splitLine[0]);
        var name = splitLine[1];

        return new Customer(id, name);
    }

    /// <summary>
    /// Overriding <cref="ToString"> to return custom string
    /// </summary>
    /// <returns>A custom string representing the points the customer
    /// has earned each month and the total points earned</returns>
    public override string ToString() {
        return $"({this.id}) {this.name} has {this.totalPoints} points";
    }
}