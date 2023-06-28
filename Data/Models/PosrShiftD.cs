using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("posr_shift_d")]
public partial class PosrShiftD
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("code")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("shift_id", TypeName = "decimal(18, 0)")]
    public decimal? ShiftId { get; set; }

    [Column("branch_id", TypeName = "decimal(18, 0)")]
    public decimal? BranchId { get; set; }

    [Column("cashier_id", TypeName = "decimal(18, 0)")]
    public decimal? CashierId { get; set; }

    [Column("sec_admin_id", TypeName = "decimal(18, 0)")]
    public decimal? SecAdminId { get; set; }

    [Column("sec_mang_id", TypeName = "decimal(18, 0)")]
    public decimal? SecMangId { get; set; }

    [Column("sec_super_id", TypeName = "decimal(18, 0)")]
    public decimal? SecSuperId { get; set; }

    [Column("sec_open_by_id", TypeName = "decimal(18, 0)")]
    public decimal? SecOpenById { get; set; }

    [Column("sec_close_by_id", TypeName = "decimal(18, 0)")]
    public decimal? SecCloseById { get; set; }

    [Column("from_date", TypeName = "datetime")]
    public DateTime? FromDate { get; set; }

    [Column("from_time", TypeName = "datetime")]
    public DateTime? FromTime { get; set; }

    [Column("to_date", TypeName = "datetime")]
    public DateTime? ToDate { get; set; }

    [Column("to_time", TypeName = "datetime")]
    public DateTime? ToTime { get; set; }

    [Column("shift_no", TypeName = "decimal(10, 0)")]
    public decimal? ShiftNo { get; set; }

    [Column("status")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Status { get; set; }

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
