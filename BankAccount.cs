﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation_Exercise
{
    public class BankAccount
    {
        private double _balance = 0;
        
        public void Deposit(double amount)
        {
            _balance = amount;
        }
        public double GetBalance()
        {
            return _balance;
        }

    }
}