using System;

namespace Avalonia.NETCoreMVVMApp.INotifyOnChanged.Core;

internal static class CalculateMortgage
{
    //calculate overall mortage payment
    internal static double CalculateOverallMortagePayment(int loanAmount, double interestRate, int termInYears)
    {
        double monthlyInterestRate = interestRate / 12;
        double numberOfPayments = termInYears * 12;
        double payment = (loanAmount * monthlyInterestRate) / (1 - Math.Pow(1 + monthlyInterestRate, -numberOfPayments));
        double overallPayment = payment * numberOfPayments;
        return overallPayment;
    }
    
    //calculate monthly payment
    internal static double CalculateMonthlyPayment(int loanAmount, double interestRate, int termInYears)
    {
        double monthlyInterestRate = interestRate / 12;
        double numberOfPayments = termInYears * 12;
        double payment = (loanAmount * monthlyInterestRate) / (1 - Math.Pow(1 + monthlyInterestRate, -numberOfPayments));
        return payment;
    }
}