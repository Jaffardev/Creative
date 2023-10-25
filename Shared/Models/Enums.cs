using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Creative.Shared.Models
{
    public enum Lookup
    {
        All,
        Jobs,
        Religions,
        Classes,
        Grades,
        Years,
        Branches,
        Parents,
        Nationals,
        Employees,
        ExamTypes,
        ParentsAndStudent,
        HandicapType,
        Goverment,
        Area,
        Part,
        IdType,
        AccAccounts,
        AccAnalyses,
        AccCost,
        AccExpenses,
        BooksAccounts,
        BusAccount,
        AccAccCats,
    }

    public enum Identity
    {
        Parent,
        Student
    }

    public enum OnlineStatus
    {
        RegisterInSchool = 0,
        OnlineRegister = 1
    }



    ////stu_status intial value
    public enum StudentStatus
    {
        None = default,
        Registered = 1,
        Transfer = 2,
        Suspended = 3,
        Withdrawn = 4,
        ReservationAndNotPaid = 6,
        RegistrationInProgress = 7,
        NotReRegister = 8,
        Graduates = 9,
    }
    public enum StudentResult
    {
        successful = 1,
        fail = 2,
        noob = 3,
        ReEnlisted = 4,
        Transported = 5,
        ReRegistered = 6,
        FinishedYearsOfFailure = 7,
        ComingFromOutside = 8
    }

    ////stu_type intial value
    public enum StudentType
    {
        Civil = 1,
        Military = 2,
        CharityFund = 3,
        Merge = 4,
        SpecialNeeds = 5,
    }

    ////accepted intial value
    public enum AcceptedInitialValue
    {
        Rejected = 0,
        UnderTest = 2,
        Acceptable = 1,
    }

    public enum TransferStatus
    {
        Pending = 0,
        New = 1,
        Started = 2,
        Inprogress = 3,
        Posted = 6,
    }


    public enum PassportType
    {
        Normal = 1,
        Diplomat = 2,
        Private = 3,
        Temporary = 4,
        Document = 5,
        Other = 6

    }


    public enum StudentPay
    {
        OnParents = 1,
        OnOrganization = 2,
        Other = 3
    }

    public enum FinancialType
    {
        Father = 1,
        Mother = 2,
        Other = 3
    }

    public enum SchoolGoType
    {
        Father = 1,
        Mother = 2,
        Other = 3
    }
}

