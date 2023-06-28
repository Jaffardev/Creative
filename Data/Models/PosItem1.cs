using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("pos_items")]
public partial class PosItem1
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("code")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("item_id", TypeName = "decimal(18, 0)")]
    public decimal? ItemId { get; set; }

    [Column("row_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? RowType { get; set; }

    [Column("parent_id", TypeName = "decimal(18, 0)")]
    public decimal? ParentId { get; set; }

    [Column("photo_path")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? PhotoPath { get; set; }

    [Column("extrnal_code")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ExtrnalCode { get; set; }

    [Column("pur_unit_id", TypeName = "decimal(18, 0)")]
    public decimal? PurUnitId { get; set; }

    [Column("inv_unit_id", TypeName = "decimal(18, 0)")]
    public decimal? InvUnitId { get; set; }

    [Column("sel_unit", TypeName = "decimal(18, 0)")]
    public decimal? SelUnit { get; set; }

    [Column("pur_retio", TypeName = "decimal(18, 5)")]
    public decimal? PurRetio { get; set; }

    [Column("sel_retio", TypeName = "decimal(18, 5)")]
    public decimal? SelRetio { get; set; }

    [Column("unit_price", TypeName = "decimal(18, 3)")]
    public decimal? UnitPrice { get; set; }

    [Column("item_cost", TypeName = "decimal(18, 5)")]
    public decimal? ItemCost { get; set; }

    [Column("item_order", TypeName = "decimal(10, 0)")]
    public decimal? ItemOrder { get; set; }

    [Column("chang_price", TypeName = "decimal(10, 0)")]
    public decimal? ChangPrice { get; set; }

    [Column("price_1", TypeName = "decimal(18, 3)")]
    public decimal? Price1 { get; set; }

    [Column("price_2", TypeName = "decimal(18, 3)")]
    public decimal? Price2 { get; set; }

    [Column("price_3", TypeName = "decimal(18, 3)")]
    public decimal? Price3 { get; set; }

    [Column("price_4", TypeName = "decimal(18, 3)")]
    public decimal? Price4 { get; set; }

    [Column("name_1")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Name1 { get; set; }

    [Column("name_2")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Name2 { get; set; }

    [Column("notes")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes { get; set; }

    [Column("active")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Active { get; set; }

    [Column("modify_by", TypeName = "decimal(18, 0)")]
    public decimal? ModifyBy { get; set; }

    [Column("modify_date", TypeName = "datetime")]
    public DateTime? ModifyDate { get; set; }

    [Column("creation_by", TypeName = "decimal(18, 0)")]
    public decimal? CreationBy { get; set; }

    [Column("creation_date", TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    [Column("name_rep_1")]
    [StringLength(50)]
    [Unicode(false)]
    public string? NameRep1 { get; set; }

    [Column("name_rep_2")]
    [StringLength(50)]
    [Unicode(false)]
    public string? NameRep2 { get; set; }

    [Column("name_kechen_1")]
    [StringLength(50)]
    [Unicode(false)]
    public string? NameKechen1 { get; set; }

    [Column("name_kechen_2")]
    [StringLength(50)]
    [Unicode(false)]
    public string? NameKechen2 { get; set; }

    [Column("name_screen_1")]
    [StringLength(50)]
    [Unicode(false)]
    public string? NameScreen1 { get; set; }

    [Column("name_screen_2")]
    [StringLength(50)]
    [Unicode(false)]
    public string? NameScreen2 { get; set; }

    [Column("name_invoice_1")]
    [StringLength(50)]
    [Unicode(false)]
    public string? NameInvoice1 { get; set; }

    [Column("name__invoice_2")]
    [StringLength(50)]
    [Unicode(false)]
    public string? NameInvoice2 { get; set; }

    [Column("cook_time", TypeName = "datetime")]
    public DateTime? CookTime { get; set; }

    [Column("pos_item_type")]
    [StringLength(50)]
    [Unicode(false)]
    public string? PosItemType { get; set; }

    [Column("pos_item_id", TypeName = "decimal(18, 0)")]
    public decimal? PosItemId { get; set; }
}
