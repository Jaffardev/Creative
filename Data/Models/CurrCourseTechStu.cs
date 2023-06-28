using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("curr_course_tech_stu")]
public partial class CurrCourseTechStu
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

    [Column("course_id", TypeName = "decimal(18, 0)")]
    public decimal? CourseId { get; set; }

    [Column("teacher_id", TypeName = "decimal(18, 0)")]
    public decimal? TeacherId { get; set; }

    [Column("stu_id", TypeName = "decimal(18, 0)")]
    public decimal? StuId { get; set; }

    [Column("year_id", TypeName = "decimal(18, 0)")]
    public decimal? YearId { get; set; }

    [Column("student_strengths")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? StudentStrengths { get; set; }

    [Column("additional_comments")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? AdditionalComments { get; set; }

    [Column("general_comments")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? GeneralComments { get; set; }

    [Column("curr_date", TypeName = "datetime")]
    public DateTime? CurrDate { get; set; }

    [Column("prog_gc_teaher_term1")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? ProgGcTeaherTerm1 { get; set; }

    [Column("prog_gc_teaher_term2")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? ProgGcTeaherTerm2 { get; set; }

    [Column("prog_gc_parent_term1")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? ProgGcParentTerm1 { get; set; }

    [Column("prog_gc_parent_term2")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? ProgGcParentTerm2 { get; set; }

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
}
