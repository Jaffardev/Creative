using Creative.Shared.Extensions;
using System.ComponentModel.DataAnnotations;

namespace Creative.Shared.Models;

public class AdmissionModel
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

    [Required]
    public int? RelegionId { get; set; }
    public int? StudentType { get; set; }

    [Required]
    public string? AgeAtAdmission { get; set; }

    [Required]
    public string? EligibleGrade { get; set; }

    [Required]
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

    [Required]
    public decimal? CurBranchId { get; set; }

    [Required]
    public int? CurGradeId { get; set; }

    [Required]
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

    [Required]
    public DateTime? BirthDate { get; set; }


    public string? BirthPlace { get; set; }
    public string? BirthDocPlace { get; set; }
    public string? CertificateNumber { get; set; }
    [Required]
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
    public string? XxxstudentTypeKind { get; set; }
}
