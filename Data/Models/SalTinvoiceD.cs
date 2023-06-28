using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("sal_tinvoice_d")]
public partial class SalTinvoiceD
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("code")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("h_id", TypeName = "decimal(18, 0)")]
    public decimal? HId { get; set; }

    [Column("item_id", TypeName = "decimal(18, 0)")]
    public decimal? ItemId { get; set; }

    [Column("unit_id", TypeName = "decimal(18, 0)")]
    public decimal? UnitId { get; set; }

    [Column("qty", TypeName = "decimal(18, 4)")]
    public decimal? Qty { get; set; }

    [Column("amount", TypeName = "decimal(18, 4)")]
    public decimal? Amount { get; set; }

    [Column("discount", TypeName = "decimal(18, 4)")]
    public decimal? Discount { get; set; }

    [Column("whs_id", TypeName = "decimal(18, 0)")]
    public decimal? WhsId { get; set; }

    [Column("row_status")]
    [StringLength(1)]
    [Unicode(false)]
    public string? RowStatus { get; set; }

    [Column("posted")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Posted { get; set; }

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

    [Column("currency_id", TypeName = "decimal(18, 0)")]
    public decimal? CurrencyId { get; set; }

    [Column("exchange_rate", TypeName = "decimal(18, 5)")]
    public decimal? ExchangeRate { get; set; }

    [Column("amount_main", TypeName = "decimal(18, 4)")]
    public decimal? AmountMain { get; set; }

    [Column("convertion", TypeName = "decimal(18, 5)")]
    public decimal? Convertion { get; set; }

    [Column("Commission_rate", TypeName = "decimal(18, 4)")]
    public decimal? CommissionRate { get; set; }

    [Column("Commission_amount", TypeName = "decimal(18, 4)")]
    public decimal? CommissionAmount { get; set; }

    [Column("rec_isu")]
    [StringLength(1)]
    [Unicode(false)]
    public string? RecIsu { get; set; }

    [Column("acc_trans_id", TypeName = "decimal(18, 0)")]
    public decimal? AccTransId { get; set; }

    [Column("desc_1")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Desc1 { get; set; }

    [Column("desc_2")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Desc2 { get; set; }

    [Column("desc_3")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Desc3 { get; set; }

    [Column("desc_4")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Desc4 { get; set; }

    [Column("desc_5")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Desc5 { get; set; }

    [Column("desc_6")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Desc6 { get; set; }

    [Column("desc_7")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Desc7 { get; set; }

    [Column("desc_8")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Desc8 { get; set; }

    [Column("desc_9")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Desc9 { get; set; }

    [Column("desc_10")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Desc10 { get; set; }

    [Column("qty_scnd", TypeName = "decimal(18, 4)")]
    public decimal? QtyScnd { get; set; }

    [Column("pay_status")]
    [StringLength(1)]
    [Unicode(false)]
    public string? PayStatus { get; set; }

    [Column("responser_ext_id", TypeName = "decimal(18, 0)")]
    public decimal? ResponserExtId { get; set; }

    [Column("Commission_rate_ext", TypeName = "decimal(18, 4)")]
    public decimal? CommissionRateExt { get; set; }

    [Column("Commission_amount_ext", TypeName = "decimal(18, 4)")]
    public decimal? CommissionAmountExt { get; set; }

    [Column("responser_id", TypeName = "decimal(18, 0)")]
    public decimal? ResponserId { get; set; }

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

    [Column("is_expire")]
    [StringLength(1)]
    [Unicode(false)]
    public string? IsExpire { get; set; }

    [Column("lot_no", TypeName = "decimal(18, 0)")]
    public decimal? LotNo { get; set; }

    [Column("expier_date", TypeName = "datetime")]
    public DateTime? ExpierDate { get; set; }

    [Column("batch_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? BatchNo { get; set; }

    [Column("discount_rate", TypeName = "decimal(18, 5)")]
    public decimal? DiscountRate { get; set; }

    [Column("discount_item", TypeName = "decimal(18, 5)")]
    public decimal? DiscountItem { get; set; }

    [Column("acc_id", TypeName = "decimal(18, 0)")]
    public decimal? AccId { get; set; }

    [Column("cost_id", TypeName = "decimal(18, 0)")]
    public decimal? CostId { get; set; }

    [Column("exp_id", TypeName = "decimal(18, 0)")]
    public decimal? ExpId { get; set; }

    [Column("analysis_id", TypeName = "decimal(18, 0)")]
    public decimal? AnalysisId { get; set; }

    [Column("row_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? RowType { get; set; }

    [Column("equ_tcontract_d_id", TypeName = "decimal(18, 0)")]
    public decimal? EquTcontractDId { get; set; }
}
