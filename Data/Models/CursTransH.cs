using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("curs_trans_h")]
public partial class CursTransH
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

    [Column("exam_id", TypeName = "decimal(18, 0)")]
    public decimal? ExamId { get; set; }

    [Column("course_id", TypeName = "decimal(18, 0)")]
    public decimal? CourseId { get; set; }

    [Column("level_id", TypeName = "decimal(18, 0)")]
    public decimal? LevelId { get; set; }

    [Column("emp_id", TypeName = "decimal(18, 0)")]
    public decimal? EmpId { get; set; }

    [Column("emp_ass_id", TypeName = "decimal(18, 0)")]
    public decimal? EmpAssId { get; set; }

    [Column("strength_point")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? StrengthPoint { get; set; }

    [Column("weaknees_point")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? WeakneesPoint { get; set; }

    [Column("diagnose")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Diagnose { get; set; }

    [Column("long_target")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? LongTarget { get; set; }

    [Column("short_target")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? ShortTarget { get; set; }

    [Column("tools")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Tools { get; set; }

    [Column("assessment_way")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? AssessmentWay { get; set; }

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
