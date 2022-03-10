using System;
using System.Collections.Generic;
using System.Text;

namespace MySuperBank
{
    class Transaction
    {
        public decimal Amount { get; }
        public DateTime Time { get; }
        public string Notes { get; }
        public object Date { get; internal set; }

        public Transaction(decimal Amount, DateTime Time, string Notes)
        {
            this.Amount = Amount;
            this.Time = Time;
            this.Notes = Notes;  
        }
    }
}
