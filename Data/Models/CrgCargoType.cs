using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("crg_cargo_type")]
public partial class CrgCargoType
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

    [Column("vendoe_id", TypeName = "decimal(18, 0)")]
    public decimal? VendoeId { get; set; }

    [Column("length", TypeName = "decimal(18, 3)")]
    public decimal? Length { get; set; }

    [Column("width", TypeName = "decimal(18, 3)")]
    public decimal? Width { get; set; }

    [Column("height", TypeName = "decimal(18, 3)")]
    public decimal? Height { get; set; }

    [Column("weight", TypeName = "decimal(18, 3)")]
    public decimal? Weight { get; set; }

    [Column("volume", TypeName = "decimal(18, 3)")]
    public decimal? Volume { get; set; }

    [Column("accept_volume", TypeName = "decimal(18, 3)")]
    public decimal? AcceptVolume { get; set; }

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

    [Column("photo_path")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? PhotoPath { get; set; }
}
