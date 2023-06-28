using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("pos_shift")]
public partial class PosShift
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("code")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("shift_no")]
    public int? ShiftNo { get; set; }

    [Column("from_time", TypeName = "datetime")]
    public DateTime? FromTime { get; set; }

    [Column("to_time", TypeName = "datetime")]
    public DateTime? ToTime { get; set; }

    [Column("creation_by", TypeName = "decimal(18, 0)")]
    public decimal? CreationBy { get; set; }

    [Column("creation_date", TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    [Column("chang_by", TypeName = "decimal(18, 0)")]
    public decimal? ChangBy { get; set; }

    [Column("chang_date", TypeName = "datetime")]
    public DateTime? ChangDate { get; set; }

    [Column("notes")]
    [StringLength(255)]
    [Unicode(false)]
    public string? Notes { get; set; }
}
