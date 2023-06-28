using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("lib_visit")]
public partial class LibVisit
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

    [Column("visit_date", TypeName = "datetime")]
    public DateTime? VisitDate { get; set; }

    [Column("visit_time", TypeName = "datetime")]
    public DateTime? VisitTime { get; set; }

    [Column("branch_id", TypeName = "decimal(18, 0)")]
    public decimal? BranchId { get; set; }

    [Column("gread_id", TypeName = "decimal(18, 0)")]
    public decimal? GreadId { get; set; }

    [Column("class_id", TypeName = "decimal(18, 0)")]
    public decimal? ClassId { get; set; }

    [Column("lib_id", TypeName = "decimal(18, 0)")]
    public decimal? LibId { get; set; }

    [Column("location_id", TypeName = "decimal(18, 0)")]
    public decimal? LocationId { get; set; }

    [Column("techer")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Techer { get; set; }

    [Column("ression")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Ression { get; set; }

    [Column("desc_1")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Desc1 { get; set; }

    [Column("desc_2")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Desc2 { get; set; }

    [Column("desc_3")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Desc3 { get; set; }

    [Column("desc_4")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Desc4 { get; set; }

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
