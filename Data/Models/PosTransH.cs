using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("pos_trans_h")]
public partial class PosTransH
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("code")]
    [StringLength(15)]
    [Unicode(false)]
    public string Code { get; set; } = null!;

    [Column("trans_status")]
    [StringLength(1)]
    [Unicode(false)]
    public string? TransStatus { get; set; }

    [Column("trans_date", TypeName = "datetime")]
    public DateTime? TransDate { get; set; }

    [Column("casher_id", TypeName = "decimal(18, 0)")]
    public decimal? CasherId { get; set; }

    [Column("cust_cat", TypeName = "decimal(18, 0)")]
    public decimal? CustCat { get; set; }

    [Column("customer_id", TypeName = "decimal(18, 0)")]
    public decimal? CustomerId { get; set; }

    [Column("shift_no", TypeName = "decimal(18, 0)")]
    public decimal? ShiftNo { get; set; }

    [Column("trans_time", TypeName = "datetime")]
    public DateTime? TransTime { get; set; }

    [Column("discount_retio", TypeName = "decimal(18, 4)")]
    public decimal? DiscountRetio { get; set; }

    [Column("discount_amount", TypeName = "decimal(18, 4)")]
    public decimal? DiscountAmount { get; set; }

    [Column("manger_id", TypeName = "decimal(18, 0)")]
    public decimal? MangerId { get; set; }

    [Column("total_amount", TypeName = "decimal(18, 4)")]
    public decimal? TotalAmount { get; set; }

    [Column("pay_cash", TypeName = "decimal(18, 4)")]
    public decimal? PayCash { get; set; }

    [Column("pay_key", TypeName = "decimal(18, 4)")]
    public decimal? PayKey { get; set; }

    [Column("pay_visa", TypeName = "decimal(18, 4)")]
    public decimal? PayVisa { get; set; }

    [Column("pay_master", TypeName = "decimal(18, 4)")]
    public decimal? PayMaster { get; set; }

    [Column("pay_atm", TypeName = "decimal(18, 4)")]
    public decimal? PayAtm { get; set; }

    [Column("pay_other", TypeName = "decimal(18, 4)")]
    public decimal? PayOther { get; set; }

    [Column("total_pay", TypeName = "decimal(18, 4)")]
    public decimal? TotalPay { get; set; }

    [Column("suspend_commend")]
    [StringLength(100)]
    [Unicode(false)]
    public string? SuspendCommend { get; set; }

    [Column("creation_date", TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    [Column("chang_by", TypeName = "decimal(18, 0)")]
    public decimal? ChangBy { get; set; }

    [Column("chang_date", TypeName = "datetime")]
    public DateTime? ChangDate { get; set; }

    [Column("notes")]
    [StringLength(255)]
    [Unicode(false)]
    public string? Notes { get; set; }

    [Column("posted")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Posted { get; set; }

    [Column("service_by", TypeName = "decimal(18, 0)")]
    public decimal? ServiceBy { get; set; }

    [Column("issued")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Issued { get; set; }

    [Column("invoice_id", TypeName = "decimal(18, 0)")]
    public decimal? InvoiceId { get; set; }

    [Column("return_invoice_id", TypeName = "decimal(18, 0)")]
    public decimal? ReturnInvoiceId { get; set; }

    [Column("branch_id", TypeName = "decimal(18, 0)")]
    public decimal? BranchId { get; set; }

    [Column("bank_notes")]
    [StringLength(255)]
    [Unicode(false)]
    public string? BankNotes { get; set; }

    [Column("online_id", TypeName = "decimal(18, 0)")]
    public decimal? OnlineId { get; set; }

    [Column("delivery_status")]
    [StringLength(1)]
    [Unicode(false)]
    public string? DeliveryStatus { get; set; }
}
