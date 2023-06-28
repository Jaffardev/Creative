using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("wts_trans")]
public partial class WtsTran
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("wfl_trans_h_id", TypeName = "decimal(18, 0)")]
    public decimal? WflTransHId { get; set; }

    [Column("wfl_trans_d_id", TypeName = "decimal(18, 0)")]
    public decimal? WflTransDId { get; set; }

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

    [Column("task_h_id", TypeName = "decimal(18, 0)")]
    public decimal? TaskHId { get; set; }

    [Column("task_d_id", TypeName = "decimal(18, 0)")]
    public decimal? TaskDId { get; set; }

    [Column("task_id", TypeName = "decimal(18, 0)")]
    public decimal? TaskId { get; set; }

    [Column("action_id", TypeName = "decimal(18, 0)")]
    public decimal? ActionId { get; set; }

    [Column("doc_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? DocNo { get; set; }

    [Column("doc_date", TypeName = "datetime")]
    public DateTime? DocDate { get; set; }

    [Column("cust_id", TypeName = "decimal(18, 0)")]
    public decimal? CustId { get; set; }

    [Column("con_id", TypeName = "decimal(18, 0)")]
    public decimal? ConId { get; set; }

    [Column("con_type_id", TypeName = "decimal(18, 0)")]
    public decimal? ConTypeId { get; set; }

    [Column("in_out")]
    [StringLength(1)]
    [Unicode(false)]
    public string? InOut { get; set; }

    [Column("work_approve")]
    [StringLength(1)]
    [Unicode(false)]
    public string? WorkApprove { get; set; }

    [Column("from_dept_id", TypeName = "decimal(18, 0)")]
    public decimal? FromDeptId { get; set; }

    [Column("from_team_id", TypeName = "decimal(18, 0)")]
    public decimal? FromTeamId { get; set; }

    [Column("from_emp_id", TypeName = "decimal(18, 0)")]
    public decimal? FromEmpId { get; set; }

    [Column("to_dept_id", TypeName = "decimal(18, 0)")]
    public decimal? ToDeptId { get; set; }

    [Column("to_team_id", TypeName = "decimal(18, 0)")]
    public decimal? ToTeamId { get; set; }

    [Column("to_emp_id", TypeName = "decimal(18, 0)")]
    public decimal? ToEmpId { get; set; }

    [Column("defualt_day", TypeName = "decimal(18, 0)")]
    public decimal? DefualtDay { get; set; }

    [Column("defualt_hour", TypeName = "decimal(18, 0)")]
    public decimal? DefualtHour { get; set; }

    [Column("defualt_mint", TypeName = "decimal(18, 0)")]
    public decimal? DefualtMint { get; set; }

    [Column("defualt_work_cost", TypeName = "decimal(18, 3)")]
    public decimal? DefualtWorkCost { get; set; }

    [Column("defualt_work_price", TypeName = "decimal(18, 3)")]
    public decimal? DefualtWorkPrice { get; set; }

    [Column("defualt_exp_cost", TypeName = "decimal(18, 0)")]
    public decimal? DefualtExpCost { get; set; }

    [Column("defualt_exp_price", TypeName = "decimal(18, 0)")]
    public decimal? DefualtExpPrice { get; set; }

    [Column("actual_day", TypeName = "decimal(18, 0)")]
    public decimal? ActualDay { get; set; }

    [Column("actual_hour", TypeName = "decimal(18, 0)")]
    public decimal? ActualHour { get; set; }

    [Column("actual_mint", TypeName = "decimal(18, 0)")]
    public decimal? ActualMint { get; set; }

    [Column("actual_work_cost", TypeName = "decimal(18, 3)")]
    public decimal? ActualWorkCost { get; set; }

    [Column("actual_work_price", TypeName = "decimal(18, 3)")]
    public decimal? ActualWorkPrice { get; set; }

    [Column("actual_exp_cost", TypeName = "decimal(18, 0)")]
    public decimal? ActualExpCost { get; set; }

    [Column("actual_exp_price", TypeName = "decimal(18, 0)")]
    public decimal? ActualExpPrice { get; set; }

    [Column("dept_id", TypeName = "decimal(18, 0)")]
    public decimal? DeptId { get; set; }

    [Column("team_id", TypeName = "decimal(18, 0)")]
    public decimal? TeamId { get; set; }

    [Column("emp_id", TypeName = "decimal(18, 0)")]
    public decimal? EmpId { get; set; }

    [Column("start_date", TypeName = "datetime")]
    public DateTime? StartDate { get; set; }

    [Column("end_date", TypeName = "datetime")]
    public DateTime? EndDate { get; set; }

    [Column("start_time", TypeName = "datetime")]
    public DateTime? StartTime { get; set; }

    [Column("end_time", TypeName = "datetime")]
    public DateTime? EndTime { get; set; }

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

    [Column("photo_path")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? PhotoPath { get; set; }
}
