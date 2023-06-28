using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("sch_clb_services")]
public partial class SchClbService
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

    [Column("morning")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Morning { get; set; }

    [Column("afternoon")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Afternoon { get; set; }

    [Column("girls")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Girls { get; set; }

    [Column("boys")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Boys { get; set; }

    [Column("from_birth_date", TypeName = "datetime")]
    public DateTime? FromBirthDate { get; set; }

    [Column("to_birth_date", TypeName = "datetime")]
    public DateTime? ToBirthDate { get; set; }

    [Column("from_hour", TypeName = "datetime")]
    public DateTime? FromHour { get; set; }

    [Column("to_hour", TypeName = "datetime")]
    public DateTime? ToHour { get; set; }

    [Column("saturday")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Saturday { get; set; }

    [Column("sunday")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Sunday { get; set; }

    [Column("monday")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Monday { get; set; }

    [Column("tuesday")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Tuesday { get; set; }

    [Column("wednesday")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Wednesday { get; set; }

    [Column("thursday")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Thursday { get; set; }

    [Column("friday")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Friday { get; set; }

    [Column("amount_1", TypeName = "decimal(18, 3)")]
    public decimal? Amount1 { get; set; }

    [Column("amount_2", TypeName = "decimal(18, 3)")]
    public decimal? Amount2 { get; set; }

    [Column("amount_3", TypeName = "decimal(18, 3)")]
    public decimal? Amount3 { get; set; }

    [Column("amount_4", TypeName = "decimal(18, 3)")]
    public decimal? Amount4 { get; set; }

    [Column("description")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Description { get; set; }

    [Column("parent_id", TypeName = "decimal(18, 0)")]
    public decimal? ParentId { get; set; }

    [Column("last_level")]
    [StringLength(1)]
    [Unicode(false)]
    public string? LastLevel { get; set; }

    [Column("photo_1")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Photo1 { get; set; }

    [Column("active")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Active { get; set; }

    [Column("notes")]
    [StringLength(1000)]
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
