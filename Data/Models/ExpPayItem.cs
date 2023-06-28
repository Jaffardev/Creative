using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Keyless]
[Table("exp_pay_item")]
public partial class ExpPayItem
{
    [Column("id", TypeName = "numeric(18, 0)")]
    public decimal Id { get; set; }

    [Column("h_id", TypeName = "numeric(18, 0)")]
    public decimal? HId { get; set; }

    [Column("d_id", TypeName = "numeric(18, 0)")]
    public decimal? DId { get; set; }

    [Column("student_id", TypeName = "numeric(18, 0)")]
    public decimal? StudentId { get; set; }

    [Column("exp_item_id", TypeName = "numeric(18, 0)")]
    public decimal? ExpItemId { get; set; }

    [Column("exp_amount", TypeName = "numeric(18, 3)")]
    public decimal? ExpAmount { get; set; }

    [Column("discount", TypeName = "numeric(18, 3)")]
    public decimal? Discount { get; set; }

    [Column("pay_amount", TypeName = "numeric(18, 3)")]
    public decimal? PayAmount { get; set; }

    [Column("amount", TypeName = "numeric(18, 3)")]
    public decimal? Amount { get; set; }

    [Column("notes")]
    [StringLength(255)]
    [Unicode(false)]
    public string? Notes { get; set; }

    [Column("creation_by", TypeName = "numeric(18, 0)")]
    public decimal? CreationBy { get; set; }

    [Column("creation_date", TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    [Column("chang_by", TypeName = "numeric(18, 0)")]
    public decimal? ChangBy { get; set; }

    [Column("chang_date", TypeName = "datetime")]
    public DateTime? ChangDate { get; set; }

    [Column("next_grade", TypeName = "numeric(18, 0)")]
    public decimal? NextGrade { get; set; }

    [Column("next_year", TypeName = "numeric(18, 0)")]
    public decimal? NextYear { get; set; }

    [Column("gl_tran_d_id", TypeName = "numeric(18, 0)")]
    public decimal? GlTranDId { get; set; }
}
