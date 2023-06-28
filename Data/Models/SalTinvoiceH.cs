using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("sal_tinvoice_h")]
public partial class SalTinvoiceH
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("code")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("trans_date", TypeName = "datetime")]
    public DateTime? TransDate { get; set; }

    [Column("order_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? OrderType { get; set; }

    [Column("invoice_id", TypeName = "decimal(18, 0)")]
    public decimal? InvoiceId { get; set; }

    [Column("quotation_id", TypeName = "decimal(18, 0)")]
    public decimal? QuotationId { get; set; }

    [Column("cust_id", TypeName = "decimal(18, 0)")]
    public decimal? CustId { get; set; }

    [Column("branch_id", TypeName = "decimal(18, 0)")]
    public decimal? BranchId { get; set; }

    [Column("responser_id", TypeName = "decimal(18, 0)")]
    public decimal? ResponserId { get; set; }

    [Column("price_list_id", TypeName = "decimal(18, 0)")]
    public decimal? PriceListId { get; set; }

    [Column("more_whs")]
    [StringLength(1)]
    [Unicode(false)]
    public string? MoreWhs { get; set; }

    [Column("whs_id", TypeName = "decimal(18, 0)")]
    public decimal? WhsId { get; set; }

    [Column("from_date", TypeName = "datetime")]
    public DateTime? FromDate { get; set; }

    [Column("to_date", TypeName = "datetime")]
    public DateTime? ToDate { get; set; }

    [Column("discount", TypeName = "decimal(18, 4)")]
    public decimal? Discount { get; set; }

    [Column("terms_1")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Terms1 { get; set; }

    [Column("terms_2")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Terms2 { get; set; }

    [Column("terms_3")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Terms3 { get; set; }

    [Column("terms_4")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Terms4 { get; set; }

    [Column("terms_5")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Terms5 { get; set; }

    [Column("status")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Status { get; set; }

    [Column("posted")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Posted { get; set; }

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

    [Column("currency_id", TypeName = "decimal(18, 0)")]
    public decimal? CurrencyId { get; set; }

    [Column("exchange_rate", TypeName = "decimal(18, 5)")]
    public decimal? ExchangeRate { get; set; }

    [Column("amount_main", TypeName = "decimal(18, 4)")]
    public decimal? AmountMain { get; set; }

    [Column("Commission_rate", TypeName = "decimal(18, 4)")]
    public decimal? CommissionRate { get; set; }

    [Column("Commission_amount", TypeName = "decimal(18, 4)")]
    public decimal? CommissionAmount { get; set; }

    [Column("rec_isu")]
    [StringLength(1)]
    [Unicode(false)]
    public string? RecIsu { get; set; }

    [Column("acc_trans_id", TypeName = "decimal(18, 0)")]
    public decimal? AccTransId { get; set; }

    [Column("sal_torder_h_id", TypeName = "decimal(18, 0)")]
    public decimal? SalTorderHId { get; set; }

    [Column("discount_rate", TypeName = "decimal(18, 5)")]
    public decimal? DiscountRate { get; set; }

    [Column("pay_type_id", TypeName = "decimal(18, 0)")]
    public decimal? PayTypeId { get; set; }

    [Column("pay_amount", TypeName = "decimal(18, 3)")]
    public decimal? PayAmount { get; set; }

    [Column("pay_date", TypeName = "datetime")]
    public DateTime? PayDate { get; set; }

    [Column("pay_due_date", TypeName = "datetime")]
    public DateTime? PayDueDate { get; set; }

    [Column("pay_status")]
    [StringLength(1)]
    [Unicode(false)]
    public string? PayStatus { get; set; }

    [Column("term_date_1", TypeName = "datetime")]
    public DateTime? TermDate1 { get; set; }

    [Column("term_date_2", TypeName = "datetime")]
    public DateTime? TermDate2 { get; set; }

    [Column("term_date_3", TypeName = "datetime")]
    public DateTime? TermDate3 { get; set; }

    [Column("term_date_4", TypeName = "datetime")]
    public DateTime? TermDate4 { get; set; }

    [Column("term_date_5", TypeName = "datetime")]
    public DateTime? TermDate5 { get; set; }

    [Column("term_6")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Term6 { get; set; }

    [Column("term_7")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Term7 { get; set; }

    [Column("term_8")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Term8 { get; set; }

    [Column("term_9")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Term9 { get; set; }

    [Column("term_10")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Term10 { get; set; }

    [Column("cost_amount", TypeName = "decimal(18, 3)")]
    public decimal? CostAmount { get; set; }

    [Column("responser_ext_id", TypeName = "decimal(18, 0)")]
    public decimal? ResponserExtId { get; set; }

    [Column("Commission_rate_ext", TypeName = "decimal(18, 4)")]
    public decimal? CommissionRateExt { get; set; }

    [Column("Commission_amount_ext", TypeName = "decimal(18, 4)")]
    public decimal? CommissionAmountExt { get; set; }

    [Column("pay_cash", TypeName = "decimal(18, 5)")]
    public decimal? PayCash { get; set; }

    [Column("pay_key", TypeName = "decimal(18, 5)")]
    public decimal? PayKey { get; set; }

    [Column("pay_visa", TypeName = "decimal(18, 5)")]
    public decimal? PayVisa { get; set; }

    [Column("pay_master", TypeName = "decimal(18, 5)")]
    public decimal? PayMaster { get; set; }

    [Column("pay_atm", TypeName = "decimal(18, 5)")]
    public decimal? PayAtm { get; set; }

    [Column("pay_other", TypeName = "decimal(18, 5)")]
    public decimal? PayOther { get; set; }

    [Column("treasury_id", TypeName = "decimal(18, 0)")]
    public decimal? TreasuryId { get; set; }

    [Column("doc_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? DocNo { get; set; }

    [Column("row_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? RowType { get; set; }

    [InverseProperty("SalInvoice")]
    public virtual ICollection<EquTcontractD> EquTcontractDs { get; set; } = new List<EquTcontractD>();
}
