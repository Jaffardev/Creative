﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("lib_org")]
public partial class LibOrg
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

    [Column("org_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? OrgType { get; set; }

    [Column("emp_id", TypeName = "decimal(18, 0)")]
    public decimal? EmpId { get; set; }

    [Column("stu_id", TypeName = "decimal(18, 0)")]
    public decimal? StuId { get; set; }

    [Column("lib_id", TypeName = "decimal(18, 0)")]
    public decimal? LibId { get; set; }

    [Column("tel_1")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Tel1 { get; set; }

    [Column("tel_2")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Tel2 { get; set; }

    [Column("address")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Address { get; set; }

    [Column("l_row")]
    [StringLength(50)]
    [Unicode(false)]
    public string? LRow { get; set; }

    [Column("l_column")]
    [StringLength(50)]
    [Unicode(false)]
    public string? LColumn { get; set; }

    [Column("manger")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Manger { get; set; }

    [Column("day_no")]
    public int? DayNo { get; set; }

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

    [Column("allow_Qty")]
    public int? AllowQty { get; set; }

    [Column("photo_1")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Photo1 { get; set; }

    [Column("photo_2")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Photo2 { get; set; }
}
