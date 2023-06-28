using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Keyless]
[Table("Cart_payment")]
public partial class CartPayment
{
    [Column("id")]
    public int Id { get; set; }

    [Column("cid")]
    public int? Cid { get; set; }

    [Column("txnid")]
    public long? Txnid { get; set; }

    [Column("iscaptured")]
    public int? Iscaptured { get; set; }

    [Column("orderid")]
    public int? Orderid { get; set; }

    [Column("total")]
    public double? Total { get; set; }

    [Column("create_date", TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    [Column("captured_date", TypeName = "datetime")]
    public DateTime? CapturedDate { get; set; }

    [Column("Mode_of_payment")]
    [StringLength(10)]
    public string? ModeOfPayment { get; set; }
}
