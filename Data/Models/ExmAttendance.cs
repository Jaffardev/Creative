using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("exm_attendance")]
public partial class ExmAttendance
{
    [Key]
    [Column("id", TypeName = "numeric(18, 0)")]
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

    [Column("stu_id", TypeName = "numeric(18, 0)")]
    public decimal? StuId { get; set; }

    [Column("stu_code")]
    [StringLength(50)]
    [Unicode(false)]
    public string? StuCode { get; set; }

    [Column("stu_name_1")]
    [StringLength(100)]
    [Unicode(false)]
    public string? StuName1 { get; set; }

    [Column("stu_name_2")]
    [StringLength(100)]
    [Unicode(false)]
    public string? StuName2 { get; set; }

    [Column("q1_a", TypeName = "numeric(18, 0)")]
    public decimal? Q1A { get; set; }

    [Column("q1_t", TypeName = "numeric(18, 0)")]
    public decimal? Q1T { get; set; }

    [Column("q2_a", TypeName = "numeric(18, 0)")]
    public decimal? Q2A { get; set; }

    [Column("q2_t", TypeName = "numeric(18, 0)")]
    public decimal? Q2T { get; set; }

    [Column("q3_a", TypeName = "numeric(18, 0)")]
    public decimal? Q3A { get; set; }

    [Column("q3_t", TypeName = "numeric(18, 0)")]
    public decimal? Q3T { get; set; }

    [Column("q4_a", TypeName = "numeric(18, 0)")]
    public decimal? Q4A { get; set; }

    [Column("q4_t", TypeName = "numeric(18, 0)")]
    public decimal? Q4T { get; set; }

    [Column("active")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Active { get; set; }

    [Column("notes")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes { get; set; }

    [Column("creation_by", TypeName = "numeric(18, 0)")]
    public decimal? CreationBy { get; set; }

    [Column("creation_date", TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    [Column("modify_by", TypeName = "numeric(18, 0)")]
    public decimal? ModifyBy { get; set; }

    [Column("modify_date", TypeName = "datetime")]
    public DateTime? ModifyDate { get; set; }
}
