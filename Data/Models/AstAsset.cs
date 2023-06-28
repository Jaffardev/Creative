using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("ast_asset")]
public partial class AstAsset
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

    [Column("class_id", TypeName = "decimal(18, 0)")]
    public decimal? ClassId { get; set; }

    [Column("type_id", TypeName = "decimal(18, 0)")]
    public decimal? TypeId { get; set; }

    [Column("group_id", TypeName = "decimal(18, 0)")]
    public decimal? GroupId { get; set; }

    [Column("location_id", TypeName = "decimal(18, 0)")]
    public decimal? LocationId { get; set; }

    [Column("description")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Description { get; set; }

    [Column("emp_id", TypeName = "decimal(18, 0)")]
    public decimal? EmpId { get; set; }

    [Column("pur_date", TypeName = "datetime")]
    public DateTime? PurDate { get; set; }

    [Column("pur_doc_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? PurDocNo { get; set; }

    [Column("asset_actual_amount", TypeName = "decimal(18, 3)")]
    public decimal? AssetActualAmount { get; set; }

    [Column("asset_qty", TypeName = "decimal(18, 3)")]
    public decimal? AssetQty { get; set; }

    [Column("vendor_name")]
    [StringLength(100)]
    [Unicode(false)]
    public string? VendorName { get; set; }

    [Column("model")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Model { get; set; }

    [Column("serial_no")]
    [StringLength(100)]
    [Unicode(false)]
    public string? SerialNo { get; set; }

    [Column("made_year", TypeName = "decimal(18, 0)")]
    public decimal? MadeYear { get; set; }

    [Column("color")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Color { get; set; }

    [Column("doc_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? DocNo { get; set; }

    [Column("other_1")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Other1 { get; set; }

    [Column("other_2")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Other2 { get; set; }

    [Column("other_3")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Other3 { get; set; }

    [Column("other_4")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Other4 { get; set; }

    [Column("other_5")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Other5 { get; set; }

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

    [Column("dimension_1")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Dimension1 { get; set; }

    [Column("dimension_2")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Dimension2 { get; set; }

    [Column("dimension_3")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Dimension3 { get; set; }

    [Column("dimension_4")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Dimension4 { get; set; }

    [Column("depreciation_old", TypeName = "decimal(18, 3)")]
    public decimal? DepreciationOld { get; set; }

    [Column("depreciation_pariod")]
    [StringLength(1)]
    [Unicode(false)]
    public string? DepreciationPariod { get; set; }

    [Column("asset_status")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AssetStatus { get; set; }

    [Column("company_insurance_id", TypeName = "decimal(18, 0)")]
    public decimal? CompanyInsuranceId { get; set; }

    [Column("ins_amount", TypeName = "decimal(18, 3)")]
    public decimal? InsAmount { get; set; }

    [Column("parent_id", TypeName = "decimal(18, 0)")]
    public decimal? ParentId { get; set; }

    [Column("last_level")]
    [StringLength(1)]
    [Unicode(false)]
    public string? LastLevel { get; set; }

    [Column("level_no")]
    public int? LevelNo { get; set; }

    [Column("long_code")]
    [StringLength(255)]
    [Unicode(false)]
    public string? LongCode { get; set; }
}
