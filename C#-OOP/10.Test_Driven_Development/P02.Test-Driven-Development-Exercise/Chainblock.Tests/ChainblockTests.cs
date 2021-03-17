using Transaction.Contracts;
using NUnit.Framework;
using ChainblockT;
using System;
using System.Linq;

namespace Transaction.Tests
{ 
    public class ChainblockTests
    {
        private IChainblock chainblock;

        [SetUp]
        public void Initialize()
        {
            chainblock = new Chainblock();
        }

        [Test]
        public void AddingTransactionWithNonExistingTransactionIdShouldIncreaseCount()
        {
            ITransaction dummyTx = new Transaction(1, TransactionStatus.Aborted,
                "me", "my friend", 1234.0);

            IChainblock chainblock = new Chainblock();

            chainblock.Add(dummyTx);

            Assert.That(chainblock.Count, Is.EqualTo(1), "Count should be increased and equal to 1.");
        }

        [Test]
        public void AddingTransactionWithExistingIdShouldThrowException()
        {
            ITransaction dummyTx = new Transaction(1, TransactionStatus.Aborted,
                "me", "my friend", 1234.0);

            IChainblock chainblock = new Chainblock();

            chainblock.Add(dummyTx);

            Assert.Throws<InvalidOperationException>(() => chainblock.Add(dummyTx),
                "Transaction id already exists.");

            Assert.That(chainblock.Count, Is.EqualTo(1),
                "The count shouldn't increase with Add operation is invalid.");
        }

        [Test]
        public void ContainsByIdShouldReturnTrueWithExistingTransaction()
        {
            int txId = 1;
            ITransaction dummyTx = new Transaction(txId, TransactionStatus.Aborted,
                "me", "my friend", 1234.0);

            this.chainblock.Add(dummyTx);

            Assert.That(this.chainblock.Contains(txId),
                Is.EqualTo(true),
                "Contains should return true with existing transaction.");
        }

        [Test]
        public void ContainsByIdShouldReturnFalseWithNonExistingTransaction()
        {
            Assert.That(this.chainblock.Contains(1),
                Is.EqualTo(false),
                "Contains should return false with non existing transaction.");
        }

        [Test]
        public void ContainsByTxShouldReturnTrueWithNonExistingTransaction()
        {
            ITransaction dummyTx = new Transaction(1, TransactionStatus.Aborted,
                "me", "my friend", 1234.0);

            this.chainblock.Add(dummyTx);

            Assert.That(this.chainblock.Contains(dummyTx),
                Is.EqualTo(true),
                "Contains should return true with existing transaction.");
        }

        [Test]
        public void ContainsByTxShouldReturnFalseWithNonExistingTransaction()
        {
            ITransaction dummyTx = new Transaction(1, TransactionStatus.Aborted,
                "me", "my friend", 1234.0);

            ITransaction anotherDummyTx = new Transaction(2, TransactionStatus.Aborted,
                "me", "my friend", 1234.0);

            Assert.That(this.chainblock.Contains(anotherDummyTx),
                Is.EqualTo(false),
                "Contains should return false with non existing transaction.");
        }

        [Test]
        public void GetByIdShouldReturnExpectedTx()
        {
            var dummyTxId = 1;

            ITransaction dummyTx = new Transaction(dummyTxId, TransactionStatus.Aborted,
                "me", "my friend", 1234.0);

            ITransaction anotherDummyTx = new Transaction(2, TransactionStatus.Successfull,
                "me", "my friend", 2345.0);

            this.chainblock.Add(dummyTx);
            this.chainblock.Add(anotherDummyTx);

            ITransaction tx = this.chainblock.GetById(dummyTxId);

            Assert.That(
                tx, Is.EqualTo(dummyTx),
                "Transaction are unique.");
        }

        [Test]
        public void GetByIdShouldThrowExceptionWithNonExistingTx()
        {
            ITransaction dummyTx = new Transaction(1, TransactionStatus.Aborted,
                "me", "my friend", 1234.0);

            ITransaction anotherDummyTx = new Transaction(2, TransactionStatus.Successfull,
                "me", "my friend", 2345.0);

            this.chainblock.Add(dummyTx);
            this.chainblock.Add(anotherDummyTx);

            Assert.Throws<InvalidOperationException>(() => this.chainblock.GetById(3),
                "Get by Id with non existing transaction should throw an InvalidOperationException.");
        }

