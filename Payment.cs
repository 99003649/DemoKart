using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Website
{
    class Payment
    {
        public enum payment_mode
        {
            cash,
            creditCard,
            debitCard
        };

        public payment_mode pay1 = payment_mode.cash;
        public payment_mode pay2 = payment_mode.creditCard;
        public payment_mode pay3 = payment_mode.debitCard;

    }
}
