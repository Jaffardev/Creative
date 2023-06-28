using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("posr_shift")]
public partial class PosrShift
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

    [Column("sec_admin_id", TypeName = "decimal(18, 0)")]
    public decimal? SecAdminId { get; set; }

    [Column("sec_mang_id", TypeName = "decimal(18, 0)")]
    public decimal? SecMangId { get; set; }

    [Column("sec_super_id", TypeName = "decimal(18, 0)")]
    public decimal? SecSuperId { get; set; }

    [Column("from_time", TypeName = "datetime")]
    public DateTime? FromTime { get; set; }

    [Column("to_time", TypeName = "datetime")]
    public DateTime? ToTime { get; set; }

    [Column("shift_no", TypeName = "decimal(10, 0)")]
    public decimal? ShiftNo { get; set; }

    [Column("from_time_1", TypeName = "datetime")]
    public DateTime? FromTime1 { get; set; }

    [Column("to_time_1", TypeName = "datetime")]
    public DateTime? ToTime1 { get; set; }

    [Column("from_time_2", TypeName = "datetime")]
    public DateTime? FromTime2 { get; set; }

    [Column("to_time_2", TypeName = "datetime")]
    public DateTime? ToTime2 { get; set; }

    [Column("from_time_3", TypeName = "datetime")]
    public DateTime? FromTime3 { get; set; }

    [Column("to_time_3", TypeName = "datetime")]
    public DateTime? ToTime3 { get; set; }

    [Column("from_time_4", TypeName = "datetime")]
    public DateTime? FromTime4 { get; set; }

    [Column("to_time_4", TypeName = "datetime")]
    public DateTime? ToTime4 { get; set; }

    [Column("from_time_5", TypeName = "datetime")]
    public DateTime? FromTime5 { get; set; }

    [Column("to_time_5", TypeName = "datetime")]
    public DateTime? ToTime5 { get; set; }

    [Column("from_time_6", TypeName = "datetime")]
    public DateTime? FromTime6 { get; set; }

    [Column("to_time_6", TypeName = "datetime")]
    public DateTime? ToTime6 { get; set; }

    [Column("from_time_7", TypeName = "datetime")]
    public DateTime? FromTime7 { get; set; }

    [Column("to_time_7", TypeName = "datetime")]
    public DateTime? ToTime7 { get; set; }

    [Column("active")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Active { get; set; }

    [Column("photo_path")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? PhotoPath { get; set; }

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

    [Column("branch_id", TypeName = "decimal(18, 0)")]
    public decimal? BranchId { get; set; }
}
