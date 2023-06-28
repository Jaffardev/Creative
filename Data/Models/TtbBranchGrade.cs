using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("ttb_branch_grade")]
public partial class TtbBranchGrade
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("code")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("grade_id", TypeName = "decimal(18, 0)")]
    public decimal? GradeId { get; set; }

    [Column("branch_id", TypeName = "decimal(18, 0)")]
    public decimal? BranchId { get; set; }

    [Column("name_1")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Name1 { get; set; }

    [Column("name_2")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Name2 { get; set; }

    [Column("notes")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes { get; set; }

    [Column("active")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Active { get; set; }

    [Column("day_1", TypeName = "decimal(18, 0)")]
    public decimal? Day1 { get; set; }

    [Column("day_2", TypeName = "decimal(18, 0)")]
    public decimal? Day2 { get; set; }

    [Column("day_3", TypeName = "decimal(18, 0)")]
    public decimal? Day3 { get; set; }

    [Column("day_4", TypeName = "decimal(18, 0)")]
    public decimal? Day4 { get; set; }

    [Column("day_5", TypeName = "decimal(18, 0)")]
    public decimal? Day5 { get; set; }

    [Column("day_6", TypeName = "decimal(18, 0)")]
    public decimal? Day6 { get; set; }

    [Column("day_7", TypeName = "decimal(18, 0)")]
    public decimal? Day7 { get; set; }

    [Column("from_date", TypeName = "datetime")]
    public DateTime? FromDate { get; set; }

    [Column("to_date", TypeName = "datetime")]
    public DateTime? ToDate { get; set; }

    [Column("creation_by", TypeName = "decimal(18, 0)")]
    public decimal? CreationBy { get; set; }

    [Column("creation_date", TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    [Column("modify_by", TypeName = "decimal(18, 0)")]
    public decimal? ModifyBy { get; set; }

    [Column("modify_date", TypeName = "datetime")]
    public DateTime? ModifyDate { get; set; }
}
