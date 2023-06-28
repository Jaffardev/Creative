using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("hre_trans_d")]
public partial class HreTransD
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("h_id", TypeName = "decimal(18, 0)")]
    public decimal? HId { get; set; }

    [Column("evaluation_d_id", TypeName = "decimal(18, 0)")]
    public decimal? EvaluationDId { get; set; }

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

    [Column("evaluate_text")]
    [StringLength(200)]
    [Unicode(false)]
    public string? EvaluateText { get; set; }

    [Column("chose_no_1")]
    [StringLength(1)]
    [Unicode(false)]
    public string? ChoseNo1 { get; set; }

    [Column("chose_no_2")]
    [StringLength(1)]
    [Unicode(false)]
    public string? ChoseNo2 { get; set; }

    [Column("chose_no_3")]
    [StringLength(1)]
    [Unicode(false)]
    public string? ChoseNo3 { get; set; }

    [Column("chose_no_4")]
    [StringLength(1)]
    [Unicode(false)]
    public string? ChoseNo4 { get; set; }

    [Column("chose_no_5")]
    [StringLength(1)]
    [Unicode(false)]
    public string? ChoseNo5 { get; set; }
}
