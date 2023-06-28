using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("cst_om")]
public partial class CstOm
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("trans_date", TypeName = "datetime")]
    public DateTime? TransDate { get; set; }

    [Column("active")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Active { get; set; }

    [Column("item_amount_1", TypeName = "decimal(18, 3)")]
    public decimal? ItemAmount1 { get; set; }

    [Column("item_amount_2", TypeName = "decimal(18, 3)")]
    public decimal? ItemAmount2 { get; set; }

    [Column("item_amount_3", TypeName = "decimal(18, 3)")]
    public decimal? ItemAmount3 { get; set; }

    [Column("item_amount_4", TypeName = "decimal(18, 3)")]
    public decimal? ItemAmount4 { get; set; }

    [Column("item_amount_5", TypeName = "decimal(18, 3)")]
    public decimal? ItemAmount5 { get; set; }

    [Column("exp_amount_1", TypeName = "decimal(18, 3)")]
    public decimal? ExpAmount1 { get; set; }

    [Column("exp_amount_2", TypeName = "decimal(18, 3)")]
    public decimal? ExpAmount2 { get; set; }

    [Column("exp_amount_3", TypeName = "decimal(18, 3)")]
    public decimal? ExpAmount3 { get; set; }

    [Column("exp_amount_4", TypeName = "decimal(18, 3)")]
    public decimal? ExpAmount4 { get; set; }

    [Column("exp_amount_5", TypeName = "decimal(18, 3)")]
    public decimal? ExpAmount5 { get; set; }

    [Column("item_1")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Item1 { get; set; }

    [Column("from_1")]
    [StringLength(100)]
    [Unicode(false)]
    public string? From1 { get; set; }

    [Column("to_1")]
    [StringLength(100)]
    [Unicode(false)]
    public string? To1 { get; set; }

    [Column("item_2")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Item2 { get; set; }

    [Column("from_2")]
    [StringLength(100)]
    [Unicode(false)]
    public string? From2 { get; set; }

    [Column("to_2")]
    [StringLength(100)]
    [Unicode(false)]
    public string? To2 { get; set; }

    [Column("item_3")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Item3 { get; set; }

    [Column("from_3")]
    [StringLength(100)]
    [Unicode(false)]
    public string? From3 { get; set; }

    [Column("to_3")]
    [StringLength(100)]
    [Unicode(false)]
    public string? To3 { get; set; }

    [Column("item_4")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Item4 { get; set; }

    [Column("item_5")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Item5 { get; set; }

    [Column("from_4")]
    [StringLength(100)]
    [Unicode(false)]
    public string? From4 { get; set; }

    [Column("to_4")]
    [StringLength(100)]
    [Unicode(false)]
    public string? To4 { get; set; }

    [Column("from_5")]
    [StringLength(100)]
    [Unicode(false)]
    public string? From5 { get; set; }

    [Column("to_5")]
    [StringLength(100)]
    [Unicode(false)]
    public string? To5 { get; set; }

    [Column("exp_1")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Exp1 { get; set; }

    [Column("exp_from_1")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ExpFrom1 { get; set; }

    [Column("exp_to_1")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ExpTo1 { get; set; }

    [Column("exp_2")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Exp2 { get; set; }

    [Column("exp_from_2")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ExpFrom2 { get; set; }

    [Column("exp_to_2")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ExpTo2 { get; set; }

    [Column("exp_3")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Exp3 { get; set; }

    [Column("exp_from_3")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ExpFrom3 { get; set; }

    [Column("exp_to_3")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ExpTo3 { get; set; }

    [Column("exp_4")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Exp4 { get; set; }

    [Column("exp_from_4")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ExpFrom4 { get; set; }

    [Column("exp_to_4")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ExpTo4 { get; set; }

    [Column("exp_5")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Exp5 { get; set; }

    [Column("exp_from_5")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ExpFrom5 { get; set; }

    [Column("exp_to_5")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ExpTo5 { get; set; }

    [Column("from_date", TypeName = "datetime")]
    public DateTime? FromDate { get; set; }

    [Column("to_date", TypeName = "datetime")]
    public DateTime? ToDate { get; set; }

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
