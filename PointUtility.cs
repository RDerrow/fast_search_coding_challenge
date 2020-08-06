using System;
using System.Collections.Generic;

/// <summary>
/// The point calculator utility
/// </summary>
public static class PointUtility {


    /// <summary>
    /// 
    /// </summary>
    /// <param name="transactions"></param>
    /// <returns></returns>
    public static string calculatePointsPerMonthString(List<Transaction> transactions) {
        var pointStringDictionary = new Dictionary<string, int>();

        var pointsPerMonthString = "";

        transactions.ForEach(t => {

            var points = 0;

            points = calculateTransactionPoints(t);

            var monthString = getMonthString(t.transactionDate.Month);

            if (pointStringDictionary.ContainsKey(monthString)) {
                pointStringDictionary[monthString] += points;
            } else {
                pointStringDictionary.Add(monthString, points);
            }

            points = 0;
        });

        foreach(KeyValuePair<string, int> entry in pointStringDictionary) {
            pointsPerMonthString += $"{entry.Key}: {entry.Value} points.\n";
        }

        return pointsPerMonthString.TrimEnd();
    }

    /// <summary>
    /// Calcualte the total number of points in the transaction list.
    /// </summary>
    /// <param name="transactions">The list of transactions</param>
    /// <returns>The total points</returns>
    public static int calculateTotalPoints(List<Transaction> transactions) {
        var points = 0;
        transactions.ForEach(t => {
            points += calculateTransactionPoints(t);
        });

        return points;
    }

    private static int calculateTransactionPoints(Transaction transaction) {
        var points = 0;
        if (transaction.cost > 50) {
            points += (int)(Math.Floor(transaction.cost) - 50);
        }

        if (transaction.cost > 100) {
            points += (int)(Math.Floor(transaction.cost) - 100) * 2;
        }

        return points;
    }


    private static string getMonthString(int month) {
        switch(month) {
            case (int)Month.January:
                return Month.January.ToString();

            case (int)Month.February:
                return Month.February.ToString();

            case (int)Month.March:
                return Month.March.ToString();

            case (int)Month.April:
                return Month.April.ToString();

            case (int)Month.May:
                return Month.May.ToString();

            case (int)Month.June:
                return Month.June.ToString();

            case (int)Month.July:
                return Month.July.ToString();

            case (int)Month.August:
                return Month.August.ToString();

            case (int)Month.September:
                return Month.September.ToString();

            case (int)Month.October:
                return Month.October.ToString();

            case (int)Month.November:
                return Month.November.ToString();

            case (int)Month.December:
                return Month.December.ToString();
            
            default:
                return "";
        }
    }
}