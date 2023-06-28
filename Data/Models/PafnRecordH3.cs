﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("pafn_record_h_3")]
public partial class PafnRecordH3
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

    [Column("emp_no")]
    [StringLength(200)]
    [Unicode(false)]
    public string? EmpNo { get; set; }

    [Column("emp_job")]
    [StringLength(200)]
    [Unicode(false)]
    public string? EmpJob { get; set; }

    [Column("emp_name")]
    [StringLength(200)]
    [Unicode(false)]
    public string? EmpName { get; set; }

    [Column("emp_id", TypeName = "decimal(18, 0)")]
    public decimal? EmpId { get; set; }

    [Column("company_name")]
    [StringLength(500)]
    [Unicode(false)]
    public string? CompanyName { get; set; }

    [Column("address")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Address { get; set; }

    [Column("activity")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Activity { get; set; }

    [Column("owner_name")]
    [StringLength(200)]
    [Unicode(false)]
    public string? OwnerName { get; set; }

    [Column("id_no")]
    [StringLength(200)]
    [Unicode(false)]
    public string? IdNo { get; set; }

    [Column("license_no")]
    [StringLength(200)]
    [Unicode(false)]
    public string? LicenseNo { get; set; }

    [Column("license_date", TypeName = "datetime")]
    public DateTime? LicenseDate { get; set; }

    [Column("job_name")]
    [StringLength(500)]
    [Unicode(false)]
    public string? JobName { get; set; }

    [Column("job_id", TypeName = "decimal(18, 0)")]
    public decimal? JobId { get; set; }

    [Column("nationality")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Nationality { get; set; }

    [Column("national_id", TypeName = "decimal(18, 0)")]
    public decimal? NationalId { get; set; }

    [Column("residence_place")]
    [StringLength(200)]
    [Unicode(false)]
    public string? ResidencePlace { get; set; }

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
