using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("exm_course_gread")]
public partial class ExmCourseGread
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("code")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("gread_id", TypeName = "decimal(18, 0)")]
    public decimal? GreadId { get; set; }

    [Column("course_id", TypeName = "decimal(18, 0)")]
    public decimal? CourseId { get; set; }

    [Column("weekly_lesson_no", TypeName = "decimal(18, 0)")]
    public decimal? WeeklyLessonNo { get; set; }

    [Column("hour_no", TypeName = "decimal(18, 3)")]
    public decimal? HourNo { get; set; }

    [Column("default_degree", TypeName = "decimal(18, 3)")]
    public decimal? DefaultDegree { get; set; }

    [Column("min_degree", TypeName = "decimal(18, 3)")]
    public decimal? MinDegree { get; set; }

    [Column("max_degree", TypeName = "decimal(18, 3)")]
    public decimal? MaxDegree { get; set; }

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
