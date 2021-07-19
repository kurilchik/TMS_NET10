﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW14._1
{
    public class Account
    {
        public event Action<object, AccountEventArgs> Notify;
        public int Sum { get; private set; }

        public Account(int sum)
        {
            Sum = sum;
        }

        public void Put(int sum)
        {
            Sum += sum;
            Notify?.Invoke(this, new AccountEventArgs($"На счет поступило {sum}", sum));
        }
        public void Take(int sum)
        {
            if (Sum >= sum)
            {
                Sum -= sum;
                Notify?.Invoke(this, new AccountEventArgs($"Сумма {sum} снята со счета", sum));
            }
            else
            {
                Notify?.Invoke(this, new AccountEventArgs("Недостаточно денег на счете", sum)); ;
            }
        }
    }
}
