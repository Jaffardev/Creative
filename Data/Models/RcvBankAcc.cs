using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("rcv_bank_acc")]
public partial class RcvBankAcc
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("code")]
    [StringLength(20)]
    [Unicode(false)]
    public string Code { get; set; } = null!;

    [Column("name_1")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Name1 { get; set; }

    [Column("name_2")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Name2 { get; set; }

    [Column("branch_id", TypeName = "decimal(18, 0)")]
    public decimal? BranchId { get; set; }

    [Column("acc_no")]
    [StringLength(20)]
    [Unicode(false)]
    public string? AccNo { get; set; }

    [Column("acc_manager")]
    [StringLength(100)]
    [Unicode(false)]
    public string? AccManager { get; set; }

    [Column("tel_1")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Tel1 { get; set; }

    [Column("tel_2")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Tel2 { get; set; }

    [Column("fax")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Fax { get; set; }

    [Column("email")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Email { get; set; }

    [Column("min_balance", TypeName = "decimal(18, 4)")]
    public decimal? MinBalance { get; set; }

    [Column("credit_limed", TypeName = "decimal(18, 4)")]
    public decimal? CreditLimed { get; set; }

    [Column("currency_id", TypeName = "decimal(18, 0)")]
    public decimal? CurrencyId { get; set; }

    [Column("agent_name_1")]
    [StringLength(100)]
    [Unicode(false)]
    public string? AgentName1 { get; set; }

    [Column("agent_name_2")]
    [StringLength(100)]
    [Unicode(false)]
    public string? AgentName2 { get; set; }

    [Column("agent_name_3")]
    [StringLength(100)]
    [Unicode(false)]
    public string? AgentName3 { get; set; }

    [Column("agent_name_4")]
    [StringLength(100)]
    [Unicode(false)]
    public string? AgentName4 { get; set; }

    [Column("photo_1")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Photo1 { get; set; }

    [Column("photo_2")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Photo2 { get; set; }

    [Column("photo_3")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Photo3 { get; set; }

    [Column("acc_id", TypeName = "decimal(18, 0)")]
    public decimal? AccId { get; set; }

    [Column("cost_id", TypeName = "decimal(18, 0)")]
    public decimal? CostId { get; set; }

    [Column("exp_id", TypeName = "decimal(18, 0)")]
    public decimal? ExpId { get; set; }

    [Column("analysis_id", TypeName = "decimal(18, 0)")]
    public decimal? AnalysisId { get; set; }

    [Column("notes")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes { get; set; }

    [Column("active")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Active { get; set; }

    [Column("creation_by", TypeName = "decimal(18, 0)")]
    public decimal? CreationBy { get; set; }

    [Column("creation_date", TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    [Column("modify_by", TypeName = "decimal(18, 0)")]
    public decimal? ModifyBy { get; set; }

    [Column("modify_date", TypeName = "datetime")]
    public DateTime? ModifyDate { get; set; }
}
