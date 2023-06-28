using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("curr_checklist_trans")]
public partial class CurrChecklistTran
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

    [Column("stu_id", TypeName = "decimal(18, 0)")]
    public decimal? StuId { get; set; }

    [Column("course_id", TypeName = "decimal(18, 0)")]
    public decimal? CourseId { get; set; }

    [Column("cat_id", TypeName = "decimal(18, 0)")]
    public decimal? CatId { get; set; }

    [Column("level_id", TypeName = "decimal(18, 0)")]
    public decimal? LevelId { get; set; }

    [Column("item_id", TypeName = "decimal(18, 0)")]
    public decimal? ItemId { get; set; }

    [Column("year_id", TypeName = "decimal(18, 0)")]
    public decimal? YearId { get; set; }

    [Column("selected")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Selected { get; set; }

    [Column("teaching_strategy")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? TeachingStrategy { get; set; }

    [Column("assessment_strategy")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? AssessmentStrategy { get; set; }

    [Column("start_date", TypeName = "datetime")]
    public DateTime? StartDate { get; set; }

    [Column("first_term", TypeName = "decimal(18, 0)")]
    public decimal? FirstTerm { get; set; }

    [Column("second_term", TypeName = "decimal(18, 0)")]
    public decimal? SecondTerm { get; set; }

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

    [Column("photo_path")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? PhotoPath { get; set; }

    [Column("selected_1")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Selected1 { get; set; }

    [Column("selected_2")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Selected2 { get; set; }

    [Column("comments_1")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Comments1 { get; set; }

    [Column("comments_2")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Comments2 { get; set; }

    [Column("instructional_1")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Instructional1 { get; set; }

    [Column("instructional_2")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Instructional2 { get; set; }

    [Column("environmental_1")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Environmental1 { get; set; }

    [Column("environmental_2")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Environmental2 { get; set; }

    [Column("assessment_1")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Assessment1 { get; set; }

    [Column("assessment_2")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Assessment2 { get; set; }

    [Column("sub_cat_id", TypeName = "decimal(18, 0)")]
    public decimal? SubCatId { get; set; }

    [Column("intial")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Intial { get; set; }

    [Column("objective_id", TypeName = "decimal(18, 0)")]
    public decimal? ObjectiveId { get; set; }

    [Column("teacher_id", TypeName = "decimal(18, 0)")]
    public decimal? TeacherId { get; set; }

    [Column("gread_id", TypeName = "decimal(18, 0)")]
    public decimal? GreadId { get; set; }

    [Column("class_id", TypeName = "decimal(18, 0)")]
    public decimal? ClassId { get; set; }

    [Column("stage_id", TypeName = "decimal(18, 0)")]
    public decimal? StageId { get; set; }

    [Column("branch_id", TypeName = "decimal(18, 0)")]
    public decimal? BranchId { get; set; }

    [Column("row_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? RowType { get; set; }

    [Column("posted")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Posted { get; set; }
}
