using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Transaction;
using Transaction.Contracts;

namespace ChainblockT
{
    public class Chainblock : IChainblock
    {
        private readonly Dictionary<int, ITransaction> transactionsById;

        public Chainblock()
        {
            this.transactionsById = new Dictionary<int, ITransaction>();
        }

        public int Count => this.transactionsById.Count;

        public void Add(ITransaction tx)
        {
            if (this.Contains(tx))
            {
                throw new InvalidOperationException($"Transaction with {tx.Id} already exists.");
            }

            this.transactionsById.Add(tx.Id, tx);
        }

        public bool Contains(ITransaction tx) => this.Contains(tx.Id);

        public bool Contains(int id) => this.transactionsById.ContainsKey(id);
       
        public void ChangeTransactionStatus(int id, TransactionStatus newStatus)
        {
            if (!this.Contains(id))
            {
                throw new ArgumentException();
            }

            var tx = this.GetById(id);

            tx.Status = newStatus;
        }

        public IEnumerable<ITransaction> GetAllInAmountRange(double lo, double hi)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ITransaction> GetAllOrderedByAmountDescendingThenById()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> GetAllReceiversWithTransactionStatus(TransactionStatus status)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> GetAllSendersWithTransactionStatus(TransactionStatus status)
        {
            throw new NotImplementedException();
        }

        public ITransaction GetById(int id)
        {
            if (!this.Contains(id))
            {
                throw new InvalidOperationException($"Transaction with {id} doesn't exist.");
            }

            return this.transactionsById[id];
        }

        public IEnumerable<ITransaction> GetByReceiverAndAmountRange(string receiver, double lo, double hi)
        {
            var filtered = this.transactionsById
                .Values
                .Where(t => t.To == receiver && t.Amount >= lo && t.Amount < hi)
                .OrderByDescending(t => t.Amount)
                .ThenBy(t => t.Id)
                .ToArray();

            if(filtered.Length == 0)
            {
                throw new InvalidOperationException();
            }

            return filtered;
        }

        public IEnumerable<ITransaction> GetByReceiverOrderedByAmountThenById(string receiver)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ITransaction> GetBySenderAndMinimumAmountDescending(string sender, double amount)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ITransaction> GetBySenderOrderedByAmountDescending(string sender)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ITransaction> GetByTransactionStatus(TransactionStatus status)
        {
            var filteredTransactions = this.transactionsById.Values
                .Where(v => v.Status == status)
                .OrderByDescending(tx => tx.Amount)
                .ToArray();

            if (filteredTransactions.Length == 0)
            {
                throw new InvalidOperationException();
            }

            return filteredTransactions;
        }

        public IEnumerable<ITransaction> GetByTransactionStatusAndMaximumAmount(TransactionStatus status, double amount)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<ITransaction> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void RemoveTransactionById(int id)
        {
            if (!this.Contains(id))
            {
                throw new InvalidOperationException();
            }

            this.transactionsById.Remove(id);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
