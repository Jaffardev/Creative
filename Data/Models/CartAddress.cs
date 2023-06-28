using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Keyless]
[Table("Cart_Address")]
public partial class CartAddress
{
    [Column("id")]
    public int Id { get; set; }

    [Column("cid")]
    public int? Cid { get; set; }

    [Column("address")]
    [StringLength(150)]
    public string? Address { get; set; }

    [Column("create_date", TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    [Column("active")]
    public int? Active { get; set; }

    public int? Orderid { get; set; }
}
