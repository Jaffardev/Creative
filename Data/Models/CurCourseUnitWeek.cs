using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("cur_course_unit_week")]
public partial class CurCourseUnitWeek
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

    [Column("class_id", TypeName = "decimal(18, 0)")]
    public decimal? ClassId { get; set; }

    [Column("term_id", TypeName = "decimal(18, 0)")]
    public decimal? TermId { get; set; }

    [Column("unit_id", TypeName = "decimal(18, 0)")]
    public decimal? UnitId { get; set; }

    [Column("week_id", TypeName = "decimal(18, 0)")]
    public decimal? WeekId { get; set; }

    [Column("active")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Active { get; set; }

    [Column("standards", TypeName = "text")]
    public string? Standards { get; set; }

    [Column("question", TypeName = "text")]
    public string? Question { get; set; }

    [Column("materials", TypeName = "text")]
    public string? Materials { get; set; }

    [Column("formative", TypeName = "text")]
    public string? Formative { get; set; }

    [Column("differentaition", TypeName = "text")]
    public string? Differentaition { get; set; }

    [Column("beging_1", TypeName = "text")]
    public string? Beging1 { get; set; }

    [Column("beging_2", TypeName = "text")]
    public string? Beging2 { get; set; }

    [Column("beging_3", TypeName = "text")]
    public string? Beging3 { get; set; }

    [Column("beging_4", TypeName = "text")]
    public string? Beging4 { get; set; }

    [Column("beging_5", TypeName = "text")]
    public string? Beging5 { get; set; }

    [Column("beging_6", TypeName = "text")]
    public string? Beging6 { get; set; }

    [Column("beging_7", TypeName = "text")]
    public string? Beging7 { get; set; }

    [Column("instruction_1", TypeName = "text")]
    public string? Instruction1 { get; set; }

    [Column("instruction_2", TypeName = "text")]
    public string? Instruction2 { get; set; }

    [Column("instruction_3", TypeName = "text")]
    public string? Instruction3 { get; set; }

    [Column("instruction_4", TypeName = "text")]
    public string? Instruction4 { get; set; }

    [Column("instruction_5", TypeName = "text")]
    public string? Instruction5 { get; set; }

    [Column("instruction_6", TypeName = "text")]
    public string? Instruction6 { get; set; }

    [Column("instruction_7", TypeName = "text")]
    public string? Instruction7 { get; set; }

    [Column("active_1", TypeName = "text")]
    public string? Active1 { get; set; }

    [Column("active_2", TypeName = "text")]
    public string? Active2 { get; set; }

    [Column("active_3", TypeName = "text")]
    public string? Active3 { get; set; }

    [Column("active_4", TypeName = "text")]
    public string? Active4 { get; set; }

    [Column("active_5", TypeName = "text")]
    public string? Active5 { get; set; }

    [Column("active_6", TypeName = "text")]
    public string? Active6 { get; set; }

    [Column("active_7", TypeName = "text")]
    public string? Active7 { get; set; }

    [Column("wrap_1", TypeName = "text")]
    public string? Wrap1 { get; set; }

    [Column("wrap_2", TypeName = "text")]
    public string? Wrap2 { get; set; }

    [Column("wrap_3", TypeName = "text")]
    public string? Wrap3 { get; set; }

    [Column("wrap_4", TypeName = "text")]
    public string? Wrap4 { get; set; }

    [Column("wrap_5", TypeName = "text")]
    public string? Wrap5 { get; set; }

    [Column("wrap_6", TypeName = "text")]
    public string? Wrap6 { get; set; }

    [Column("wrap_7", TypeName = "text")]
    public string? Wrap7 { get; set; }

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

    [Column("hw_1", TypeName = "text")]
    public string? Hw1 { get; set; }

    [Column("hw_2", TypeName = "text")]
    public string? Hw2 { get; set; }

    [Column("hw_3", TypeName = "text")]
    public string? Hw3 { get; set; }

    [Column("hw_4", TypeName = "text")]
    public string? Hw4 { get; set; }

    [Column("hw_5", TypeName = "text")]
    public string? Hw5 { get; set; }

    [Column("hw_6", TypeName = "text")]
    public string? Hw6 { get; set; }

    [Column("hw_7", TypeName = "text")]
    public string? Hw7 { get; set; }
}
