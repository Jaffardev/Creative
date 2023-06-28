using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("curr_stu_sub")]
public partial class CurrStuSub
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

    [Column("cat_id", TypeName = "decimal(18, 0)")]
    public decimal? CatId { get; set; }

    [Column("ft_teaher_comment1")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? FtTeaherComment1 { get; set; }

    [Column("ft_parent_comment2")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? FtParentComment2 { get; set; }

    [Column("st_teaher_comment1")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? StTeaherComment1 { get; set; }

    [Column("st_parent_comment2")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? StParentComment2 { get; set; }

    [Column("selected")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Selected { get; set; }

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
