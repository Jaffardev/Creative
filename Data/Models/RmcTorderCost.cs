using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("rmc_torder_cost")]
public partial class RmcTorderCost
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("code")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("h_id", TypeName = "decimal(18, 0)")]
    public decimal? HId { get; set; }

    [Column("pay_h_id", TypeName = "decimal(18, 0)")]
    public decimal? PayHId { get; set; }

    [Column("order_pay")]
    [StringLength(1)]
    [Unicode(false)]
    public string? OrderPay { get; set; }

    [Column("exp_id", TypeName = "decimal(18, 0)")]
    public decimal? ExpId { get; set; }

    [Column("name_1")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Name1 { get; set; }

    [Column("name_2")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Name2 { get; set; }

    [Column("portfolio_id", TypeName = "decimal(18, 0)")]
    public decimal? PortfolioId { get; set; }

    [Column("real_id", TypeName = "decimal(18, 0)")]
    public decimal? RealId { get; set; }

    [Column("unit_id", TypeName = "decimal(18, 0)")]
    public decimal? UnitId { get; set; }

    [Column("rent_id", TypeName = "decimal(18, 0)")]
    public decimal? RentId { get; set; }

    [Column("con_id", TypeName = "decimal(18, 0)")]
    public decimal? ConId { get; set; }

    [Column("dept_id", TypeName = "decimal(18, 0)")]
    public decimal? DeptId { get; set; }

    [Column("team_id", TypeName = "decimal(18, 0)")]
    public decimal? TeamId { get; set; }

    [Column("emp_id", TypeName = "decimal(18, 0)")]
    public decimal? EmpId { get; set; }

    [Column("comp_id", TypeName = "decimal(18, 0)")]
    public decimal? CompId { get; set; }

    [Column("doc_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? DocNo { get; set; }

    [Column("doc_date", TypeName = "datetime")]
    public DateTime? DocDate { get; set; }

    [Column("invoice_no")]
    [StringLength(100)]
    [Unicode(false)]
    public string? InvoiceNo { get; set; }

    [Column("pur_amount", TypeName = "decimal(18, 3)")]
    public decimal? PurAmount { get; set; }

    [Column("pur_discount", TypeName = "decimal(18, 3)")]
    public decimal? PurDiscount { get; set; }

    [Column("sal_amount", TypeName = "decimal(18, 3)")]
    public decimal? SalAmount { get; set; }

    [Column("sal_discount", TypeName = "decimal(18, 3)")]
    public decimal? SalDiscount { get; set; }

    [Column("pay_amount", TypeName = "decimal(18, 3)")]
    public decimal? PayAmount { get; set; }

    [Column("posted")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Posted { get; set; }

    [Column("acc_trans_id", TypeName = "decimal(18, 0)")]
    public decimal? AccTransId { get; set; }

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
}
