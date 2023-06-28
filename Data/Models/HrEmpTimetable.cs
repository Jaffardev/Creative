using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("hr_emp_timetable")]
public partial class HrEmpTimetable
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

    [Column("issue_date", TypeName = "datetime")]
    public DateTime? IssueDate { get; set; }

    [Column("trans_year")]
    public int? TransYear { get; set; }

    [Column("trans_month")]
    public int? TransMonth { get; set; }

    [Column("job_id", TypeName = "decimal(18, 0)")]
    public decimal? JobId { get; set; }

    [Column("emp_group_id", TypeName = "decimal(18, 0)")]
    public decimal? EmpGroupId { get; set; }

    [Column("acdmc_qulfc_id", TypeName = "decimal(18, 0)")]
    public decimal? AcdmcQulfcId { get; set; }

    [Column("categry_id", TypeName = "decimal(18, 0)")]
    public decimal? CategryId { get; set; }

    [Column("emp_class_id", TypeName = "decimal(18, 0)")]
    public decimal? EmpClassId { get; set; }

    [Column("bank_id", TypeName = "decimal(18, 0)")]
    public decimal? BankId { get; set; }

    [Column("branch_id", TypeName = "decimal(18, 0)")]
    public decimal? BranchId { get; set; }

    [Column("deprt_id", TypeName = "decimal(18, 0)")]
    public decimal? DeprtId { get; set; }

    [Column("row_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? RowType { get; set; }

    [Column("deduct_day", TypeName = "decimal(18, 3)")]
    public decimal? DeductDay { get; set; }

    [Column("deduct_hour", TypeName = "decimal(18, 3)")]
    public decimal? DeductHour { get; set; }

    [Column("from_date", TypeName = "datetime")]
    public DateTime? FromDate { get; set; }

    [Column("to_date", TypeName = "datetime")]
    public DateTime? ToDate { get; set; }

    [Column("from_hour", TypeName = "datetime")]
    public DateTime? FromHour { get; set; }

    [Column("to_hour", TypeName = "datetime")]
    public DateTime? ToHour { get; set; }

    [Column("notes")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes { get; set; }

    [Column("active")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Active { get; set; }

    [Column("creation_by", TypeName = "decimal(18, 0)")]
    public decimal? CreationBy { get; set; }

    [Column("creation_date", TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    [Column("modify_by", TypeName = "decimal(18, 0)")]
    public decimal? ModifyBy { get; set; }

    [Column("modify_date", TypeName = "datetime")]
    public DateTime? ModifyDate { get; set; }

    [Column("atd_id", TypeName = "decimal(18, 0)")]
    public decimal? AtdId { get; set; }

    [Column("emp_id", TypeName = "decimal(18, 0)")]
    public decimal? EmpId { get; set; }

    [Column("unpaid_vacation", TypeName = "decimal(18, 3)")]
    public decimal? UnpaidVacation { get; set; }

    [Column("paied_vacation", TypeName = "decimal(18, 3)")]
    public decimal? PaiedVacation { get; set; }
}
