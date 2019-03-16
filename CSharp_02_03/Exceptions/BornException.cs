using System;

namespace CSharp_02_03.Exceptions
{
    class BornException : Exception
    {
        public override string Message => "You have not born yet!";
    }
}
