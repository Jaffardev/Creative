using Creative.Shared.Extensions;
using System.ComponentModel.DataAnnotations;

namespace Creative.Shared.Models;

public class StudentRegistrationModel
{
    public decimal Id { get; set; }
    public string? Code { get; set; }
    public int? StuStatus { get; set; }
    public int? ParentId { get; set; }
    public int Gender { get; set; } = -1;

    public string? Name1 { get; set; }
    public string? Name2 { get; set; }
    public string? Name11 { get; set; }
    public string? Name12 { get; set; }
    public string? Name13 { get; set; }
    public string? Name14 { get; set; }
    public string? Name15 { get; set; }
    public string? Name21 { get; set; }
    public string? Name22 { get; set; }
    public string? Name23 { get; set; }
    public string? Name24 { get; set; }
    public string? Name25 { get; set; }
    public string? Notes { get; set; }
    public string? DeptNotes { get; set; }
    public int? Result { get; set; }
    public int? NationalId { get; set; }

    [Required(ErrorMessage = "Relegion is required")]
    public int? RelegionId { get; set; }
    public int? StudentType { get; set; }
    public string? AgeAtAdmission { get; set; }
    public string? EligibleGrade { get; set; }
    public string? Age { get => BirthDate?.ToAgeString(); }
    public string? LastYearClass { get; set; }
    public string? LastModifiedBy { get; set; }
    public DateTime? LastModifiedDate { get; set; }
    public DateTime? AdmissionDate { get; set; }
    public DateTime? RegistrationDate { get; set; }
    public DateTime? JoinDate { get; set; }
    public int? ComeBranchId { get; set; }

    public decimal? ComeGradeId { get; set; }

    public string? ComeFrom { get; set; }
    public int? ComeYearId { get; set; }

    [Required(ErrorMessage = "Current Branch is required")]
    public decimal? CurBranchId { get; set; }

    [Required(ErrorMessage = "Current Grade is required")]
    public int? CurGradeId { get; set; }

    [Required(ErrorMessage = "Current Year is required")]
    public int? CurYearId { get; set; }

    public int? CurClassId { get; set; }

    public DateTime? ExaminationDate { get; set; }

    public bool HealthStatus { get; set; }

    public string? ExaminationResult { get; set; }
    public string? HealthFileNo { get; set; }
    public string? EducationDecisionNo { get; set; }
    public decimal? DisablityAsPerTheDecisionId { get; set; }
    public DateTime? EduDecisionDate { get; set; }
    public DateTime? NextVisitDate { get; set; }

    public decimal? DisablityCertificateId { get; set; }

    public DateTime? EduProveDate { get; set; }
    public DateTime? EduProveEndDate { get; set; }

    public string? MotherName { get; set; }
    public string? MotherCivilID { get; set; }
    public string? Tel1 { get; set; }
    public string? Tel2 { get; set; }
    public string? Email { get; set; }
    public string? Address1 { get; set; }
    public DateTime? PassportDate { get; set; }

    [Required(ErrorMessage = "Date of Birth Year is required")]
    public DateTime? BirthDate { get; set; }


    public string? BirthPlace { get; set; }
    public string? BirthDocPlace { get; set; }
    public string? CertificateNumber { get; set; }

    [Required(ErrorMessage = "Civil Id is required")]
    public string? IdNumber { get; set; }
    public DateTime? EndDate { get; set; }
    public decimal? EmpId { get; set; }
    public int? OnlineStatus { get; set; }
    public List<ExamEditModel> Exams { get; set; } = new();


    public bool AcpDirect { get; set; }

    public bool AcpApprove { get; set; }

    public bool AcpRecommend { get; set; }

    public bool AcpTransferCertificate { get; set; }

    public bool BrotherAcp { get; set; }

    public bool AcpEquivalencyCertificate { get; set; }

    public bool BrotherReg { get; set; }

    public bool AcpClearance { get; set; }

    public bool AcpHealthFile { get; set; }

    public bool ResEmp { get; set; }
    public string? Accepted { get; set; } = ((int)AcceptedInitialValue.UnderTest).ToString();
    public string? RejectPerson { get; set; }
    public string? RejectReason { get; set; }
    public bool? AcceptPrepaid { get; set; }
    public bool? AcceptFees { get; set; }
    public bool? AcceptDebt { get; set; }
    public int? StuPayBy { get; set; }

    public string? ManagementNotes { get; set; }
    public DateTime? TravelDate { get; set; }
    public DateTime? ReturnDate { get; set; }
    public DateTime? WithdrawDate { get; set; }
    public int? WithdrawReasonId { get; set; }
    public string? WithdrawReasonEng { get; set; }

    public string? WithdrawReasonArab { get; set; }

    public string? ComeFromE { get; set; }
    public int? Stay { get; set; }
    public int? SchoolComeType { get; set; }

    public int? ToSchoolId { get; set; }
    public int? FromSchoolId { get; set; }
    public int? SchoolGotype { get; set; }


    public int? TransferStatus { get; set; }
    public int? CurBranchIdD { get; set; }

    public int? CurGradeIdD { get; set; }

    public int? CurClassIdD { get; set; }

    public string? Other9 { get; set; }
    public int? ResidenceNo { get; set; }

    public DateTime? ResidenceEndDate { get; set; }
    public int? IdTypeId { get; set; }
    public int? ImsNo { get; set; }

    public int? IdNo { get; set; }
    public DateTime? IdEndDate { get; set; }
    public int? PassportType { get; set; }
    public string? PassportNumber { get; set; }
    public DateTime? PassportEndDate { get; set; }
    public string? Fax { get; set; }
    public string? EmergencyTel { get; set; }
    public int? GovernId { get; set; }

    public int? AreaId { get; set; }

    public int? PartId { get; set; }
    public int? HouseNo { get; set; }
    public string? Address2 { get; set; }


}
