using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("inv_type")]
public partial class InvType
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

    [Column("salse_item")]
    [StringLength(1)]
    [Unicode(false)]
    public string? SalseItem { get; set; }

    [Column("comp_item")]
    [StringLength(1)]
    [Unicode(false)]
    public string? CompItem { get; set; }

    [Column("lot_control")]
    [StringLength(1)]
    [Unicode(false)]
    public string? LotControl { get; set; }

    [Column("contener_controll")]
    [StringLength(1)]
    [Unicode(false)]
    public string? ContenerControll { get; set; }

    [Column("expier_date")]
    [StringLength(1)]
    [Unicode(false)]
    public string? ExpierDate { get; set; }

    [Column("plan_item")]
    [StringLength(1)]
    [Unicode(false)]
    public string? PlanItem { get; set; }

    [Column("issue_polce")]
    [StringLength(10)]
    [Unicode(false)]
    public string? IssuePolce { get; set; }

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
