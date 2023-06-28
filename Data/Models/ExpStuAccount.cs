using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Keyless]
[Table("EXP_STU_ACCOUNTS")]
public partial class ExpStuAccount
{
    [Column("ID", TypeName = "numeric(18, 0)")]
    public decimal Id { get; set; }

    [Column("code")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("EXP_DISC_ID", TypeName = "numeric(18, 0)")]
    public decimal? ExpDiscId { get; set; }

    [Column("STUDENT_ID", TypeName = "numeric(18, 0)")]
    public decimal? StudentId { get; set; }

    [Column("RESP_ID", TypeName = "numeric(18, 0)")]
    public decimal? RespId { get; set; }

    [Column("BRANCH_ID", TypeName = "numeric(18, 0)")]
    public decimal? BranchId { get; set; }

    [Column("GREAD_ID", TypeName = "numeric(18, 0)")]
    public decimal? GreadId { get; set; }

    [Column("YEAR_ID", TypeName = "numeric(18, 0)")]
    public decimal? YearId { get; set; }

    [Column("AMOUNT_1", TypeName = "numeric(18, 3)")]
    public decimal? Amount1 { get; set; }

    [Column("AMOUNT_2", TypeName = "numeric(18, 3)")]
    public decimal? Amount2 { get; set; }

    [Column("AMOUNT_3", TypeName = "numeric(18, 3)")]
    public decimal? Amount3 { get; set; }

    [Column("AMOUNT_4", TypeName = "numeric(18, 3)")]
    public decimal? Amount4 { get; set; }

    [Column("DUE_DATE_1", TypeName = "datetime")]
    public DateTime? DueDate1 { get; set; }

    [Column("DUE_DATE_2", TypeName = "datetime")]
    public DateTime? DueDate2 { get; set; }

    [Column("DUE_DATE_3", TypeName = "datetime")]
    public DateTime? DueDate3 { get; set; }

    [Column("DUE_DATE_4", TypeName = "datetime")]
    public DateTime? DueDate4 { get; set; }

    [Column("ROW_TYPE")]
    [StringLength(1)]
    [Unicode(false)]
    public string? RowType { get; set; }

    [Column("post")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Post { get; set; }

    [Column("DESCRIPTION")]
    [StringLength(255)]
    [Unicode(false)]
    public string? Description { get; set; }

    [Column("NOTES")]
    [StringLength(255)]
    [Unicode(false)]
    public string? Notes { get; set; }

    [Column("CREATION_BY", TypeName = "numeric(18, 0)")]
    public decimal? CreationBy { get; set; }

    [Column("CREATION_DATE", TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    [Column("CHANG_BY", TypeName = "numeric(18, 0)")]
    public decimal? ChangBy { get; set; }

    [Column("CHANG_DATE", TypeName = "datetime")]
    public DateTime? ChangDate { get; set; }

    [Column("Date_year", TypeName = "datetime")]
    public DateTime? DateYear { get; set; }

    [Column("Expenses_item_id", TypeName = "numeric(18, 0)")]
    public decimal? ExpensesItemId { get; set; }

    [Column("check_list")]
    public int? CheckList { get; set; }

    [Column("posted")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Posted { get; set; }

    [Column("posted_trans_date", TypeName = "datetime")]
    public DateTime? PostedTransDate { get; set; }

    [Column("gl_trans_d_id", TypeName = "numeric(18, 0)")]
    public decimal? GlTransDId { get; set; }

    [Column("load_date", TypeName = "datetime")]
    public DateTime? LoadDate { get; set; }

    [Column("old_palance")]
    [StringLength(1)]
    [Unicode(false)]
    public string? OldPalance { get; set; }
}
