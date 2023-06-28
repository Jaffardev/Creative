using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("pafn_pledge")]
public partial class PafnPledge
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

    [Column("gover_name")]
    [StringLength(200)]
    [Unicode(false)]
    public string? GoverName { get; set; }

    [Column("gover_id", TypeName = "decimal(18, 0)")]
    public decimal? GoverId { get; set; }

    [Column("tans_date", TypeName = "datetime")]
    public DateTime? TansDate { get; set; }

    [Column("trans_time", TypeName = "datetime")]
    public DateTime? TransTime { get; set; }

    [Column("comm_name")]
    [StringLength(200)]
    [Unicode(false)]
    public string? CommName { get; set; }

    [Column("comm_activity")]
    [StringLength(200)]
    [Unicode(false)]
    public string? CommActivity { get; set; }

    [Column("address")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Address { get; set; }

    [Column("owner_lincense_name")]
    [StringLength(200)]
    [Unicode(false)]
    public string? OwnerLincenseName { get; set; }

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

    [Column("period")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Period { get; set; }

    [Column("data_1")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Data1 { get; set; }

    [Column("data_2")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Data2 { get; set; }

    [Column("data_3")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Data3 { get; set; }

    [Column("data_4")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Data4 { get; set; }

    [Column("data_5")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Data5 { get; set; }

    [Column("person_name")]
    [StringLength(200)]
    [Unicode(false)]
    public string? PersonName { get; set; }

    [Column("person_type")]
    [StringLength(200)]
    [Unicode(false)]
    public string? PersonType { get; set; }

    [Column("emp_no")]
    [StringLength(200)]
    [Unicode(false)]
    public string? EmpNo { get; set; }

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
