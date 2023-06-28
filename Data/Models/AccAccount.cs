using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("acc_account")]
public partial class AccAccount
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

    [Column("parent_id", TypeName = "decimal(18, 0)")]
    public decimal? ParentId { get; set; }

    [Column("last_level")]
    [StringLength(1)]
    [Unicode(false)]
    public string? LastLevel { get; set; }

    [Column("level_no")]
    public int? LevelNo { get; set; }

    [Column("long_code")]
    [StringLength(255)]
    [Unicode(false)]
    public string? LongCode { get; set; }

    [Column("acc_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AccType { get; set; }

    [Column("balance_sheet")]
    [StringLength(1)]
    [Unicode(false)]
    public string? BalanceSheet { get; set; }

    [Column("profit_loss")]
    [StringLength(1)]
    [Unicode(false)]
    public string? ProfitLoss { get; set; }

    [Column("activity")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Activity { get; set; }

    [Column("budget")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Budget { get; set; }

    [Column("control")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Control { get; set; }

    [Column("acc_voucher")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AccVoucher { get; set; }

    [Column("acc_issue")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AccIssue { get; set; }

    [Column("acc_recived")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AccRecived { get; set; }

    [Column("acc_inv")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AccInv { get; set; }

    [Column("acc_sal")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AccSal { get; set; }

    [Column("acc_pur")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AccPur { get; set; }

    [Column("acc_school")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AccSchool { get; set; }

    [Column("acc_real")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AccReal { get; set; }

    [Column("cost_center")]
    [StringLength(1)]
    [Unicode(false)]
    public string? CostCenter { get; set; }

    [Column("expenses")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Expenses { get; set; }

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

    [Column("acc_ledger")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AccLedger { get; set; }

    [Column("analysis")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Analysis { get; set; }

    [Column("acc_bank")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AccBank { get; set; }

    [Column("acc_issue_add")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AccIssueAdd { get; set; }

    [Column("acc_recived_add")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AccRecivedAdd { get; set; }

    [Column("cost_id_default", TypeName = "decimal(18, 0)")]
    public decimal? CostIdDefault { get; set; }

    [Column("exp_id_default", TypeName = "decimal(18, 0)")]
    public decimal? ExpIdDefault { get; set; }

    [Column("analysis_id_default", TypeName = "decimal(18, 0)")]
    public decimal? AnalysisIdDefault { get; set; }
}
