
using _1C30JT_HtetOoWaiYan_pbl01.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _1C30JT_HtetOoWaiYan_pbl01
{
    internal class TransactionManage
    {
        public void addTransaction(Transaction transaction)
        {
            using (TransactionContext context = new TransactionContext())
            {
                context.Add(transaction);
                context.SaveChanges();
            }
        }

        public (decimal balance, decimal totalIncome, decimal totalExpense) getBalanceDetails()
        {
            using (TransactionContext context = new TransactionContext())
            {
                decimal totalIncome = context.Transactions
                    .Where(t => t.Type == "In")
                    .Sum(t => t.Amount);

                decimal totalExpense = context.Transactions
                    .Where(t => t.Type == "Out")
                    .Sum(t => t.Amount);

                decimal balance = totalIncome - totalExpense;

                return (balance, totalIncome, totalExpense);
            }
        }

        public List<Transaction> findWithFilter(DateTime? fromDate,DateTime? toDate,string type,decimal? minAmount)
        {
            using (TransactionContext context = new TransactionContext())
            {
                var query = context.Transactions.AsQueryable();

                if (fromDate.HasValue)
                {
                    query = query.Where(t =>
                        t.TransactionDate >= fromDate.Value.Date);
                }

                if (toDate.HasValue)
                {
                    DateTime nextDay = toDate.Value.Date.AddDays(1);

                    query = query.Where(t =>
                        t.TransactionDate < nextDay);
                }

                if (type == "収入")
                {
                    query = query.Where(t => t.Type == "In");
                }
                else if (type == "支出")
                {
                    query = query.Where(t => t.Type == "Out");
                }

                if (minAmount.HasValue)
                {
                    query = query.Where(t =>
                        t.Amount >= minAmount.Value);
                }
                return query
                    .OrderByDescending(t => t.TransactionDate)
                    .ToList();
            }
        }
    }
}
