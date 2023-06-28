using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Keyless]
[Table("Cart")]
public partial class Cart
{
    [Column("id")]
    public int Id { get; set; }

    [Column("cid")]
    public int? Cid { get; set; }

    [Column("itemid")]
    public int? Itemid { get; set; }

    [Column("qty")]
    public int? Qty { get; set; }

    [Column("create_date", TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    [Column("checkout")]
    public int? Checkout { get; set; }

    [Column("checkout_date", TypeName = "datetime")]
    public DateTime? CheckoutDate { get; set; }

    [Column("orderId")]
    public int? OrderId { get; set; }

    [Column("pos_id", TypeName = "decimal(18, 0)")]
    public decimal? PosId { get; set; }

    [Column("posted")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Posted { get; set; }
}
