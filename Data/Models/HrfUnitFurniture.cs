using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("hrf_unit_furniture")]
public partial class HrfUnitFurniture
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("code")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("unit_id", TypeName = "decimal(18, 0)")]
    public decimal? UnitId { get; set; }

    [Column("furniture_id", TypeName = "decimal(18, 0)")]
    public decimal? FurnitureId { get; set; }

    [Column("cost_amount", TypeName = "decimal(18, 3)")]
    public decimal? CostAmount { get; set; }

    [Column("price_amount", TypeName = "decimal(18, 3)")]
    public decimal? PriceAmount { get; set; }

    [Column("inv_item")]
    [StringLength(1)]
    [Unicode(false)]
    public string? InvItem { get; set; }

    [Column("onwer_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? OnwerType { get; set; }

    [Column("onwer_name")]
    [StringLength(100)]
    [Unicode(false)]
    public string? OnwerName { get; set; }

    [Column("qty", TypeName = "decimal(18, 3)")]
    public decimal? Qty { get; set; }

    [Column("delivery_date", TypeName = "datetime")]
    public DateTime? DeliveryDate { get; set; }

    [Column("delivery_by")]
    [StringLength(100)]
    [Unicode(false)]
    public string? DeliveryBy { get; set; }

    [Column("return_date", TypeName = "datetime")]
    public DateTime? ReturnDate { get; set; }

    [Column("mandotary")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Mandotary { get; set; }

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
}
