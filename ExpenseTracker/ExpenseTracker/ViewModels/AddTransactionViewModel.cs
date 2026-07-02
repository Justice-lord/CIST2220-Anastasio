using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ExpenseTracker.Models;
using ExpenseTracker.Services;

namespace ExpenseTracker.ViewModels
{
    public partial class AddTransactionViewModel : ObservableObject
    {
        private readonly DatabaseService _databaseService;

        public AddTransactionViewModel(DatabaseService databaseService)
        {
            _databaseService = databaseService;
            date = DateTime.Now;
        }

        [ObservableProperty]
        decimal amount;

        [ObservableProperty]
        string category;

        [ObservableProperty]
        string description;

        [ObservableProperty]
        DateTime date;

        [ObservableProperty]
        string transactionType = "Expense";

        [RelayCommand]
        async Task SaveTransaction()
        {
            var transaction = new Transaction
            {
                Amount = Amount,
                Category = Category,
                Description = Description,
                Date = Date,
                TransactionType = TransactionType
            };

            System.Diagnostics.Debug.WriteLine("SAVE CLICKED");

            await _databaseService.AddTransactionAsync(transaction);

            Amount = 0;
            Category = "";
            Description = "";
            Date = DateTime.Now;
            TransactionType = "Expense";
        }
    }
}
