using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("posr_item")]
public partial class PosrItem
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

    [Column("item_id", TypeName = "decimal(18, 0)")]
    public decimal? ItemId { get; set; }

    [Column("row_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? RowType { get; set; }

    [Column("parent_id", TypeName = "decimal(18, 0)")]
    public decimal? ParentId { get; set; }

    [Column("last_level")]
    [StringLength(1)]
    [Unicode(false)]
    public string? LastLevel { get; set; }

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

    [Column("name_order_1")]
    [StringLength(50)]
    [Unicode(false)]
    public string? NameOrder1 { get; set; }

    [Column("name_order_2")]
    [StringLength(50)]
    [Unicode(false)]
    public string? NameOrder2 { get; set; }

    [Column("name_kitchen_1")]
    [StringLength(50)]
    [Unicode(false)]
    public string? NameKitchen1 { get; set; }

    [Column("name_kitchen_2")]
    [StringLength(50)]
    [Unicode(false)]
    public string? NameKitchen2 { get; set; }

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

    [Column("name_invoice_2")]
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

    [Column("color_red")]
    public int? ColorRed { get; set; }

    [Column("color_green")]
    public int? ColorGreen { get; set; }

    [Column("color_blue")]
    public int? ColorBlue { get; set; }

    [Column("color", TypeName = "decimal(18, 0)")]
    public decimal? Color { get; set; }

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

    [Column("print_ord_1")]
    [StringLength(1)]
    [Unicode(false)]
    public string? PrintOrd1 { get; set; }

    [Column("print_ord_2")]
    [StringLength(1)]
    [Unicode(false)]
    public string? PrintOrd2 { get; set; }

    [Column("print_ord_3")]
    [StringLength(1)]
    [Unicode(false)]
    public string? PrintOrd3 { get; set; }

    [Column("print_ord_4")]
    [StringLength(1)]
    [Unicode(false)]
    public string? PrintOrd4 { get; set; }

    [Column("print_ord_5")]
    [StringLength(1)]
    [Unicode(false)]
    public string? PrintOrd5 { get; set; }

    [Column("print_inv_1")]
    [StringLength(1)]
    [Unicode(false)]
    public string? PrintInv1 { get; set; }

    [Column("print_inv_2")]
    [StringLength(1)]
    [Unicode(false)]
    public string? PrintInv2 { get; set; }

    [Column("print_inv_3")]
    [StringLength(1)]
    [Unicode(false)]
    public string? PrintInv3 { get; set; }

    [Column("print_inv_4")]
    [StringLength(1)]
    [Unicode(false)]
    public string? PrintInv4 { get; set; }

    [Column("print_inv_5")]
    [StringLength(1)]
    [Unicode(false)]
    public string? PrintInv5 { get; set; }

    [Column("print_ord_6")]
    [StringLength(1)]
    [Unicode(false)]
    public string? PrintOrd6 { get; set; }

    [Column("print_ord_7")]
    [StringLength(1)]
    [Unicode(false)]
    public string? PrintOrd7 { get; set; }

    [Column("print_ord_8")]
    [StringLength(1)]
    [Unicode(false)]
    public string? PrintOrd8 { get; set; }

    [Column("print_ord_9")]
    [StringLength(1)]
    [Unicode(false)]
    public string? PrintOrd9 { get; set; }

    [Column("print_ord_10")]
    [StringLength(1)]
    [Unicode(false)]
    public string? PrintOrd10 { get; set; }

    [Column("print_inv_6")]
    [StringLength(1)]
    [Unicode(false)]
    public string? PrintInv6 { get; set; }

    [Column("print_inv_7")]
    [StringLength(1)]
    [Unicode(false)]
    public string? PrintInv7 { get; set; }

    [Column("print_inv_8")]
    [StringLength(1)]
    [Unicode(false)]
    public string? PrintInv8 { get; set; }

    [Column("print_inv_9")]
    [StringLength(1)]
    [Unicode(false)]
    public string? PrintInv9 { get; set; }

    [Column("print_inv_10")]
    [StringLength(1)]
    [Unicode(false)]
    public string? PrintInv10 { get; set; }

    [Column("Level_no")]
    public int? LevelNo { get; set; }

    [Column("Long_code")]
    [StringLength(255)]
    [Unicode(false)]
    public string? LongCode { get; set; }
}
