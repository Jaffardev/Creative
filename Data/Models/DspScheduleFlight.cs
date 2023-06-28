using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("dsp_schedule_flight")]
public partial class DspScheduleFlight
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("code")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("h_id", TypeName = "decimal(18, 0)")]
    public decimal? HId { get; set; }

    [Column("arrival_time", TypeName = "datetime")]
    public DateTime? ArrivalTime { get; set; }

    [Column("depautre_time", TypeName = "datetime")]
    public DateTime? DepautreTime { get; set; }

    [Column("arrival_days_01")]
    public int? ArrivalDays01 { get; set; }

    [Column("arrival_days_02")]
    public int? ArrivalDays02 { get; set; }

    [Column("arrival_days_03")]
    public int? ArrivalDays03 { get; set; }

    [Column("arrival_days_04")]
    public int? ArrivalDays04 { get; set; }

    [Column("arrival_days_05")]
    public int? ArrivalDays05 { get; set; }

    [Column("arrival_days_06")]
    public int? ArrivalDays06 { get; set; }

    [Column("arrival_days_07")]
    public int? ArrivalDays07 { get; set; }

    [Column("departure_days_01")]
    public int? DepartureDays01 { get; set; }

    [Column("departure_days_02")]
    public int? DepartureDays02 { get; set; }

    [Column("departure_days_03")]
    public int? DepartureDays03 { get; set; }

    [Column("departure_days_04")]
    public int? DepartureDays04 { get; set; }

    [Column("departure_days_05")]
    public int? DepartureDays05 { get; set; }

    [Column("departure_days_06")]
    public int? DepartureDays06 { get; set; }

    [Column("departure_days_07")]
    public int? DepartureDays07 { get; set; }

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
