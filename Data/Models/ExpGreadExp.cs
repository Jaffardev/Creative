using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("exp_gread_exp")]
public partial class ExpGreadExp
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("exp_id", TypeName = "decimal(18, 0)")]
    public decimal? ExpId { get; set; }

    [Column("branch_id", TypeName = "decimal(18, 0)")]
    public decimal? BranchId { get; set; }

    [Column("gread_id", TypeName = "decimal(18, 0)")]
    public decimal? GreadId { get; set; }

    [Column("year_id", TypeName = "decimal(18, 0)")]
    public decimal? YearId { get; set; }

    [Column("amount_1", TypeName = "decimal(18, 3)")]
    public decimal? Amount1 { get; set; }

    [Column("amount_2", TypeName = "decimal(18, 3)")]
    public decimal? Amount2 { get; set; }

    [Column("amount_3", TypeName = "decimal(18, 3)")]
    public decimal? Amount3 { get; set; }

    [Column("amount_4", TypeName = "decimal(18, 3)")]
    public decimal? Amount4 { get; set; }

    [Column("due_date_1", TypeName = "datetime")]
    public DateTime? DueDate1 { get; set; }

    [Column("due_date_2", TypeName = "datetime")]
    public DateTime? DueDate2 { get; set; }

    [Column("due_date_3", TypeName = "datetime")]
    public DateTime? DueDate3 { get; set; }

    [Column("due_date_4", TypeName = "datetime")]
    public DateTime? DueDate4 { get; set; }

    [Column("approve")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Approve { get; set; }

    [Column("posted")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Posted { get; set; }

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
