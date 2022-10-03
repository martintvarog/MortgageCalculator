using System.ComponentModel;

namespace Avalonia.MortgageCalculator.ViewModels
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private decimal _monthlyPayment;

        public decimal MonthlyPayment
        {
            get => _monthlyPayment;
            set
            {
                _monthlyPayment = value;
                OnPropertyChanged(nameof(MonthlyPayment));
            }
        }

        private decimal _totalPayment;

        public decimal TotalPayment
        {
            get => _totalPayment;
            set
            {
                _totalPayment = value;
                OnPropertyChanged(nameof(TotalPayment));
            }
        }


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