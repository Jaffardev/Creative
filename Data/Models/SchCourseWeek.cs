using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("sch_course_weeks")]
public partial class SchCourseWeek
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

    [Column("from_date", TypeName = "datetime")]
    public DateTime? FromDate { get; set; }

    [Column("to_date", TypeName = "datetime")]
    public DateTime? ToDate { get; set; }

    [Column("weeks_id", TypeName = "decimal(18, 0)")]
    public decimal? WeeksId { get; set; }

    [Column("Course_id", TypeName = "decimal(18, 0)")]
    public decimal? CourseId { get; set; }

    [Column("stage_id", TypeName = "decimal(18, 0)")]
    public decimal? StageId { get; set; }

    [Column("gread_id", TypeName = "decimal(18, 0)")]
    public decimal? GreadId { get; set; }

    [Column("branch_id", TypeName = "decimal(18, 0)")]
    public decimal? BranchId { get; set; }

    [Column("class_id", TypeName = "decimal(18, 0)")]
    public decimal? ClassId { get; set; }

    [Column("Teacher_id", TypeName = "decimal(18, 0)")]
    public decimal? TeacherId { get; set; }

    [Column("arb_sum")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? ArbSum { get; set; }

    [Column("arb_mon")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? ArbMon { get; set; }

    [Column("arb_tues")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? ArbTues { get; set; }

    [Column("arb_wed")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? ArbWed { get; set; }

    [Column("arb_thu")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? ArbThu { get; set; }

    [Column("arb_notes")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? ArbNotes { get; set; }

    [Column("math_sum")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? MathSum { get; set; }

    [Column("math_mon")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? MathMon { get; set; }

    [Column("math_tues")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? MathTues { get; set; }

    [Column("math_wed")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? MathWed { get; set; }

    [Column("math_thu")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? MathThu { get; set; }

    [Column("math_notes")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? MathNotes { get; set; }

    [Column("eng_sum")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? EngSum { get; set; }

    [Column("eng_mon")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? EngMon { get; set; }

    [Column("eng_tues")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? EngTues { get; set; }

    [Column("eng_wed")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? EngWed { get; set; }

    [Column("eng_thu")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? EngThu { get; set; }

    [Column("eng_notes")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? EngNotes { get; set; }

    [Column("other_sum")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? OtherSum { get; set; }

    [Column("other_mon")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? OtherMon { get; set; }

    [Column("other_tues")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? OtherTues { get; set; }

    [Column("other_wed")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? OtherWed { get; set; }

    [Column("other_thu")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? OtherThu { get; set; }

    [Column("other_notes")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? OtherNotes { get; set; }

    [Column("row_status")]
    [StringLength(1)]
    [Unicode(false)]
    public string? RowStatus { get; set; }

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
