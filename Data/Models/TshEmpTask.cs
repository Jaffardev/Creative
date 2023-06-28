using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("tsh_emp_task")]
public partial class TshEmpTask
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

    [Column("active")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Active { get; set; }

    [Column("sat_status")]
    [StringLength(1)]
    [Unicode(false)]
    public string? SatStatus { get; set; }

    [Column("sat_work_hour", TypeName = "decimal(18, 3)")]
    public decimal? SatWorkHour { get; set; }

    [Column("sun_status")]
    [StringLength(1)]
    [Unicode(false)]
    public string? SunStatus { get; set; }

    [Column("sun_work_hour", TypeName = "decimal(18, 3)")]
    public decimal? SunWorkHour { get; set; }

    [Column("mon_status")]
    [StringLength(1)]
    [Unicode(false)]
    public string? MonStatus { get; set; }

    [Column("mon_work_hour", TypeName = "decimal(18, 3)")]
    public decimal? MonWorkHour { get; set; }

    [Column("tue_status")]
    [StringLength(1)]
    [Unicode(false)]
    public string? TueStatus { get; set; }

    [Column("tue_work_hour", TypeName = "decimal(18, 3)")]
    public decimal? TueWorkHour { get; set; }

    [Column("wed_status")]
    [StringLength(1)]
    [Unicode(false)]
    public string? WedStatus { get; set; }

    [Column("wed_work_hour", TypeName = "decimal(18, 3)")]
    public decimal? WedWorkHour { get; set; }

    [Column("thu_status")]
    [StringLength(1)]
    [Unicode(false)]
    public string? ThuStatus { get; set; }

    [Column("thu_work_hour", TypeName = "decimal(18, 3)")]
    public decimal? ThuWorkHour { get; set; }

    [Column("fri_status")]
    [StringLength(1)]
    [Unicode(false)]
    public string? FriStatus { get; set; }

    [Column("fri_work_hour", TypeName = "decimal(18, 3)")]
    public decimal? FriWorkHour { get; set; }

    [Column("work_hour", TypeName = "decimal(18, 0)")]
    public decimal? WorkHour { get; set; }

    [Column("emp_id", TypeName = "decimal(18, 0)")]
    public decimal? EmpId { get; set; }

    [Column("week_id", TypeName = "decimal(18, 0)")]
    public decimal? WeekId { get; set; }

    [Column("task_id", TypeName = "decimal(18, 0)")]
    public decimal? TaskId { get; set; }

    [Column("hour_cost", TypeName = "decimal(18, 0)")]
    public decimal? HourCost { get; set; }

    [Column("hour_profit", TypeName = "decimal(18, 0)")]
    public decimal? HourProfit { get; set; }

    [Column("total_cost", TypeName = "decimal(18, 0)")]
    public decimal? TotalCost { get; set; }

    [Column("description")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Description { get; set; }

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
