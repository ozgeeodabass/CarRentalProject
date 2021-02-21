using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //for voids
    public interface IResult
    {
        //encapsulate
        bool Success { get; }
        string Message { get; }

    }
}
