using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
   public  class SuccessResult: Result
    {
        //burada base Result classıdırı buna bir sey gondermek icin
        //base().. kullanılır
        public SuccessResult(string message) : base(true, message) 
        {

        }
          public SuccessResult():base(true)
      {
            
     }
    }
}
