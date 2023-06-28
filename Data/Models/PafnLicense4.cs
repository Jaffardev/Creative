using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("pafn_license_4")]
public partial class PafnLicense4
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("code")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("gover_name")]
    [StringLength(200)]
    [Unicode(false)]
    public string? GoverName { get; set; }

    [Column("gover_id", TypeName = "decimal(18, 0)")]
    public decimal? GoverId { get; set; }

    [Column("license_no")]
    [StringLength(200)]
    [Unicode(false)]
    public string? LicenseNo { get; set; }

    [Column("issue_date", TypeName = "datetime")]
    public DateTime? IssueDate { get; set; }

    [Column("expire_date", TypeName = "datetime")]
    public DateTime? ExpireDate { get; set; }

    [Column("comm_name")]
    [StringLength(200)]
    [Unicode(false)]
    public string? CommName { get; set; }

    [Column("health_license_no")]
    [StringLength(200)]
    [Unicode(false)]
    public string? HealthLicenseNo { get; set; }

    [Column("health_issue_date", TypeName = "datetime")]
    public DateTime? HealthIssueDate { get; set; }

    [Column("health_expire_date", TypeName = "datetime")]
    public DateTime? HealthExpireDate { get; set; }

    [Column("material_type")]
    [StringLength(200)]
    [Unicode(false)]
    public string? MaterialType { get; set; }

    [Column("area")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Area { get; set; }

    [Column("street")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Street { get; set; }

    [Column("block")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Block { get; set; }

    [Column("qaseema")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Qaseema { get; set; }

    [Column("emp_name")]
    [StringLength(200)]
    [Unicode(false)]
    public string? EmpName { get; set; }

    [Column("emp_id", TypeName = "decimal(18, 0)")]
    public decimal? EmpId { get; set; }

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

    [Column("user_post_id", TypeName = "decimal(18, 0)")]
    public decimal? UserPostId { get; set; }

    [Column("posted")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Posted { get; set; }

    [Column("active")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Active { get; set; }
}
