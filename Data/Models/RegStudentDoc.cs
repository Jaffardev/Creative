using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("reg_student_doc")]
public partial class RegStudentDoc
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("code")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("name_1")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Name1 { get; set; }

    [Column("name_2")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Name2 { get; set; }

    [Column("h_id", TypeName = "decimal(18, 0)")]
    public decimal? HId { get; set; }

    [Column("description")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Description { get; set; }

    [Column("photo_path")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? PhotoPath { get; set; }

    [Column("row_status")]
    [StringLength(1)]
    [Unicode(false)]
    public string? RowStatus { get; set; }

    [Column("posted")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Posted { get; set; }

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

    [Column("doc_type_id", TypeName = "decimal(18, 0)")]
    public decimal? DocTypeId { get; set; }

    [Column("photo_path_1")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? PhotoPath1 { get; set; }

    [Column("photo_path_2")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? PhotoPath2 { get; set; }

    [Column("photo_path_3")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? PhotoPath3 { get; set; }
}
