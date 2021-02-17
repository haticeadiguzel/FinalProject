using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T>:DataResult<T>
    {
        public SuccessDataResult(T data, string message):base (data,true,message)
        {

        }
        //mesaj olayına girmek istemiyorsa eğer
        public SuccessDataResult(T data):base (data,true)
        {

        }
        //istersen data verme
        public SuccessDataResult(string message):base (default,true,message)
        {

        }
        //istersen hiçbi şey verme
        public SuccessDataResult():base(default,true)
        {
                
        }
    }
}
