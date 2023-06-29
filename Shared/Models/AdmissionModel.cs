namespace Creative.Shared.Models;

public class AdmissionModel
{
    public decimal Id { get; set; }
    public string? Code { get; set; }
    public StudentStatus? StuStatus { get; set; }
    public int? ParentId { get; set; }
    public int? Gender { get; set; }

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
    public StudentResult? Result { get; set; }
    public int? NationalId { get; set; }
    public Item? SelectedNational { get; set; }

    public int? RelegionId { get; set; }
    public Item? SelectedRelegion { get; set; }
    public int? StudentType { get; set; }
    public int? AgeAtAdmission { get; set; }
    public int? Age { get; set; }
    public string? LastYearClass { get; set; }
    public string? LastModifiedBy { get; set; }
    public DateTime? LastModifiedDate { get; set; }
    public DateTime? AdmissionDate { get; set; }
    public DateTime? RegistrationDate { get; set; }
    public DateTime? JoinDate { get; set; }
    public int? ComeBranchId { get; set; }
    public Item? ComeBranch { get; set; }

    public int? ComeGradeId { get; set; }
    public Item? ComeGrade { get; set; }

    public int? ComeYearId { get; set; }
    public Item? ComeYear { get; set; }

    public int? CurBranchIdD { get; set; }
    public Item? CurBranch { get; set; }

    public int? CurGradeIdD { get; set; }
    public Item? CurGrade { get; set; }

    public int? CurYearId { get; set; }
    public Item? CurYear { get; set; }

    public int? CurClassId { get; set; }
    public Item? CurClass { get; set; }

    public DateTime? ExaminationDate { get; set; }
    public bool HealthStatus { get; set; }
    public string? ExaminationResult { get; set; }
    public string? HealthFileNo { get; set; }
    public string? EducationDecisionNo { get; set; }
    public string? DisablityAsPerTheDecision { get; set; }
    public DateTime? EduDecisionDate { get; set; }
    public DateTime? NextVisitDate { get; set; }

    public string? DisablityCertificateId { get; set; }
    public DateTime? EduProveDate { get; set; }
    public DateTime? EduProveEndDate { get; set; }

    public string? MotherName { get; set; }
    public string? MotherCivilID { get; set; }
    public string? Tel1 { get; set; }
    public string? Tel2 { get; set; }
    public string? Email { get; set; }
    public string? Address1 { get; set; }
    public DateTime? PassportDate { get; set; }
    public DateTime? BirthDate { get; set; }


    public string? BirthPlace { get; set; }
    public string? BirthDocPlace { get; set; }
    public string? CertificateNumber { get; set; }
    public string? IdNumber { get; set; }
    public DateTime? EndDate { get; set; }
    public int? EmployeeId { get; set; }
    public OnlineStatus OnlineStatus { get; set; }
    public List<ExamEditModel> Exams { get; set; } = new();
}
