using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("posr_invoice_d")]
public partial class PosrInvoiceD
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

    [Column("order_d_id", TypeName = "decimal(18, 0)")]
    public decimal? OrderDId { get; set; }

    [Column("item_id", TypeName = "decimal(18, 0)")]
    public decimal? ItemId { get; set; }

    [Column("seat_id", TypeName = "decimal(18, 0)")]
    public decimal? SeatId { get; set; }

    [Column("row_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? RowType { get; set; }

    [Column("unit_id", TypeName = "decimal(18, 0)")]
    public decimal? UnitId { get; set; }

    [Column("item_size")]
    [StringLength(1)]
    [Unicode(false)]
    public string? ItemSize { get; set; }

    [Column("qty", TypeName = "decimal(18, 3)")]
    public decimal? Qty { get; set; }

    [Column("unit_price", TypeName = "decimal(18, 5)")]
    public decimal? UnitPrice { get; set; }

    [Column("amount", TypeName = "decimal(18, 3)")]
    public decimal? Amount { get; set; }

    [Column("discount", TypeName = "decimal(18, 3)")]
    public decimal? Discount { get; set; }

    [Column("lot_no", TypeName = "decimal(18, 0)")]
    public decimal? LotNo { get; set; }

    [Column("expierd_date", TypeName = "datetime")]
    public DateTime? ExpierdDate { get; set; }

    [Column("service_ratio", TypeName = "decimal(18, 0)")]
    public decimal? ServiceRatio { get; set; }

    [Column("service_amount", TypeName = "decimal(18, 3)")]
    public decimal? ServiceAmount { get; set; }

    [Column("tax_ratio", TypeName = "decimal(18, 3)")]
    public decimal? TaxRatio { get; set; }

    [Column("reason_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? ReasonType { get; set; }

    [Column("reason_id", TypeName = "decimal(18, 0)")]
    public decimal? ReasonId { get; set; }

    [Column("reason_desc")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? ReasonDesc { get; set; }

    [Column("name_1")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Name1 { get; set; }

    [Column("name_2")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Name2 { get; set; }

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

    [Column("order_extra_id", TypeName = "decimal(18, 0)")]
    public decimal? OrderExtraId { get; set; }
}
