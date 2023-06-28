using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("crg_trans")]
public partial class CrgTran
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

    [Column("stage_id", TypeName = "decimal(18, 0)")]
    public decimal? StageId { get; set; }

    [Column("cnt_car_id", TypeName = "decimal(18, 0)")]
    public decimal? CntCarId { get; set; }

    [Column("border_id", TypeName = "decimal(18, 0)")]
    public decimal? BorderId { get; set; }

    [Column("shipment_id", TypeName = "decimal(18, 0)")]
    public decimal? ShipmentId { get; set; }

    [Column("cnt_emp_id", TypeName = "decimal(18, 0)")]
    public decimal? CntEmpId { get; set; }

    [Column("enter_date", TypeName = "datetime")]
    public DateTime? EnterDate { get; set; }

    [Column("transload_date", TypeName = "datetime")]
    public DateTime? TransloadDate { get; set; }

    [Column("declar_date", TypeName = "datetime")]
    public DateTime? DeclarDate { get; set; }

    [Column("exit_date", TypeName = "datetime")]
    public DateTime? ExitDate { get; set; }

    [Column("work_day_no", TypeName = "decimal(18, 3)")]
    public decimal? WorkDayNo { get; set; }

    [Column("delay_day_no", TypeName = "decimal(18, 3)")]
    public decimal? DelayDayNo { get; set; }

    [Column("day_cost", TypeName = "decimal(18, 3)")]
    public decimal? DayCost { get; set; }

    [Column("late_day_cost", TypeName = "decimal(18, 3)")]
    public decimal? LateDayCost { get; set; }

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

    [Column("photo_path")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? PhotoPath { get; set; }
}
