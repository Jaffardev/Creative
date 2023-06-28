using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("dsp_aircraft_config")]
public partial class DspAircraftConfig
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("sal_cust_id", TypeName = "decimal(18, 0)")]
    public decimal? SalCustId { get; set; }

    [Column("aircraft_type")]
    [StringLength(100)]
    [Unicode(false)]
    public string? AircraftType { get; set; }

    [Column("description")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Description { get; set; }

    [Column("start_date", TypeName = "datetime")]
    public DateTime? StartDate { get; set; }

    [Column("end_date", TypeName = "datetime")]
    public DateTime? EndDate { get; set; }

    [Column("first_prefix")]
    public int? FirstPrefix { get; set; }

    [Column("first_seats")]
    public int? FirstSeats { get; set; }

    [Column("biz_prefix")]
    public int? BizPrefix { get; set; }

    [Column("biz_seats")]
    public int? BizSeats { get; set; }

    [Column("econ_prefix")]
    public int? EconPrefix { get; set; }

    [Column("econ_seats")]
    public int? EconSeats { get; set; }

    [Column("world_prefix")]
    public int? WorldPrefix { get; set; }

    [Column("world_seats")]
    public int? WorldSeats { get; set; }

    [Column("royal_prefix")]
    public int? RoyalPrefix { get; set; }

    [Column("royal_seats")]
    public int? RoyalSeats { get; set; }

    [Column("cabin_crew_no")]
    public int? CabinCrewNo { get; set; }

    [Column("deck_crew_no")]
    public int? DeckCrewNo { get; set; }

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
