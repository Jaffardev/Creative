using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("cns_cont_cat")]
public partial class CnsContCat
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("code")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("proj_id", TypeName = "decimal(18, 0)")]
    public decimal? ProjId { get; set; }

    [Column("item_id", TypeName = "decimal(18, 0)")]
    public decimal? ItemId { get; set; }

    [Column("resp_id", TypeName = "decimal(18, 0)")]
    public decimal? RespId { get; set; }

    [Column("qty", TypeName = "decimal(18, 4)")]
    public decimal? Qty { get; set; }

    [Column("price", TypeName = "decimal(18, 4)")]
    public decimal? Price { get; set; }

    [Column("amount", TypeName = "decimal(18, 4)")]
    public decimal? Amount { get; set; }

    [Column("cont_qty", TypeName = "decimal(18, 4)")]
    public decimal? ContQty { get; set; }

    [Column("cont_price", TypeName = "decimal(18, 4)")]
    public decimal? ContPrice { get; set; }

    [Column("cont_amount", TypeName = "decimal(18, 4)")]
    public decimal? ContAmount { get; set; }

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

    [Column("cont_id", TypeName = "decimal(18, 0)")]
    public decimal? ContId { get; set; }

    [Column("cat_id", TypeName = "decimal(18, 0)")]
    public decimal? CatId { get; set; }
}
