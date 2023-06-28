using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("med_stu_permission")]
public partial class MedStuPermission
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

    [Column("name_1")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Name1 { get; set; }

    [Column("name_2")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Name2 { get; set; }

    [Column("trans_date", TypeName = "datetime")]
    public DateTime? TransDate { get; set; }

    [Column("trans_time", TypeName = "datetime")]
    public DateTime? TransTime { get; set; }

    [Column("lesson")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Lesson { get; set; }

    [Column("reason")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Reason { get; set; }

    [Column("responsible_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? ResponsibleType { get; set; }

    [Column("responsible_name")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ResponsibleName { get; set; }

    [Column("lesson_time", TypeName = "datetime")]
    public DateTime? LessonTime { get; set; }

    [Column("return_time", TypeName = "datetime")]
    public DateTime? ReturnTime { get; set; }

    [Column("actual_return_time", TypeName = "datetime")]
    public DateTime? ActualReturnTime { get; set; }

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
    public DateTime CreationDate { get; set; }

    [Column("modify_by", TypeName = "decimal(18, 0)")]
    public decimal? ModifyBy { get; set; }

    [Column("modify_date", TypeName = "datetime")]
    public DateTime? ModifyDate { get; set; }
}
