using System;

namespace CSharp_02_03.Exceptions
{
    class EmailException : Exception
    {
        public override string Message => "Email adress is not correct!";
    }
}
