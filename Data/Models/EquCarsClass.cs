using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("equ_cars_class")]
public partial class EquCarsClass
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

    [Column("income_acc_id", TypeName = "decimal(18, 0)")]
    public decimal? IncomeAccId { get; set; }

    [Column("income_cost_id", TypeName = "decimal(18, 0)")]
    public decimal? IncomeCostId { get; set; }

    [Column("income_exp_id", TypeName = "decimal(18, 0)")]
    public decimal? IncomeExpId { get; set; }

    [Column("income_analysis_id", TypeName = "decimal(18, 0)")]
    public decimal? IncomeAnalysisId { get; set; }

    [Column("expenses_acc_id", TypeName = "decimal(18, 0)")]
    public decimal? ExpensesAccId { get; set; }

    [Column("expenses_cost_id", TypeName = "decimal(18, 0)")]
    public decimal? ExpensesCostId { get; set; }

    [Column("expenses_exp_id", TypeName = "decimal(18, 0)")]
    public decimal? ExpensesExpId { get; set; }

    [Column("expenses_analysis_id", TypeName = "decimal(18, 0)")]
    public decimal? ExpensesAnalysisId { get; set; }

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
