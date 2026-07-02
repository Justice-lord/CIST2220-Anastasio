using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using ExpenseTracker.Models;
using ExpenseTracker.Services;
using System.Collections.ObjectModel;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Maui;

namespace ExpenseTracker.ViewModels
{
    public partial class DashboardViewModel : ObservableObject
    {
        private readonly DatabaseService _databaseService;

        public DashboardViewModel(DatabaseService databaseService)
        {
            _databaseService = databaseService;
        }

        public ISeries[] Series {  get; set; }

        [ObservableProperty]
        decimal totalIncome;

        [ObservableProperty]
        decimal totalExpenses;

        [ObservableProperty]
        decimal balance;

        [ObservableProperty]
        string balanceColor;

        [ObservableProperty]
        string incomeColor;

        [ObservableProperty]
        string expensesColor;

        public async Task LoadDashboardAsync()
        {
            await _databaseService.InitializeAsync();

            var transactions = await _databaseService.GetTransactionsAsync();

            decimal income = 0;
            decimal expenses = 0;

            foreach (var t in transactions)
            {
                if (t.TransactionType == "Income")
                    income += t.Amount;
                else
                    expenses += t.Amount;
            }

            TotalIncome = income;
            TotalExpenses = expenses;
            Balance = income - expenses;
            BalanceColor = Balance >= 0 ? "lightGreen" : "Red";
            IncomeColor = "LightGreen";
            ExpensesColor = "Salmon";

            Series = new ISeries[]
            {
                new PieSeries<double>
                {
                    Values = new double[] {(double)TotalIncome},
                    Name ="Income"
                },

                new PieSeries<double>
                {
                    Values = new double[] { (double)TotalExpenses},
                    Name = "Expenses"
                }
            };

            OnPropertyChanged(nameof(Series));
        }
    }
}
