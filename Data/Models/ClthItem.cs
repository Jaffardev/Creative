using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("clth_item")]
public partial class ClthItem
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("code")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Code { get; set; }

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

    [Column("unit_id", TypeName = "decimal(18, 0)")]
    public decimal? UnitId { get; set; }

    [Column("vendor")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Vendor { get; set; }

    [Column("ven_code")]
    [StringLength(50)]
    [Unicode(false)]
    public string? VenCode { get; set; }

    [Column("price", TypeName = "decimal(18, 4)")]
    public decimal? Price { get; set; }

    [Column("min_qty", TypeName = "decimal(18, 4)")]
    public decimal? MinQty { get; set; }

    [Column("max_qty", TypeName = "decimal(18, 0)")]
    public decimal? MaxQty { get; set; }

    [Column("req_qty", TypeName = "decimal(18, 4)")]
    public decimal? ReqQty { get; set; }

    [Column("item_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? ItemType { get; set; }

    [Column("path_1")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Path1 { get; set; }

    [Column("path_2")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Path2 { get; set; }

    [Column("path_3")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Path3 { get; set; }

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
