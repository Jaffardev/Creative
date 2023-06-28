using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("exp_exp_item")]
public partial class ExpExpItem
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

    [Column("exp_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? ExpType { get; set; }

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

    [Column("exp_class")]
    [StringLength(1)]
    [Unicode(false)]
    public string? ExpClass { get; set; }

    [Column("acc_db_id", TypeName = "decimal(18, 0)")]
    public decimal? AccDbId { get; set; }

    [Column("acc_cr_id", TypeName = "decimal(18, 0)")]
    public decimal? AccCrId { get; set; }

    [Column("acc_cost_db_id", TypeName = "decimal(18, 0)")]
    public decimal? AccCostDbId { get; set; }

    [Column("acc_cost_cr_id", TypeName = "decimal(18, 0)")]
    public decimal? AccCostCrId { get; set; }

    [Column("acc_exp_db_id", TypeName = "decimal(18, 0)")]
    public decimal? AccExpDbId { get; set; }

    [Column("acc_exp_cr_id", TypeName = "decimal(18, 0)")]
    public decimal? AccExpCrId { get; set; }

    [Column("acc_analysis_cr_id", TypeName = "decimal(18, 0)")]
    public decimal? AccAnalysisCrId { get; set; }

    [Column("acc_analysis_db_id", TypeName = "decimal(18, 0)")]
    public decimal? AccAnalysisDbId { get; set; }
}
