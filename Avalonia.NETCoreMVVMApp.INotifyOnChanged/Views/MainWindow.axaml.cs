using System.Globalization;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.NETCoreMVVMApp.INotifyOnChanged.Core;
using Avalonia.NETCoreMVVMApp.INotifyOnChanged.ViewModels;

namespace Avalonia.NETCoreMVVMApp.INotifyOnChanged.Views
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