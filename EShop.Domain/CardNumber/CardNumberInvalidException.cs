using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.Exceptions
{
    public class CardNumberInvalidException : Exception
    {
        public CardNumberInvalidException()
            : base("Numer karty jest nie prawidłowy.") { }

        public CardNumberInvalidException(Exception innerException) : base("Numer karty jest nie prawidłowy.", innerException) { }
    }

}