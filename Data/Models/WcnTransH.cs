using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("wcn_trans_h")]
public partial class WcnTransH
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

    [Column("name_1")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Name1 { get; set; }

    [Column("name_2")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Name2 { get; set; }

    [Column("con_type_id", TypeName = "decimal(18, 0)")]
    public decimal? ConTypeId { get; set; }

    [Column("currency_id", TypeName = "decimal(18, 0)")]
    public decimal? CurrencyId { get; set; }

    [Column("exchange_rate", TypeName = "decimal(18, 5)")]
    public decimal? ExchangeRate { get; set; }

    [Column("sign_by")]
    [StringLength(100)]
    [Unicode(false)]
    public string? SignBy { get; set; }

    [Column("cust_id", TypeName = "decimal(18, 0)")]
    public decimal? CustId { get; set; }

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

    [Column("description")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Description { get; set; }

    [Column("gover_id", TypeName = "decimal(18, 0)")]
    public decimal? GoverId { get; set; }

    [Column("area_id", TypeName = "decimal(18, 0)")]
    public decimal? AreaId { get; set; }

    [Column("part_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? PartNo { get; set; }

    [Column("streat")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Streat { get; set; }

    [Column("gada")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Gada { get; set; }

    [Column("bulding")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Bulding { get; set; }

    [Column("house")]
    [StringLength(50)]
    [Unicode(false)]
    public string? House { get; set; }

    [Column("address")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Address { get; set; }

    [Column("total_amount", TypeName = "decimal(18, 3)")]
    public decimal? TotalAmount { get; set; }

    [Column("disc_amount", TypeName = "decimal(18, 3)")]
    public decimal? DiscAmount { get; set; }

    [Column("cost_amount", TypeName = "decimal(18, 3)")]
    public decimal? CostAmount { get; set; }

    [Column("commission_rate", TypeName = "decimal(18, 4)")]
    public decimal? CommissionRate { get; set; }

    [Column("commission_amount", TypeName = "decimal(18, 4)")]
    public decimal? CommissionAmount { get; set; }

    [Column("pay_no")]
    public int? PayNo { get; set; }

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

    [Column("approve")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Approve { get; set; }

    [Column("posted")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Posted { get; set; }

    [Column("photo_path")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? PhotoPath { get; set; }

    [Column("task_h_id", TypeName = "decimal(18, 0)")]
    public decimal? TaskHId { get; set; }

    [Column("row_status")]
    [StringLength(1)]
    [Unicode(false)]
    public string? RowStatus { get; set; }

    [Column("observe_status")]
    [StringLength(1)]
    [Unicode(false)]
    public string? ObserveStatus { get; set; }

    [Column("observe")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Observe { get; set; }

    [Column("observe_start_date", TypeName = "datetime")]
    public DateTime? ObserveStartDate { get; set; }

    [Column("observe_end_date", TypeName = "datetime")]
    public DateTime? ObserveEndDate { get; set; }

    [Column("observe_position")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ObservePosition { get; set; }

    [Column("observe_amount", TypeName = "decimal(18, 3)")]
    public decimal? ObserveAmount { get; set; }

    [Column("sales_man_id", TypeName = "decimal(18, 0)")]
    public decimal? SalesManId { get; set; }

    [Column("acc_trans_id", TypeName = "decimal(18, 0)")]
    public decimal? AccTransId { get; set; }

    [Column("to_acc_id", TypeName = "decimal(18, 0)")]
    public decimal? ToAccId { get; set; }

    [Column("to_cost_id", TypeName = "decimal(18, 0)")]
    public decimal? ToCostId { get; set; }

    [Column("to_exp_id", TypeName = "decimal(18, 0)")]
    public decimal? ToExpId { get; set; }

    [Column("to_analysis_id", TypeName = "decimal(18, 0)")]
    public decimal? ToAnalysisId { get; set; }

    [Column("from_acc_id", TypeName = "decimal(18, 0)")]
    public decimal? FromAccId { get; set; }

    [Column("from_cost_id", TypeName = "decimal(18, 0)")]
    public decimal? FromCostId { get; set; }

    [Column("from_exp_id", TypeName = "decimal(18, 0)")]
    public decimal? FromExpId { get; set; }

    [Column("from_analysis_id", TypeName = "decimal(18, 0)")]
    public decimal? FromAnalysisId { get; set; }

    [Column("branch_id", TypeName = "decimal(18, 0)")]
    public decimal? BranchId { get; set; }

    [Column("sal_order_h_id", TypeName = "decimal(18, 0)")]
    public decimal? SalOrderHId { get; set; }
}
