using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.Exceptions
{
    public class CardNumberTooLongException : Exception
    {
        public CardNumberTooLongException()
            : base("Numer karty jest za długi.") { }

        public CardNumberTooLongException(Exception innerException) : base("Numer karty jest za długi.", innerException) { }
    }

}