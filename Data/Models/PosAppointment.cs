using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("pos_appointment")]
public partial class PosAppointment
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

    [Column("trans_date", TypeName = "datetime")]
    public DateTime? TransDate { get; set; }

    [Column("from_time", TypeName = "datetime")]
    public DateTime? FromTime { get; set; }

    [Column("to_time", TypeName = "datetime")]
    public DateTime? ToTime { get; set; }

    [Column("from_period_id", TypeName = "decimal(18, 0)")]
    public decimal? FromPeriodId { get; set; }

    [Column("to_period_id", TypeName = "decimal(18, 0)")]
    public decimal? ToPeriodId { get; set; }

    [Column("new_patient")]
    [StringLength(1)]
    [Unicode(false)]
    public string? NewPatient { get; set; }

    [Column("status")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Status { get; set; }

    [Column("need_confirm")]
    [StringLength(1)]
    [Unicode(false)]
    public string? NeedConfirm { get; set; }

    [Column("duration")]
    public int? Duration { get; set; }

    [Column("item_id", TypeName = "decimal(18, 0)")]
    public decimal? ItemId { get; set; }

    [Column("cust_id", TypeName = "decimal(18, 0)")]
    public decimal? CustId { get; set; }

    [Column("casher_id", TypeName = "decimal(18, 0)")]
    public decimal? CasherId { get; set; }

    [Column("trainder_id", TypeName = "decimal(18, 0)")]
    public decimal? TrainderId { get; set; }

    [Column("room_id", TypeName = "decimal(18, 0)")]
    public decimal? RoomId { get; set; }

    [Column("call_center", TypeName = "decimal(18, 0)")]
    public decimal? CallCenter { get; set; }

    [Column("amount", TypeName = "decimal(18, 3)")]
    public decimal? Amount { get; set; }

    [Column("discount", TypeName = "decimal(18, 3)")]
    public decimal? Discount { get; set; }

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
