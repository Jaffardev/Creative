using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("tbl_mid_data")]
public partial class TblMidDatum
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("code")]
    [StringLength(15)]
    [Unicode(false)]
    public string Code { get; set; } = null!;

    [Column("pay_date", TypeName = "datetime")]
    public DateTime? PayDate { get; set; }

    [Column("fees_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? FeesType { get; set; }

    [Column("treasury_id", TypeName = "decimal(18, 0)")]
    public decimal? TreasuryId { get; set; }

    [Column("trans_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? TransType { get; set; }

    [Column("responsibile_id", TypeName = "decimal(18, 0)")]
    public decimal? ResponsibileId { get; set; }

    [Column("pay_types_id", TypeName = "decimal(18, 0)")]
    public decimal? PayTypesId { get; set; }

    [Column("doc_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? DocNo { get; set; }

    [Column("student_id", TypeName = "decimal(18, 0)")]
    public decimal? StudentId { get; set; }

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

    [Column("posted")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Posted { get; set; }

    [Column("exp_pay_id", TypeName = "decimal(18, 0)")]
    public decimal? ExpPayId { get; set; }

    [Column("year_id")]
    public int? YearId { get; set; }
}
