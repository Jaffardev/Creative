using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("pos_item")]
public partial class PosItem
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("item_id", TypeName = "decimal(18, 0)")]
    public decimal? ItemId { get; set; }

    [Column("row_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? RowType { get; set; }

    [Column("parent_id", TypeName = "decimal(18, 0)")]
    public decimal? ParentId { get; set; }

    [Column("photo_path")]
    [StringLength(255)]
    [Unicode(false)]
    public string? PhotoPath { get; set; }

    [Column("code")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("extrnal_code")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ExtrnalCode { get; set; }

    [Column("name_1")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Name1 { get; set; }

    [Column("name_2")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Name2 { get; set; }

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

    [Column("unit_price", TypeName = "decimal(18, 4)")]
    public decimal? UnitPrice { get; set; }

    [Column("item_cost", TypeName = "decimal(18, 5)")]
    public decimal? ItemCost { get; set; }

    [Column("item_order")]
    public int? ItemOrder { get; set; }

    [Column("chang_price")]
    public int? ChangPrice { get; set; }

    [Column("creation_by", TypeName = "decimal(18, 0)")]
    public decimal? CreationBy { get; set; }

    [Column("creation_date", TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    [Column("chang_by", TypeName = "decimal(18, 0)")]
    public decimal? ChangBy { get; set; }

    [Column("chang_date", TypeName = "datetime")]
    public DateTime? ChangDate { get; set; }

    [Column("notes")]
    [StringLength(255)]
    [Unicode(false)]
    public string? Notes { get; set; }

    [Column("qty", TypeName = "decimal(18, 3)")]
    public decimal? Qty { get; set; }

    [Column("cat_id", TypeName = "decimal(18, 3)")]
    public decimal? CatId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Carat { get; set; }

    [Column("class_id", TypeName = "decimal(18, 3)")]
    public decimal? ClassId { get; set; }

    [Column("color_id", TypeName = "decimal(18, 3)")]
    public decimal? ColorId { get; set; }

    [Column("cat_1")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Cat1 { get; set; }

    [Column("cat_2")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Cat2 { get; set; }

    [Column("cat_3")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Cat3 { get; set; }

    [Column("cat_4")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Cat4 { get; set; }

    [Column("cat_5")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Cat5 { get; set; }

    [Column("inv_item_matrix")]
    [StringLength(1)]
    [Unicode(false)]
    public string? InvItemMatrix { get; set; }

    [Column("matrix_id", TypeName = "decimal(18, 0)")]
    public decimal? MatrixId { get; set; }
}
