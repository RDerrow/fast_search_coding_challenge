using System;

public class Transaction {

    /// <summary>
    /// Initialize an instance of <cref="Transaction">.
    /// </summary>
    public Transaction(Guid id, Guid customerId, decimal cost, DateTime transactionDate) {
        this.id = id;
        this.customerId = customerId;
        this.cost = cost;
        this.transactionDate = transactionDate;
    }

    public static Transaction FromCsv(string csvLine) {
        var splitLine = csvLine.Split(',');

        var transactionId = new Guid(splitLine[0]);
        var customerId = new Guid(splitLine[1]);
        var cost = Convert.ToDecimal(splitLine[2]);
        var transactionDate = Convert.ToDateTime(splitLine[3]);


        return new Transaction(transactionId, customerId, cost, transactionDate);
    }

    /// <summary>
    /// The transaction id.
    /// </summary>
    public Guid id;

    /// <summary>
    /// The id of the customer that made the transaction.
    /// </summary>
    public Guid customerId;

    /// <summary>
    /// The cost of the transaction.
    /// </summary>
    public decimal cost;

    /// <summary>
    /// The date the transaction occurred.
    /// </summary>
    public DateTime transactionDate;
}