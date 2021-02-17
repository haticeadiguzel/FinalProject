using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    
        public class ErrorDataResult<T> : DataResult<T>
        {
            public ErrorDataResult(T data, string message) : base(data, false, message)
            {

            }
            //mesaj olayına girmek istemiyorsa eğer
            public ErrorDataResult(T data) : base(data, false)
            {

            }
            //istersen data verme
            public ErrorDataResult(string message) : base(default, false, message)
            {

            }
            //istersen hiçbi şey verme
            public ErrorDataResult() : base(default, false)
            {

            }
        }
    
}
