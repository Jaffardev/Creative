using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("rprt_portfolio")]
[Index("Code", Name = "ix_rprt_portfolio", IsUnique = true)]
public partial class RprtPortfolio
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

    [Column("portfolio_type_id", TypeName = "decimal(18, 0)")]
    public decimal? PortfolioTypeId { get; set; }

    [Column("from_date", TypeName = "datetime")]
    public DateTime? FromDate { get; set; }

    [Column("to_date", TypeName = "datetime")]
    public DateTime? ToDate { get; set; }

    [Column("agent_sign")]
    [StringLength(100)]
    [Unicode(false)]
    public string? AgentSign { get; set; }

    [Column("agent_id_no")]
    [StringLength(15)]
    [Unicode(false)]
    public string? AgentIdNo { get; set; }

    [Column("authorization_no")]
    [StringLength(100)]
    [Unicode(false)]
    public string? AuthorizationNo { get; set; }

    [Column("authorization_date", TypeName = "datetime")]
    public DateTime? AuthorizationDate { get; set; }

    [Column("gald_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? GaldNo { get; set; }

    [Column("bank_id", TypeName = "decimal(18, 0)")]
    public decimal? BankId { get; set; }

    [Column("bank_branch_id", TypeName = "decimal(18, 0)")]
    public decimal? BankBranchId { get; set; }

    [Column("bank_acc_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? BankAccNo { get; set; }

    [Column("real_no", TypeName = "decimal(18, 0)")]
    public decimal? RealNo { get; set; }

    [Column("titel_a_1")]
    [StringLength(100)]
    [Unicode(false)]
    public string? TitelA1 { get; set; }

    [Column("titel_a_2")]
    [StringLength(100)]
    [Unicode(false)]
    public string? TitelA2 { get; set; }

    [Column("titel_a_3")]
    [StringLength(100)]
    [Unicode(false)]
    public string? TitelA3 { get; set; }

    [Column("titel_a_4")]
    [StringLength(100)]
    [Unicode(false)]
    public string? TitelA4 { get; set; }

    [Column("titel_a_5")]
    [StringLength(100)]
    [Unicode(false)]
    public string? TitelA5 { get; set; }

    [Column("titel_a_6")]
    [StringLength(100)]
    [Unicode(false)]
    public string? TitelA6 { get; set; }

    [Column("titel_e_1")]
    [StringLength(100)]
    [Unicode(false)]
    public string? TitelE1 { get; set; }

    [Column("titel_e_2")]
    [StringLength(100)]
    [Unicode(false)]
    public string? TitelE2 { get; set; }

    [Column("titel_e_3")]
    [StringLength(100)]
    [Unicode(false)]
    public string? TitelE3 { get; set; }

    [Column("titel_e_4")]
    [StringLength(100)]
    [Unicode(false)]
    public string? TitelE4 { get; set; }

    [Column("titel_e_5")]
    [StringLength(100)]
    [Unicode(false)]
    public string? TitelE5 { get; set; }

    [Column("titel_e_6")]
    [StringLength(100)]
    [Unicode(false)]
    public string? TitelE6 { get; set; }

    [Column("logo")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Logo { get; set; }

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

    [Column("acc_id", TypeName = "decimal(18, 0)")]
    public decimal? AccId { get; set; }

    [Column("cost_id", TypeName = "decimal(18, 0)")]
    public decimal? CostId { get; set; }

    [Column("exp_id", TypeName = "decimal(18, 0)")]
    public decimal? ExpId { get; set; }

    [Column("analysis_id", TypeName = "decimal(18, 0)")]
    public decimal? AnalysisId { get; set; }
}
