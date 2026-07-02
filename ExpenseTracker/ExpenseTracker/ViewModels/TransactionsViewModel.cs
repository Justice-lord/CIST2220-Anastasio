using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using ExpenseTracker.Models;
using ExpenseTracker.Services;
using ExpenseTracker.Views;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.Input;

namespace ExpenseTracker.ViewModels
{
    public partial class TransactionsViewModel : ObservableObject
    {
        private readonly DatabaseService _databaseService;

        public TransactionsViewModel(DatabaseService databaseService)
        {
            _databaseService = databaseService;
            Transactions = new ObservableCollection<Transaction>();
        }

        [ObservableProperty]
        private ObservableCollection<Transaction> transactions;

        public async Task LoadTransactionsAsync()
        {
            await _databaseService.InitializeAsync();

            var items = await _databaseService.GetTransactionsAsync();

            Transactions.Clear();

            foreach (var item in items)
            {
                Transactions.Add(item);
            }
        }

        [RelayCommand]
        async Task DeleteTransaction(Transaction transaction)
        {
            if (transaction == null)
            {
                return;
            }

            await _databaseService.DeleteTransactionAsync(transaction);

            Transactions.Remove(transaction);
        }
    }
}
