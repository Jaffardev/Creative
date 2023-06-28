using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("crg_tinvoice_d")]
public partial class CrgTinvoiceD
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

    [Column("commission_rate", TypeName = "decimal(18, 4)")]
    public decimal? CommissionRate { get; set; }

    [Column("commission_amount", TypeName = "decimal(18, 4)")]
    public decimal? CommissionAmount { get; set; }

    [Column("rec_isu")]
    [StringLength(20)]
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
}
