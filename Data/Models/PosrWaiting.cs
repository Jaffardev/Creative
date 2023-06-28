using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("posr_waiting")]
public partial class PosrWaiting
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

    [Column("day_name", TypeName = "datetime")]
    public DateTime? DayName { get; set; }

    [Column("cutomer_no", TypeName = "decimal(18, 0)")]
    public decimal? CutomerNo { get; set; }

    [Column("brach_id", TypeName = "decimal(18, 0)")]
    public decimal? BrachId { get; set; }

    [Column("take_date", TypeName = "decimal(18, 0)")]
    public decimal? TakeDate { get; set; }

    [Column("take_time", TypeName = "decimal(18, 0)")]
    public decimal? TakeTime { get; set; }

    [Column("enter_date", TypeName = "datetime")]
    public DateTime? EnterDate { get; set; }

    [Column("enter_time", TypeName = "datetime")]
    public DateTime? EnterTime { get; set; }

    [Column("active")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Active { get; set; }

    [Column("notes")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes { get; set; }

    [Column("photo_path")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? PhotoPath { get; set; }

    [Column("creation_by", TypeName = "decimal(18, 0)")]
    public decimal? CreationBy { get; set; }

    [Column("creation_date", TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    [Column("modify_by", TypeName = "decimal(18, 0)")]
    public decimal? ModifyBy { get; set; }

    [Column("modify_date", TypeName = "datetime")]
    public DateTime? ModifyDate { get; set; }
}
