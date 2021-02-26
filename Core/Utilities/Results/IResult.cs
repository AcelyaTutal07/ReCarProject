using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //temel voidler için bir başlangıç
    //işlem sonuçlarını burda tutucaz
    public interface IResult
    {
        
        bool Success { get; }
        string Message { get; }

    }
}

