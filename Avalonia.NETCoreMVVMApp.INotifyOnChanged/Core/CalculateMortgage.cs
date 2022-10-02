using System;

namespace Avalonia.NETCoreMVVMApp.INotifyOnChanged.Core;

internal static class CalculateMortgage
{
    //calculate overall mortage payment
    internal static double CalculateOverallMortgagePayment(int loanAmount, double interestRate, int termInYears)
    {
        double monthlyInterestRate = interestRate / 100 / 12;
        double numberOfPayments = termInYears * 12;
        double payment = (loanAmount * monthlyInterestRate) /
                         (1 - Math.Pow(1 + monthlyInterestRate, -numberOfPayments));
        double overallPayment = payment * numberOfPayments;
        return overallPayment;
    }

    //calculate monthly payment
    internal static double CalculateMonthlyPayment(int loanAmount, double interestRate, int termInYears)
    {
        var monthlyInterestRate = interestRate / 100 / 12;
        var numberOfPayments = termInYears * 12;

        var result = loanAmount * (monthlyInterestRate * Math.Pow(1 + monthlyInterestRate, numberOfPayments)) /
                     (Math.Pow(1 + monthlyInterestRate, numberOfPayments) - 1);
        return result;
    }
}