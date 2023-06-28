using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("pos_trans_d")]
public partial class PosTransD
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("h_id", TypeName = "decimal(18, 0)")]
    public decimal? HId { get; set; }

    [Column("item_id", TypeName = "decimal(18, 0)")]
    public decimal? ItemId { get; set; }

    [Column("qty", TypeName = "decimal(18, 4)")]
    public decimal? Qty { get; set; }

    [Column("unit_price", TypeName = "decimal(18, 5)")]
    public decimal? UnitPrice { get; set; }

    [Column("amount", TypeName = "decimal(18, 4)")]
    public decimal? Amount { get; set; }

    [Column("discount", TypeName = "decimal(18, 4)")]
    public decimal? Discount { get; set; }

    [Column("lot_no", TypeName = "decimal(18, 0)")]
    public decimal? LotNo { get; set; }

    [Column("expierd_date", TypeName = "datetime")]
    public DateTime? ExpierdDate { get; set; }

    [Column("rec_status")]
    [StringLength(1)]
    [Unicode(false)]
    public string? RecStatus { get; set; }

    [Column("creation_by", TypeName = "decimal(18, 0)")]
    public decimal? CreationBy { get; set; }

    [Column("creation_date", TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    [Column("chang_by", TypeName = "decimal(18, 0)")]
    public decimal? ChangBy { get; set; }

    [Column("chang_date", TypeName = "datetime")]
    public DateTime? ChangDate { get; set; }

    [Column("notes")]
    [StringLength(255)]
    [Unicode(false)]
    public string? Notes { get; set; }

    [Column("unit_price_main", TypeName = "decimal(18, 3)")]
    public decimal? UnitPriceMain { get; set; }

    [Column("service_by", TypeName = "decimal(18, 0)")]
    public decimal? ServiceBy { get; set; }
}
