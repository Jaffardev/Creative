using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("curs_trans_d")]
public partial class CursTransD
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("code")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("h_id", TypeName = "decimal(18, 0)")]
    public decimal? HId { get; set; }

    [Column("item_id", TypeName = "decimal(18, 0)")]
    public decimal? ItemId { get; set; }

    [Column("choose_1")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Choose1 { get; set; }

    [Column("degree_1")]
    public int? Degree1 { get; set; }

    [Column("choose_2")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Choose2 { get; set; }

    [Column("degree_2")]
    public int? Degree2 { get; set; }

    [Column("choose_3")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Choose3 { get; set; }

    [Column("degree_3")]
    public int? Degree3 { get; set; }

    [Column("choose_4")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Choose4 { get; set; }

    [Column("degree_4")]
    public int? Degree4 { get; set; }

    [Column("choose_5")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Choose5 { get; set; }

    [Column("degree_5")]
    public int? Degree5 { get; set; }

    [Column("choose_6")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Choose6 { get; set; }

    [Column("degree_6")]
    public int? Degree6 { get; set; }

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
