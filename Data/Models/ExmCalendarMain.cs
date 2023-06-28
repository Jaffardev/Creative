using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("exm_calendar_main")]
public partial class ExmCalendarMain
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("code")]
    [StringLength(20)]
    [Unicode(false)]
    public string Code { get; set; } = null!;

    [Column("name_1")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Name1 { get; set; }

    [Column("name_2")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Name2 { get; set; }

    [Column("from_date", TypeName = "datetime")]
    public DateTime? FromDate { get; set; }

    [Column("to_date", TypeName = "datetime")]
    public DateTime? ToDate { get; set; }

    [Column("status_saturday")]
    [StringLength(1)]
    [Unicode(false)]
    public string? StatusSaturday { get; set; }

    [Column("status_sunday")]
    [StringLength(1)]
    [Unicode(false)]
    public string? StatusSunday { get; set; }

    [Column("status_monday")]
    [StringLength(1)]
    [Unicode(false)]
    public string? StatusMonday { get; set; }

    [Column("status_tuesday")]
    [StringLength(1)]
    [Unicode(false)]
    public string? StatusTuesday { get; set; }

    [Column("status_wednesday")]
    [StringLength(1)]
    [Unicode(false)]
    public string? StatusWednesday { get; set; }

    [Column("status_thursday")]
    [StringLength(1)]
    [Unicode(false)]
    public string? StatusThursday { get; set; }

    [Column("status_friday")]
    [StringLength(1)]
    [Unicode(false)]
    public string? StatusFriday { get; set; }

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
