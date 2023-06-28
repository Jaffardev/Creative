using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("pos_invoice_h")]
public partial class PosInvoiceH
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("code")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("name_1")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Name1 { get; set; }

    [Column("name_2")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Name2 { get; set; }

    [Column("no_invoice", TypeName = "decimal(18, 0)")]
    public decimal? NoInvoice { get; set; }

    [Column("invoice_status")]
    [StringLength(1)]
    [Unicode(false)]
    public string? InvoiceStatus { get; set; }

    [Column("trans_date", TypeName = "datetime")]
    public DateTime? TransDate { get; set; }

    [Column("order_h_id", TypeName = "decimal(18, 0)")]
    public decimal? OrderHId { get; set; }

    [Column("casher_id", TypeName = "decimal(18, 0)")]
    public decimal? CasherId { get; set; }

    [Column("table_id", TypeName = "decimal(18, 0)")]
    public decimal? TableId { get; set; }

    [Column("branch_id", TypeName = "decimal(18, 0)")]
    public decimal? BranchId { get; set; }

    [Column("day_id", TypeName = "decimal(18, 0)")]
    public decimal? DayId { get; set; }

    [Column("cust_cat_id", TypeName = "decimal(18, 0)")]
    public decimal? CustCatId { get; set; }

    [Column("customer_id", TypeName = "decimal(18, 0)")]
    public decimal? CustomerId { get; set; }

    [Column("shift_id", TypeName = "decimal(18, 0)")]
    public decimal? ShiftId { get; set; }

    [Column("area_id", TypeName = "decimal(18, 0)")]
    public decimal? AreaId { get; set; }

    [Column("gov_id", TypeName = "decimal(18, 0)")]
    public decimal? GovId { get; set; }

    [Column("sales_man_id", TypeName = "decimal(18, 0)")]
    public decimal? SalesManId { get; set; }

    [Column("tax_ratio", TypeName = "decimal(18, 3)")]
    public decimal? TaxRatio { get; set; }

    [Column("tip_amount", TypeName = "decimal(18, 3)")]
    public decimal? TipAmount { get; set; }

    [Column("discount_reason")]
    [StringLength(100)]
    [Unicode(false)]
    public string? DiscountReason { get; set; }

    [Column("reason_id", TypeName = "decimal(18, 0)")]
    public decimal? ReasonId { get; set; }

    [Column("reason_description")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? ReasonDescription { get; set; }

    [Column("invoice_time", TypeName = "datetime")]
    public DateTime? InvoiceTime { get; set; }

    [Column("discount_retio", TypeName = "decimal(18, 3)")]
    public decimal? DiscountRetio { get; set; }

    [Column("discount_amount", TypeName = "decimal(18, 3)")]
    public decimal? DiscountAmount { get; set; }

    [Column("manger_id", TypeName = "decimal(18, 0)")]
    public decimal? MangerId { get; set; }

    [Column("service_ratio", TypeName = "decimal(18, 0)")]
    public decimal? ServiceRatio { get; set; }

    [Column("service_amount", TypeName = "decimal(18, 3)")]
    public decimal? ServiceAmount { get; set; }

    [Column("total_amount", TypeName = "decimal(18, 3)")]
    public decimal? TotalAmount { get; set; }

    [Column("pay_cash", TypeName = "decimal(18, 3)")]
    public decimal? PayCash { get; set; }

    [Column("pay_key", TypeName = "decimal(18, 3)")]
    public decimal? PayKey { get; set; }

    [Column("pay_visa", TypeName = "decimal(18, 3)")]
    public decimal? PayVisa { get; set; }

    [Column("pay_master", TypeName = "decimal(18, 3)")]
    public decimal? PayMaster { get; set; }

    [Column("pay_atm", TypeName = "decimal(18, 3)")]
    public decimal? PayAtm { get; set; }

    [Column("pay_other", TypeName = "decimal(18, 3)")]
    public decimal? PayOther { get; set; }

    [Column("total_pay", TypeName = "decimal(18, 3)")]
    public decimal? TotalPay { get; set; }

    [Column("suspend_command")]
    [StringLength(100)]
    [Unicode(false)]
    public string? SuspendCommand { get; set; }

    [Column("posted")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Posted { get; set; }

    [Column("active")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Active { get; set; }

    [Column("doc_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? DocNo { get; set; }

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
}
