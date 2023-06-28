using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("pafn_license_7")]
public partial class PafnLicense7
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

    [Column("dept_name")]
    [StringLength(200)]
    [Unicode(false)]
    public string? DeptName { get; set; }

    [Column("dept_id", TypeName = "decimal(18, 0)")]
    public decimal? DeptId { get; set; }

    [Column("tans_date", TypeName = "datetime")]
    public DateTime? TansDate { get; set; }

    [Column("trans_time", TypeName = "datetime")]
    public DateTime? TransTime { get; set; }

    [Column("emp_legal")]
    [StringLength(200)]
    [Unicode(false)]
    public string? EmpLegal { get; set; }

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

    [Column("comm_name")]
    [StringLength(200)]
    [Unicode(false)]
    public string? CommName { get; set; }

    [Column("comm_tel")]
    [StringLength(200)]
    [Unicode(false)]
    public string? CommTel { get; set; }

    [Column("address")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Address { get; set; }

    [Column("address_serial_no")]
    [StringLength(200)]
    [Unicode(false)]
    public string? AddressSerialNo { get; set; }

    [Column("license_no")]
    [StringLength(200)]
    [Unicode(false)]
    public string? LicenseNo { get; set; }

    [Column("issue_date", TypeName = "datetime")]
    public DateTime? IssueDate { get; set; }

    [Column("owner_lincense_name")]
    [StringLength(200)]
    [Unicode(false)]
    public string? OwnerLincenseName { get; set; }

    [Column("id_no")]
    [StringLength(200)]
    [Unicode(false)]
    public string? IdNo { get; set; }

    [Column("violation_type")]
    [StringLength(200)]
    [Unicode(false)]
    public string? ViolationType { get; set; }

    [Column("manager_ame")]
    [StringLength(200)]
    [Unicode(false)]
    public string? ManagerAme { get; set; }

    [Column("national_1")]
    [StringLength(200)]
    [Unicode(false)]
    public string? National1 { get; set; }

    [Column("national_2")]
    [StringLength(200)]
    [Unicode(false)]
    public string? National2 { get; set; }

    [Column("national_id", TypeName = "decimal(18, 0)")]
    public decimal? NationalId { get; set; }

    [Column("manager_id_no")]
    [StringLength(200)]
    [Unicode(false)]
    public string? ManagerIdNo { get; set; }

    [Column("violation_name")]
    [StringLength(200)]
    [Unicode(false)]
    public string? ViolationName { get; set; }

    [Column("violation_id_no")]
    [StringLength(200)]
    [Unicode(false)]
    public string? ViolationIdNo { get; set; }

    [Column("decide_1")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Decide1 { get; set; }

    [Column("decide_2")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Decide2 { get; set; }

    [Column("sign_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? SignType { get; set; }

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
