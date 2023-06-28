using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Keyless]
[Table("rcon_trans_unit_d")]
public partial class RconTransUnitD
{
    [Column("id", TypeName = "numeric(18, 0)")]
    public decimal Id { get; set; }

    [Column("h_id", TypeName = "numeric(18, 0)")]
    public decimal? HId { get; set; }

    [Column("code")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("trans_year", TypeName = "numeric(18, 0)")]
    public decimal? TransYear { get; set; }

    [Column("trans_month", TypeName = "numeric(18, 0)")]
    public decimal? TransMonth { get; set; }

    [Column("from_date", TypeName = "smalldatetime")]
    public DateTime? FromDate { get; set; }

    [Column("to_date", TypeName = "smalldatetime")]
    public DateTime? ToDate { get; set; }

    [Column("amount", TypeName = "numeric(18, 3)")]
    public decimal? Amount { get; set; }

    [Column("insurance_amount", TypeName = "numeric(18, 3)")]
    public decimal? InsuranceAmount { get; set; }

    [Column("electrets_amount", TypeName = "numeric(18, 3)")]
    public decimal? ElectretsAmount { get; set; }

    [Column("service_amount", TypeName = "numeric(18, 3)")]
    public decimal? ServiceAmount { get; set; }

    [Column("case_amount", TypeName = "numeric(18, 3)")]
    public decimal? CaseAmount { get; set; }

    [Column("discount", TypeName = "numeric(18, 3)")]
    public decimal? Discount { get; set; }

    [Column("rpay_trans_h_id", TypeName = "numeric(18, 0)")]
    public decimal? RpayTransHId { get; set; }

    [Column("pay_amount", TypeName = "numeric(18, 3)")]
    public decimal? PayAmount { get; set; }

    [Column("bank_id", TypeName = "numeric(18, 0)")]
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

    [Column("creation_by", TypeName = "numeric(18, 0)")]
    public decimal? CreationBy { get; set; }

    [Column("creation_date", TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    [Column("modify_by", TypeName = "numeric(18, 0)")]
    public decimal? ModifyBy { get; set; }

    [Column("modify_date", TypeName = "datetime")]
    public DateTime? ModifyDate { get; set; }

    [Column("unit_id", TypeName = "numeric(18, 0)")]
    public decimal? UnitId { get; set; }

    [Column("h_notes")]
    [StringLength(500)]
    [Unicode(false)]
    public string? HNotes { get; set; }

    [Column("rpay_code")]
    [StringLength(20)]
    [Unicode(false)]
    public string? RpayCode { get; set; }

    [Column("rpay_trans_date", TypeName = "datetime")]
    public DateTime? RpayTransDate { get; set; }

    [Column("rpay_treasury_id", TypeName = "numeric(18, 0)")]
    public decimal? RpayTreasuryId { get; set; }

    [Column("rpay_pay_type_id", TypeName = "numeric(18, 0)")]
    public decimal? RpayPayTypeId { get; set; }

    [Column("rpay_doc_no")]
    [StringLength(20)]
    [Unicode(false)]
    public string? RpayDocNo { get; set; }

    [Column("rpay_doc_date", TypeName = "datetime")]
    public DateTime? RpayDocDate { get; set; }

    [Column("rpay_bank_acc_id", TypeName = "numeric(18, 0)")]
    public decimal? RpayBankAccId { get; set; }
}
