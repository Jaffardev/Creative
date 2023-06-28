using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("hre_evaluation_d")]
public partial class HreEvaluationD
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

    [Column("h_id", TypeName = "decimal(18, 0)")]
    public decimal? HId { get; set; }

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

    [Column("alow_text")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowText { get; set; }

    [Column("chose_no")]
    public int? ChoseNo { get; set; }

    [Column("chose_titel_1")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ChoseTitel1 { get; set; }

    [Column("chose_degry_1")]
    public int? ChoseDegry1 { get; set; }

    [Column("chose_degry_max_1")]
    public int? ChoseDegryMax1 { get; set; }

    [Column("chose_degry_min_1")]
    public int? ChoseDegryMin1 { get; set; }

    [Column("chose_titel_2")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ChoseTitel2 { get; set; }

    [Column("chose_degry_2")]
    public int? ChoseDegry2 { get; set; }

    [Column("chose_degry_max_2")]
    public int? ChoseDegryMax2 { get; set; }

    [Column("chose_degry_min_2")]
    public int? ChoseDegryMin2 { get; set; }

    [Column("chose_titel_3")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ChoseTitel3 { get; set; }

    [Column("chose_degry_3")]
    public int? ChoseDegry3 { get; set; }

    [Column("chose_degry_max_3")]
    public int? ChoseDegryMax3 { get; set; }

    [Column("chose_degry_min_3")]
    public int? ChoseDegryMin3 { get; set; }

    [Column("chose_titel_4")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ChoseTitel4 { get; set; }

    [Column("chose_degry_4")]
    public int? ChoseDegry4 { get; set; }

    [Column("chose_degry_max_4")]
    public int? ChoseDegryMax4 { get; set; }

    [Column("chose_degry_min_4")]
    public int? ChoseDegryMin4 { get; set; }

    [Column("chose_titel_5")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ChoseTitel5 { get; set; }

    [Column("chose_degry_5")]
    public int? ChoseDegry5 { get; set; }

    [Column("chose_degry_max_5")]
    public int? ChoseDegryMax5 { get; set; }

    [Column("chose_degry_min_5")]
    public int? ChoseDegryMin5 { get; set; }
}
