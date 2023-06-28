using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("pad_tpay_h")]
public partial class PadTpayH
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("code")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("pay_date", TypeName = "datetime")]
    public DateTime? PayDate { get; set; }

    [Column("fees_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? FeesType { get; set; }

    [Column("treasury_id", TypeName = "decimal(18, 0)")]
    public decimal? TreasuryId { get; set; }

    [Column("school_id", TypeName = "decimal(18, 0)")]
    public decimal? SchoolId { get; set; }

    [Column("bank_branch_id", TypeName = "decimal(18, 0)")]
    public decimal? BankBranchId { get; set; }

    [Column("iban_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? IbanNo { get; set; }

    [Column("year_id", TypeName = "decimal(18, 0)")]
    public decimal? YearId { get; set; }

    [Column("trans_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? TransType { get; set; }

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

    [Column("bank_name")]
    [StringLength(255)]
    [Unicode(false)]
    public string? BankName { get; set; }

    [Column("doc_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? DocNo { get; set; }

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

    [Column("f_discount_1", TypeName = "decimal(18, 3)")]
    public decimal? FDiscount1 { get; set; }

    [Column("f_discount_2", TypeName = "decimal(18, 3)")]
    public decimal? FDiscount2 { get; set; }

    [Column("f_discount_3", TypeName = "decimal(18, 3)")]
    public decimal? FDiscount3 { get; set; }

    [Column("f_discount_4", TypeName = "decimal(18, 3)")]
    public decimal? FDiscount4 { get; set; }

    [Column("bank_id", TypeName = "decimal(18, 0)")]
    public decimal? BankId { get; set; }

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
}
