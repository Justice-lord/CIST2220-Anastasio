using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace ExpenseTracker.Models
{
    public class Budget
    {
        [PrimaryKey]
        public int Id { get; set; }

        public decimal MonthlyBudget { get; set; }
    }
}
