using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("pad_tpay_d")]
public partial class PadTpayD
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("h_id", TypeName = "decimal(18, 0)")]
    public decimal? HId { get; set; }

    [Column("responsibile_id", TypeName = "decimal(18, 0)")]
    public decimal? ResponsibileId { get; set; }

    [Column("student_id", TypeName = "decimal(18, 0)")]
    public decimal? StudentId { get; set; }

    [Column("gread_id", TypeName = "decimal(18, 0)")]
    public decimal? GreadId { get; set; }

    [Column("school_id", TypeName = "decimal(18, 0)")]
    public decimal? SchoolId { get; set; }

    [Column("year_id", TypeName = "decimal(18, 0)")]
    public decimal? YearId { get; set; }

    [Column("join_date", TypeName = "datetime")]
    public DateTime? JoinDate { get; set; }

    [Column("reg_date", TypeName = "datetime")]
    public DateTime? RegDate { get; set; }

    [Column("day_no", TypeName = "decimal(18, 0)")]
    public decimal? DayNo { get; set; }

    [Column("exp_amount", TypeName = "decimal(18, 3)")]
    public decimal? ExpAmount { get; set; }

    [Column("disc_amount", TypeName = "decimal(18, 3)")]
    public decimal? DiscAmount { get; set; }

    [Column("paied_amount", TypeName = "decimal(18, 3)")]
    public decimal? PaiedAmount { get; set; }

    [Column("f_amount", TypeName = "decimal(18, 3)")]
    public decimal? FAmount { get; set; }

    [Column("f_amount_1", TypeName = "decimal(18, 3)")]
    public decimal? FAmount1 { get; set; }

    [Column("f_amount_2", TypeName = "decimal(18, 3)")]
    public decimal? FAmount2 { get; set; }

    [Column("f_amount_3", TypeName = "decimal(18, 3)")]
    public decimal? FAmount3 { get; set; }

    [Column("f_amount_4", TypeName = "decimal(18, 3)")]
    public decimal? FAmount4 { get; set; }

    [Column("due_date_1", TypeName = "datetime")]
    public DateTime? DueDate1 { get; set; }

    [Column("due_date_2", TypeName = "datetime")]
    public DateTime? DueDate2 { get; set; }

    [Column("due_date_3", TypeName = "datetime")]
    public DateTime? DueDate3 { get; set; }

    [Column("due_date_4", TypeName = "datetime")]
    public DateTime? DueDate4 { get; set; }

    [Column("f_amount_pay_1", TypeName = "decimal(18, 3)")]
    public decimal? FAmountPay1 { get; set; }

    [Column("f_amount_pay_2", TypeName = "decimal(18, 3)")]
    public decimal? FAmountPay2 { get; set; }

    [Column("f_amount_pay_3", TypeName = "decimal(18, 3)")]
    public decimal? FAmountPay3 { get; set; }

    [Column("f_amount_pay_4", TypeName = "decimal(18, 3)")]
    public decimal? FAmountPay4 { get; set; }

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

    [Column("active")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Active { get; set; }

    [Column("notes")]
    [StringLength(255)]
    [Unicode(false)]
    public string? Notes { get; set; }

    [Column("description")]
    [StringLength(255)]
    [Unicode(false)]
    public string? Description { get; set; }

    [Column("creation_by", TypeName = "decimal(18, 0)")]
    public decimal? CreationBy { get; set; }

    [Column("creation_date", TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    [Column("modify_by", TypeName = "decimal(18, 0)")]
    public decimal? ModifyBy { get; set; }

    [Column("modify_date", TypeName = "datetime")]
    public DateTime? ModifyDate { get; set; }

    [Column("f_amount_5", TypeName = "decimal(18, 3)")]
    public decimal? FAmount5 { get; set; }

    [Column("f_amount_pay_5", TypeName = "decimal(18, 3)")]
    public decimal? FAmountPay5 { get; set; }

    [Column("f_discount_1", TypeName = "decimal(18, 3)")]
    public decimal? FDiscount1 { get; set; }

    [Column("f_discount_2", TypeName = "decimal(18, 3)")]
    public decimal? FDiscount2 { get; set; }

    [Column("f_discount_3", TypeName = "decimal(18, 3)")]
    public decimal? FDiscount3 { get; set; }

    [Column("f_discount_4", TypeName = "decimal(18, 3)")]
    public decimal? FDiscount4 { get; set; }

    [Column("ratio_1", TypeName = "decimal(18, 3)")]
    public decimal? Ratio1 { get; set; }

    [Column("ratio_2", TypeName = "decimal(18, 3)")]
    public decimal? Ratio2 { get; set; }

    [Column("ratio_3", TypeName = "decimal(18, 3)")]
    public decimal? Ratio3 { get; set; }

    [Column("ratio_4", TypeName = "decimal(18, 3)")]
    public decimal? Ratio4 { get; set; }

    [Column("f_discount_5", TypeName = "decimal(18, 3)")]
    public decimal? FDiscount5 { get; set; }

    [Column("ratio_5", TypeName = "decimal(18, 3)")]
    public decimal? Ratio5 { get; set; }
}
