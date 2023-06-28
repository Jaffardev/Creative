using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("clth_salary")]
public partial class ClthSalary
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

    [Column("trans_date", TypeName = "datetime")]
    public DateTime? TransDate { get; set; }

    [Column("trans_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? TransType { get; set; }

    [Column("emp_id", TypeName = "decimal(18, 0)")]
    public decimal? EmpId { get; set; }

    [Column("s_month", TypeName = "decimal(18, 0)")]
    public decimal? SMonth { get; set; }

    [Column("s_year", TypeName = "decimal(18, 0)")]
    public decimal? SYear { get; set; }

    [Column("salary", TypeName = "decimal(18, 4)")]
    public decimal? Salary { get; set; }

    [Column("allowen", TypeName = "decimal(18, 4)")]
    public decimal? Allowen { get; set; }

    [Column("other_salary", TypeName = "decimal(18, 4)")]
    public decimal? OtherSalary { get; set; }

    [Column("discount", TypeName = "decimal(18, 4)")]
    public decimal? Discount { get; set; }

    [Column("leave", TypeName = "decimal(18, 4)")]
    public decimal? Leave { get; set; }

    [Column("leave_day", TypeName = "decimal(18, 0)")]
    public decimal? LeaveDay { get; set; }

    [Column("amount", TypeName = "decimal(18, 4)")]
    public decimal? Amount { get; set; }

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
