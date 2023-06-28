using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("pafn_license_8")]
public partial class PafnLicense8
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

    [Column("center_no")]
    [StringLength(200)]
    [Unicode(false)]
    public string? CenterNo { get; set; }

    [Column("following_no")]
    [StringLength(200)]
    [Unicode(false)]
    public string? FollowingNo { get; set; }

    [Column("issue_date", TypeName = "datetime")]
    public DateTime? IssueDate { get; set; }

    [Column("renewal_date", TypeName = "datetime")]
    public DateTime? RenewalDate { get; set; }

    [Column("expire_date", TypeName = "datetime")]
    public DateTime? ExpireDate { get; set; }

    [Column("owner_lincense_name")]
    [StringLength(200)]
    [Unicode(false)]
    public string? OwnerLincenseName { get; set; }

    [Column("lincense_id_no")]
    [StringLength(200)]
    [Unicode(false)]
    public string? LincenseIdNo { get; set; }

    [Column("nationality")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Nationality { get; set; }

    [Column("national_id", TypeName = "decimal(18, 0)")]
    public decimal? NationalId { get; set; }

    [Column("comm_activity")]
    [StringLength(200)]
    [Unicode(false)]
    public string? CommActivity { get; set; }

    [Column("comm_name")]
    [StringLength(200)]
    [Unicode(false)]
    public string? CommName { get; set; }

    [Column("comm_license_no")]
    [StringLength(200)]
    [Unicode(false)]
    public string? CommLicenseNo { get; set; }

    [Column("comm_license_date", TypeName = "datetime")]
    public DateTime? CommLicenseDate { get; set; }

    [Column("vehicle_no")]
    [StringLength(200)]
    [Unicode(false)]
    public string? VehicleNo { get; set; }

    [Column("shasy_no")]
    [StringLength(200)]
    [Unicode(false)]
    public string? ShasyNo { get; set; }

    [Column("color")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Color { get; set; }

    [Column("type")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Type { get; set; }

    [Column("model")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Model { get; set; }

    [Column("amount", TypeName = "decimal(18, 3)")]
    public decimal? Amount { get; set; }

    [Column("year_no")]
    [StringLength(200)]
    [Unicode(false)]
    public string? YearNo { get; set; }

    [Column("year_id", TypeName = "decimal(18, 3)")]
    public decimal? YearId { get; set; }

    [Column("legal_name")]
    [StringLength(200)]
    [Unicode(false)]
    public string? LegalName { get; set; }

    [Column("legal_id_no")]
    [StringLength(200)]
    [Unicode(false)]
    public string? LegalIdNo { get; set; }

    [Column("emp_name")]
    [StringLength(200)]
    [Unicode(false)]
    public string? EmpName { get; set; }

    [Column("emp_id", TypeName = "decimal(18, 0)")]
    public decimal? EmpId { get; set; }

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
