using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlocks
{
    public class Account
    {
        double _balance; int _id;
        public Account(int id, int balance)
        {
            this._balance = balance;
            this._id = id;
        }

        public int ID
        {
            get
            {
                return _id;
            }
        }

        public void Withdraw(double amount)
        {
            _balance -= amount;
        }

        public void Deposit(double amount)
        {
            _balance += amount;
        }

    }
}
