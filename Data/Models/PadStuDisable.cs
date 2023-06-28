using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("pad_stu_disable")]
public partial class PadStuDisable
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("stu_id", TypeName = "decimal(18, 0)")]
    public decimal? StuId { get; set; }

    [Column("year_id", TypeName = "decimal(18, 0)")]
    public decimal? YearId { get; set; }

    [Column("disable_id")]
    [StringLength(10)]
    public string? DisableId { get; set; }

    [Column("decision_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? DecisionType { get; set; }

    [Column("disable_no")]
    [StringLength(100)]
    [Unicode(false)]
    public string? DisableNo { get; set; }

    [Column("disable_date", TypeName = "datetime")]
    public DateTime? DisableDate { get; set; }

    [Column("disable_end_date", TypeName = "datetime")]
    public DateTime? DisableEndDate { get; set; }

    [Column("next_visit_date", TypeName = "datetime")]
    public DateTime? NextVisitDate { get; set; }

    [Column("intellegent_ratio", TypeName = "decimal(18, 3)")]
    public decimal? IntellegentRatio { get; set; }

    [Column("disable_certif_id", TypeName = "decimal(18, 0)")]
    public decimal? DisableCertifId { get; set; }

    [Column("disable_certif_no")]
    [StringLength(100)]
    [Unicode(false)]
    public string? DisableCertifNo { get; set; }

    [Column("disable_certif_date", TypeName = "datetime")]
    public DateTime? DisableCertifDate { get; set; }

    [Column("disable_certif_end_date", TypeName = "datetime")]
    public DateTime? DisableCertifEndDate { get; set; }

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

    [Column("reg_date", TypeName = "datetime")]
    public DateTime? RegDate { get; set; }

    [Column("join_date", TypeName = "datetime")]
    public DateTime? JoinDate { get; set; }

    [Column("registed_end_date", TypeName = "datetime")]
    public DateTime? RegistedEndDate { get; set; }
}
