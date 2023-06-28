using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("posr_order_extra")]
public partial class PosrOrderExtra
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

    [Column("d_id", TypeName = "decimal(18, 0)")]
    public decimal? DId { get; set; }

    [Column("name_1")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Name1 { get; set; }

    [Column("name_2")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Name2 { get; set; }

    [Column("row_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? RowType { get; set; }

    [Column("d_code")]
    [StringLength(50)]
    [Unicode(false)]
    public string? DCode { get; set; }

    [Column("d_item_id", TypeName = "decimal(18, 0)")]
    public decimal? DItemId { get; set; }

    [Column("item_id", TypeName = "decimal(18, 0)")]
    public decimal? ItemId { get; set; }

    [Column("unit_id", TypeName = "decimal(18, 0)")]
    public decimal? UnitId { get; set; }

    [Column("item_size")]
    [StringLength(1)]
    [Unicode(false)]
    public string? ItemSize { get; set; }

    [Column("unit_price", TypeName = "decimal(18, 5)")]
    public decimal? UnitPrice { get; set; }

    [Column("qty", TypeName = "decimal(18, 3)")]
    public decimal? Qty { get; set; }

    [Column("amount", TypeName = "decimal(18, 3)")]
    public decimal? Amount { get; set; }

    [Column("discount", TypeName = "decimal(18, 3)")]
    public decimal? Discount { get; set; }

    [Column("lot_no", TypeName = "decimal(18, 0)")]
    public decimal? LotNo { get; set; }

    [Column("expierd_date", TypeName = "datetime")]
    public DateTime? ExpierdDate { get; set; }

    [Column("rec_status")]
    [StringLength(1)]
    [Unicode(false)]
    public string? RecStatus { get; set; }

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
}
