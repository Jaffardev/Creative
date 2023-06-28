using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("rcon_trans_d")]
public partial class RconTransD
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("h_id", TypeName = "decimal(18, 0)")]
    public decimal? HId { get; set; }

    [Column("code")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("trans_year", TypeName = "decimal(18, 0)")]
    public decimal? TransYear { get; set; }

    [Column("trans_month", TypeName = "decimal(18, 0)")]
    public decimal? TransMonth { get; set; }

    [Column("from_date", TypeName = "smalldatetime")]
    public DateTime? FromDate { get; set; }

    [Column("to_date", TypeName = "smalldatetime")]
    public DateTime? ToDate { get; set; }

    [Column("amount", TypeName = "decimal(18, 3)")]
    public decimal? Amount { get; set; }

    [Column("insurance_amount", TypeName = "decimal(18, 3)")]
    public decimal? InsuranceAmount { get; set; }

    [Column("electrets_amount", TypeName = "decimal(18, 3)")]
    public decimal? ElectretsAmount { get; set; }

    [Column("service_amount", TypeName = "decimal(18, 3)")]
    public decimal? ServiceAmount { get; set; }

    [Column("case_amount", TypeName = "decimal(18, 3)")]
    public decimal? CaseAmount { get; set; }

    [Column("discount", TypeName = "decimal(18, 3)")]
    public decimal? Discount { get; set; }

    [Column("rpay_trans_h_id", TypeName = "decimal(18, 0)")]
    public decimal? RpayTransHId { get; set; }

    [Column("pay_amount", TypeName = "decimal(18, 3)")]
    public decimal? PayAmount { get; set; }

    [Column("bank_id", TypeName = "decimal(18, 0)")]
    public decimal? BankId { get; set; }

    [Column("cheque_bank_name")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ChequeBankName { get; set; }

    [Column("cheque_no")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ChequeNo { get; set; }

    [Column("cheque_date", TypeName = "datetime")]
    public DateTime? ChequeDate { get; set; }

    [Column("status")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Status { get; set; }

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

    [Column("posted")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Posted { get; set; }

    [Column("posted_pay")]
    [StringLength(1)]
    [Unicode(false)]
    public string? PostedPay { get; set; }

    [Column("acc_trans_id", TypeName = "decimal(18, 0)")]
    public decimal? AccTransId { get; set; }

    [Column("acc_trans_id_pay", TypeName = "decimal(18, 0)")]
    public decimal? AccTransIdPay { get; set; }

    [Column("doc_no")]
    [StringLength(15)]
    [Unicode(false)]
    public string? DocNo { get; set; }

    [Column("pay_type_id", TypeName = "decimal(18, 0)")]
    public decimal? PayTypeId { get; set; }

    [Column("doc_date", TypeName = "datetime")]
    public DateTime? DocDate { get; set; }
}
