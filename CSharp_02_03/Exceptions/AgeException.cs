using System;

namespace CSharp_02_03.Exceptions
{
    class AgeException : Exception
    {
        public override string Message => "Wrong age";
    }
}
