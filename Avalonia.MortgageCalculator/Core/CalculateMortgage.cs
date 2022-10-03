using System;

namespace Avalonia.MortgageCalculator.Core;

internal static class CalculateMortgage
{
    //calculate overall mortage payment
    internal static decimal CalculateOverallMortgagePayment(int loanAmount, double interestRate, int termInYears)
    {
        var monthlyInterestRate = interestRate / 100 / 12;
        var numberOfPayments = termInYears * 12;
        var payment = (loanAmount * monthlyInterestRate) /
                          (1 - Math.Pow(1 + monthlyInterestRate, -numberOfPayments));
        var overallPayment = payment * numberOfPayments;
        return (decimal) overallPayment;
    }

    //calculate monthly payment
    internal static decimal CalculateMonthlyPayment(int loanAmount, double interestRate, int termInYears)
    {
        var monthlyInterestRate = interestRate / 100 / 12;
        var numberOfPayments = termInYears * 12;

        var result = loanAmount * (monthlyInterestRate * Math.Pow(1 + monthlyInterestRate, numberOfPayments)) /
                     (Math.Pow(1 + monthlyInterestRate, numberOfPayments) - 1);
        return (decimal) result;
    }
}