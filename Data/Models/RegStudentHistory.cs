using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("reg_student_history")]
public partial class RegStudentHistory
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("code")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("stu_id", TypeName = "decimal(18, 0)")]
    public decimal? StuId { get; set; }

    [Column("stu_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? StuType { get; set; }

    [Column("stu_status")]
    [StringLength(1)]
    [Unicode(false)]
    public string? StuStatus { get; set; }

    [Column("stu_result")]
    [StringLength(1)]
    [Unicode(false)]
    public string? StuResult { get; set; }

    [Column("notes")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes { get; set; }

    [Column("helth_stutus")]
    [StringLength(1)]
    [Unicode(false)]
    public string? HelthStutus { get; set; }

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

    [Column("handicape_type")]
    [StringLength(100)]
    [Unicode(false)]
    public string? HandicapeType { get; set; }

    [Column("handicape_id", TypeName = "decimal(18, 0)")]
    public decimal? HandicapeId { get; set; }

    [Column("handicape_certificate_id", TypeName = "decimal(18, 0)")]
    public decimal? HandicapeCertificateId { get; set; }

    [Column("resedence_no")]
    [StringLength(15)]
    [Unicode(false)]
    public string? ResedenceNo { get; set; }

    [Column("resedence_end_date", TypeName = "datetime")]
    public DateTime? ResedenceEndDate { get; set; }

    [Column("id_type_id", TypeName = "decimal(18, 0)")]
    public decimal? IdTypeId { get; set; }

    [Column("national_id", TypeName = "decimal(18, 0)")]
    public decimal? NationalId { get; set; }

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

    [Column("come_from")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ComeFrom { get; set; }

    [Column("come_year_id", TypeName = "decimal(18, 0)")]
    public decimal? ComeYearId { get; set; }

    [Column("come_branch_id", TypeName = "decimal(18, 0)")]
    public decimal? ComeBranchId { get; set; }

    [Column("cur_branch_id_d", TypeName = "decimal(18, 0)")]
    public decimal? CurBranchIdD { get; set; }

    [Column("cur_gread_id_d", TypeName = "decimal(18, 0)")]
    public decimal? CurGreadIdD { get; set; }

    [Column("cur_class_id_d", TypeName = "decimal(18, 0)")]
    public decimal? CurClassIdD { get; set; }

    [Column("emp_id", TypeName = "decimal(18, 0)")]
    public decimal? EmpId { get; set; }

    [Column("stu_pay_by")]
    [StringLength(1)]
    [Unicode(false)]
    public string? StuPayBy { get; set; }

    [Column("educational_decision")]
    [StringLength(50)]
    [Unicode(false)]
    public string? EducationalDecision { get; set; }

    [Column("re_evaluation")]
    [StringLength(1)]
    [Unicode(false)]
    public string? ReEvaluation { get; set; }

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

    [Column("school_come_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? SchoolComeType { get; set; }

    [Column("school_go_type")]
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

    [Column("creation_by", TypeName = "decimal(18, 0)")]
    public decimal? CreationBy { get; set; }

    [Column("creation_date", TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    [Column("modify_by", TypeName = "decimal(18, 0)")]
    public decimal? ModifyBy { get; set; }

    [Column("modify_date", TypeName = "datetime")]
    public DateTime? ModifyDate { get; set; }

    [Column("gpa", TypeName = "decimal(18, 3)")]
    public decimal? Gpa { get; set; }

    [Column("gpa_hour", TypeName = "decimal(18, 3)")]
    public decimal? GpaHour { get; set; }

    [Column("gpa_degree", TypeName = "decimal(18, 3)")]
    public decimal? GpaDegree { get; set; }
}
