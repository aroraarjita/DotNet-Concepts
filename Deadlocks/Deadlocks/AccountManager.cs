﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;



namespace Deadlocks
{
  
    class AccountManager
    {
        Account _fromAccount; Account _toAccount; double _amountToTransfer;
        public AccountManager(Account fromAccount, Account toAccount, double amountToTransfer)
        {
            this._fromAccount = fromAccount;
            this._toAccount = toAccount;
            this._amountToTransfer = amountToTransfer;

        }

        public void Transfer()
        {
            Console.WriteLine(Thread.CurrentThread.Name + " trying to acquire lock on " + _fromAccount.ID.ToString());
            lock (_fromAccount)
            {
                Console.WriteLine(Thread.CurrentThread.Name + " acquired lock on " + _fromAccount.ID.ToString());
                Console.WriteLine(Thread.CurrentThread.Name + " suspended for 1 second");
                Thread.Sleep(1000);
                Console.WriteLine(Thread.CurrentThread.Name + " back in action and trying to acquire lock on " + _toAccount.ID.ToString());
                lock (_toAccount)
                {
                     Console.WriteLine("This code will not be executed");
                    _fromAccount.Withdraw(_amountToTransfer);
                    _toAccount.Deposit(_amountToTransfer);

                }
            }
        }

    }

}
