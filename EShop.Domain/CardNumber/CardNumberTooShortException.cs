using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.Exceptions
{
    public class CardNumberTooShortException : Exception
    {
        public CardNumberTooShortException()
            : base("Numer karty jest za krótki.") { }

        public CardNumberTooShortException(Exception innerException) : base("Numer karty jest za krótki.", innerException) { }
    }

}