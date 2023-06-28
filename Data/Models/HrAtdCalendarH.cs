using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("hr_atd_calendar_h")]
public partial class HrAtdCalendarH
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

    [Column("from_date", TypeName = "datetime")]
    public DateTime? FromDate { get; set; }

    [Column("to_date", TypeName = "datetime")]
    public DateTime? ToDate { get; set; }

    [Column("from_time", TypeName = "datetime")]
    public DateTime? FromTime { get; set; }

    [Column("to_time", TypeName = "datetime")]
    public DateTime? ToTime { get; set; }

    [Column("allow_time", TypeName = "datetime")]
    public DateTime? AllowTime { get; set; }

    [Column("status_saturday")]
    [StringLength(1)]
    [Unicode(false)]
    public string? StatusSaturday { get; set; }

    [Column("from_time_1", TypeName = "datetime")]
    public DateTime? FromTime1 { get; set; }

    [Column("to_time_1", TypeName = "datetime")]
    public DateTime? ToTime1 { get; set; }

    [Column("allow_time_1", TypeName = "datetime")]
    public DateTime? AllowTime1 { get; set; }

    [Column("status_sunday")]
    [StringLength(1)]
    [Unicode(false)]
    public string? StatusSunday { get; set; }

    [Column("from_time_2", TypeName = "datetime")]
    public DateTime? FromTime2 { get; set; }

    [Column("to_time_2", TypeName = "datetime")]
    public DateTime? ToTime2 { get; set; }

    [Column("allow_time_2", TypeName = "datetime")]
    public DateTime? AllowTime2 { get; set; }

    [Column("status_monday")]
    [StringLength(1)]
    [Unicode(false)]
    public string? StatusMonday { get; set; }

    [Column("from_time_3", TypeName = "datetime")]
    public DateTime? FromTime3 { get; set; }

    [Column("to_time_3", TypeName = "datetime")]
    public DateTime? ToTime3 { get; set; }

    [Column("allow_time_3", TypeName = "datetime")]
    public DateTime? AllowTime3 { get; set; }

    [Column("status_tuesday")]
    [StringLength(1)]
    [Unicode(false)]
    public string? StatusTuesday { get; set; }

    [Column("from_time_4", TypeName = "datetime")]
    public DateTime? FromTime4 { get; set; }

    [Column("to_time_4", TypeName = "datetime")]
    public DateTime? ToTime4 { get; set; }

    [Column("allow_time_4", TypeName = "datetime")]
    public DateTime? AllowTime4 { get; set; }

    [Column("status_wednesday")]
    [StringLength(1)]
    [Unicode(false)]
    public string? StatusWednesday { get; set; }

    [Column("from_time_5", TypeName = "datetime")]
    public DateTime? FromTime5 { get; set; }

    [Column("to_time_5", TypeName = "datetime")]
    public DateTime? ToTime5 { get; set; }

    [Column("allow_time_5", TypeName = "datetime")]
    public DateTime? AllowTime5 { get; set; }

    [Column("status_thursday")]
    [StringLength(1)]
    [Unicode(false)]
    public string? StatusThursday { get; set; }

    [Column("from_time_6", TypeName = "datetime")]
    public DateTime? FromTime6 { get; set; }

    [Column("to_time_6", TypeName = "datetime")]
    public DateTime? ToTime6 { get; set; }

    [Column("allow_time_6", TypeName = "datetime")]
    public DateTime? AllowTime6 { get; set; }

    [Column("status_friday")]
    [StringLength(1)]
    [Unicode(false)]
    public string? StatusFriday { get; set; }

    [Column("from_time_7", TypeName = "datetime")]
    public DateTime? FromTime7 { get; set; }

    [Column("to_time_7", TypeName = "datetime")]
    public DateTime? ToTime7 { get; set; }

    [Column("allow_time_7", TypeName = "datetime")]
    public DateTime? AllowTime7 { get; set; }

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
