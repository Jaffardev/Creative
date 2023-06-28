using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("mps_trans_h")]
public partial class MpsTransH
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

    [Column("plan_master_id", TypeName = "decimal(18, 0)")]
    public decimal? PlanMasterId { get; set; }

    [Column("company_id", TypeName = "decimal(18, 0)")]
    public decimal? CompanyId { get; set; }

    [Column("salse_line_id", TypeName = "decimal(18, 0)")]
    public decimal? SalseLineId { get; set; }

    [Column("pariod_h_id", TypeName = "decimal(18, 0)")]
    public decimal? PariodHId { get; set; }

    [Column("trans_date", TypeName = "datetime")]
    public DateTime? TransDate { get; set; }

    [Column("salse_order")]
    [StringLength(1)]
    [Unicode(false)]
    public string? SalseOrder { get; set; }

    [Column("plan_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? PlanType { get; set; }

    [Column("copy_trans_h_id", TypeName = "decimal(18, 0)")]
    public decimal? CopyTransHId { get; set; }

    [Column("grow1_trans_h_id", TypeName = "decimal(18, 0)")]
    public decimal? Grow1TransHId { get; set; }

    [Column("grow2_trans_h_id", TypeName = "decimal(18, 0)")]
    public decimal? Grow2TransHId { get; set; }

    [Column("resio1_trans_h_id", TypeName = "decimal(18, 0)")]
    public decimal? Resio1TransHId { get; set; }

    [Column("resio1", TypeName = "decimal(18, 4)")]
    public decimal? Resio1 { get; set; }

    [Column("resio2_trans_h_id", TypeName = "decimal(18, 0)")]
    public decimal? Resio2TransHId { get; set; }

    [Column("resio2", TypeName = "decimal(18, 4)")]
    public decimal? Resio2 { get; set; }

    [Column("resio3_trans_h_id", TypeName = "decimal(18, 0)")]
    public decimal? Resio3TransHId { get; set; }

    [Column("resio3", TypeName = "decimal(18, 4)")]
    public decimal? Resio3 { get; set; }

    [Column("resio4_trans_h_id", TypeName = "decimal(18, 0)")]
    public decimal? Resio4TransHId { get; set; }

    [Column("resio4", TypeName = "decimal(18, 4)")]
    public decimal? Resio4 { get; set; }

    [Column("resio5_trans_h_id", TypeName = "decimal(18, 0)")]
    public decimal? Resio5TransHId { get; set; }

    [Column("resio5", TypeName = "decimal(18, 4)")]
    public decimal? Resio5 { get; set; }

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
}
