using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("c_byn_main")]
public partial class CBynMain
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

    [Column("group_id", TypeName = "decimal(18, 0)")]
    public decimal? GroupId { get; set; }

    [Column("byn_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? BynType { get; set; }

    [Column("company_id", TypeName = "decimal(18, 0)")]
    public decimal? CompanyId { get; set; }

    [Column("product_id", TypeName = "decimal(18, 0)")]
    public decimal? ProductId { get; set; }

    [Column("activty_id", TypeName = "decimal(18, 0)")]
    public decimal? ActivtyId { get; set; }

    [Column("other_id", TypeName = "decimal(18, 0)")]
    public decimal? OtherId { get; set; }

    [Column("sturt_date", TypeName = "datetime")]
    public DateTime? SturtDate { get; set; }

    [Column("end_date", TypeName = "datetime")]
    public DateTime? EndDate { get; set; }

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
