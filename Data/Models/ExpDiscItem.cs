using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("exp_disc_item")]
public partial class ExpDiscItem
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

    [Column("disc_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? DiscType { get; set; }

    [Column("year_id")]
    [StringLength(100)]
    [Unicode(false)]
    public string? YearId { get; set; }

    [Column("from_no", TypeName = "decimal(18, 0)")]
    public decimal? FromNo { get; set; }

    [Column("to_no", TypeName = "decimal(18, 0)")]
    public decimal? ToNo { get; set; }

    [Column("amount_ratio")]
    [StringLength(50)]
    [Unicode(false)]
    public string? AmountRatio { get; set; }

    [Column("ratio", TypeName = "decimal(18, 3)")]
    public decimal? Ratio { get; set; }

    [Column("ratio_min", TypeName = "decimal(18, 3)")]
    public decimal? RatioMin { get; set; }

    [Column("ratio_max", TypeName = "decimal(18, 3)")]
    public decimal? RatioMax { get; set; }

    [Column("amount_1", TypeName = "decimal(18, 3)")]
    public decimal? Amount1 { get; set; }

    [Column("amount_2", TypeName = "decimal(18, 3)")]
    public decimal? Amount2 { get; set; }

    [Column("amount_3", TypeName = "decimal(18, 3)")]
    public decimal? Amount3 { get; set; }

    [Column("amount_4", TypeName = "decimal(18, 3)")]
    public decimal? Amount4 { get; set; }

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

    [Column("is_chiled_no")]
    [StringLength(1)]
    [Unicode(false)]
    public string? IsChiledNo { get; set; }

    [Column("is_org")]
    [StringLength(1)]
    [Unicode(false)]
    public string? IsOrg { get; set; }

    [Column("org_id", TypeName = "decimal(18, 0)")]
    public decimal? OrgId { get; set; }

    [Column("is_emp")]
    [StringLength(1)]
    [Unicode(false)]
    public string? IsEmp { get; set; }

    [Column("stu_result")]
    [StringLength(1)]
    [Unicode(false)]
    public string? StuResult { get; set; }

    [Column("stu_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? StuType { get; set; }

    [Column("is_national")]
    [StringLength(1)]
    [Unicode(false)]
    public string? IsNational { get; set; }

    [Column("national_id", TypeName = "decimal(18, 0)")]
    public decimal? NationalId { get; set; }

    [Column("is_gread")]
    [StringLength(1)]
    [Unicode(false)]
    public string? IsGread { get; set; }

    [Column("gread_id", TypeName = "decimal(18, 0)")]
    public decimal? GreadId { get; set; }

    [Column("is_stage")]
    [StringLength(1)]
    [Unicode(false)]
    public string? IsStage { get; set; }

    [Column("stage_id", TypeName = "decimal(18, 0)")]
    public decimal? StageId { get; set; }

    [Column("is_branch")]
    [StringLength(1)]
    [Unicode(false)]
    public string? IsBranch { get; set; }

    [Column("branch_id", TypeName = "decimal(18, 0)")]
    public decimal? BranchId { get; set; }

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

    [Column("disc_class")]
    [StringLength(1)]
    [Unicode(false)]
    public string? DiscClass { get; set; }
}
