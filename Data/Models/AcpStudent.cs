using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("acp_student")]
public partial class AcpStudent
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
    public string? Gender { get; set; }

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
    public decimal? ParentId { get; set; }

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
    public DateTime? RegistrationDate { get; set; }

    [Column("join_date", TypeName = "datetime")]
    public DateTime? JoinDate { get; set; }

    [Column("come_gread_id", TypeName = "decimal(18, 0)")]
    public decimal? ComeGradeId { get; set; }

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
    public decimal? CurGradeIdD { get; set; }

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
    public string? HealthStatus { get; set; }

    [Column("helth_notes_1")]
    [StringLength(500)]
    [Unicode(false)]
    public string? ExaminationResult { get; set; }

    [Column("helth_date_1", TypeName = "datetime")]
    public DateTime? ExaminationDate { get; set; }

    [Column("helth_notes_2")]
    [StringLength(500)]
    [Unicode(false)]
    public string? HealthNotes2 { get; set; }

    [Column("helth_date_2", TypeName = "datetime")]
    public DateTime? HealthDate2 { get; set; }

    [Column("helth_notes_3")]
    [StringLength(500)]
    [Unicode(false)]
    public string? HealthNotes3 { get; set; }

    [Column("helth_date_3", TypeName = "datetime")]
    public DateTime? HealthDate3 { get; set; }

    [Column("helth_notes_4")]
    [StringLength(500)]
    [Unicode(false)]
    public string? HealthNotes4 { get; set; }

    [Column("helth_date_4", TypeName = "datetime")]
    public DateTime? HealthDate4 { get; set; }

    [Column("helth_tel")]
    [StringLength(10)]
    [Unicode(false)]
    public string? HealthTel { get; set; }

    [Column("mother_national_id", TypeName = "decimal(18, 0)")]
    public decimal? MotherNationalId { get; set; }

    [Column("mother_work")]
    [StringLength(500)]
    [Unicode(false)]
    public string? MotherWork { get; set; }

    [Column("mother_name")]
    [StringLength(100)]
    [Unicode(false)]
    public string? MotherName { get; set; }

    [Column("father_work")]
    [StringLength(500)]
    [Unicode(false)]
    public string? FatherWork { get; set; }

    [Column("transfer_status")]
    [StringLength(1)]
    [Unicode(false)]
    public string? TransferStatus { get; set; }

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

    [Column("reg_stu_id", TypeName = "decimal(18, 0)")]
    public decimal? RegStuId { get; set; }

    [Column("next_class_no", TypeName = "decimal(18, 0)")]
    public decimal? NextClassNo { get; set; }

    [Column("branch_id_old", TypeName = "decimal(18, 0)")]
    public decimal? BranchIdOld { get; set; }

    [Column("gread_id_old", TypeName = "decimal(18, 0)")]
    public decimal? GreadIdOld { get; set; }

    [Column("class_id_old", TypeName = "decimal(18, 0)")]
    public decimal? ClassIdOld { get; set; }

    [Column("allow_class_1")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AllowClass1 { get; set; }

    [Column("class_id_1", TypeName = "decimal(18, 0)")]
    public decimal? ClassId1 { get; set; }

    [Column("allow_class_2")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AllowClass2 { get; set; }

    [Column("class_id_2", TypeName = "decimal(18, 0)")]
    public decimal? ClassId2 { get; set; }

    [Column("allow_class_3")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AllowClass3 { get; set; }

    [Column("class_id_3", TypeName = "decimal(18, 0)")]
    public decimal? ClassId3 { get; set; }

    [Column("allow_class_4")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AllowClass4 { get; set; }

    [Column("class_id_4", TypeName = "decimal(18, 0)")]
    public decimal? ClassId4 { get; set; }

    [Column("allow_class_5")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AllowClass5 { get; set; }

    [Column("class_id_5", TypeName = "decimal(18, 0)")]
    public decimal? ClassId5 { get; set; }

    [Column("allow_class_6")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AllowClass6 { get; set; }

    [Column("class_id_6", TypeName = "decimal(18, 0)")]
    public decimal? ClassId6 { get; set; }

    [Column("allow_class_7")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AllowClass7 { get; set; }

    [Column("class_id_7", TypeName = "decimal(18, 0)")]
    public decimal? ClassId7 { get; set; }

    [Column("allow_class_8")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AllowClass8 { get; set; }

    [Column("class_id_8", TypeName = "decimal(18, 0)")]
    public decimal? ClassId8 { get; set; }

    [Column("allow_class_9")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AllowClass9 { get; set; }

    [Column("class_id_9", TypeName = "decimal(18, 0)")]
    public decimal? ClassId9 { get; set; }

    [Column("allow_class_10")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AllowClass10 { get; set; }

    [Column("class_id_10", TypeName = "decimal(18, 0)")]
    public decimal? ClassId10 { get; set; }

    [Column("allow_class_11")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AllowClass11 { get; set; }

    [Column("class_id_11", TypeName = "decimal(18, 0)")]
    public decimal? ClassId11 { get; set; }

    [Column("allow_class_12")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AllowClass12 { get; set; }

    [Column("class_id_12", TypeName = "decimal(18, 0)")]
    public decimal? ClassId12 { get; set; }

    [Column("allow_class_13")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AllowClass13 { get; set; }

    [Column("class_id_13", TypeName = "decimal(18, 0)")]
    public decimal? ClassId13 { get; set; }

    [Column("allow_class_14")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AllowClass14 { get; set; }

    [Column("class_id_14", TypeName = "decimal(18, 0)")]
    public decimal? ClassId14 { get; set; }

    [Column("allow_class_15")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AllowClass15 { get; set; }

    [Column("class_id_15", TypeName = "decimal(18, 0)")]
    public decimal? ClassId15 { get; set; }

    [Column("prepaid")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Prepaid { get; set; }

    [Column("accepted")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Accepted { get; set; }

    [Column("Reject_person")]
    [StringLength(100)]
    [Unicode(false)]
    public string? RejectPerson { get; set; }

    [Column("Reject_reason")]
    [StringLength(100)]
    [Unicode(false)]
    public string? RejectReason { get; set; }

    [Column("accept_prepaid")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AcceptPrepaid { get; set; }

    [Column("accept_fees")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AcceptFees { get; set; }

    [Column("accept_Debt")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AcceptDebt { get; set; }

    [Column("brother_reg")]
    [StringLength(1)]
    [Unicode(false)]
    public string? BrotherReg { get; set; }

    [Column("brother_acp")]
    [StringLength(1)]
    [Unicode(false)]
    public string? BrotherAcp { get; set; }

    [Column("acp_recommend")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AcpRecommend { get; set; }

    [Column("acp_Direct")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AcpDirect { get; set; }

    [Column("acp_date", TypeName = "datetime")]
    public DateTime? AdmissionDate { get; set; }

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
    public string? DisablityAsPerTheDecision { get; set; }

    [Column("handicape_id", TypeName = "decimal(18, 0)")]
    public decimal? HandicapeId { get; set; }

    [Column("dept_notes")]
    [StringLength(500)]
    [Unicode(false)]
    public string? DeptNotes { get; set; }

    [Column("edu_decision_date", TypeName = "datetime")]
    public DateTime? EduDecisionDate { get; set; }

    [Column("edu_decision_no")]
    [StringLength(100)]
    [Unicode(false)]
    public string? EducationDecisionNo { get; set; }

    [Column("edu_prove_date", TypeName = "datetime")]
    public DateTime? EduProveDate { get; set; }

    [Column("health_file_no")]
    [StringLength(100)]
    [Unicode(false)]
    public string? HealthFileNo { get; set; }

    [Column("next_visit_date", TypeName = "datetime")]
    public DateTime? NextVisitDate { get; set; }

    [Column("edu_prove_end_date", TypeName = "datetime")]
    public DateTime? EduProveEndDate { get; set; }

    [Column("handicape_certificate_id", TypeName = "decimal(18, 0)")]
    public decimal? DisablityCertificateId { get; set; }

    [Column("mother_id_no")]
    [StringLength(20)]
    [Unicode(false)]
    public string? MotherCivilID { get; set; }

    [Column("acp_online")]
    [StringLength(1)]
    [Unicode(false)]
    public string? OnlineStatus { get; set; }

    [Column("acp_approve")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AcpApprove { get; set; }

    [Column("acp_transfer_certificate")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AcpTransferCertificate { get; set; }

    [Column("acp_equivalency_certificate")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AcpEquivalencyCertificate { get; set; }

    [Column("acp_clearance")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AcpClearance { get; set; }

    [Column("acp_health_file")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AcpHealthFile { get; set; }

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

    
}
