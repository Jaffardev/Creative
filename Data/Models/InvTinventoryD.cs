using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("inv_tinventory_d")]
public partial class InvTinventoryD
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("h_id", TypeName = "decimal(18, 0)")]
    public decimal? HId { get; set; }

    [Column("trans_date", TypeName = "datetime")]
    public DateTime? TransDate { get; set; }

    [Column("doc_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? DocNo { get; set; }

    [Column("doc_date", TypeName = "datetime")]
    public DateTime? DocDate { get; set; }

    [Column("more_whs")]
    [StringLength(1)]
    [Unicode(false)]
    public string? MoreWhs { get; set; }

    [Column("whs_id", TypeName = "decimal(18, 0)")]
    public decimal? WhsId { get; set; }

    [Column("whs_code")]
    [StringLength(20)]
    [Unicode(false)]
    public string? WhsCode { get; set; }

    [Column("qty_balance", TypeName = "decimal(18, 3)")]
    public decimal? QtyBalance { get; set; }

    [Column("qty_inventory", TypeName = "decimal(18, 3)")]
    public decimal? QtyInventory { get; set; }

    [Column("qty", TypeName = "decimal(18, 4)")]
    public decimal? Qty { get; set; }

    [Column("item_id", TypeName = "decimal(18, 0)")]
    public decimal? ItemId { get; set; }

    [Column("unit_id", TypeName = "decimal(18, 0)")]
    public decimal? UnitId { get; set; }

    [Column("unit_conv", TypeName = "decimal(18, 5)")]
    public decimal? UnitConv { get; set; }

    [Column("cost_amount", TypeName = "decimal(18, 5)")]
    public decimal? CostAmount { get; set; }

    [Column("lot_no", TypeName = "decimal(18, 0)")]
    public decimal? LotNo { get; set; }

    [Column("expier_date", TypeName = "datetime")]
    public DateTime? ExpierDate { get; set; }

    [Column("batch_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? BatchNo { get; set; }

    [Column("is_lot")]
    [StringLength(1)]
    [Unicode(false)]
    public string? IsLot { get; set; }

    [Column("is_contenar")]
    [StringLength(1)]
    [Unicode(false)]
    public string? IsContenar { get; set; }

    [Column("is_sec")]
    [StringLength(1)]
    [Unicode(false)]
    public string? IsSec { get; set; }

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

    [Column("posted")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Posted { get; set; }
}
