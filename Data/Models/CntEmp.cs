using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("cnt_emp")]
public partial class CntEmp
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("code")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("name_1")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Name1 { get; set; }

    [Column("name_2")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Name2 { get; set; }

    [Column("work_status")]
    [StringLength(50)]
    [Unicode(false)]
    public string? WorkStatus { get; set; }

    [Column("project_id", TypeName = "decimal(18, 0)")]
    public decimal? ProjectId { get; set; }

    [Column("location_id", TypeName = "decimal(18, 0)")]
    public decimal? LocationId { get; set; }

    [Column("birth_place")]
    [StringLength(100)]
    [Unicode(false)]
    public string? BirthPlace { get; set; }

    [Column("birth_date", TypeName = "datetime")]
    public DateTime? BirthDate { get; set; }

    [Column("birth_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? BirthNo { get; set; }

    [Column("passport_with")]
    [StringLength(1)]
    [Unicode(false)]
    public string? PassportWith { get; set; }

    [Column("passport_place_issue")]
    [StringLength(100)]
    [Unicode(false)]
    public string? PassportPlaceIssue { get; set; }

    [Column("passport_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? PassportNo { get; set; }

    [Column("passport_issue_date", TypeName = "datetime")]
    public DateTime? PassportIssueDate { get; set; }

    [Column("passport_end_date", TypeName = "datetime")]
    public DateTime? PassportEndDate { get; set; }

    [Column("id_with")]
    [StringLength(1)]
    [Unicode(false)]
    public string? IdWith { get; set; }

    [Column("id_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? IdNo { get; set; }

    [Column("id_end_date", TypeName = "datetime")]
    public DateTime? IdEndDate { get; set; }

    [Column("radiance_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? RadianceNo { get; set; }

    [Column("radiance_with")]
    [StringLength(50)]
    [Unicode(false)]
    public string? RadianceWith { get; set; }

    [Column("radiance_from_date", TypeName = "datetime")]
    public DateTime? RadianceFromDate { get; set; }

    [Column("radiance_end_date", TypeName = "datetime")]
    public DateTime? RadianceEndDate { get; set; }

    [Column("enter_kw_date", TypeName = "datetime")]
    public DateTime? EnterKwDate { get; set; }

    [Column("work_start_date", TypeName = "datetime")]
    public DateTime? WorkStartDate { get; set; }

    [Column("work_end_date", TypeName = "datetime")]
    public DateTime? WorkEndDate { get; set; }

    [Column("lessen_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? LessenNo { get; set; }

    [Column("lessen_with")]
    [StringLength(1)]
    [Unicode(false)]
    public string? LessenWith { get; set; }

    [Column("lessen_end_date", TypeName = "datetime")]
    public DateTime? LessenEndDate { get; set; }

    [Column("car_id", TypeName = "decimal(18, 0)")]
    public decimal? CarId { get; set; }

    [Column("tel_1")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Tel1 { get; set; }

    [Column("tel_2")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Tel2 { get; set; }

    [Column("tel_3")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Tel3 { get; set; }

    [Column("mobile")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Mobile { get; set; }

    [Column("fax")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Fax { get; set; }

    [Column("address")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Address { get; set; }

    [Column("address_out_kw")]
    [StringLength(200)]
    [Unicode(false)]
    public string? AddressOutKw { get; set; }

    [Column("email")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Email { get; set; }

    [Column("titel")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Titel { get; set; }

    [Column("ksa_approve")]
    [StringLength(1)]
    [Unicode(false)]
    public string? KsaApprove { get; set; }

    [Column("ksa_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? KsaNo { get; set; }

    [Column("ksa_start_date", TypeName = "datetime")]
    public DateTime? KsaStartDate { get; set; }

    [Column("ksa_end_date", TypeName = "datetime")]
    public DateTime? KsaEndDate { get; set; }

    [Column("ksa_tel")]
    [StringLength(15)]
    [Unicode(false)]
    public string? KsaTel { get; set; }

    [Column("ksa_other")]
    [StringLength(100)]
    [Unicode(false)]
    public string? KsaOther { get; set; }

    [Column("ksa_cost", TypeName = "decimal(18, 4)")]
    public decimal? KsaCost { get; set; }

    [Column("iraq_approve")]
    [StringLength(1)]
    [Unicode(false)]
    public string? IraqApprove { get; set; }

    [Column("iraq_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? IraqNo { get; set; }

    [Column("iraq_start_date", TypeName = "datetime")]
    public DateTime? IraqStartDate { get; set; }

    [Column("iraq_end_date", TypeName = "datetime")]
    public DateTime? IraqEndDate { get; set; }

    [Column("iraq_tel")]
    [StringLength(15)]
    [Unicode(false)]
    public string? IraqTel { get; set; }

    [Column("iraq_other")]
    [StringLength(100)]
    [Unicode(false)]
    public string? IraqOther { get; set; }

    [Column("iraq_cost", TypeName = "decimal(18, 4)")]
    public decimal? IraqCost { get; set; }

    [Column("port_approve")]
    [StringLength(1)]
    [Unicode(false)]
    public string? PortApprove { get; set; }

    [Column("port_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? PortNo { get; set; }

    [Column("port_start_date", TypeName = "datetime")]
    public DateTime? PortStartDate { get; set; }

    [Column("port_end_date", TypeName = "datetime")]
    public DateTime? PortEndDate { get; set; }

    [Column("port_tel")]
    [StringLength(15)]
    [Unicode(false)]
    public string? PortTel { get; set; }

    [Column("port_other")]
    [StringLength(100)]
    [Unicode(false)]
    public string? PortOther { get; set; }

    [Column("port_cost", TypeName = "decimal(18, 4)")]
    public decimal? PortCost { get; set; }

    [Column("add_approve")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AddApprove { get; set; }

    [Column("add_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? AddNo { get; set; }

    [Column("add_start_date", TypeName = "datetime")]
    public DateTime? AddStartDate { get; set; }

    [Column("add_end_date", TypeName = "datetime")]
    public DateTime? AddEndDate { get; set; }

    [Column("add_tel")]
    [StringLength(15)]
    [Unicode(false)]
    public string? AddTel { get; set; }

    [Column("add_other")]
    [StringLength(100)]
    [Unicode(false)]
    public string? AddOther { get; set; }

    [Column("add_cost", TypeName = "decimal(18, 4)")]
    public decimal? AddCost { get; set; }

    [Column("othr_approve")]
    [StringLength(1)]
    [Unicode(false)]
    public string? OthrApprove { get; set; }

    [Column("othr_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? OthrNo { get; set; }

    [Column("othr_start_date", TypeName = "datetime")]
    public DateTime? OthrStartDate { get; set; }

    [Column("othr_end_date", TypeName = "datetime")]
    public DateTime? OthrEndDate { get; set; }

    [Column("othr_tel")]
    [StringLength(15)]
    [Unicode(false)]
    public string? OthrTel { get; set; }

    [Column("othr_other")]
    [StringLength(100)]
    [Unicode(false)]
    public string? OthrOther { get; set; }

    [Column("othr_cost", TypeName = "decimal(18, 4)")]
    public decimal? OthrCost { get; set; }

    [Column("branch_id", TypeName = "decimal(18, 0)")]
    public decimal? BranchId { get; set; }

    [Column("acc_id", TypeName = "decimal(18, 0)")]
    public decimal? AccId { get; set; }

    [Column("cost_id", TypeName = "decimal(18, 0)")]
    public decimal? CostId { get; set; }

    [Column("exp_id", TypeName = "decimal(18, 0)")]
    public decimal? ExpId { get; set; }

    [Column("analysis_id", TypeName = "decimal(18, 0)")]
    public decimal? AnalysisId { get; set; }

    [Column("salary", TypeName = "decimal(18, 4)")]
    public decimal? Salary { get; set; }

    [Column("other_1", TypeName = "decimal(18, 4)")]
    public decimal? Other1 { get; set; }

    [Column("other_2", TypeName = "decimal(18, 4)")]
    public decimal? Other2 { get; set; }

    [Column("other_3", TypeName = "decimal(18, 4)")]
    public decimal? Other3 { get; set; }

    [Column("other_4", TypeName = "decimal(18, 4)")]
    public decimal? Other4 { get; set; }

    [Column("other_5", TypeName = "decimal(18, 4)")]
    public decimal? Other5 { get; set; }

    [Column("deduct_1", TypeName = "decimal(18, 4)")]
    public decimal? Deduct1 { get; set; }

    [Column("deduct_2", TypeName = "decimal(18, 4)")]
    public decimal? Deduct2 { get; set; }

    [Column("deduct_3", TypeName = "decimal(18, 4)")]
    public decimal? Deduct3 { get; set; }

    [Column("deduct_4", TypeName = "decimal(18, 4)")]
    public decimal? Deduct4 { get; set; }

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

    [Column("modify_by", TypeName = "decimal(18, 0)")]
    public decimal? ModifyBy { get; set; }

    [Column("modify_date", TypeName = "datetime")]
    public DateTime? ModifyDate { get; set; }

    [Column("radiance_company")]
    [StringLength(1)]
    [Unicode(false)]
    public string? RadianceCompany { get; set; }

    [Column("radiance_type")]
    [StringLength(10)]
    [Unicode(false)]
    public string? RadianceType { get; set; }

    [Column("radiance_print_date", TypeName = "datetime")]
    public DateTime? RadiancePrintDate { get; set; }

    [Column("passport_place")]
    [StringLength(100)]
    [Unicode(false)]
    public string? PassportPlace { get; set; }

    [Column("nationality")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Nationality { get; set; }

    [Column("authorization_no")]
    [StringLength(100)]
    [Unicode(false)]
    public string? AuthorizationNo { get; set; }
}
