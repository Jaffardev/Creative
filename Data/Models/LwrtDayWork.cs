using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("lwrt_day_work")]
public partial class LwrtDayWork
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("code")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("task_id", TypeName = "decimal(18, 0)")]
    public decimal? TaskId { get; set; }

    [Column("calendar_d", TypeName = "decimal(18, 0)")]
    public decimal? CalendarD { get; set; }

    [Column("parent_id", TypeName = "decimal(18, 0)")]
    public decimal? ParentId { get; set; }

    [Column("name_1")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Name1 { get; set; }

    [Column("name_2")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Name2 { get; set; }

    [Column("ref_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? RefNo { get; set; }

    [Column("doc_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? DocNo { get; set; }

    [Column("active")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Active { get; set; }

    [Column("emp_resp_id", TypeName = "decimal(18, 0)")]
    public decimal? EmpRespId { get; set; }

    [Column("emp_id", TypeName = "decimal(18, 0)")]
    public decimal? EmpId { get; set; }

    [Column("case_id", TypeName = "decimal(18, 0)")]
    public decimal? CaseId { get; set; }

    [Column("trans_date", TypeName = "datetime")]
    public DateTime? TransDate { get; set; }

    [Column("priority", TypeName = "decimal(18, 0)")]
    public decimal? Priority { get; set; }

    [Column("task_statrt_date", TypeName = "datetime")]
    public DateTime? TaskStatrtDate { get; set; }

    [Column("task_statrt_time", TypeName = "datetime")]
    public DateTime? TaskStatrtTime { get; set; }

    [Column("task_end_date", TypeName = "datetime")]
    public DateTime? TaskEndDate { get; set; }

    [Column("task_end_time", TypeName = "datetime")]
    public DateTime? TaskEndTime { get; set; }

    [Column("reson_id", TypeName = "decimal(18, 0)")]
    public decimal? ResonId { get; set; }

    [Column("reson_description")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? ResonDescription { get; set; }

    [Column("evaluation", TypeName = "decimal(18, 0)")]
    public decimal? Evaluation { get; set; }

    [Column("point", TypeName = "decimal(18, 0)")]
    public decimal? Point { get; set; }

    [Column("status")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Status { get; set; }

    [Column("complete", TypeName = "decimal(18, 0)")]
    public decimal? Complete { get; set; }

    [Column("actual_work", TypeName = "datetime")]
    public DateTime? ActualWork { get; set; }

    [Column("reminder_date", TypeName = "datetime")]
    public DateTime? ReminderDate { get; set; }

    [Column("reminder_time", TypeName = "datetime")]
    public DateTime? ReminderTime { get; set; }

    [Column("task_description")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? TaskDescription { get; set; }

    [Column("hour_actual", TypeName = "decimal(18, 0)")]
    public decimal? HourActual { get; set; }

    [Column("hour_work", TypeName = "decimal(18, 0)")]
    public decimal? HourWork { get; set; }

    [Column("hour_overhead", TypeName = "decimal(18, 0)")]
    public decimal? HourOverhead { get; set; }

    [Column("hour_cost", TypeName = "decimal(18, 0)")]
    public decimal? HourCost { get; set; }

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

    [Column("procedure_id", TypeName = "decimal(18, 0)")]
    public decimal? ProcedureId { get; set; }

    [Column("hearing_id", TypeName = "decimal(18, 0)")]
    public decimal? HearingId { get; set; }

    [Column("come_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? ComeType { get; set; }
}
