namespace Creative.Shared.Models;

public class AdmissionModel
{
    public decimal Id { get; set; }
    public string? Code { get; set; }
    public string? Status { get; set; }
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
    public string? Result { get; set; }
    public int? NationalityId { get; set; } 
    public int? RelegionId { get; set; }
    public int? StudentType { get; set; }
    public int? AgeAtAdmission { get; set; }
    public int? Age { get; set; }
    public string? LastYearClass { get; set; }
    public string? LastModifiedBy { get; set; }
    public DateOnly? LastModifiedDate { get; set; }
    public DateOnly? AdmissionDate { get; set; }
    public DateOnly? RegistrationDate { get; set; }
    public DateOnly? JoinDate { get; set; }
    public int? NextBranch { get; set; }
    public int? NextGrade { get; set; }
    public int? NextYear { get; set; }
    public int? Branch { get; set; }
    public int? Grade { get; set; }
    public int? Year { get; set; }
    public int? Class{ get; set; }
    public DateOnly? ExaminationDate { get; set; }
    public bool HealthStatus { get; set; }
    public string? ExaminationResult { get; set; }
    public string? FileNumber { get; set; }
    public string? EducationDecisionNo { get; set; }
    public string? DisablityAsPerTheDecision { get; set; }
    public DateOnly? DecisionDate { get; set; }
    public DateOnly? DecisionDateEnd { get; set; }

    public string? DisablityCertificate { get; set; }
    public DateOnly? CertificateDate { get; set; }
    public DateOnly? CertificateDateEnd { get; set; }

    public string? MotherName { get; set; }
    public string? MotherCivilID { get; set; }
    public string? Tel1 { get; set; }
    public string? Tel2{ get; set; }
    public string? Email { get; set; }
    public string? Address { get; set; }
    public DateOnly? PassportDate { get; set; }
    public DateOnly? BirthDate { get; set; }

    
    public string? BirthPlace { get; set; }
    public string? BirthDocPlace { get; set; }
    public string? CertificateNumber { get; set; }
    public string? IdNumber { get; set; }
    public DateOnly? EndDate { get; set; }
    public int? EmployeeId { get; set; }

    public List<ExamEditModel> Exams { get; set; } = new();
}
