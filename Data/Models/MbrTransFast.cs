using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("mbr_trans_fast")]
public partial class MbrTransFast
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("code")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("trans_date", TypeName = "datetime")]
    public DateTime? TransDate { get; set; }

    [Column("requst_date", TypeName = "datetime")]
    public DateTime? RequstDate { get; set; }

    [Column("recived_date", TypeName = "datetime")]
    public DateTime? RecivedDate { get; set; }

    [Column("telmarket_id", TypeName = "decimal(18, 0)")]
    public decimal? TelmarketId { get; set; }

    [Column("cust_id", TypeName = "decimal(18, 0)")]
    public decimal? CustId { get; set; }

    [Column("cust_code")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CustCode { get; set; }

    [Column("cust_name")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CustName { get; set; }

    [Column("tel_1")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Tel1 { get; set; }

    [Column("tel_2")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Tel2 { get; set; }

    [Column("gover_id", TypeName = "decimal(18, 0)")]
    public decimal? GoverId { get; set; }

    [Column("area_id", TypeName = "decimal(18, 0)")]
    public decimal? AreaId { get; set; }

    [Column("part_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? PartNo { get; set; }

    [Column("streat")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Streat { get; set; }

    [Column("gada")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Gada { get; set; }

    [Column("bulding")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Bulding { get; set; }

    [Column("house")]
    [StringLength(50)]
    [Unicode(false)]
    public string? House { get; set; }

    [Column("driver_id", TypeName = "decimal(18, 0)")]
    public decimal? DriverId { get; set; }

    [Column("row_status")]
    [StringLength(1)]
    [Unicode(false)]
    public string? RowStatus { get; set; }

    [Column("active")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Active { get; set; }

    [Column("notes")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes { get; set; }

    [Column("amount_add", TypeName = "decimal(18, 3)")]
    public decimal? AmountAdd { get; set; }

    [Column("amount_sub", TypeName = "decimal(18, 3)")]
    public decimal? AmountSub { get; set; }

    [Column("item_id_1", TypeName = "decimal(18, 0)")]
    public decimal? ItemId1 { get; set; }

    [Column("qty_1", TypeName = "decimal(18, 3)")]
    public decimal? Qty1 { get; set; }

    [Column("item_id_2", TypeName = "decimal(18, 0)")]
    public decimal? ItemId2 { get; set; }

    [Column("qty_2", TypeName = "decimal(18, 3)")]
    public decimal? Qty2 { get; set; }

    [Column("item_id_3", TypeName = "decimal(18, 0)")]
    public decimal? ItemId3 { get; set; }

    [Column("qty_3", TypeName = "decimal(18, 3)")]
    public decimal? Qty3 { get; set; }

    [Column("item_id_4", TypeName = "decimal(18, 0)")]
    public decimal? ItemId4 { get; set; }

    [Column("qty_4", TypeName = "decimal(18, 3)")]
    public decimal? Qty4 { get; set; }

    [Column("item_id_5", TypeName = "decimal(18, 0)")]
    public decimal? ItemId5 { get; set; }

    [Column("qty_5", TypeName = "decimal(18, 3)")]
    public decimal? Qty5 { get; set; }

    [Column("item_id_6", TypeName = "decimal(18, 0)")]
    public decimal? ItemId6 { get; set; }

    [Column("qty_6", TypeName = "decimal(18, 3)")]
    public decimal? Qty6 { get; set; }

    [Column("item_id_7", TypeName = "decimal(18, 0)")]
    public decimal? ItemId7 { get; set; }

    [Column("qty_7", TypeName = "decimal(18, 3)")]
    public decimal? Qty7 { get; set; }

    [Column("item_id_8", TypeName = "decimal(18, 0)")]
    public decimal? ItemId8 { get; set; }

    [Column("qty_8", TypeName = "decimal(18, 3)")]
    public decimal? Qty8 { get; set; }

    [Column("item_id_9", TypeName = "decimal(18, 0)")]
    public decimal? ItemId9 { get; set; }

    [Column("qty_9", TypeName = "decimal(18, 3)")]
    public decimal? Qty9 { get; set; }

    [Column("item_id_10", TypeName = "decimal(18, 0)")]
    public decimal? ItemId10 { get; set; }

    [Column("qty_10", TypeName = "decimal(18, 3)")]
    public decimal? Qty10 { get; set; }

    [Column("item_id_11", TypeName = "decimal(18, 0)")]
    public decimal? ItemId11 { get; set; }

    [Column("qty_11", TypeName = "decimal(18, 3)")]
    public decimal? Qty11 { get; set; }

    [Column("item_id_12", TypeName = "decimal(18, 0)")]
    public decimal? ItemId12 { get; set; }

    [Column("qty_12", TypeName = "decimal(18, 3)")]
    public decimal? Qty12 { get; set; }

    [Column("item_id_13", TypeName = "decimal(18, 0)")]
    public decimal? ItemId13 { get; set; }

    [Column("qty_13", TypeName = "decimal(18, 3)")]
    public decimal? Qty13 { get; set; }

    [Column("item_id_14", TypeName = "decimal(18, 0)")]
    public decimal? ItemId14 { get; set; }

    [Column("qty_14", TypeName = "decimal(18, 3)")]
    public decimal? Qty14 { get; set; }

    [Column("item_id_15", TypeName = "decimal(18, 0)")]
    public decimal? ItemId15 { get; set; }

    [Column("qty_15", TypeName = "decimal(18, 3)")]
    public decimal? Qty15 { get; set; }

    [Column("item_id_16", TypeName = "decimal(18, 0)")]
    public decimal? ItemId16 { get; set; }

    [Column("qty_16", TypeName = "decimal(18, 3)")]
    public decimal? Qty16 { get; set; }

    [Column("item_id_17", TypeName = "decimal(18, 0)")]
    public decimal? ItemId17 { get; set; }

    [Column("qty_17", TypeName = "decimal(18, 3)")]
    public decimal? Qty17 { get; set; }

    [Column("item_id_18", TypeName = "decimal(18, 0)")]
    public decimal? ItemId18 { get; set; }

    [Column("qty_18", TypeName = "decimal(18, 3)")]
    public decimal? Qty18 { get; set; }

    [Column("item_id_19", TypeName = "decimal(18, 0)")]
    public decimal? ItemId19 { get; set; }

    [Column("qty_19", TypeName = "decimal(18, 3)")]
    public decimal? Qty19 { get; set; }

    [Column("item_id_20", TypeName = "decimal(18, 0)")]
    public decimal? ItemId20 { get; set; }

    [Column("qty_20", TypeName = "decimal(18, 3)")]
    public decimal? Qty20 { get; set; }

    [Column("item_id_21", TypeName = "decimal(18, 0)")]
    public decimal? ItemId21 { get; set; }

    [Column("qty_21", TypeName = "decimal(18, 3)")]
    public decimal? Qty21 { get; set; }

    [Column("item_id_22", TypeName = "decimal(18, 0)")]
    public decimal? ItemId22 { get; set; }

    [Column("qty_22", TypeName = "decimal(18, 3)")]
    public decimal? Qty22 { get; set; }

    [Column("distribution")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Distribution { get; set; }

    [Column("creation_by", TypeName = "decimal(18, 0)")]
    public decimal? CreationBy { get; set; }

    [Column("creation_date", TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    [Column("modify_by", TypeName = "decimal(18, 0)")]
    public decimal? ModifyBy { get; set; }

    [Column("modify_date", TypeName = "datetime")]
    public DateTime? ModifyDate { get; set; }

    [Column("alocated_id", TypeName = "decimal(18, 0)")]
    public decimal? AlocatedId { get; set; }
}
