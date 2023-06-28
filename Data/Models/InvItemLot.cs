using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("inv_item_lot")]
public partial class InvItemLot
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("code")]
    [StringLength(15)]
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

    [Column("row_status")]
    [StringLength(1)]
    [Unicode(false)]
    public string? RowStatus { get; set; }

    [Column("item_id", TypeName = "decimal(18, 0)")]
    public decimal? ItemId { get; set; }

    [Column("unit_id", TypeName = "decimal(18, 0)")]
    public decimal? UnitId { get; set; }

    [Column("trans_date", TypeName = "datetime")]
    public DateTime? TransDate { get; set; }

    [Column("doc_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? DocNo { get; set; }

    [Column("doc_date", TypeName = "datetime")]
    public DateTime? DocDate { get; set; }

    [Column("received_date", TypeName = "datetime")]
    public DateTime? ReceivedDate { get; set; }

    [Column("expier_date", TypeName = "datetime")]
    public DateTime? ExpierDate { get; set; }

    [Column("order_date", TypeName = "datetime")]
    public DateTime? OrderDate { get; set; }

    [Column("delivery_date", TypeName = "datetime")]
    public DateTime? DeliveryDate { get; set; }

    [Column("vendor_id", TypeName = "decimal(18, 0)")]
    public decimal? VendorId { get; set; }

    [Column("vendor_name")]
    [StringLength(100)]
    [Unicode(false)]
    public string? VendorName { get; set; }

    [Column("batch_no")]
    [StringLength(100)]
    [Unicode(false)]
    public string? BatchNo { get; set; }

    [Column("is_contenar")]
    [StringLength(1)]
    [Unicode(false)]
    public string? IsContenar { get; set; }

    [Column("unit_conv", TypeName = "decimal(18, 5)")]
    public decimal? UnitConv { get; set; }

    [Column("qty", TypeName = "decimal(18, 3)")]
    public decimal? Qty { get; set; }

    [Column("qty_in", TypeName = "decimal(18, 3)")]
    public decimal? QtyIn { get; set; }

    [Column("qty_out", TypeName = "decimal(18, 3)")]
    public decimal? QtyOut { get; set; }

    [Column("qty_allocat", TypeName = "decimal(18, 3)")]
    public decimal? QtyAllocat { get; set; }

    [Column("qty_onhand", TypeName = "decimal(18, 3)")]
    public decimal? QtyOnhand { get; set; }

    [Column("pur_amount", TypeName = "decimal(18, 3)")]
    public decimal? PurAmount { get; set; }

    [Column("cost_amount", TypeName = "decimal(18, 3)")]
    public decimal? CostAmount { get; set; }

    [Column("price", TypeName = "decimal(18, 3)")]
    public decimal? Price { get; set; }

    [Column("inv_qty", TypeName = "decimal(18, 3)")]
    public decimal? InvQty { get; set; }

    [Column("inv_main_qty", TypeName = "decimal(18, 3)")]
    public decimal? InvMainQty { get; set; }

    [Column("active")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Active { get; set; }

    [Column("description")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Description { get; set; }

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
