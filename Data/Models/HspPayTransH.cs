using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("hsp_pay_trans_h")]
public partial class HspPayTransH
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("code")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("trans_status")]
    [StringLength(1)]
    [Unicode(false)]
    public string? TransStatus { get; set; }

    [Column("trans_date", TypeName = "datetime")]
    public DateTime? TransDate { get; set; }

    [Column("casher_id", TypeName = "decimal(18, 0)")]
    public decimal? CasherId { get; set; }

    [Column("visit_id", TypeName = "decimal(18, 0)")]
    public decimal? VisitId { get; set; }

    [Column("cust_cat_id", TypeName = "decimal(18, 0)")]
    public decimal? CustCatId { get; set; }

    [Column("customer_id", TypeName = "decimal(18, 0)")]
    public decimal? CustomerId { get; set; }

    [Column("posted")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Posted { get; set; }

    [Column("name_1")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Name1 { get; set; }

    [Column("name_2")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Name2 { get; set; }

    [Column("shift_no", TypeName = "decimal(18, 0)")]
    public decimal? ShiftNo { get; set; }

    [Column("trans_time", TypeName = "datetime")]
    public DateTime? TransTime { get; set; }

    [Column("discount_retio", TypeName = "decimal(18, 3)")]
    public decimal? DiscountRetio { get; set; }

    [Column("discount_amount", TypeName = "decimal(18, 3)")]
    public decimal? DiscountAmount { get; set; }

    [Column("manger_id", TypeName = "decimal(18, 0)")]
    public decimal? MangerId { get; set; }

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

    [Column("suspend_commend")]
    [StringLength(100)]
    [Unicode(false)]
    public string? SuspendCommend { get; set; }

    [Column("creation_by", TypeName = "decimal(18, 0)")]
    public decimal? CreationBy { get; set; }

    [Column("creation_date", TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    [Column("modify_by", TypeName = "decimal(18, 0)")]
    public decimal? ModifyBy { get; set; }

    [Column("modify_date", TypeName = "datetime")]
    public DateTime? ModifyDate { get; set; }

    [Column("notes")]
    [StringLength(255)]
    [Unicode(false)]
    public string? Notes { get; set; }

    [Column("patient_ratio", TypeName = "decimal(18, 3)")]
    public decimal? PatientRatio { get; set; }

    [Column("comp_ratio", TypeName = "decimal(18, 3)")]
    public decimal? CompRatio { get; set; }

    [Column("vip_comp_ratio", TypeName = "decimal(18, 3)")]
    public decimal? VipCompRatio { get; set; }

    [Column("vip_pat_ratio", TypeName = "decimal(18, 3)")]
    public decimal? VipPatRatio { get; set; }

    [Column("patient_discount", TypeName = "decimal(18, 3)")]
    public decimal? PatientDiscount { get; set; }

    [Column("comp_discount", TypeName = "decimal(18, 3)")]
    public decimal? CompDiscount { get; set; }

    [Column("vip_pat_discount", TypeName = "decimal(18, 3)")]
    public decimal? VipPatDiscount { get; set; }

    [Column("vip_com_discount", TypeName = "decimal(18, 3)")]
    public decimal? VipComDiscount { get; set; }

    [Column("patient_amount", TypeName = "decimal(18, 3)")]
    public decimal? PatientAmount { get; set; }

    [Column("company_amount", TypeName = "decimal(18, 3)")]
    public decimal? CompanyAmount { get; set; }

    [Column("vip_comp_amount", TypeName = "decimal(18, 3)")]
    public decimal? VipCompAmount { get; set; }

    [Column("vip_pat_amount", TypeName = "decimal(18, 3)")]
    public decimal? VipPatAmount { get; set; }

    [Column("ins_comp_id", TypeName = "decimal(18, 0)")]
    public decimal? InsCompId { get; set; }

    [Column("trasury_id", TypeName = "decimal(18, 0)")]
    public decimal? TrasuryId { get; set; }

    [Column("req_group_id", TypeName = "decimal(18, 0)")]
    public decimal? ReqGroupId { get; set; }

    [Column("price_list_id", TypeName = "decimal(18, 0)")]
    public decimal? PriceListId { get; set; }

    [Column("doctor_id", TypeName = "decimal(18, 0)")]
    public decimal? DoctorId { get; set; }
}
