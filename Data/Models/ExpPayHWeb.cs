using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("exp_pay_h_web")]
public partial class ExpPayHWeb
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("code")]
    [StringLength(15)]
    [Unicode(false)]
    public string Code { get; set; } = null!;

    [Column("xxxpay_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? XxxpayType { get; set; }

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

    [Column("bank_name")]
    [StringLength(255)]
    [Unicode(false)]
    public string? BankName { get; set; }

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

    [Column("post")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Post { get; set; }

    [Column("acc_trans_id", TypeName = "decimal(18, 0)")]
    public decimal? AccTransId { get; set; }

    [Column("posted")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Posted { get; set; }

    [Column("year_id", TypeName = "decimal(18, 0)")]
    public decimal? YearId { get; set; }

    [Column("pay_by_id", TypeName = "decimal(18, 0)")]
    public decimal? PayById { get; set; }
}
