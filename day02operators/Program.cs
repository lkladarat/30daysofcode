﻿
double meal_cost = Convert.ToDouble(Console.ReadLine().Trim());

int tip_percent = Convert.ToInt32(Console.ReadLine().Trim());

int tax_percent = Convert.ToInt32(Console.ReadLine().Trim());

Result.solve(meal_cost, tip_percent, tax_percent);

class Result
{

    /*
     * Complete the 'solve' function below.
     *
     * The function accepts following parameters:
     *  1. DOUBLE meal_cost
     *  2. INTEGER tip_percent
     *  3. INTEGER tax_percent
     */

    public static void solve(double meal_cost, int tip_percent, int tax_percent)
    {
        double tipAmount = (meal_cost * tip_percent) / 100;
        double taxAmount = (meal_cost * tax_percent) / 100;
        double totalPriceAmount = Math.Round((meal_cost + tipAmount + taxAmount), MidpointRounding.AwayFromZero);
        Console.WriteLine(totalPriceAmount);
    }

}