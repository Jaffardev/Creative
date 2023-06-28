using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("rman_company")]
public partial class RmanCompany
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

    [Column("group_id")]
    [StringLength(50)]
    [Unicode(false)]
    public string? GroupId { get; set; }

    [Column("address")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Address { get; set; }

    [Column("email")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Email { get; set; }

    [Column("web_site")]
    [StringLength(200)]
    [Unicode(false)]
    public string? WebSite { get; set; }

    [Column("tel_1")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Tel1 { get; set; }

    [Column("tel_2")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Tel2 { get; set; }

    [Column("fax")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Fax { get; set; }

    [Column("agent_sign")]
    [StringLength(100)]
    [Unicode(false)]
    public string? AgentSign { get; set; }

    [Column("acc_id", TypeName = "decimal(18, 0)")]
    public decimal? AccId { get; set; }

    [Column("cost_id", TypeName = "decimal(18, 0)")]
    public decimal? CostId { get; set; }

    [Column("exp_id", TypeName = "decimal(18, 0)")]
    public decimal? ExpId { get; set; }

    [Column("analysis_id", TypeName = "decimal(18, 0)")]
    public decimal? AnalysisId { get; set; }

    [Column("other_1")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Other1 { get; set; }

    [Column("other_2")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Other2 { get; set; }

    [Column("other_3")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Other3 { get; set; }

    [Column("other_4")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Other4 { get; set; }

    [Column("photo_1")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Photo1 { get; set; }

    [Column("photo_2")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Photo2 { get; set; }

    [Column("photo_3")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Photo3 { get; set; }

    [Column("photo_4")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Photo4 { get; set; }

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
