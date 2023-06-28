using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("hapt_doctor")]
public partial class HaptDoctor
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("code")]
    [StringLength(100)]
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
    [StringLength(100)]
    [Unicode(false)]
    public string? Tel1 { get; set; }

    [Column("tel_2")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Tel2 { get; set; }

    [Column("specialist")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Specialist { get; set; }

    [Column("email")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Email { get; set; }

    [Column("saturday")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Saturday { get; set; }

    [Column("sat_no", TypeName = "decimal(18, 0)")]
    public decimal? SatNo { get; set; }

    [Column("sunday")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Sunday { get; set; }

    [Column("sun_no", TypeName = "decimal(18, 0)")]
    public decimal? SunNo { get; set; }

    [Column("monday")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Monday { get; set; }

    [Column("mon_no", TypeName = "decimal(18, 0)")]
    public decimal? MonNo { get; set; }

    [Column("tuesday")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Tuesday { get; set; }

    [Column("tues_no", TypeName = "decimal(18, 0)")]
    public decimal? TuesNo { get; set; }

    [Column("wednesday")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Wednesday { get; set; }

    [Column("wed_no", TypeName = "decimal(18, 0)")]
    public decimal? WedNo { get; set; }

    [Column("thursday")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Thursday { get; set; }

    [Column("thur_no", TypeName = "decimal(18, 0)")]
    public decimal? ThurNo { get; set; }

    [Column("friday")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Friday { get; set; }

    [Column("fri_no", TypeName = "decimal(18, 0)")]
    public decimal? FriNo { get; set; }

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