        [Test]
        public void ChangeTxStatusWithExistingTxShouldChangeTxStatus()
        {
            var dummyTxStatus = TransactionStatus.Unauthorized;
            ITransaction dummyTx = new Transaction(1, dummyTxStatus,
                "me", "my friend", 1234.0);

            this.chainblock.Add(dummyTx);

            var newTxStatus = TransactionStatus.Successfull;
            this.chainblock.ChangeTransactionStatus(dummyTx.Id, newTxStatus);

            var receivedTx = this.chainblock.GetById(dummyTx.Id);

            Assert.That(receivedTx.Status, Is.EqualTo(newTxStatus),
                "Change transaction status should update the transaction status.");
        }

        [Test]
        public void ChangeStatusWithNonExistingIdShouldThrowException()
        {
            for (int i = 0; i < 5; i++)
            {
                var dummyTx = new Transaction(i, TransactionStatus.Aborted, "", "", i);

                this.chainblock.Add(dummyTx);
            }

            Assert.Throws<ArgumentException>(() =>
            this.chainblock.ChangeTransactionStatus(23, TransactionStatus.Unauthorized),
            "Change status with non-existing Id should throw ArgumentException.");          
        }

        [Test]
        public void RemoveByIdShouldBeValid()
        {
            for (int i = 0; i < 100; i++)
            {
                var tx = new Transaction(i, TransactionStatus.Successfull,
                    i.ToString(), i.ToString(), i + 0.1);

                this.chainblock.Add(tx);
            }

            var queryId = 0;
            this.chainblock.RemoveTransactionById(0);

            Assert.That(this.chainblock.Count,
                Is.EqualTo(99));

            Assert.Throws<InvalidOperationException>(() => this.chainblock.GetById(queryId));
        }

        [Test]
        public void RemoveMultipleExistingTransactionsShouldBeValid()
        {
            for (int i = 0; i < 100; i++)
            {
                var tx = new Transaction(i, TransactionStatus.Successfull,
                    i.ToString(), i.ToString(), i + 0.1);

                this.chainblock.Add(tx);
            }

            this.chainblock.RemoveTransactionById(0);
            this.chainblock.RemoveTransactionById(1);
            this.chainblock.RemoveTransactionById(2);
            this.chainblock.RemoveTransactionById(3);
            this.chainblock.RemoveTransactionById(4);

            Assert.That(
                this.chainblock.Count,
                Is.EqualTo(95));

            for (int i = 0; i < 4; i++)
            {
                Assert.Throws<InvalidOperationException>(() => 
                this.chainblock.GetById(i));
            }
        }

        [Test]
        public void RemoveTransactionWithZeroTransactionsShouldThrowException()
        {
            Assert.Throws<InvalidOperationException>(() =>
            this.chainblock.RemoveTransactionById(0));

            Assert.That(this.chainblock.Count,
                Is.EqualTo(0));
        }

        [Test]
        public void RemoveNonExistingIdWithMultipleTransactionsShouldThrowException()
        {
            for (int i = 0; i < 5; i++)
            {
                var tx = new Transaction(i, TransactionStatus.Aborted, " ", " ", i + 0.5);

                this.chainblock.Add(tx);
            }

            Assert.Throws<InvalidOperationException>(() =>
            this.chainblock.RemoveTransactionById(5));

            Assert.That(this.chainblock.Count,
                Is.EqualTo(5));
        }

        [Test]
        public void GetByTransactionStatusWithExistingTransactionShouldReturnTransactionWithTheGivenStatusOrderedByAmountInDescending()
        {
            for (int i = 1; i <= 100; i++)
            {
                TransactionStatus status = (TransactionStatus)(i % 4) + 1;

                var tx = new Transaction(i, status, i.ToString(), i.ToString(), i);

                this.chainblock.Add(tx);
            }

            var filterTransactionStatus = TransactionStatus.Successfull;

            var filteredTransactions = this.chainblock
                .GetByTransactionStatus(filterTransactionStatus)
                .ToArray();

            double amount = filteredTransactions[0].Amount;

            Assert.That(filteredTransactions[0].Status,
                    Is.EqualTo(filterTransactionStatus));

            for (int i = 1; i < filteredTransactions.Length; i++)
            {
                var currentTx = filteredTransactions[i];

                Assert.That(currentTx.Amount,
                    Is.LessThanOrEqualTo(amount));

                Assert.That(currentTx.Status,
                    Is.EqualTo(filterTransactionStatus));

                amount = currentTx.Amount;
            }
        }

