using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankAccounts;
using System;

namespace BankAccountTests
{
    [TestClass]
    public class BankAccountTests
    {
        [TestMethod]
        public void NewAccount_HasZeroBalance()
        {
            BankAccount account = new BankAccount("John Doe", 0);
            Assert.AreEqual(0, account.Balance);
        }

        [TestMethod]
        public void Deposit_IncreasesBalance()
        {
            BankAccount account = new BankAccount("John Doe", 100);
            account.Deposit(50);
            Assert.AreEqual(150, account.Balance);
        }

        [TestMethod]
        public void Withdraw_DecreasesBalance()
        {
            BankAccount account = new BankAccount("John Doe", 100);
            account.Withdraw(50);
            Assert.AreEqual(50, account.Balance);
        }

        [TestMethod]
        public void Withdraw_ThrowsExceptionForNegativeAmount()
        {
            BankAccount account = new BankAccount("John Doe", 100);
            Assert.ThrowsException<ArgumentException>(() => account.Withdraw(-50));
        }

        [TestMethod]
        public void Withdraw_ThrowsExceptionForInsufficientFunds()
        {
            BankAccount account = new BankAccount("John Doe", 100);
            Assert.ThrowsException<InvalidOperationException>(() => account.Withdraw(150));
        }

        [TestMethod]
        public void Owner_PropertyReturnsCorrectValue()
        {
            BankAccount account = new BankAccount("John Doe", 100);
            Assert.AreEqual("John Doe", account.Owner);
        }

        [TestMethod]
        public void Deposit_ThrowsExceptionForZeroAmount()
        {
            BankAccount account = new BankAccount("John Doe", 100);
            Assert.ThrowsException<ArgumentException>(() => account.Deposit(0));
        }

        [TestMethod]
        public void Constructor_ThrowsExceptionForEmptyOwnerName()
        {
            Assert.ThrowsException<ArgumentException>(() => new BankAccount("", 100));
        }

        [TestMethod]
        public void Constructor_ThrowsExceptionForNegativeInitialBalance()
        {
            Assert.ThrowsException<ArgumentException>(() => new BankAccount("John Doe", -100));
        }
    }
}