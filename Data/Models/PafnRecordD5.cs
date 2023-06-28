using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("pafn_record_d_5")]
public partial class PafnRecordD5
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("h_id", TypeName = "decimal(18, 0)")]
    public decimal? HId { get; set; }

    [Column("active")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Active { get; set; }

    [Column("material_no")]
    [StringLength(200)]
    [Unicode(false)]
    public string? MaterialNo { get; set; }

    [Column("material_name")]
    [StringLength(200)]
    [Unicode(false)]
    public string? MaterialName { get; set; }

    [Column("qty_1", TypeName = "decimal(18, 3)")]
    public decimal? Qty1 { get; set; }

    [Column("qty_2", TypeName = "decimal(18, 3)")]
    public decimal? Qty2 { get; set; }

    [Column("brand")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Brand { get; set; }

    [Column("country")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Country { get; set; }

    [Column("country_id", TypeName = "decimal(18, 0)")]
    public decimal? CountryId { get; set; }

    [Column("production_date", TypeName = "datetime")]
    public DateTime? ProductionDate { get; set; }

    [Column("expire_date", TypeName = "datetime")]
    public DateTime? ExpireDate { get; set; }

    [Column("material_status")]
    [StringLength(200)]
    [Unicode(false)]
    public string? MaterialStatus { get; set; }

    [Column("posted")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Posted { get; set; }

    [Column("user_post_id", TypeName = "decimal(18, 0)")]
    public decimal? UserPostId { get; set; }

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
