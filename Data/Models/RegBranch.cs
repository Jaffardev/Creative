using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("reg_branch")]
public partial class RegBranch
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("code")]
    [StringLength(20)]
    [Unicode(false)]
    public string Code { get; set; } = null!;

    [Column("name_1")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Name1 { get; set; }

    [Column("name_2")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Name2 { get; set; }

    [Column("emp_id")]
    [StringLength(100)]
    [Unicode(false)]
    public string? EmpId { get; set; }

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

    [Column("address")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Address { get; set; }

    [Column("email")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Email { get; set; }

    [Column("web_site")]
    [StringLength(100)]
    [Unicode(false)]
    public string? WebSite { get; set; }

    [Column("manager")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Manager { get; set; }

    [Column("school_id", TypeName = "decimal(18, 0)")]
    public decimal? SchoolId { get; set; }

    [Column("notes")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes { get; set; }

    [Column("active")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Active { get; set; }

    [Column("creation_by", TypeName = "decimal(18, 0)")]
    public decimal? CreationBy { get; set; }

    [Column("creation_date", TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    [Column("modify_by", TypeName = "decimal(18, 0)")]
    public decimal? ModifyBy { get; set; }

    [Column("modify_date", TypeName = "datetime")]
    public DateTime? ModifyDate { get; set; }

    [Column("m_sort")]
    public int? MSort { get; set; }

    [Column("icon_name")]
    [StringLength(15)]
    [Unicode(false)]
    public string? IconName { get; set; }

    [Column("stu_code")]
    [StringLength(10)]
    [Unicode(false)]
    public string? StuCode { get; set; }

    [Column("acc_cash", TypeName = "decimal(18, 0)")]
    public decimal? AccCash { get; set; }

    [Column("acc_key", TypeName = "decimal(18, 0)")]
    public decimal? AccKey { get; set; }

    [Column("acc_visa", TypeName = "decimal(18, 0)")]
    public decimal? AccVisa { get; set; }

    [Column("acc_master", TypeName = "decimal(18, 0)")]
    public decimal? AccMaster { get; set; }

    [Column("acc_atm", TypeName = "decimal(18, 0)")]
    public decimal? AccAtm { get; set; }

    [Column("acc_other", TypeName = "decimal(18, 0)")]
    public decimal? AccOther { get; set; }

    [Column("cost_center_id", TypeName = "decimal(18, 0)")]
    public decimal? CostCenterId { get; set; }

    [Column("acc_id", TypeName = "decimal(18, 0)")]
    public decimal? AccId { get; set; }

    [Column("acc_exp_id", TypeName = "decimal(18, 0)")]
    public decimal? AccExpId { get; set; }

    [Column("acc_analysis_id", TypeName = "decimal(18, 0)")]
    public decimal? AccAnalysisId { get; set; }
}
