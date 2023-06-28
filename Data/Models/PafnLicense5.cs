using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("pafn_license_5")]
public partial class PafnLicense5
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

    [Column("sample_no")]
    [StringLength(200)]
    [Unicode(false)]
    public string? SampleNo { get; set; }

    [Column("trans_date", TypeName = "datetime")]
    public DateTime? TransDate { get; set; }

    [Column("sample_sending")]
    [StringLength(200)]
    [Unicode(false)]
    public string? SampleSending { get; set; }

    [Column("sample_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? SampleType { get; set; }

    [Column("address")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Address { get; set; }

    [Column("drawn_sample_no")]
    [StringLength(200)]
    [Unicode(false)]
    public string? DrawnSampleNo { get; set; }

    [Column("drawn_sample_weight")]
    [StringLength(200)]
    [Unicode(false)]
    public string? DrawnSampleWeight { get; set; }

    [Column("taken_sample_status")]
    [StringLength(200)]
    [Unicode(false)]
    public string? TakenSampleStatus { get; set; }

    [Column("goods_taken_no")]
    [StringLength(200)]
    [Unicode(false)]
    public string? GoodsTakenNo { get; set; }

    [Column("description")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Description { get; set; }

    [Column("product_date", TypeName = "datetime")]
    public DateTime? ProductDate { get; set; }

    [Column("expire_date", TypeName = "datetime")]
    public DateTime? ExpireDate { get; set; }

    [Column("other_data")]
    [StringLength(200)]
    [Unicode(false)]
    public string? OtherData { get; set; }

    [Column("anaylsis_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AnaylsisType { get; set; }

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
