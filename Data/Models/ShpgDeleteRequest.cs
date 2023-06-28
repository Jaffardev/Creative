using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("shpg_delete_request")]
public partial class ShpgDeleteRequest
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("code")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("trans_date", TypeName = "datetime")]
    public DateTime? TransDate { get; set; }

    [Column("row_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? RowType { get; set; }

    [Column("item_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? ItemType { get; set; }

    [Column("refer_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ReferNo { get; set; }

    [Column("used_for")]
    [StringLength(1)]
    [Unicode(false)]
    public string? UsedFor { get; set; }

    [Column("other_1")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Other1 { get; set; }

    [Column("record_by")]
    [StringLength(1)]
    [Unicode(false)]
    public string? RecordBy { get; set; }

    [Column("owner_1")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Owner1 { get; set; }

    [Column("owner_2")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Owner2 { get; set; }

    [Column("owner_3")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Owner3 { get; set; }

    [Column("owner_4")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Owner4 { get; set; }

    [Column("owner_5")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Owner5 { get; set; }

    [Column("owner_6")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Owner6 { get; set; }

    [Column("id_no_1")]
    [StringLength(20)]
    [Unicode(false)]
    public string? IdNo1 { get; set; }

    [Column("id_no_2")]
    [StringLength(20)]
    [Unicode(false)]
    public string? IdNo2 { get; set; }

    [Column("id_no_3")]
    [StringLength(20)]
    [Unicode(false)]
    public string? IdNo3 { get; set; }

    [Column("id_no_4")]
    [StringLength(20)]
    [Unicode(false)]
    public string? IdNo4 { get; set; }

    [Column("id_no_5")]
    [StringLength(20)]
    [Unicode(false)]
    public string? IdNo5 { get; set; }

    [Column("id_no_6")]
    [StringLength(20)]
    [Unicode(false)]
    public string? IdNo6 { get; set; }

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
