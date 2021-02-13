using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public interface IDataResult<T>:IResult
    {
        //arkadas sen result taki succes ve message verilerine ek olarak
        // bir de Data versiene sahip olcaksın dedik
        T Data { get; }
    }
}
