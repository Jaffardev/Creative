using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("wcn_trans_inst")]
public partial class WcnTransInst
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("h_id", TypeName = "decimal(18, 0)")]
    public decimal? HId { get; set; }

    [Column("task_id", TypeName = "decimal(18, 0)")]
    public decimal? TaskId { get; set; }

    [Column("retio", TypeName = "decimal(18, 3)")]
    public decimal? Retio { get; set; }

    [Column("amount", TypeName = "decimal(18, 3)")]
    public decimal? Amount { get; set; }

    [Column("inst_amount", TypeName = "decimal(18, 3)")]
    public decimal? InstAmount { get; set; }

    [Column("disc_amount", TypeName = "decimal(18, 3)")]
    public decimal? DiscAmount { get; set; }

    [Column("install_type")]
    [StringLength(100)]
    [Unicode(false)]
    public string? InstallType { get; set; }

    [Column("install_desc")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? InstallDesc { get; set; }

    [Column("finshed")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Finshed { get; set; }

    [Column("payed")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Payed { get; set; }

    [Column("req_date", TypeName = "datetime")]
    public DateTime? ReqDate { get; set; }

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
}
