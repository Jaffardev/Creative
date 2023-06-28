using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("hr_employ_vacation")]
public partial class HrEmployVacation
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("code")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("emp_id", TypeName = "decimal(18, 0)")]
    public decimal? EmpId { get; set; }

    [Column("period_h_id", TypeName = "decimal(18, 0)")]
    public decimal? PeriodHId { get; set; }

    [Column("branch_id", TypeName = "decimal(18, 0)")]
    public decimal? BranchId { get; set; }

    [Column("emp_group_id", TypeName = "decimal(18, 0)")]
    public decimal? EmpGroupId { get; set; }

    [Column("dept_id", TypeName = "decimal(18, 0)")]
    public decimal? DeptId { get; set; }

    [Column("emp_class_id", TypeName = "decimal(18, 0)")]
    public decimal? EmpClassId { get; set; }

    [Column("acc_trans_h_id", TypeName = "decimal(18, 0)")]
    public decimal? AccTransHId { get; set; }

    [Column("year_no", TypeName = "decimal(18, 0)")]
    public decimal? YearNo { get; set; }

    [Column("start_date", TypeName = "datetime")]
    public DateTime? StartDate { get; set; }

    [Column("end_date", TypeName = "datetime")]
    public DateTime? EndDate { get; set; }

    [Column("indemnity_day", TypeName = "decimal(18, 3)")]
    public decimal? IndemnityDay { get; set; }

    [Column("vacation_day", TypeName = "decimal(18, 3)")]
    public decimal? VacationDay { get; set; }

    [Column("balance_day", TypeName = "decimal(18, 3)")]
    public decimal? BalanceDay { get; set; }

    [Column("posted")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Posted { get; set; }

    [Column("item_amount", TypeName = "decimal(18, 3)")]
    public decimal? ItemAmount { get; set; }

    [Column("alwnc_amount", TypeName = "decimal(18, 3)")]
    public decimal? AlwncAmount { get; set; }

    [Column("deduct_amount", TypeName = "decimal(18, 3)")]
    public decimal? DeductAmount { get; set; }

    [Column("discount_amount", TypeName = "decimal(18, 3)")]
    public decimal? DiscountAmount { get; set; }

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
    public string Active { get; set; } = null!;

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

    [Column("month_no", TypeName = "decimal(18, 0)")]
    public decimal? MonthNo { get; set; }

    [Column("period_d_id", TypeName = "decimal(18, 0)")]
    public decimal? PeriodDId { get; set; }

    [Column("row_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? RowType { get; set; }

    [Column("vacation_day_act", TypeName = "decimal(18, 3)")]
    public decimal? VacationDayAct { get; set; }

    [Column("indemnity_day_act", TypeName = "decimal(18, 3)")]
    public decimal? IndemnityDayAct { get; set; }
}
