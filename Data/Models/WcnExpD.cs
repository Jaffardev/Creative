using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("wcn_exp_d")]
public partial class WcnExpD
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

    [Column("con_id", TypeName = "decimal(18, 0)")]
    public decimal? ConId { get; set; }

    [Column("exp_item_id", TypeName = "decimal(18, 0)")]
    public decimal? ExpItemId { get; set; }

    [Column("trans_date", TypeName = "datetime")]
    public DateTime? TransDate { get; set; }

    [Column("doc_date", TypeName = "datetime")]
    public DateTime? DocDate { get; set; }

    [Column("doc_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? DocNo { get; set; }

    [Column("pay_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? PayType { get; set; }

    [Column("costed")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Costed { get; set; }

    [Column("amount", TypeName = "decimal(18, 3)")]
    public decimal? Amount { get; set; }

    [Column("descrption")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Descrption { get; set; }

    [Column("emp_id", TypeName = "decimal(18, 0)")]
    public decimal? EmpId { get; set; }

    [Column("pay_by")]
    [StringLength(100)]
    [Unicode(false)]
    public string? PayBy { get; set; }

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
