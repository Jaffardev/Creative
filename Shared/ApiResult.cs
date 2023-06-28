using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creative.Shared
{
    public class ApiResult<T>
    {
        public bool IsSuccess { get; set; }
        public T? Data { get; set; }

        public string Message { get; set; } = null!;

        public ApiResult<T> Success(T data)
        {
            Data = data;
            IsSuccess = true;
            return this;
        }
        public ApiResult<T> Fail(string message)
        {
            Message = message;
            IsSuccess = false;
            return this;
        }
    }

 
}
