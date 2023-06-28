using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("reg_class")]
public partial class RegClass
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

    [Column("gread_id", TypeName = "decimal(18, 0)")]
    public decimal? GreadId { get; set; }

    [Column("branch_id", TypeName = "decimal(18, 0)")]
    public decimal? BranchId { get; set; }

    [Column("stu_sex")]
    [StringLength(1)]
    [Unicode(false)]
    public string? StuSex { get; set; }

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

    [Column("red_no")]
    public int? RedNo { get; set; }

    [Column("green_no")]
    public int? GreenNo { get; set; }

    [Column("blue_no")]
    public int? BlueNo { get; set; }

    [Column("modify_by", TypeName = "decimal(18, 0)")]
    public decimal? ModifyBy { get; set; }

    [Column("modify_date", TypeName = "datetime")]
    public DateTime? ModifyDate { get; set; }

    [Column("next_class_id_mail", TypeName = "decimal(18, 0)")]
    public decimal? NextClassIdMail { get; set; }

    [Column("next_class_id_fmail", TypeName = "decimal(18, 0)")]
    public decimal? NextClassIdFmail { get; set; }

    [Column("old_id", TypeName = "decimal(18, 0)")]
    public decimal? OldId { get; set; }

    [Column("capacity", TypeName = "decimal(18, 0)")]
    public decimal? Capacity { get; set; }

    [Column("acc_cost_id", TypeName = "decimal(18, 0)")]
    public decimal? AccCostId { get; set; }

    [Column("acc_exp_id", TypeName = "decimal(18, 0)")]
    public decimal? AccExpId { get; set; }

    [Column("acc_id", TypeName = "decimal(18, 0)")]
    public decimal? AccId { get; set; }

    [Column("acc_analysis_id", TypeName = "decimal(18, 0)")]
    public decimal? AccAnalysisId { get; set; }

    [Column("priority", TypeName = "decimal(18, 0)")]
    public decimal? Priority { get; set; }

    [Column("m_sort")]
    public int? MSort { get; set; }
}
