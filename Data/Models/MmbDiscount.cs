using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("mmb_discount")]
public partial class MmbDiscount
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("code")]
    [StringLength(20)]
    [Unicode(false)]
    public string Code { get; set; } = null!;

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

    [Column("amount_ratio")]
    [StringLength(50)]
    [Unicode(false)]
    public string? AmountRatio { get; set; }

    [Column("ratio", TypeName = "decimal(18, 3)")]
    public decimal? Ratio { get; set; }

    [Column("ratio_min", TypeName = "decimal(18, 3)")]
    public decimal? RatioMin { get; set; }

    [Column("ratio_max", TypeName = "decimal(18, 3)")]
    public decimal? RatioMax { get; set; }

    [Column("amount_1", TypeName = "decimal(18, 3)")]
    public decimal? Amount1 { get; set; }

    [Column("amount_2", TypeName = "decimal(18, 3)")]
    public decimal? Amount2 { get; set; }

    [Column("amount_3", TypeName = "decimal(18, 3)")]
    public decimal? Amount3 { get; set; }

    [Column("amount_4", TypeName = "decimal(18, 3)")]
    public decimal? Amount4 { get; set; }

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
