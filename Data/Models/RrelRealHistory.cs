using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("rrel_real_history")]
public partial class RrelRealHistory
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

    [Column("real_id", TypeName = "decimal(18, 0)")]
    public decimal? RealId { get; set; }

    [Column("trans_date", TypeName = "datetime")]
    public DateTime? TransDate { get; set; }

    [Column("doc_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? DocNo { get; set; }

    [Column("doc_date", TypeName = "datetime")]
    public DateTime? DocDate { get; set; }

    [Column("evaluation_date", TypeName = "datetime")]
    public DateTime? EvaluationDate { get; set; }

    [Column("evaluation_by")]
    [StringLength(100)]
    [Unicode(false)]
    public string? EvaluationBy { get; set; }

    [Column("max_amount", TypeName = "decimal(18, 3)")]
    public decimal? MaxAmount { get; set; }

    [Column("commission_amount", TypeName = "decimal(18, 3)")]
    public decimal? CommissionAmount { get; set; }

    [Column("expenses", TypeName = "decimal(18, 3)")]
    public decimal? Expenses { get; set; }

    [Column("evaluation_amount", TypeName = "decimal(18, 3)")]
    public decimal? EvaluationAmount { get; set; }

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
