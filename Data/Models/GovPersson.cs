using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("gov_persson")]
public partial class GovPersson
{
    [Key]
    [Column("ID", TypeName = "decimal(18, 0)")]
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

    [Column("tel_1")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Tel1 { get; set; }

    [Column("tel_2")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Tel2 { get; set; }

    [Column("gover_id", TypeName = "decimal(18, 0)")]
    public decimal? GoverId { get; set; }

    [Column("area_id", TypeName = "decimal(18, 0)")]
    public decimal? AreaId { get; set; }

    [Column("part_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? PartNo { get; set; }

    [Column("streat")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Streat { get; set; }

    [Column("gada")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Gada { get; set; }

    [Column("bulding")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Bulding { get; set; }

    [Column("house")]
    [StringLength(50)]
    [Unicode(false)]
    public string? House { get; set; }

    [Column("address")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Address { get; set; }

    [Column("id_no")]
    [StringLength(12)]
    [Unicode(false)]
    public string? IdNo { get; set; }

    [Column("ref_no")]
    [StringLength(20)]
    [Unicode(false)]
    public string? RefNo { get; set; }

    [Column("arm_no")]
    [StringLength(20)]
    [Unicode(false)]
    public string? ArmNo { get; set; }

    [Column("national_no")]
    [StringLength(20)]
    [Unicode(false)]
    public string? NationalNo { get; set; }

    [Column("active")]
    [StringLength(1)]
    [Unicode(false)]
    public string Active { get; set; } = null!;

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
