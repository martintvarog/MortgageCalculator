using System.ComponentModel;

namespace Avalonia.NETCoreMVVMApp.INotifyOnChanged.ViewModels
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public double MonthlyPayment { get; set; }
        public double TotalPayment { get; set; }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private int _loanAmount;

        public int LoanAmount
        {
            get => _loanAmount;
            set
            {
                _loanAmount = value;
                OnPropertyChanged(nameof(LoanAmount));
            }
        }

        private double _interestRate;

        public double InterestRate
        {
            get => _interestRate;
            set
            {
                _interestRate = value;
                OnPropertyChanged(nameof(InterestRate));
            }
        }

        private int _termInYears;

        public int TermInYears
        {
            get => _termInYears;
            set
            {
                _termInYears = value;
                OnPropertyChanged(nameof(TermInYears));
            }
        }
    }
}