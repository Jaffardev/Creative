using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("acp_exam")]
public partial class AcpExam
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

    [Column("exm_start_time", TypeName = "datetime")]
    public DateTime? ExmStartTime { get; set; }

    [Column("exm_end_time", TypeName = "datetime")]
    public DateTime? ExmEndTime { get; set; }

    [Column("degree", TypeName = "decimal(18, 0)")]
    public decimal? Degree { get; set; }

    [Column("min_degree", TypeName = "decimal(18, 0)")]
    public decimal? MinDegree { get; set; }

    [Column("max_degree", TypeName = "decimal(18, 0)")]
    public decimal? MaxDegree { get; set; }

    [Column("priority", TypeName = "decimal(18, 0)")]
    public decimal? Priority { get; set; }

    [Column("type_id", TypeName = "decimal(18, 0)")]
    public decimal? TypeId { get; set; }

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
