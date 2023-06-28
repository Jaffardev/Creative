using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("pafn_record_h_4")]
public partial class PafnRecordH4
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("code")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("active")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Active { get; set; }

    [Column("trans_date", TypeName = "datetime")]
    public DateTime? TransDate { get; set; }

    [Column("trans_time", TypeName = "datetime")]
    public DateTime? TransTime { get; set; }

    [Column("gover_name")]
    [StringLength(200)]
    [Unicode(false)]
    public string? GoverName { get; set; }

    [Column("gover_id", TypeName = "decimal(18, 0)")]
    public decimal? GoverId { get; set; }

    [Column("emp_no_1")]
    [StringLength(200)]
    [Unicode(false)]
    public string? EmpNo1 { get; set; }

    [Column("emp_name_1")]
    [StringLength(200)]
    [Unicode(false)]
    public string? EmpName1 { get; set; }

    [Column("emp_job_1")]
    [StringLength(200)]
    [Unicode(false)]
    public string? EmpJob1 { get; set; }

    [Column("emp_no_2")]
    [StringLength(200)]
    [Unicode(false)]
    public string? EmpNo2 { get; set; }

    [Column("emp_name_2")]
    [StringLength(200)]
    [Unicode(false)]
    public string? EmpName2 { get; set; }

    [Column("emp_job_2")]
    [StringLength(200)]
    [Unicode(false)]
    public string? EmpJob2 { get; set; }

    [Column("emp_no_3")]
    [StringLength(200)]
    [Unicode(false)]
    public string? EmpNo3 { get; set; }

    [Column("emp_name_3")]
    [StringLength(200)]
    [Unicode(false)]
    public string? EmpName3 { get; set; }

    [Column("emp_job_3")]
    [StringLength(200)]
    [Unicode(false)]
    public string? EmpJob3 { get; set; }

    [Column("emp_id", TypeName = "decimal(18, 0)")]
    public decimal? EmpId { get; set; }

    [Column("job_id", TypeName = "decimal(18, 0)")]
    public decimal? JobId { get; set; }

    [Column("damage_reason")]
    [StringLength(1)]
    [Unicode(false)]
    public string? DamageReason { get; set; }

    [Column("damage_data")]
    [StringLength(500)]
    [Unicode(false)]
    public string? DamageData { get; set; }

    [Column("owner_name")]
    [StringLength(200)]
    [Unicode(false)]
    public string? OwnerName { get; set; }

    [Column("id_no")]
    [StringLength(200)]
    [Unicode(false)]
    public string? IdNo { get; set; }

    [Column("nationality")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Nationality { get; set; }

    [Column("national_id", TypeName = "decimal(18, 0)")]
    public decimal? NationalId { get; set; }

    [Column("company_name")]
    [StringLength(500)]
    [Unicode(false)]
    public string? CompanyName { get; set; }

    [Column("license_no")]
    [StringLength(200)]
    [Unicode(false)]
    public string? LicenseNo { get; set; }

    [Column("license_date", TypeName = "datetime")]
    public DateTime? LicenseDate { get; set; }

    [Column("data_1")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Data1 { get; set; }

    [Column("notes")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes { get; set; }

    [Column("user_post_id", TypeName = "decimal(18, 0)")]
    public decimal? UserPostId { get; set; }

    [Column("posted")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Posted { get; set; }

    [Column("creation_by", TypeName = "decimal(18, 0)")]
    public decimal? CreationBy { get; set; }

    [Column("creation_date", TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    [Column("modify_by", TypeName = "decimal(18, 0)")]
    public decimal? ModifyBy { get; set; }

    [Column("modify_date", TypeName = "datetime")]
    public DateTime? ModifyDate { get; set; }
}
