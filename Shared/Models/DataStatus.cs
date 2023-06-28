using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creative.Shared.Models;


public class DataItem<T>
{
    public T Data { get; set; }
    public DataStatus Status { get; internal set; } = DataStatus.Empty;
    public bool IsSuccess { get; internal set; }
    public string Message { get; set; }

    public void Success(T data)
    {
        Data = data;
        Status = DataStatus.Loaded;
        IsSuccess = true;
    }

    public void Fail(string message = "")
    {
        Message = message;
        Status = DataStatus.Error;
        IsSuccess = false;
    }
    public void Loading()
    {
        Status = DataStatus.Loading;
    }
}

public enum DataStatus
{
    Empty,
    Loading,
    Loaded,
    Error
}
