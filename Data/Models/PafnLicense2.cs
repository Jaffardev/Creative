using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("pafn_license_2")]
public partial class PafnLicense2
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

    [Column("renewal_date", TypeName = "datetime")]
    public DateTime? RenewalDate { get; set; }

    [Column("expire_date", TypeName = "datetime")]
    public DateTime? ExpireDate { get; set; }

    [Column("first_issue_date", TypeName = "datetime")]
    public DateTime? FirstIssueDate { get; set; }

    [Column("file_no")]
    [StringLength(200)]
    [Unicode(false)]
    public string? FileNo { get; set; }

    [Column("owner_lincense_name")]
    [StringLength(200)]
    [Unicode(false)]
    public string? OwnerLincenseName { get; set; }

    [Column("id_no")]
    [StringLength(200)]
    [Unicode(false)]
    public string? IdNo { get; set; }

    [Column("legal_name")]
    [StringLength(200)]
    [Unicode(false)]
    public string? LegalName { get; set; }

    [Column("legal_id_no")]
    [StringLength(200)]
    [Unicode(false)]
    public string? LegalIdNo { get; set; }

    [Column("national_1")]
    [StringLength(200)]
    [Unicode(false)]
    public string? National1 { get; set; }

    [Column("national_2")]
    [StringLength(200)]
    [Unicode(false)]
    public string? National2 { get; set; }

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

    [Column("comm_issue_date", TypeName = "datetime")]
    public DateTime? CommIssueDate { get; set; }

    [Column("comm_exipre_date", TypeName = "datetime")]
    public DateTime? CommExipreDate { get; set; }

    [Column("area_no")]
    [StringLength(200)]
    [Unicode(false)]
    public string? AreaNo { get; set; }

    [Column("area")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Area { get; set; }

    [Column("area_id", TypeName = "decimal(18, 0)")]
    public decimal? AreaId { get; set; }

    [Column("street")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Street { get; set; }

    [Column("floor")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Floor { get; set; }

    [Column("block_no")]
    [StringLength(200)]
    [Unicode(false)]
    public string? BlockNo { get; set; }

    [Column("building")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Building { get; set; }

    [Column("unit_no")]
    [StringLength(200)]
    [Unicode(false)]
    public string? UnitNo { get; set; }

    [Column("owner_name")]
    [StringLength(200)]
    [Unicode(false)]
    public string? OwnerName { get; set; }

    [Column("real_type")]
    [StringLength(200)]
    [Unicode(false)]
    public string? RealType { get; set; }

    [Column("serial_no")]
    [StringLength(200)]
    [Unicode(false)]
    public string? SerialNo { get; set; }

    [Column("amount", TypeName = "decimal(18, 3)")]
    public decimal? Amount { get; set; }

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
