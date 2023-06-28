using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("pafn_check_request")]
public partial class PafnCheckRequest
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

    [Column("request_staus")]
    [StringLength(1)]
    [Unicode(false)]
    public string? RequestStaus { get; set; }

    [Column("shop_name")]
    [StringLength(200)]
    [Unicode(false)]
    public string? ShopName { get; set; }

    [Column("comm_name")]
    [StringLength(200)]
    [Unicode(false)]
    public string? CommName { get; set; }

    [Column("company_license_no")]
    [StringLength(200)]
    [Unicode(false)]
    public string? CompanyLicenseNo { get; set; }

    [Column("area")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Area { get; set; }

    [Column("area_id", TypeName = "decimal(18, 0)")]
    public decimal? AreaId { get; set; }

    [Column("block")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Block { get; set; }

    [Column("qaseema")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Qaseema { get; set; }

    [Column("shop_no")]
    [StringLength(200)]
    [Unicode(false)]
    public string? ShopNo { get; set; }

    [Column("person_name")]
    [StringLength(200)]
    [Unicode(false)]
    public string? PersonName { get; set; }

    [Column("mobile")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Mobile { get; set; }

    [Column("request_date", TypeName = "datetime")]
    public DateTime? RequestDate { get; set; }

    [Column("request_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? RequestType { get; set; }

    [Column("emp_name")]
    [StringLength(200)]
    [Unicode(false)]
    public string? EmpName { get; set; }

    [Column("emp_no")]
    [StringLength(200)]
    [Unicode(false)]
    public string? EmpNo { get; set; }

    [Column("check_date", TypeName = "datetime")]
    public DateTime? CheckDate { get; set; }

    [Column("emp_id", TypeName = "decimal(18, 0)")]
    public decimal? EmpId { get; set; }

    [Column("active")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Active { get; set; }

    [Column("posted")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Posted { get; set; }

    [Column("user_post_id", TypeName = "decimal(18, 0)")]
    public decimal? UserPostId { get; set; }

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
