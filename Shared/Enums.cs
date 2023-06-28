using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creative.Shared
{

 

    public enum ExamResult  
    {
        Successful,
        Failure,
    }

    public enum RegistrationStatus
    {
        Registering,
        Registered,
        Withdrawn
    }
    public class DataItem
    {
        public string Name { get; set; }
        public int Value { get; set; }
    }
   
}
