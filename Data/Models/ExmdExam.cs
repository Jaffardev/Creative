using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("exmd_exam")]
public partial class ExmdExam
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

    [Column("parent_id", TypeName = "decimal(18, 0)")]
    public decimal? ParentId { get; set; }

    [Column("last_level")]
    [StringLength(1)]
    [Unicode(false)]
    public string? LastLevel { get; set; }

    [Column("level_no")]
    public int? LevelNo { get; set; }

    [Column("long_code")]
    [StringLength(255)]
    [Unicode(false)]
    public string? LongCode { get; set; }

    [Column("branch_id", TypeName = "decimal(18, 0)")]
    public decimal? BranchId { get; set; }

    [Column("stage_id", TypeName = "decimal(18, 0)")]
    public decimal? StageId { get; set; }

    [Column("grade_id", TypeName = "decimal(18, 0)")]
    public decimal? GradeId { get; set; }

    [Column("year_id", TypeName = "decimal(18, 0)")]
    public decimal? YearId { get; set; }

    [Column("term_id", TypeName = "decimal(18, 0)")]
    public decimal? TermId { get; set; }

    [Column("quarter_id", TypeName = "decimal(18, 0)")]
    public decimal? QuarterId { get; set; }

    [Column("course_id", TypeName = "decimal(18, 0)")]
    public decimal? CourseId { get; set; }

    [Column("skille_id", TypeName = "decimal(18, 0)")]
    public decimal? SkilleId { get; set; }

    [Column("item_id", TypeName = "decimal(18, 0)")]
    public decimal? ItemId { get; set; }

    [Column("cur_course_id", TypeName = "decimal(18, 0)")]
    public decimal? CurCourseId { get; set; }

    [Column("row_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? RowType { get; set; }

    [Column("item_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? ItemType { get; set; }

    [Column("exm_name_1")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ExmName1 { get; set; }

    [Column("exm_name_2")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ExmName2 { get; set; }

    [Column("min_degree", TypeName = "decimal(18, 3)")]
    public decimal? MinDegree { get; set; }

    [Column("default_degree", TypeName = "decimal(18, 3)")]
    public decimal? DefaultDegree { get; set; }

    [Column("max_degree", TypeName = "decimal(18, 3)")]
    public decimal? MaxDegree { get; set; }

    [Column("exam_ratio", TypeName = "decimal(18, 3)")]
    public decimal? ExamRatio { get; set; }

    [Column("open_date", TypeName = "datetime")]
    public DateTime? OpenDate { get; set; }

    [Column("exam_date", TypeName = "datetime")]
    public DateTime? ExamDate { get; set; }

    [Column("trans_date", TypeName = "datetime")]
    public DateTime? TransDate { get; set; }

    [Column("alow_degree")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowDegree { get; set; }

    [Column("approve")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Approve { get; set; }

    [Column("posted")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Posted { get; set; }

    [Column("printed")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Printed { get; set; }

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
