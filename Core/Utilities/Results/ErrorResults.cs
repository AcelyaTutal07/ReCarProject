using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class ErrorResults : Result
    {
        public ErrorResults (string message) : base(false,message)
        {

        }
        public ErrorResults() : base(false)
        {

        }
    }
}
