using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("ast_asset_branch")]
public partial class AstAssetBranch
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

    [Column("asset_id", TypeName = "decimal(18, 0)")]
    public decimal? AssetId { get; set; }

    [Column("branch_id", TypeName = "decimal(18, 0)")]
    public decimal? BranchId { get; set; }

    [Column("description")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Description { get; set; }

    [Column("start_depreciation", TypeName = "datetime")]
    public DateTime? StartDepreciation { get; set; }

    [Column("end_depreciation", TypeName = "datetime")]
    public DateTime? EndDepreciation { get; set; }

    [Column("depreciation_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? DepreciationType { get; set; }

    [Column("depreciation_total_amount", TypeName = "decimal(18, 3)")]
    public decimal? DepreciationTotalAmount { get; set; }

    [Column("depreciation_month_no", TypeName = "decimal(18, 0)")]
    public decimal? DepreciationMonthNo { get; set; }

    [Column("depreciation_resio", TypeName = "decimal(18, 3)")]
    public decimal? DepreciationResio { get; set; }

    [Column("depreciation_amount", TypeName = "decimal(18, 3)")]
    public decimal? DepreciationAmount { get; set; }

    [Column("depreciation_hour", TypeName = "decimal(18, 3)")]
    public decimal? DepreciationHour { get; set; }

    [Column("depreciation_old", TypeName = "decimal(18, 3)")]
    public decimal? DepreciationOld { get; set; }

    [Column("depreciation_pariod")]
    [StringLength(1)]
    [Unicode(false)]
    public string? DepreciationPariod { get; set; }

    [Column("asset_acc_id", TypeName = "decimal(18, 0)")]
    public decimal? AssetAccId { get; set; }

    [Column("liability_acc_id", TypeName = "decimal(18, 0)")]
    public decimal? LiabilityAccId { get; set; }

    [Column("expenses_acc_id", TypeName = "decimal(18, 0)")]
    public decimal? ExpensesAccId { get; set; }

    [Column("cost_id", TypeName = "decimal(18, 0)")]
    public decimal? CostId { get; set; }

    [Column("exp_id", TypeName = "decimal(18, 0)")]
    public decimal? ExpId { get; set; }

    [Column("analysis_id", TypeName = "decimal(18, 0)")]
    public decimal? AnalysisId { get; set; }

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

    [Column("location_id", TypeName = "decimal(18, 0)")]
    public decimal? LocationId { get; set; }
}
