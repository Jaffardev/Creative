using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("cur_course_unit")]
public partial class CurCourseUnit
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

    [Column("branch_id", TypeName = "decimal(18, 0)")]
    public decimal? BranchId { get; set; }

    [Column("course_id", TypeName = "decimal(18, 0)")]
    public decimal? CourseId { get; set; }

    [Column("stage_id", TypeName = "decimal(18, 0)")]
    public decimal? StageId { get; set; }

    [Column("gread_id", TypeName = "decimal(18, 0)")]
    public decimal? GreadId { get; set; }

    [Column("term_id", TypeName = "decimal(18, 0)")]
    public decimal? TermId { get; set; }

    [Column("active")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Active { get; set; }

    [Column("standards", TypeName = "text")]
    public string? Standards { get; set; }

    [Column("enduring", TypeName = "text")]
    public string? Enduring { get; set; }

    [Column("essential", TypeName = "text")]
    public string? Essential { get; set; }

    [Column("content", TypeName = "text")]
    public string? Content { get; set; }

    [Column("skills", TypeName = "text")]
    public string? Skills { get; set; }

    [Column("preformance", TypeName = "text")]
    public string? Preformance { get; set; }

    [Column("standardized", TypeName = "text")]
    public string? Standardized { get; set; }

    [Column("materials", TypeName = "text")]
    public string? Materials { get; set; }

    [Column("learning_activities", TypeName = "text")]
    public string? LearningActivities { get; set; }

    [Column("integration", TypeName = "text")]
    public string? Integration { get; set; }

    [Column("team_notes", TypeName = "text")]
    public string? TeamNotes { get; set; }

    [Column("notes", TypeName = "text")]
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
