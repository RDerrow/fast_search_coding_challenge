using System;


/// <summary>
/// The model representing a customer
/// </summary>
public class Customer {
    
    /// <summary>
    ///  Initialize a new instance of a <cref="Customer">
    /// </summary>
    public Customer(Guid id, string name, int points = 0) {
        this.id = id;
        this.name = name;
        this.points = points;
    }

    public static Customer FromCsv(string csvLine) {
        var splitLine = csvLine.Split(',');

        var id = new Guid(splitLine[0]);
        var name = splitLine[1];

        return new Customer(id, name);
    }

    public override string ToString() {
        return $"({this.id}) {this.name} has {this.points} points";
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
    /// The number of points that the customer has obtained.
    /// </summary>
    public int points;


}