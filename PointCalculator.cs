using System;
using System.Collections.Generic;
public static class PointCalculator {


    public static int calculatePoints(List<Transaction> transactions) {
        int points = 0;

        transactions.ForEach(t => {
            if (t.cost > 50) {
                points += (int)(Math.Floor(t.cost) - 50);
            }

            if (t.cost > 100) {
                points += (int)(Math.Floor(t.cost) - 100) * 2;
            }
        });

        return (int)points;
    }
}