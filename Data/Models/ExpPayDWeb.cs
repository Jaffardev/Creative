using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("exp_pay_d_web")]
public partial class ExpPayDWeb
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("h_id", TypeName = "decimal(18, 0)")]
    public decimal? HId { get; set; }

    [Column("student_id", TypeName = "decimal(18, 0)")]
    public decimal? StudentId { get; set; }

    [Column("exp_amount", TypeName = "decimal(18, 3)")]
    public decimal? ExpAmount { get; set; }

    [Column("disc_amount", TypeName = "decimal(18, 3)")]
    public decimal? DiscAmount { get; set; }

    [Column("paied_amount", TypeName = "decimal(18, 3)")]
    public decimal? PaiedAmount { get; set; }

    [Column("amount", TypeName = "decimal(18, 3)")]
    public decimal? Amount { get; set; }

    [Column("notes")]
    [StringLength(255)]
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

    [Column("exp_disc_id", TypeName = "decimal(18, 0)")]
    public decimal? ExpDiscId { get; set; }

    [Column("responsibile_id", TypeName = "decimal(18, 0)")]
    public decimal? ResponsibileId { get; set; }

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

    [Column("row_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? RowType { get; set; }

    [Column("approve")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Approve { get; set; }

    [Column("posted")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Posted { get; set; }

    [Column("description")]
    [StringLength(255)]
    [Unicode(false)]
    public string? Description { get; set; }

    [Column("amount_pay_1", TypeName = "decimal(18, 4)")]
    public decimal? AmountPay1 { get; set; }

    [Column("amount_pay_2", TypeName = "decimal(18, 4)")]
    public decimal? AmountPay2 { get; set; }

    [Column("amount_pay_3", TypeName = "decimal(18, 4)")]
    public decimal? AmountPay3 { get; set; }

    [Column("amount_pay_4", TypeName = "decimal(18, 4)")]
    public decimal? AmountPay4 { get; set; }

    [Column("amount_pay_5", TypeName = "decimal(18, 4)")]
    public decimal? AmountPay5 { get; set; }

    [Column("amount_pay_6", TypeName = "decimal(18, 4)")]
    public decimal? AmountPay6 { get; set; }

    [Column("amount_pay_7", TypeName = "decimal(18, 4)")]
    public decimal? AmountPay7 { get; set; }

    [Column("amount_pay_8", TypeName = "decimal(18, 4)")]
    public decimal? AmountPay8 { get; set; }

    [Column("amount_pay_9", TypeName = "decimal(18, 4)")]
    public decimal? AmountPay9 { get; set; }

    [Column("post_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? PostType { get; set; }

    [Column("post")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Post { get; set; }

    [Column("acc_trans_id", TypeName = "decimal(18, 0)")]
    public decimal? AccTransId { get; set; }

    [Column("tbl_mid_id", TypeName = "decimal(18, 0)")]
    public decimal? TblMidId { get; set; }

    [Column("amount_test", TypeName = "decimal(18, 0)")]
    public decimal? AmountTest { get; set; }

    [Column("exp_pay_id", TypeName = "decimal(18, 0)")]
    public decimal? ExpPayId { get; set; }
}
