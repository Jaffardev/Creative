using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("reg_stu_org")]
public partial class RegStuOrg
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("stu_id", TypeName = "decimal(18, 0)")]
    public decimal? StuId { get; set; }

    [Column("org_id", TypeName = "decimal(18, 0)")]
    public decimal? OrgId { get; set; }

    [Column("notes")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes { get; set; }

    [Column("creation_by", TypeName = "decimal(18, 0)")]
    public decimal? CreationBy { get; set; }

    [Column("creation_date", TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    [Column("amount", TypeName = "decimal(18, 3)")]
    public decimal? Amount { get; set; }

    [Column("modify_by", TypeName = "decimal(18, 0)")]
    public decimal? ModifyBy { get; set; }

    [Column("modify_date", TypeName = "datetime")]
    public DateTime? ModifyDate { get; set; }

    [Column("amount_1", TypeName = "decimal(18, 3)")]
    public decimal? Amount1 { get; set; }

    [Column("amount_2", TypeName = "decimal(18, 3)")]
    public decimal? Amount2 { get; set; }

    [Column("amount_3", TypeName = "decimal(18, 3)")]
    public decimal? Amount3 { get; set; }

    [Column("amount_4", TypeName = "decimal(18, 3)")]
    public decimal? Amount4 { get; set; }
}
