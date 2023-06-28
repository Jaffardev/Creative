﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("ciep_trans_notes")]
public partial class CiepTransNote
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("code")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("stu_id", TypeName = "decimal(18, 0)")]
    public decimal? StuId { get; set; }

    [Column("year_id", TypeName = "decimal(18, 0)")]
    public decimal? YearId { get; set; }

    [Column("term_id", TypeName = "decimal(18, 0)")]
    public decimal? TermId { get; set; }

    [Column("branch_id", TypeName = "decimal(18, 0)")]
    public decimal? BranchId { get; set; }

    [Column("stage_id", TypeName = "decimal(18, 0)")]
    public decimal? StageId { get; set; }

    [Column("gread_id", TypeName = "decimal(18, 0)")]
    public decimal? GreadId { get; set; }

    [Column("class_id", TypeName = "decimal(18, 0)")]
    public decimal? ClassId { get; set; }

    [Column("teacher_id", TypeName = "decimal(18, 0)")]
    public decimal? TeacherId { get; set; }

    [Column("course_id", TypeName = "decimal(18, 0)")]
    public decimal? CourseId { get; set; }

    [Column("cat_id", TypeName = "decimal(18, 0)")]
    public decimal? CatId { get; set; }

    [Column("sub_cat_id", TypeName = "decimal(18, 0)")]
    public decimal? SubCatId { get; set; }

    [Column("item_id", TypeName = "decimal(18, 0)")]
    public decimal? ItemId { get; set; }

    [Column("skille_id", TypeName = "decimal(18, 0)")]
    public decimal? SkilleId { get; set; }

    [Column("long_term")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? LongTerm { get; set; }

    [Column("short_term")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? ShortTerm { get; set; }

    [Column("gc_rep_1")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? GcRep1 { get; set; }

    [Column("gc_rep_2")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? GcRep2 { get; set; }

    [Column("photo_path")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? PhotoPath { get; set; }

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

    [Column("alow_gc_rep_1")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowGcRep1 { get; set; }

    [Column("posted_1")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Posted1 { get; set; }

    [Column("approve_1")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Approve1 { get; set; }

    [Column("alow_gc_rep_2")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowGcRep2 { get; set; }

    [Column("posted_2")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Posted2 { get; set; }
}
