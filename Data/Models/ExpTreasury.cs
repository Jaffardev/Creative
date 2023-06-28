using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("exp_treasury")]
public partial class ExpTreasury
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

    [Column("branch_id", TypeName = "decimal(18, 0)")]
    public decimal? BranchId { get; set; }

    [Column("emp_id", TypeName = "decimal(18, 0)")]
    public decimal? EmpId { get; set; }

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

    [Column("posetion")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Posetion { get; set; }

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

    [Column("acc_db_id", TypeName = "decimal(18, 0)")]
    public decimal? AccDbId { get; set; }

    [Column("acc_bank_id", TypeName = "decimal(18, 0)")]
    public decimal? AccBankId { get; set; }

    [Column("acc_other_id", TypeName = "decimal(18, 0)")]
    public decimal? AccOtherId { get; set; }

    [Column("acc_analysis1_id", TypeName = "decimal(18, 0)")]
    public decimal? AccAnalysis1Id { get; set; }

    [Column("acc_analysis2_id", TypeName = "decimal(18, 0)")]
    public decimal? AccAnalysis2Id { get; set; }

    [Column("acc_analysis3_id", TypeName = "decimal(18, 0)")]
    public decimal? AccAnalysis3Id { get; set; }

    [Column("acc_analysis4_id", TypeName = "decimal(18, 0)")]
    public decimal? AccAnalysis4Id { get; set; }

    [Column("acc_analysis5_id", TypeName = "decimal(18, 0)")]
    public decimal? AccAnalysis5Id { get; set; }

    [Column("acc_analysis6_id", TypeName = "decimal(18, 0)")]
    public decimal? AccAnalysis6Id { get; set; }

    [Column("acc_analysis7_id", TypeName = "decimal(18, 0)")]
    public decimal? AccAnalysis7Id { get; set; }
}
