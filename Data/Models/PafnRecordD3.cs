using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("pafn_record_d_3")]
public partial class PafnRecordD3
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

    [Column("material_type")]
    [StringLength(200)]
    [Unicode(false)]
    public string? MaterialType { get; set; }

    [Column("qty", TypeName = "decimal(18, 3)")]
    public decimal? Qty { get; set; }

    [Column("brand")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Brand { get; set; }

    [Column("material_status")]
    [StringLength(200)]
    [Unicode(false)]
    public string? MaterialStatus { get; set; }

    [Column("production_date", TypeName = "datetime")]
    public DateTime? ProductionDate { get; set; }

    [Column("expire_date", TypeName = "datetime")]
    public DateTime? ExpireDate { get; set; }

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
