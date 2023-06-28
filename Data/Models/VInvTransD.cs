using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Keyless]
public partial class VInvTransD
{
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("h_id", TypeName = "decimal(18, 0)")]
    public decimal? HId { get; set; }

    [Column("allocat_id", TypeName = "decimal(18, 0)")]
    public decimal? AllocatId { get; set; }

    [Column("trans_date", TypeName = "datetime")]
    public DateTime? TransDate { get; set; }

    [Column("doc_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? DocNo { get; set; }

    [Column("doc_date", TypeName = "datetime")]
    public DateTime? DocDate { get; set; }

    [Column("more_whs")]
    [StringLength(1)]
    [Unicode(false)]
    public string? MoreWhs { get; set; }

    [Column("whs_id", TypeName = "decimal(18, 0)")]
    public decimal? WhsId { get; set; }

    [Column("whs_code")]
    [StringLength(20)]
    [Unicode(false)]
    public string? WhsCode { get; set; }

    [Column("org_id", TypeName = "decimal(18, 0)")]
    public decimal? OrgId { get; set; }

    [Column("reson_id", TypeName = "decimal(18, 0)")]
    public decimal? ResonId { get; set; }

    [Column("rec_isu")]
    [StringLength(1)]
    [Unicode(false)]
    public string? RecIsu { get; set; }

    [Column("from_qty", TypeName = "decimal(18, 4)")]
    public decimal? FromQty { get; set; }

    [Column("to_qty", TypeName = "decimal(18, 4)")]
    public decimal? ToQty { get; set; }

    [Column("item_id", TypeName = "decimal(18, 0)")]
    public decimal? ItemId { get; set; }

    [Column("unit_id", TypeName = "decimal(18, 0)")]
    public decimal? UnitId { get; set; }

    [Column("unit_conv", TypeName = "decimal(18, 5)")]
    public decimal? UnitConv { get; set; }

    [Column("inv_from_qty", TypeName = "decimal(18, 5)")]
    public decimal? InvFromQty { get; set; }

    [Column("inv_to_qty", TypeName = "decimal(18, 5)")]
    public decimal? InvToQty { get; set; }

    [Column("cost_amount", TypeName = "decimal(18, 5)")]
    public decimal? CostAmount { get; set; }

    [Column("total_amount", TypeName = "decimal(18, 5)")]
    public decimal? TotalAmount { get; set; }

    [Column("lot_no", TypeName = "decimal(18, 0)")]
    public decimal? LotNo { get; set; }

    [Column("expier_date", TypeName = "datetime")]
    public DateTime? ExpierDate { get; set; }

    [Column("batch_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? BatchNo { get; set; }

    [Column("is_lot")]
    [StringLength(1)]
    [Unicode(false)]
    public string? IsLot { get; set; }

    [Column("is_contenar")]
    [StringLength(1)]
    [Unicode(false)]
    public string? IsContenar { get; set; }

    [Column("is_sec")]
    [StringLength(1)]
    [Unicode(false)]
    public string? IsSec { get; set; }

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

    [Column("trans_type_id", TypeName = "decimal(18, 0)")]
    public decimal? TransTypeId { get; set; }

    [Column("posted")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Posted { get; set; }

    [Column("from_acc_id", TypeName = "decimal(18, 0)")]
    public decimal? FromAccId { get; set; }

    [Column("from_cost_id", TypeName = "decimal(18, 0)")]
    public decimal? FromCostId { get; set; }

    [Column("from_exp_id", TypeName = "decimal(18, 0)")]
    public decimal? FromExpId { get; set; }

    [Column("from_analysis_id", TypeName = "decimal(18, 0)")]
    public decimal? FromAnalysisId { get; set; }

    [Column("to_acc_id", TypeName = "decimal(18, 0)")]
    public decimal? ToAccId { get; set; }

    [Column("to_cost_id", TypeName = "decimal(18, 0)")]
    public decimal? ToCostId { get; set; }

    [Column("to_exp_id", TypeName = "decimal(18, 0)")]
    public decimal? ToExpId { get; set; }

    [Column("to_analysis_id", TypeName = "decimal(18, 0)")]
    public decimal? ToAnalysisId { get; set; }

    [Column("acc_trans_id", TypeName = "decimal(18, 0)")]
    public decimal? AccTransId { get; set; }
}
