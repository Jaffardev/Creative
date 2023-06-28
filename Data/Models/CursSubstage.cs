using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("curs_substage")]
public partial class CursSubstage
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

    [Column("doc_no")]
    [StringLength(20)]
    [Unicode(false)]
    public string? DocNo { get; set; }

    [Column("stage_id", TypeName = "decimal(18, 0)")]
    public decimal? StageId { get; set; }

    [Column("from_age", TypeName = "decimal(18, 3)")]
    public decimal? FromAge { get; set; }

    [Column("to_age", TypeName = "decimal(18, 3)")]
    public decimal? ToAge { get; set; }

    [Column("from_birth_date", TypeName = "datetime")]
    public DateTime? FromBirthDate { get; set; }

    [Column("to_birth_date", TypeName = "datetime")]
    public DateTime? ToBirthDate { get; set; }

    [Column("manager")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Manager { get; set; }

    [Column("manager_tel")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ManagerTel { get; set; }

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
