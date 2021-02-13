using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        
        //this classsın kendisini kasdeder biz tek aprametereli const
        //calıstırmak için diğer constraı cagrabiliriz
        //yani resul(bool,str) calisinca otoamtik olarak result(bool) da calisacak
        public Result(bool success, string message):this(success)
        {
            Message = message;
            
        }
        //Kullanıcaya mesaj vermek istemiyorum sadece true false bilgisi
        // dondurmek istiyorum
        public Result(bool success)
        {
           
            Success = success;
        }


        public bool Success  {get;}

         public string Message {get; }
    }
}
