using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("inv_class")]
public partial class InvClass
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

    [Column("acc_inv_id", TypeName = "decimal(18, 0)")]
    public decimal? AccInvId { get; set; }

    [Column("acc_pur_id", TypeName = "decimal(18, 0)")]
    public decimal? AccPurId { get; set; }

    [Column("acc_sal_id", TypeName = "decimal(18, 0)")]
    public decimal? AccSalId { get; set; }

    [Column("acc_sal_cost_id", TypeName = "decimal(18, 0)")]
    public decimal? AccSalCostId { get; set; }

    [Column("cost_id", TypeName = "decimal(18, 0)")]
    public decimal? CostId { get; set; }

    [Column("exp_id", TypeName = "decimal(18, 0)")]
    public decimal? ExpId { get; set; }

    [Column("cost_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? CostType { get; set; }

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

    [Column("acc_sfc_id", TypeName = "decimal(18, 0)")]
    public decimal? AccSfcId { get; set; }

    [Column("acc_sfc_cost_id", TypeName = "decimal(18, 0)")]
    public decimal? AccSfcCostId { get; set; }

    [Column("analysis_id", TypeName = "decimal(18, 0)")]
    public decimal? AnalysisId { get; set; }

    [Column("discount_acc_id", TypeName = "decimal(18, 0)")]
    public decimal? DiscountAccId { get; set; }

    [Column("under_tax")]
    [StringLength(1)]
    [Unicode(false)]
    public string? UnderTax { get; set; }

    [Column("accept_exemption")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AcceptExemption { get; set; }

    [Column("tax_value", TypeName = "decimal(18, 4)")]
    public decimal? TaxValue { get; set; }
}
