using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("inv_trans_matrix")]
public partial class InvTransMatrix
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("h_id", TypeName = "decimal(18, 0)")]
    public decimal? HId { get; set; }

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

    [Column("matrix_id", TypeName = "decimal(18, 0)")]
    public decimal? MatrixId { get; set; }

    [Column("cat_matrix_id_1", TypeName = "decimal(18, 0)")]
    public decimal? CatMatrixId1 { get; set; }

    [Column("alow_")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Alow { get; set; }

    [Column("item_id_", TypeName = "decimal(18, 0)")]
    public decimal? ItemId { get; set; }

    [Column("cat_matrix_id_2", TypeName = "decimal(18, 0)")]
    public decimal? CatMatrixId2 { get; set; }

    [Column("qty_", TypeName = "decimal(18, 3)")]
    public decimal? Qty { get; set; }

    [Column("alow_1")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Alow1 { get; set; }

    [Column("item_id_1", TypeName = "decimal(18, 0)")]
    public decimal? ItemId1 { get; set; }

    [Column("cat_matrix_id_21", TypeName = "decimal(18, 0)")]
    public decimal? CatMatrixId21 { get; set; }

    [Column("qty_1", TypeName = "decimal(18, 3)")]
    public decimal? Qty1 { get; set; }

    [Column("alow_2")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Alow2 { get; set; }

    [Column("item_id_2", TypeName = "decimal(18, 0)")]
    public decimal? ItemId2 { get; set; }

    [Column("cat_matrix_id_22", TypeName = "decimal(18, 0)")]
    public decimal? CatMatrixId22 { get; set; }

    [Column("qty_2", TypeName = "decimal(18, 3)")]
    public decimal? Qty2 { get; set; }

    [Column("alow_3")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Alow3 { get; set; }

    [Column("item_id_3", TypeName = "decimal(18, 0)")]
    public decimal? ItemId3 { get; set; }

    [Column("cat_matrix_id_23", TypeName = "decimal(18, 0)")]
    public decimal? CatMatrixId23 { get; set; }

    [Column("qty_3", TypeName = "decimal(18, 3)")]
    public decimal? Qty3 { get; set; }

    [Column("alow_4")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Alow4 { get; set; }

    [Column("item_id_4", TypeName = "decimal(18, 0)")]
    public decimal? ItemId4 { get; set; }

    [Column("cat_matrix_id_24", TypeName = "decimal(18, 0)")]
    public decimal? CatMatrixId24 { get; set; }

    [Column("qty_4", TypeName = "decimal(18, 3)")]
    public decimal? Qty4 { get; set; }

    [Column("alow_5")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Alow5 { get; set; }

    [Column("item_id_5", TypeName = "decimal(18, 0)")]
    public decimal? ItemId5 { get; set; }

    [Column("cat_matrix_id_25", TypeName = "decimal(18, 0)")]
    public decimal? CatMatrixId25 { get; set; }

    [Column("qty_5", TypeName = "decimal(18, 3)")]
    public decimal? Qty5 { get; set; }

    [Column("alow_6")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Alow6 { get; set; }

    [Column("item_id_6", TypeName = "decimal(18, 0)")]
    public decimal? ItemId6 { get; set; }

    [Column("cat_matrix_id_26", TypeName = "decimal(18, 0)")]
    public decimal? CatMatrixId26 { get; set; }

    [Column("qty_6", TypeName = "decimal(18, 3)")]
    public decimal? Qty6 { get; set; }

    [Column("alow_7")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Alow7 { get; set; }

    [Column("item_id_7", TypeName = "decimal(18, 0)")]
    public decimal? ItemId7 { get; set; }

    [Column("cat_matrix_id_27", TypeName = "decimal(18, 0)")]
    public decimal? CatMatrixId27 { get; set; }

    [Column("qty_7", TypeName = "decimal(18, 3)")]
    public decimal? Qty7 { get; set; }

    [Column("alow_8")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Alow8 { get; set; }

    [Column("item_id_8", TypeName = "decimal(18, 0)")]
    public decimal? ItemId8 { get; set; }

    [Column("cat_matrix_id_28", TypeName = "decimal(18, 0)")]
    public decimal? CatMatrixId28 { get; set; }

    [Column("qty_8", TypeName = "decimal(18, 3)")]
    public decimal? Qty8 { get; set; }

    [Column("alow_9")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Alow9 { get; set; }

    [Column("item_id_9", TypeName = "decimal(18, 0)")]
    public decimal? ItemId9 { get; set; }

    [Column("cat_matrix_id_29", TypeName = "decimal(18, 0)")]
    public decimal? CatMatrixId29 { get; set; }

    [Column("qty_9", TypeName = "decimal(18, 3)")]
    public decimal? Qty9 { get; set; }

    [Column("alow_10")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Alow10 { get; set; }

    [Column("item_id_10", TypeName = "decimal(18, 0)")]
    public decimal? ItemId10 { get; set; }

    [Column("cat_matrix_id_210", TypeName = "decimal(18, 0)")]
    public decimal? CatMatrixId210 { get; set; }

    [Column("qty_10", TypeName = "decimal(18, 3)")]
    public decimal? Qty10 { get; set; }

    [Column("alow_11")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Alow11 { get; set; }

    [Column("item_id_11", TypeName = "decimal(18, 0)")]
    public decimal? ItemId11 { get; set; }

    [Column("cat_matrix_id_211", TypeName = "decimal(18, 0)")]
    public decimal? CatMatrixId211 { get; set; }

    [Column("qty_11", TypeName = "decimal(18, 3)")]
    public decimal? Qty11 { get; set; }

    [Column("alow_12")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Alow12 { get; set; }

    [Column("item_id_12", TypeName = "decimal(18, 0)")]
    public decimal? ItemId12 { get; set; }

    [Column("cat_matrix_id_212", TypeName = "decimal(18, 0)")]
    public decimal? CatMatrixId212 { get; set; }

    [Column("qty_12", TypeName = "decimal(18, 3)")]
    public decimal? Qty12 { get; set; }

    [Column("alow_13")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Alow13 { get; set; }

    [Column("item_id_13", TypeName = "decimal(18, 0)")]
    public decimal? ItemId13 { get; set; }

    [Column("cat_matrix_id_213", TypeName = "decimal(18, 0)")]
    public decimal? CatMatrixId213 { get; set; }

    [Column("qty_13", TypeName = "decimal(18, 3)")]
    public decimal? Qty13 { get; set; }

    [Column("alow_14")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Alow14 { get; set; }

    [Column("item_id_14", TypeName = "decimal(18, 0)")]
    public decimal? ItemId14 { get; set; }

    [Column("cat_matrix_id_214", TypeName = "decimal(18, 0)")]
    public decimal? CatMatrixId214 { get; set; }

    [Column("qty_14", TypeName = "decimal(18, 3)")]
    public decimal? Qty14 { get; set; }

    [Column("alow_15")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Alow15 { get; set; }

    [Column("item_id_15", TypeName = "decimal(18, 0)")]
    public decimal? ItemId15 { get; set; }

    [Column("cat_matrix_id_215", TypeName = "decimal(18, 0)")]
    public decimal? CatMatrixId215 { get; set; }

    [Column("qty_15", TypeName = "decimal(18, 3)")]
    public decimal? Qty15 { get; set; }

    [Column("alow_16")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Alow16 { get; set; }

    [Column("item_id_16", TypeName = "decimal(18, 0)")]
    public decimal? ItemId16 { get; set; }

    [Column("cat_matrix_id_216", TypeName = "decimal(18, 0)")]
    public decimal? CatMatrixId216 { get; set; }

    [Column("qty_16", TypeName = "decimal(18, 3)")]
    public decimal? Qty16 { get; set; }

    [Column("alow_17")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Alow17 { get; set; }

    [Column("item_id_17", TypeName = "decimal(18, 0)")]
    public decimal? ItemId17 { get; set; }

    [Column("cat_matrix_id_217", TypeName = "decimal(18, 0)")]
    public decimal? CatMatrixId217 { get; set; }

    [Column("qty_17", TypeName = "decimal(18, 3)")]
    public decimal? Qty17 { get; set; }

    [Column("alow_18")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Alow18 { get; set; }

    [Column("item_id_18", TypeName = "decimal(18, 0)")]
    public decimal? ItemId18 { get; set; }

    [Column("cat_matrix_id_218", TypeName = "decimal(18, 0)")]
    public decimal? CatMatrixId218 { get; set; }

    [Column("qty_18", TypeName = "decimal(18, 3)")]
    public decimal? Qty18 { get; set; }

    [Column("alow_19")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Alow19 { get; set; }

    [Column("item_id_19", TypeName = "decimal(18, 0)")]
    public decimal? ItemId19 { get; set; }

    [Column("cat_matrix_id_219", TypeName = "decimal(18, 0)")]
    public decimal? CatMatrixId219 { get; set; }

    [Column("qty_19", TypeName = "decimal(18, 3)")]
    public decimal? Qty19 { get; set; }

    [Column("alow_20")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Alow20 { get; set; }

    [Column("item_id_20", TypeName = "decimal(18, 0)")]
    public decimal? ItemId20 { get; set; }

    [Column("cat_matrix_id_220", TypeName = "decimal(18, 0)")]
    public decimal? CatMatrixId220 { get; set; }

    [Column("qty_20", TypeName = "decimal(18, 3)")]
    public decimal? Qty20 { get; set; }

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
