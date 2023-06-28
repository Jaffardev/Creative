using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("reg_student")]
[Index("Code", Name = "IX_reg_student", IsUnique = true)]
public partial class RegStudent
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("id_o", TypeName = "decimal(18, 0)")]
    public decimal? IdO { get; set; }

    [Column("code")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("name_1_1")]
    [StringLength(25)]
    [Unicode(false)]
    public string? Name11 { get; set; }

    [Column("name_1_2")]
    [StringLength(25)]
    [Unicode(false)]
    public string? Name12 { get; set; }

    [Column("name_1_3")]
    [StringLength(25)]
    [Unicode(false)]
    public string? Name13 { get; set; }

    [Column("name_1_4")]
    [StringLength(25)]
    [Unicode(false)]
    public string? Name14 { get; set; }

    [Column("name_1_5")]
    [StringLength(25)]
    [Unicode(false)]
    public string? Name15 { get; set; }

    [Column("name_1")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Name1 { get; set; }

    [Column("name_2_1")]
    [StringLength(25)]
    [Unicode(false)]
    public string? Name21 { get; set; }

    [Column("name_2_2")]
    [StringLength(25)]
    [Unicode(false)]
    public string? Name22 { get; set; }

    [Column("name_2_3")]
    [StringLength(25)]
    [Unicode(false)]
    public string? Name23 { get; set; }

    [Column("name_2_4")]
    [StringLength(25)]
    [Unicode(false)]
    public string? Name24 { get; set; }

    [Column("name_2_5")]
    [StringLength(25)]
    [Unicode(false)]
    public string? Name25 { get; set; }

    [Column("name_2")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Name2 { get; set; }

    [Column("tel_1")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Tel1 { get; set; }

    [Column("tel_2")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Tel2 { get; set; }

    [Column("fax")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Fax { get; set; }

    [Column("address_1")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Address1 { get; set; }

    [Column("address_2")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Address2 { get; set; }

    [Column("email")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Email { get; set; }

    [Column("birth_date", TypeName = "datetime")]
    public DateTime? BirthDate { get; set; }

    [Column("birth_place")]
    [StringLength(100)]
    [Unicode(false)]
    public string? BirthPlace { get; set; }

    [Column("birth_doc_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? BirthDocNo { get; set; }

    [Column("birth_doc_place")]
    [StringLength(100)]
    [Unicode(false)]
    public string? BirthDocPlace { get; set; }

    [Column("resedence_no")]
    [StringLength(15)]
    [Unicode(false)]
    public string? ResedenceNo { get; set; }

    [Column("xxxresedence_date", TypeName = "datetime")]
    public DateTime? XxxresedenceDate { get; set; }

    [Column("resedence_end_date", TypeName = "datetime")]
    public DateTime? ResedenceEndDate { get; set; }

    [Column("id_type_id", TypeName = "decimal(18, 0)")]
    public decimal? IdTypeId { get; set; }

    [Column("id_no")]
    [StringLength(20)]
    [Unicode(false)]
    public string? IdNo { get; set; }

    [Column("xxxid_date", TypeName = "datetime")]
    public DateTime? XxxidDate { get; set; }

    [Column("id_end_date", TypeName = "datetime")]
    public DateTime? IdEndDate { get; set; }

    [Column("stu_sex")]
    [StringLength(1)]
    [Unicode(false)]
    public string? StuSex { get; set; }

    [NotMapped]
    public int Gender { get; set; }

    [Column("national_id", TypeName = "decimal(18, 0)")]
    public decimal? NationalId { get; set; }

    [Column("relegion_id", TypeName = "decimal(18, 0)")]
    public decimal? RelegionId { get; set; }

    [Column("passport_no")]
    [StringLength(20)]
    [Unicode(false)]
    public string? PassportNo { get; set; }

    [Column("passport_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? PassportType { get; set; }

    [Column("passport_date", TypeName = "datetime")]
    public DateTime? PassportDate { get; set; }

    [Column("passport_end_date", TypeName = "datetime")]
    public DateTime? PassportEndDate { get; set; }

    [Column("responsibile_id", TypeName = "decimal(18, 0)")]
    public decimal? ResponsibileId { get; set; }

    [Column("res_emp")]
    [StringLength(1)]
    [Unicode(false)]
    public string? ResEmp { get; set; }

    [Column("res_relation")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ResRelation { get; set; }

    [Column("finance_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? FinanceType { get; set; }

    [Column("finance_name")]
    [StringLength(100)]
    [Unicode(false)]
    public string? FinanceName { get; set; }

    [Column("finance_tel")]
    [StringLength(15)]
    [Unicode(false)]
    public string? FinanceTel { get; set; }

    [Column("finance_address")]
    [StringLength(255)]
    [Unicode(false)]
    public string? FinanceAddress { get; set; }

    [Column("gover_id", TypeName = "decimal(18, 0)")]
    public decimal? GoverId { get; set; }

    [Column("area_id", TypeName = "decimal(18, 0)")]
    public decimal? AreaId { get; set; }

    [Column("part_id", TypeName = "decimal(18, 0)")]
    public decimal? PartId { get; set; }

    [Column("reg_date", TypeName = "datetime")]
    public DateTime? RegDate { get; set; }

    [Column("join_date", TypeName = "datetime")]
    public DateTime? JoinDate { get; set; }

    [Column("come_gread_id", TypeName = "decimal(18, 0)")]
    public decimal? ComeGreadId { get; set; }

    [Column("cur_year_id", TypeName = "decimal(18, 0)")]
    public decimal? CurYearId { get; set; }

    [Column("cur_branch_id", TypeName = "decimal(18, 0)")]
    public decimal? CurBranchId { get; set; }

    [Column("cur_gread_id", TypeName = "decimal(18, 0)")]
    public decimal? CurGreadId { get; set; }

    [Column("cur_class_id", TypeName = "decimal(18, 0)")]
    public decimal? CurClassId { get; set; }

    [Column("stay")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Stay { get; set; }

    [Column("stu_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? StuType { get; set; }

    [Column("stu_status")]
    [StringLength(1)]
    [Unicode(false)]
    public string? StuStatus { get; set; }

    [Column("photo_1")]
    [StringLength(255)]
    [Unicode(false)]
    public string? Photo1 { get; set; }

    [Column("photo_2")]
    [StringLength(255)]
    [Unicode(false)]
    public string? Photo2 { get; set; }

    [Column("photo_3")]
    [StringLength(255)]
    [Unicode(false)]
    public string? Photo3 { get; set; }

    [Column("stu_result")]
    [StringLength(1)]
    [Unicode(false)]
    public string? StuResult { get; set; }

    [Column("come_from")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ComeFrom { get; set; }

    [Column("come_year_id", TypeName = "decimal(18, 0)")]
    public decimal? ComeYearId { get; set; }

    [Column("xxxbirth_certfc_date", TypeName = "datetime")]
    public DateTime? XxxbirthCertfcDate { get; set; }

    [Column("come_branch_id", TypeName = "decimal(18, 0)")]
    public decimal? ComeBranchId { get; set; }

    [Column("active")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Active { get; set; }

    [Column("notes")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes { get; set; }

    [Column("creation_by", TypeName = "decimal(18, 0)")]
    public decimal? CreationBy { get; set; }

    [Column("creation_date", TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    [Column("cur_branch_id_d", TypeName = "decimal(18, 0)")]
    public decimal? CurBranchIdD { get; set; }

    [Column("cur_gread_id_d", TypeName = "decimal(18, 0)")]
    public decimal? CurGreadIdD { get; set; }

    [Column("cur_class_id_d", TypeName = "decimal(18, 0)")]
    public decimal? CurClassIdD { get; set; }

    [Column("xxxstudent_type_kind")]
    [StringLength(1)]
    [Unicode(false)]
    public string? XxxstudentTypeKind { get; set; }

    [Column("modify_by", TypeName = "decimal(18, 0)")]
    public decimal? ModifyBy { get; set; }

    [Column("modify_date", TypeName = "datetime")]
    public DateTime? ModifyDate { get; set; }

    [Column("emp_id", TypeName = "decimal(18, 0)")]
    public decimal? EmpId { get; set; }

    [Column("helth_stutus")]
    [StringLength(1)]
    [Unicode(false)]
    public string? HelthStutus { get; set; }

    [Column("helth_notes_1")]
    [StringLength(500)]
    [Unicode(false)]
    public string? HelthNotes1 { get; set; }

    [Column("helth_date_1", TypeName = "datetime")]
    public DateTime? HelthDate1 { get; set; }

    [Column("helth_notes_2")]
    [StringLength(500)]
    [Unicode(false)]
    public string? HelthNotes2 { get; set; }

    [Column("helth_date_2", TypeName = "datetime")]
    public DateTime? HelthDate2 { get; set; }

    [Column("helth_notes_3")]
    [StringLength(500)]
    [Unicode(false)]
    public string? HelthNotes3 { get; set; }

    [Column("helth_date_3", TypeName = "datetime")]
    public DateTime? HelthDate3 { get; set; }

    [Column("helth_notes_4")]
    [StringLength(500)]
    [Unicode(false)]
    public string? HelthNotes4 { get; set; }

    [Column("helth_date_4", TypeName = "datetime")]
    public DateTime? HelthDate4 { get; set; }

    [Column("helth_tel")]
    [StringLength(10)]
    [Unicode(false)]
    public string? HelthTel { get; set; }

    [Column("mother_national_id", TypeName = "decimal(18, 0)")]
    public decimal? MotherNationalId { get; set; }

    [Column("mother_work")]
    [StringLength(500)]
    [Unicode(false)]
    public string? MotherWork { get; set; }

    [Column("father_work")]
    [StringLength(500)]
    [Unicode(false)]
    public string? FatherWork { get; set; }

    [Column("other_1")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Other1 { get; set; }

    [Column("other_2")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Other2 { get; set; }

    [Column("other_3")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Other3 { get; set; }

    [Column("other_4")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Other4 { get; set; }

    [Column("mother_name")]
    [StringLength(100)]
    [Unicode(false)]
    public string? MotherName { get; set; }

    [Column("transfer_status")]
    [StringLength(1)]
    [Unicode(false)]
    public string? TransferStatus { get; set; }

    [Column("withdrow_date", TypeName = "datetime")]
    public DateTime? WithdrowDate { get; set; }

    [Column("withdrow_resson")]
    [StringLength(500)]
    [Unicode(false)]
    public string? WithdrowResson { get; set; }

    [Column("take_code")]
    [StringLength(1)]
    [Unicode(false)]
    public string? TakeCode { get; set; }

    [Column("stu_pay_by")]
    [StringLength(1)]
    [Unicode(false)]
    public string? StuPayBy { get; set; }

    [Column("job_mother_id", TypeName = "decimal(18, 0)")]
    public decimal? JobMotherId { get; set; }

    [Column("code_old")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CodeOld { get; set; }

    [Column("registered")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Registered { get; set; }

    [Column("Educational_decision")]
    [StringLength(50)]
    [Unicode(false)]
    public string? EducationalDecision { get; set; }

    [Column("Re_Evaluation")]
    [StringLength(1)]
    [Unicode(false)]
    public string? ReEvaluation { get; set; }

    [Column("Handicape_type")]
    [StringLength(100)]
    [Unicode(false)]
    public string? HandicapeType { get; set; }

    [Column("handicape_id", TypeName = "decimal(18, 0)")]
    public decimal? HandicapeId { get; set; }

    [Column("other_5")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Other5 { get; set; }

    [Column("other_6")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Other6 { get; set; }

    [Column("other_7")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Other7 { get; set; }

    [Column("other_8")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Other8 { get; set; }

    [Column("other_9")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Other9 { get; set; }

    [Column("other_10")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Other10 { get; set; }

    [Column("registed_end_date", TypeName = "datetime")]
    public DateTime? RegistedEndDate { get; set; }

    [Column("come_from_e")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ComeFromE { get; set; }

    [Column("withdrow_resson_e")]
    [StringLength(500)]
    [Unicode(false)]
    public string? WithdrowRessonE { get; set; }

    [Column("school_come_Type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? SchoolComeType { get; set; }

    [Column("school_go_Type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? SchoolGoType { get; set; }

    [Column("from_school_id", TypeName = "decimal(18, 0)")]
    public decimal? FromSchoolId { get; set; }

    [Column("to_school_id", TypeName = "decimal(18, 0)")]
    public decimal? ToSchoolId { get; set; }

    [Column("withdraw_reasonl_id", TypeName = "decimal(18, 0)")]
    public decimal? WithdrawReasonlId { get; set; }

    [Column("edu_decision_date", TypeName = "datetime")]
    public DateTime? EduDecisionDate { get; set; }

    [Column("edu_decision_no")]
    [StringLength(100)]
    [Unicode(false)]
    public string? EduDecisionNo { get; set; }

    [Column("edu_prove_date", TypeName = "datetime")]
    public DateTime? EduProveDate { get; set; }

    [Column("health_file_no")]
    [StringLength(100)]
    [Unicode(false)]
    public string? HealthFileNo { get; set; }

    [Column("next_visit_date", TypeName = "datetime")]
    public DateTime? NextVisitDate { get; set; }

    [Column("intellegent_ratio", TypeName = "decimal(18, 3)")]
    public decimal? IntellegentRatio { get; set; }

    [Column("handicape_certificate_id", TypeName = "decimal(18, 0)")]
    public decimal? HandicapeCertificateId { get; set; }

    [Column("acc_id", TypeName = "decimal(18, 0)")]
    public decimal? AccId { get; set; }

    [Column("classification")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Classification { get; set; }

    [Column("travel_date", TypeName = "datetime")]
    public DateTime? TravelDate { get; set; }

    [Column("return_date", TypeName = "datetime")]
    public DateTime? ReturnDate { get; set; }

    [Column("acc_cost_id", TypeName = "decimal(18, 0)")]
    public decimal? AccCostId { get; set; }

    [Column("acc_exp_id", TypeName = "decimal(18, 0)")]
    public decimal? AccExpId { get; set; }

    [Column("acc_analysis_id", TypeName = "decimal(18, 0)")]
    public decimal? AccAnalysisId { get; set; }

    [Column("mother_id_no")]
    [StringLength(20)]
    [Unicode(false)]
    public string? MotherIdNo { get; set; }

    [Column("acc_branch_id", TypeName = "decimal(18, 0)")]
    public decimal? AccBranchId { get; set; }

    [Column("acc_gread_id", TypeName = "decimal(18, 0)")]
    public decimal? AccGreadId { get; set; }

    [Column("acc_class_id", TypeName = "decimal(18, 0)")]
    public decimal? AccClassId { get; set; }

    [Column("acc_year_id", TypeName = "decimal(18, 0)")]
    public decimal? AccYearId { get; set; }

    [Column("acc_prepay_id", TypeName = "decimal(18, 0)")]
    public decimal? AccPrepayId { get; set; }

    [Column("acc_debit_id", TypeName = "decimal(18, 0)")]
    public decimal? AccDebitId { get; set; }

    [Column("gpa", TypeName = "decimal(18, 3)")]
    public decimal? Gpa { get; set; }

    [Column("gpa_hour", TypeName = "decimal(18, 3)")]
    public decimal? GpaHour { get; set; }

    [Column("gpa_degree", TypeName = "decimal(18, 3)")]
    public decimal? GpaDegree { get; set; }

    [Column("lms_no", TypeName = "decimal(18, 0)")]
    public decimal? LmsNo { get; set; }

    [Column("acc_id_book", TypeName = "decimal(18, 0)")]
    public decimal? AccIdBook { get; set; }

    [Column("acc_id_open", TypeName = "decimal(18, 0)")]
    public decimal? AccIdOpen { get; set; }

    [Column("acc_id_bus", TypeName = "decimal(18, 0)")]
    public decimal? AccIdBus { get; set; }

    [Column("acc_id_uniform", TypeName = "decimal(18, 0)")]
    public decimal? AccIdUniform { get; set; }

    [Column("reg_student")]
    [StringLength(20)]
    [Unicode(false)]
    public string? RegStudent1 { get; set; }

    [Column("cur_branch_id_d_d", TypeName = "decimal(18, 0)")]
    public decimal? CurBranchIdDD { get; set; }

    [Column("cur_gread_id_d_d", TypeName = "decimal(18, 0)")]
    public decimal? CurGreadIdDD { get; set; }

    [Column("cur_class_id_d_d", TypeName = "decimal(18, 0)")]
    public decimal? CurClassIdDD { get; set; }

    [Column("edu_prove_end_date", TypeName = "datetime")]
    public DateTime? EduProveEndDate { get; set; }

    [Column("health_file")]
    [StringLength(1)]
    [Unicode(false)]
    public string? HealthFile { get; set; }

    [Column("absent_date", TypeName = "datetime")]
    public DateTime? AbsentDate { get; set; }

    [Column("absent_reason")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? AbsentReason { get; set; }

    [Column("house_no")]
    [StringLength(500)]
    [Unicode(false)]
    public string? HouseNo { get; set; }

    [Column("street_no")]
    [StringLength(500)]
    [Unicode(false)]
    public string? StreetNo { get; set; }

    [Column("gada_no")]
    [StringLength(500)]
    [Unicode(false)]
    public string? GadaNo { get; set; }

    [InverseProperty("Student")]
    public virtual ICollection<ExpPayD> ExpPayDs { get; set; } = new List<ExpPayD>();
}
