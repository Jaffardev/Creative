using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("posr_table")]
public partial class PosrTable
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

    [Column("branch_id", TypeName = "decimal(18, 0)")]
    public decimal? BranchId { get; set; }

    [Column("section_id")]
    [StringLength(10)]
    [Unicode(false)]
    public string? SectionId { get; set; }

    [Column("disc_retio", TypeName = "decimal(18, 3)")]
    public decimal? DiscRetio { get; set; }

    [Column("disc_amount", TypeName = "decimal(18, 3)")]
    public decimal? DiscAmount { get; set; }

    [Column("serv_ratio", TypeName = "decimal(18, 3)")]
    public decimal? ServRatio { get; set; }

    [Column("serv_amount", TypeName = "decimal(18, 3)")]
    public decimal? ServAmount { get; set; }

    [Column("chair_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ChairNo { get; set; }

    [Column("row_status")]
    [StringLength(1)]
    [Unicode(false)]
    public string? RowStatus { get; set; }

    [Column("smoking")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Smoking { get; set; }

    [Column("allow_resvd")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AllowResvd { get; set; }

    [Column("loc_x", TypeName = "decimal(18, 0)")]
    public decimal? LocX { get; set; }

    [Column("loc_y", TypeName = "decimal(18, 0)")]
    public decimal? LocY { get; set; }

    [Column("loc_w", TypeName = "decimal(18, 0)")]
    public decimal? LocW { get; set; }

    [Column("loc_h", TypeName = "decimal(18, 0)")]
    public decimal? LocH { get; set; }

    [Column("active")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Active { get; set; }

    [Column("acc_id", TypeName = "decimal(18, 0)")]
    public decimal? AccId { get; set; }

    [Column("cost_id", TypeName = "decimal(18, 0)")]
    public decimal? CostId { get; set; }

    [Column("exp_id", TypeName = "decimal(18, 0)")]
    public decimal? ExpId { get; set; }

    [Column("analysis_id", TypeName = "decimal(18, 0)")]
    public decimal? AnalysisId { get; set; }

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