        [Test]
        public void GetByTransactionStatusWithNonExistingTransactionStatusShouldThrowException()
        {
            for (int i = 1; i <= 100; i++)
            {
                TransactionStatus status = (TransactionStatus)(i % 3) + 1;

                var tx = new Transaction(i, status, i.ToString(), i.ToString(), i);

                this.chainblock.Add(tx);
            }

            Assert.Throws<InvalidOperationException>(() =>
            this.chainblock.GetByTransactionStatus(TransactionStatus.Unauthorized));
        }

        [Test]
        public void GetByReceiverInRangeShouldReturnFilteredTransactionsOrderedByAmountInDescendingOrder()
        {
            var receiverName = "Peter";

            for (int i = 1; i <= 100; i++)
            {
                TransactionStatus status = (TransactionStatus)(i % 4) + 1;

                var receiver = i % 2 == 0 ?
                    receiverName : i.ToString();

                var tx = new Transaction(i, status, string.Empty, receiver, i + 50);

                this.chainblock.Add(tx);
            }

            double lo = 60;
            double hi = 90;

            var filtered = this.chainblock.GetByReceiverAndAmountRange(receiverName, lo, hi);

            double amount = double.MaxValue;

            foreach(var tx in filtered)
            {
                Assert.That(tx.Amount,
                    Is.LessThan(amount),
                    "Filtered transactions should be ordered by amount in descending order.");

                Assert.That(tx.To,
                    Is.EqualTo(receiverName),
                    "Transactions should be filtered by receiver name.");

                Assert.That(tx.Amount,
                    Is.LessThan(hi).And.GreaterThanOrEqualTo(lo),
                    "Transactions should be filtered in the given range.");

                amount = tx.Amount;
            }
        }

        [Test]
        public void GetByReceiverAndAmountRangeWithInvalidReceiverShouldThrowException()
        {
            for (int i = 0; i < 100; i++)
            {
                var tx = new Transaction(i, TransactionStatus.Successfull, string.Empty, i.ToString(), i + 50);

                this.chainblock.Add(tx);
            }

            var receiverName = "Peter";

            Assert.Throws<InvalidOperationException>(() =>
            this.chainblock.GetByReceiverAndAmountRange(receiverName, 60, 90));
        }

        [Test]
        public void GetByReceiverAndAmountRangeWithInvalidRangeShouldThrowException()
        {
            var receiverName = "Peter";

            for (int i = 0; i < 100; i++)
            {
                var tx = new Transaction(i, TransactionStatus.Successfull, string.Empty, receiverName, i + 50);

                this.chainblock.Add(tx);
            }

            Assert.Throws<InvalidOperationException>(() =>
            this.chainblock.GetByReceiverAndAmountRange(receiverName, int.MinValue, 49));

            Assert.Throws<InvalidOperationException>(() =>
            this.chainblock.GetByReceiverAndAmountRange(receiverName, 150, int.MaxValue));
        }

        [Test]
        public void GetByReceiverAndAmountRangeWithEqualAmountsShouldOrderTransactionsInAscendingOrderById()
        {
            var chainblock = new Chainblock();

            var receiverName = "Peter";

            for (int i = 1; i <= 100; i++)
            {
                TransactionStatus status = (TransactionStatus)(i % 4) + 1;

                var receiver = i % 2 == 0 ?
                    receiverName : i.ToString();

                var txAmount = i % 4 == 0 ? 50 : i + 50;

                var tx = new Transaction(i, status, string.Empty, receiver, txAmount);

                this.chainblock.Add(tx);
            }

            double lo = 60;
            double hi = 90;

            var filtered = this.chainblock.GetByReceiverAndAmountRange(receiverName, lo, hi)
                .Where(tx => tx.Amount == 50)
                .ToArray();

            int id = int.MinValue;

            foreach (var tx in filtered)
            {
                Assert.That(
                    tx.Id, Is.GreaterThan(id));

                Assert.That(tx.To,
                    Is.EqualTo(receiverName));

                id = tx.Id;
            }
        }

        // first half TESTS DONE....
    }
}
