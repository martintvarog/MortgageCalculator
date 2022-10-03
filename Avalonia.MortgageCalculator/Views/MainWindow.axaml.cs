using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.MortgageCalculator.Core;
using Avalonia.MortgageCalculator.ViewModels;

namespace Avalonia.MortgageCalculator.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new ViewModelBase();
        }

        private void CalculateMortgagePayments(object? sender, RoutedEventArgs e)
        {
            var vm = (ViewModelBase) DataContext!;
            vm.MonthlyPayment = CalculateMortgage
                .CalculateMonthlyPayment(vm.LoanAmount, vm.InterestRate, vm.TermInYears);
            vm.TotalPayment = CalculateMortgage
                .CalculateOverallMortgagePayment(vm.LoanAmount, vm.InterestRate, vm.TermInYears);
        }
    }
}