using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("pur_tquotation_d")]
public partial class PurTquotationD
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

    [Column("terms_1")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Terms1 { get; set; }

    [Column("terms_2")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Terms2 { get; set; }

    [Column("terms_3")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Terms3 { get; set; }

    [Column("terms_4")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Terms4 { get; set; }

    [Column("terms_5")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Terms5 { get; set; }

    [Column("discount_item", TypeName = "decimal(18, 5)")]
    public decimal? DiscountItem { get; set; }

    [Column("discount_rate", TypeName = "decimal(18, 5)")]
    public decimal? DiscountRate { get; set; }
}
