using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("Inv_Warehouse")]
public partial class InvWarehouse
{
    [Key]
    [Column("ID", TypeName = "decimal(18, 0)")]
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

    [Column("acc_inv_id", TypeName = "decimal(18, 0)")]
    public decimal? AccInvId { get; set; }

    [Column("acc_pur_id", TypeName = "decimal(18, 0)")]
    public decimal? AccPurId { get; set; }

    [Column("acc_sal_id", TypeName = "decimal(18, 0)")]
    public decimal? AccSalId { get; set; }

    [Column("acc_sal_cost_id", TypeName = "decimal(18, 0)")]
    public decimal? AccSalCostId { get; set; }

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

    [Column("address")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Address { get; set; }

    [Column("manger")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Manger { get; set; }

    [Column("costed")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Costed { get; set; }

    [Column("carog")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Carog { get; set; }

    [Column("netable")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Netable { get; set; }

    [Column("allocated")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Allocated { get; set; }

    [Column("planing")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Planing { get; set; }

    [Column("serialize")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Serialize { get; set; }

    [Column("resio", TypeName = "decimal(18, 5)")]
    public decimal? Resio { get; set; }

    [Column("max_qty", TypeName = "decimal(18, 3)")]
    public decimal? MaxQty { get; set; }

    [Column("unit_id", TypeName = "decimal(18, 0)")]
    public decimal? UnitId { get; set; }

    [Column("max_valum", TypeName = "decimal(18, 3)")]
    public decimal? MaxValum { get; set; }

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

    [Column("acc_sfc_id", TypeName = "decimal(18, 0)")]
    public decimal? AccSfcId { get; set; }

    [Column("acc_sfc_cost_id", TypeName = "decimal(18, 0)")]
    public decimal? AccSfcCostId { get; set; }

    [Column("cost_id", TypeName = "decimal(18, 0)")]
    public decimal? CostId { get; set; }

    [Column("exp_id", TypeName = "decimal(18, 0)")]
    public decimal? ExpId { get; set; }

    [Column("analysis_id", TypeName = "decimal(18, 0)")]
    public decimal? AnalysisId { get; set; }
}
