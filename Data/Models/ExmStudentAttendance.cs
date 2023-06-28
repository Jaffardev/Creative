using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("exm_student_attendance")]
[Index("StudentId", "DayDate", Name = "IX_exm_student_attendance", IsUnique = true)]
public partial class ExmStudentAttendance
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

    [Column("calendar_id", TypeName = "decimal(18, 0)")]
    public decimal? CalendarId { get; set; }

    [Column("student_id", TypeName = "decimal(18, 0)")]
    public decimal? StudentId { get; set; }

    [Column("day_date", TypeName = "datetime")]
    public DateTime? DayDate { get; set; }

    [Column("status")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Status { get; set; }

    [Column("actual_status")]
    [StringLength(1)]
    [Unicode(false)]
    public string? ActualStatus { get; set; }

    [Column("late")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Late { get; set; }

    [Column("late_notes")]
    [StringLength(100)]
    [Unicode(false)]
    public string? LateNotes { get; set; }

    [Column("lesson_1")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Lesson1 { get; set; }

    [Column("lesson_notes_1")]
    [StringLength(100)]
    [Unicode(false)]
    public string? LessonNotes1 { get; set; }

    [Column("lesson_2")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Lesson2 { get; set; }

    [Column("lesson_notes_2")]
    [StringLength(100)]
    [Unicode(false)]
    public string? LessonNotes2 { get; set; }

    [Column("lesson_3")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Lesson3 { get; set; }

    [Column("lesson_notes_3")]
    [StringLength(100)]
    [Unicode(false)]
    public string? LessonNotes3 { get; set; }

    [Column("lesson_4")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Lesson4 { get; set; }

    [Column("lesson_notes_4")]
    [StringLength(100)]
    [Unicode(false)]
    public string? LessonNotes4 { get; set; }

    [Column("lesson_5")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Lesson5 { get; set; }

    [Column("lesson_notes_5")]
    [StringLength(100)]
    [Unicode(false)]
    public string? LessonNotes5 { get; set; }

    [Column("lesson_6")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Lesson6 { get; set; }

    [Column("lesson_notes_6")]
    [StringLength(100)]
    [Unicode(false)]
    public string? LessonNotes6 { get; set; }

    [Column("lesson_7")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Lesson7 { get; set; }

    [Column("lesson_notes_7")]
    [StringLength(100)]
    [Unicode(false)]
    public string? LessonNotes7 { get; set; }

    [Column("lesson_8")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Lesson8 { get; set; }

    [Column("lesson_notes_8")]
    [StringLength(100)]
    [Unicode(false)]
    public string? LessonNotes8 { get; set; }

    [Column("lesson_9")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Lesson9 { get; set; }

    [Column("lesson_notes_9")]
    [StringLength(100)]
    [Unicode(false)]
    public string? LessonNotes9 { get; set; }

    [Column("lesson_10")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Lesson10 { get; set; }

    [Column("lesson_notes_10")]
    [StringLength(100)]
    [Unicode(false)]
    public string? LessonNotes10 { get; set; }

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

    [Column("late_2")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Late2 { get; set; }

    [Column("late_notes_2")]
    [StringLength(100)]
    [Unicode(false)]
    public string? LateNotes2 { get; set; }

    [Column("late_3")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Late3 { get; set; }

    [Column("late_notes_3")]
    [StringLength(100)]
    [Unicode(false)]
    public string? LateNotes3 { get; set; }

    [Column("year_id", TypeName = "decimal(18, 0)")]
    public decimal? YearId { get; set; }

    [Column("branch_id", TypeName = "decimal(18, 0)")]
    public decimal? BranchId { get; set; }

    [Column("gread_id", TypeName = "decimal(18, 0)")]
    public decimal? GreadId { get; set; }

    [Column("class_id", TypeName = "decimal(18, 0)")]
    public decimal? ClassId { get; set; }
}
