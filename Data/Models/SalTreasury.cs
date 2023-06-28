using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("sal_treasury")]
public partial class SalTreasury
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

    [Column("active")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Active { get; set; }

    [Column("emp_id", TypeName = "decimal(18, 0)")]
    public decimal? EmpId { get; set; }

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

    [Column("creation_by", TypeName = "decimal(18, 0)")]
    public decimal? CreationBy { get; set; }

    [Column("creation_date", TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    [Column("modify_by", TypeName = "decimal(18, 0)")]
    public decimal? ModifyBy { get; set; }

    [Column("modify_date", TypeName = "datetime")]
    public DateTime? ModifyDate { get; set; }

    [Column("photo_path")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? PhotoPath { get; set; }

    [Column("journal_id", TypeName = "decimal(18, 0)")]
    public decimal? JournalId { get; set; }

    [Column("acc_cash", TypeName = "decimal(18, 0)")]
    public decimal? AccCash { get; set; }

    [Column("acc_key", TypeName = "decimal(18, 0)")]
    public decimal? AccKey { get; set; }

    [Column("acc_visa", TypeName = "decimal(18, 0)")]
    public decimal? AccVisa { get; set; }

    [Column("acc_master", TypeName = "decimal(18, 0)")]
    public decimal? AccMaster { get; set; }

    [Column("acc_atm", TypeName = "decimal(18, 0)")]
    public decimal? AccAtm { get; set; }

    [Column("acc_other", TypeName = "decimal(18, 0)")]
    public decimal? AccOther { get; set; }

    [Column("acc_Commission", TypeName = "decimal(18, 0)")]
    public decimal? AccCommission { get; set; }

    [Column("acc_key_Commission", TypeName = "decimal(18, 5)")]
    public decimal? AccKeyCommission { get; set; }

    [Column("acc_visa_Commission", TypeName = "decimal(18, 5)")]
    public decimal? AccVisaCommission { get; set; }

    [Column("acc_master_Commission", TypeName = "decimal(18, 5)")]
    public decimal? AccMasterCommission { get; set; }

    [Column("acc_atm_Commission", TypeName = "decimal(18, 5)")]
    public decimal? AccAtmCommission { get; set; }

    [Column("acc_other_Commission", TypeName = "decimal(18, 5)")]
    public decimal? AccOtherCommission { get; set; }

    [Column("acc_Commission_db", TypeName = "decimal(18, 0)")]
    public decimal? AccCommissionDb { get; set; }

    [Column("acc_Commission_cr", TypeName = "decimal(18, 0)")]
    public decimal? AccCommissionCr { get; set; }
}
