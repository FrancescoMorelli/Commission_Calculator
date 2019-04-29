using System;
using System.Collections.Generic;

namespace Commission_Calculator
{
    public class Calculator
    {

        static public int CalculateCommission(Dictionary<string, string> employerData)
        {
            int totalRevenue = Convert.ToInt32(employerData["MilkRevenue"]) +
                            Convert.ToInt32(employerData["WaterRevenue"]) +
                            Convert.ToInt32(employerData["CoffeeRevenue"]) +
                            Convert.ToInt32(employerData["TeaRevenue"]);

            int totalExpenses = Convert.ToInt32(employerData["MilkExpenses"]) +
                             Convert.ToInt32(employerData["WaterExpenses"]) +
                             Convert.ToInt32(employerData["CoffeeExpenses"]) +
                             Convert.ToInt32(employerData["TeaRevenue"]);

            int profit = totalRevenue - totalExpenses;

            return profit;

        }
    }
}
