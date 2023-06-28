using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("lib_thistory")]
public partial class LibThistory
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

    [Column("trans_date", TypeName = "datetime")]
    public DateTime? TransDate { get; set; }

    [Column("trans_time", TypeName = "datetime")]
    public DateTime? TransTime { get; set; }

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

    [Column("activty_type_id", TypeName = "decimal(18, 0)")]
    public decimal? ActivtyTypeId { get; set; }

    [Column("manger")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Manger { get; set; }

    [Column("shared")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Shared { get; set; }

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

    [Column("photo_1")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Photo1 { get; set; }

    [Column("photo_2")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Photo2 { get; set; }

    [Column("photo_3")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Photo3 { get; set; }

    [Column("photo_4")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Photo4 { get; set; }

    [Column("photo_5")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Photo5 { get; set; }

    [Column("photo_6")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Photo6 { get; set; }

    [Column("photo_7")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Photo7 { get; set; }

    [Column("photo_8")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Photo8 { get; set; }

    [Column("photo_9")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Photo9 { get; set; }

    [Column("photo_10")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Photo10 { get; set; }

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
