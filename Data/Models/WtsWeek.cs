using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("wts_week")]
public partial class WtsWeek
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

    [Column("sat_status")]
    [StringLength(1)]
    [Unicode(false)]
    public string? SatStatus { get; set; }

    [Column("sun_status")]
    [StringLength(1)]
    [Unicode(false)]
    public string? SunStatus { get; set; }

    [Column("mon_status")]
    [StringLength(1)]
    [Unicode(false)]
    public string? MonStatus { get; set; }

    [Column("tue_status")]
    [StringLength(1)]
    [Unicode(false)]
    public string? TueStatus { get; set; }

    [Column("wed_status")]
    [StringLength(1)]
    [Unicode(false)]
    public string? WedStatus { get; set; }

    [Column("thu_status")]
    [StringLength(1)]
    [Unicode(false)]
    public string? ThuStatus { get; set; }

    [Column("fri_status")]
    [StringLength(1)]
    [Unicode(false)]
    public string? FriStatus { get; set; }

    [Column("from_date", TypeName = "datetime")]
    public DateTime? FromDate { get; set; }

    [Column("to_date", TypeName = "datetime")]
    public DateTime? ToDate { get; set; }

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

    [Column("photo_path")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? PhotoPath { get; set; }
}
