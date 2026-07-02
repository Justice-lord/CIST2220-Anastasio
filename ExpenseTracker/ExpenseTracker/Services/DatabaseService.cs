using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using ExpenseTracker.Models;

namespace ExpenseTracker.Services
{
    public class DatabaseService
    {
        private readonly SQLiteAsyncConnection _database;
        private const string DatabaseName = "ExpenseTracker.db3";
        private bool _initialized;

        public DatabaseService()
        {
            var dbPath = Path.Combine(FileSystem.AppDataDirectory, DatabaseName);

            _database = new SQLiteAsyncConnection(dbPath);
        }

        public async Task InitializeAsync()
        {
            if (_initialized) 
                return;

            await _database.CreateTableAsync<Transaction>();
            await _database.CreateTableAsync<Budget>();

            _initialized = true;
        }

        public async Task<List<Transaction>> GetTransactionsAsync()
        {
            await InitializeAsync();

            return await _database.Table<Transaction>()
                .OrderByDescending(t => t.Date)
                .ToListAsync();
        }

        public async Task<Transaction?> GetTransactionAsync(int id)
        {
            await InitializeAsync();

            return await _database.Table<Transaction>()
                .Where(t => t.Id == id)
                .FirstOrDefaultAsync();
        }

        public async Task<int> AddTransactionAsync(Transaction transaction)
        {
            await InitializeAsync();

            return await _database.InsertAsync(transaction);
        }

        public async Task<int> UpdateTransactionAsync(Transaction transaction)
        {
            await InitializeAsync();

            return await _database.UpdateAsync(transaction);
        }

        public async Task<int> DeleteTransactionAsync(Transaction transaction)
        {
            await InitializeAsync();

            return await _database.DeleteAsync(transaction);
        }

        public async Task<Budget?> GetBudgetAsync()
        {
            await InitializeAsync();

            return await _database.Table<Budget>()
                .FirstOrDefaultAsync();
        }

        public async Task SaveBudgetAsync(decimal amount)
        {
            await InitializeAsync();

            var budget = await GetBudgetAsync();

            if (budget == null)
            {
                budget = new Budget
                {
                    Id = 1,
                    MonthlyBudget = amount
                };

                await _database.InsertAsync(budget);
            }
            else
            {
                budget.MonthlyBudget = amount;
                await _database.UpdateAsync(budget);
            }
        }
        
        public async Task TestDatabaseAsync()
        {
            await InitializeAsync();

            var testTranscation = new Transaction
            {
                Amount = 9.99m,
                Category = "Test",
                Description = "Database test entry",
                Date = DateTime.Now,
                TransactionType = "Expense"
            };

            await _database.InsertAsync(testTranscation);

            var all = await _database.Table<Transaction>().ToListAsync();

            System.Diagnostics.Debug.WriteLine($"Transaction in DB: {all.Count}");

            foreach (var t in all)
            {
                System.Diagnostics.Debug.WriteLine($"{t.Id} | {t.Description} | {t.Amount}");
            }

            System.Diagnostics.Debug.WriteLine(FileSystem.AppDataDirectory);
        }
    }
}
