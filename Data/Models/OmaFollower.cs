using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("oma_followers")]
public partial class OmaFollower
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

    [Column("voters_id", TypeName = "decimal(18, 0)")]
    public decimal? VotersId { get; set; }

    [Column("area_id", TypeName = "decimal(18, 0)")]
    public decimal? AreaId { get; set; }

    [Column("active")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Active { get; set; }

    [Column("parent_id", TypeName = "decimal(18, 0)")]
    public decimal? ParentId { get; set; }

    [Column("last_level")]
    [StringLength(1)]
    [Unicode(false)]
    public string? LastLevel { get; set; }

    [Column("level_no")]
    public int? LevelNo { get; set; }

    [Column("long_code")]
    [StringLength(255)]
    [Unicode(false)]
    public string? LongCode { get; set; }

    [Column("budget")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Budget { get; set; }

    [Column("control")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Control { get; set; }

    [Column("sex")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Sex { get; set; }

    [Column("tel_1")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Tel1 { get; set; }

    [Column("tel_2")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Tel2 { get; set; }

    [Column("tel_3")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Tel3 { get; set; }

    [Column("contact_name")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ContactName { get; set; }

    [Column("by_tel_1")]
    [StringLength(15)]
    [Unicode(false)]
    public string? ByTel1 { get; set; }

    [Column("by_tel_2")]
    [StringLength(15)]
    [Unicode(false)]
    public string? ByTel2 { get; set; }

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
