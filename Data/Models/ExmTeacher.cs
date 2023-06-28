using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("exm_teacher")]
public partial class ExmTeacher
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

    [Column("emp_id", TypeName = "decimal(18, 0)")]
    public decimal? EmpId { get; set; }

    [Column("weekly_lesson_no", TypeName = "decimal(18, 0)")]
    public decimal? WeeklyLessonNo { get; set; }

    [Column("hour_no", TypeName = "decimal(18, 3)")]
    public decimal? HourNo { get; set; }

    [Column("tel_1")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Tel1 { get; set; }

    [Column("tel_2")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Tel2 { get; set; }

    [Column("postion")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Postion { get; set; }

    [Column("priority", TypeName = "decimal(18, 0)")]
    public decimal? Priority { get; set; }

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

    [Column("sec_user_id", TypeName = "decimal(18, 0)")]
    public decimal? SecUserId { get; set; }

    [Column("allow_1")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Allow1 { get; set; }

    [Column("lesson_no_1")]
    [StringLength(1)]
    [Unicode(false)]
    public string? LessonNo1 { get; set; }

    [Column("from_time_1", TypeName = "datetime")]
    public DateTime? FromTime1 { get; set; }

    [Column("to_time_1", TypeName = "datetime")]
    public DateTime? ToTime1 { get; set; }

    [Column("visitor_no_1", TypeName = "decimal(18, 0)")]
    public decimal? VisitorNo1 { get; set; }

    [Column("allow_2")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Allow2 { get; set; }

    [Column("lesson_no_2")]
    [StringLength(1)]
    [Unicode(false)]
    public string? LessonNo2 { get; set; }

    [Column("from_time_2", TypeName = "datetime")]
    public DateTime? FromTime2 { get; set; }

    [Column("to_time_2", TypeName = "datetime")]
    public DateTime? ToTime2 { get; set; }

    [Column("visitor_no_2", TypeName = "decimal(18, 0)")]
    public decimal? VisitorNo2 { get; set; }

    [Column("allow_3")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Allow3 { get; set; }

    [Column("lesson_no_3")]
    [StringLength(1)]
    [Unicode(false)]
    public string? LessonNo3 { get; set; }

    [Column("from_time_3", TypeName = "datetime")]
    public DateTime? FromTime3 { get; set; }

    [Column("to_time_3", TypeName = "datetime")]
    public DateTime? ToTime3 { get; set; }

    [Column("visitor_no_3", TypeName = "decimal(18, 0)")]
    public decimal? VisitorNo3 { get; set; }

    [Column("allow_4")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Allow4 { get; set; }

    [Column("lesson_no_4")]
    [StringLength(1)]
    [Unicode(false)]
    public string? LessonNo4 { get; set; }

    [Column("from_time_4", TypeName = "datetime")]
    public DateTime? FromTime4 { get; set; }

    [Column("to_time_4", TypeName = "datetime")]
    public DateTime? ToTime4 { get; set; }

    [Column("visitor_no_4", TypeName = "decimal(18, 0)")]
    public decimal? VisitorNo4 { get; set; }

    [Column("allow_5")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Allow5 { get; set; }

    [Column("lesson_no_5")]
    [StringLength(1)]
    [Unicode(false)]
    public string? LessonNo5 { get; set; }

    [Column("from_time_5", TypeName = "datetime")]
    public DateTime? FromTime5 { get; set; }

    [Column("to_time_5", TypeName = "datetime")]
    public DateTime? ToTime5 { get; set; }

    [Column("visitor_no_5", TypeName = "decimal(18, 0)")]
    public decimal? VisitorNo5 { get; set; }

    [Column("allow_6")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Allow6 { get; set; }

    [Column("lesson_no_6")]
    [StringLength(1)]
    [Unicode(false)]
    public string? LessonNo6 { get; set; }

    [Column("from_time_6", TypeName = "datetime")]
    public DateTime? FromTime6 { get; set; }

    [Column("to_time_6", TypeName = "datetime")]
    public DateTime? ToTime6 { get; set; }

    [Column("visitor_no_6", TypeName = "decimal(18, 0)")]
    public decimal? VisitorNo6 { get; set; }

    [Column("allow_7")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Allow7 { get; set; }

    [Column("lesson_no_7")]
    [StringLength(1)]
    [Unicode(false)]
    public string? LessonNo7 { get; set; }

    [Column("from_time_7", TypeName = "datetime")]
    public DateTime? FromTime7 { get; set; }

    [Column("to_time_7", TypeName = "datetime")]
    public DateTime? ToTime7 { get; set; }

    [Column("visitor_no_7", TypeName = "decimal(18, 0)")]
    public decimal? VisitorNo7 { get; set; }
}
