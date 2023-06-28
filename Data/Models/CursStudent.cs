﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("curs_student")]
public partial class CursStudent
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

    [Column("level_id", TypeName = "decimal(18, 0)")]
    public decimal? LevelId { get; set; }

    [Column("class_id", TypeName = "decimal(18, 0)")]
    public decimal? ClassId { get; set; }

    [Column("doc_no")]
    [StringLength(20)]
    [Unicode(false)]
    public string? DocNo { get; set; }

    [Column("birth_date", TypeName = "datetime")]
    public DateTime? BirthDate { get; set; }

    [Column("curs_handicap_id", TypeName = "decimal(18, 3)")]
    public decimal? CursHandicapId { get; set; }

    [Column("handicap_desc")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? HandicapDesc { get; set; }

    [Column("teacher_id", TypeName = "decimal(18, 0)")]
    public decimal? TeacherId { get; set; }

    [Column("assestant_teache_id", TypeName = "decimal(18, 0)")]
    public decimal? AssestantTeacheId { get; set; }

    [Column("join_date", TypeName = "datetime")]
    public DateTime? JoinDate { get; set; }

    [Column("plan_start_date", TypeName = "datetime")]
    public DateTime? PlanStartDate { get; set; }

    [Column("program_id", TypeName = "decimal(18, 0)")]
    public decimal? ProgramId { get; set; }

    [Column("strength_point")]
    [StringLength(5000)]
    [Unicode(false)]
    public string? StrengthPoint { get; set; }

    [Column("weaknees_point")]
    [StringLength(5000)]
    [Unicode(false)]
    public string? WeakneesPoint { get; set; }

    [Column("photo_path")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? PhotoPath { get; set; }

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
