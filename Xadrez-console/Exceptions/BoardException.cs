using System;
using System.Collections.Generic;
using System.Text;

namespace Xadrez_console.Exceptions
{
    public class BoardException : ApplicationException
    {

        public BoardException(string message) : base(message)
        {
        }

    }
}
