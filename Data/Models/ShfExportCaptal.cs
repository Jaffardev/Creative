using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("shf_export_captal")]
public partial class ShfExportCaptal
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

    [Column("active")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Active { get; set; }

    [Column("trans_date", TypeName = "datetime")]
    public DateTime TransDate { get; set; }

    [Column("h_date")]
    [StringLength(8)]
    [Unicode(false)]
    public string? HDate { get; set; }

    [Column("m_date", TypeName = "datetime")]
    public DateTime? MDate { get; set; }

    [Column("from_issue")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FromIssue { get; set; }

    [Column("ref_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? RefNo { get; set; }

    [Column("ship_by_1")]
    [StringLength(200)]
    [Unicode(false)]
    public string? ShipBy1 { get; set; }

    [Column("ship_by_2")]
    [StringLength(200)]
    [Unicode(false)]
    public string? ShipBy2 { get; set; }

    [Column("line_1")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Line1 { get; set; }

    [Column("line_2")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Line2 { get; set; }

    [Column("line_3")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Line3 { get; set; }

    [Column("line_4")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Line4 { get; set; }

    [Column("line_5")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Line5 { get; set; }

    [Column("line_6")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Line6 { get; set; }

    [Column("line_7")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Line7 { get; set; }

    [Column("line_8")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Line8 { get; set; }

    [Column("line_9")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Line9 { get; set; }

    [Column("item_1")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Item1 { get; set; }

    [Column("contener_1")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Contener1 { get; set; }

    [Column("qty_1", TypeName = "decimal(18, 0)")]
    public decimal? Qty1 { get; set; }

    [Column("prodation_date_1", TypeName = "datetime")]
    public DateTime? ProdationDate1 { get; set; }

    [Column("end_date_1", TypeName = "datetime")]
    public DateTime? EndDate1 { get; set; }

    [Column("code_1")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Code1 { get; set; }

    [Column("item_2")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Item2 { get; set; }

    [Column("contener_2")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Contener2 { get; set; }

    [Column("qty_2", TypeName = "decimal(18, 0)")]
    public decimal? Qty2 { get; set; }

    [Column("prodation_date_2", TypeName = "datetime")]
    public DateTime? ProdationDate2 { get; set; }

    [Column("end_date_2", TypeName = "datetime")]
    public DateTime? EndDate2 { get; set; }

    [Column("code_2")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Code2 { get; set; }

    [Column("item_3")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Item3 { get; set; }

    [Column("contener_3")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Contener3 { get; set; }

    [Column("qty_3", TypeName = "decimal(18, 0)")]
    public decimal? Qty3 { get; set; }

    [Column("prodation_date_3", TypeName = "datetime")]
    public DateTime? ProdationDate3 { get; set; }

    [Column("end_date_3", TypeName = "datetime")]
    public DateTime? EndDate3 { get; set; }

    [Column("code_3")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Code3 { get; set; }

    [Column("item_4")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Item4 { get; set; }

    [Column("contener_4")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Contener4 { get; set; }

    [Column("qty_4", TypeName = "decimal(18, 0)")]
    public decimal? Qty4 { get; set; }

    [Column("prodation_date_4", TypeName = "datetime")]
    public DateTime? ProdationDate4 { get; set; }

    [Column("end_date_4", TypeName = "datetime")]
    public DateTime? EndDate4 { get; set; }

    [Column("code_4")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Code4 { get; set; }

    [Column("item_5")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Item5 { get; set; }

    [Column("contener_5")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Contener5 { get; set; }

    [Column("qty_5", TypeName = "decimal(18, 0)")]
    public decimal? Qty5 { get; set; }

    [Column("prodation_date_5", TypeName = "datetime")]
    public DateTime? ProdationDate5 { get; set; }

    [Column("end_date_5", TypeName = "datetime")]
    public DateTime? EndDate5 { get; set; }

    [Column("code_5")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Code5 { get; set; }

    [Column("item_6")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Item6 { get; set; }

    [Column("contener_6")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Contener6 { get; set; }

    [Column("qty_6", TypeName = "decimal(18, 0)")]
    public decimal? Qty6 { get; set; }

    [Column("prodation_date_6", TypeName = "datetime")]
    public DateTime? ProdationDate6 { get; set; }

    [Column("end_date_6", TypeName = "datetime")]
    public DateTime? EndDate6 { get; set; }

    [Column("code_6")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Code6 { get; set; }

    [Column("item_7")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Item7 { get; set; }

    [Column("contener_7")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Contener7 { get; set; }

    [Column("qty_7", TypeName = "decimal(18, 0)")]
    public decimal? Qty7 { get; set; }

    [Column("prodation_date_7", TypeName = "datetime")]
    public DateTime? ProdationDate7 { get; set; }

    [Column("end_date_7", TypeName = "datetime")]
    public DateTime? EndDate7 { get; set; }

    [Column("code_7")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Code7 { get; set; }

    [Column("item_8")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Item8 { get; set; }

    [Column("contener_8")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Contener8 { get; set; }

    [Column("qty_8", TypeName = "decimal(18, 0)")]
    public decimal? Qty8 { get; set; }

    [Column("prodation_date_8", TypeName = "datetime")]
    public DateTime? ProdationDate8 { get; set; }

    [Column("end_date_8", TypeName = "datetime")]
    public DateTime? EndDate8 { get; set; }

    [Column("code_8")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Code8 { get; set; }

    [Column("item_9")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Item9 { get; set; }

    [Column("contener_9")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Contener9 { get; set; }

    [Column("qty_9", TypeName = "decimal(18, 0)")]
    public decimal? Qty9 { get; set; }

    [Column("prodation_date_9", TypeName = "datetime")]
    public DateTime? ProdationDate9 { get; set; }

    [Column("end_date_9", TypeName = "datetime")]
    public DateTime? EndDate9 { get; set; }

    [Column("code_9")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Code9 { get; set; }

    [Column("item_10")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Item10 { get; set; }

    [Column("contener_10")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Contener10 { get; set; }

    [Column("qty_10", TypeName = "decimal(18, 0)")]
    public decimal? Qty10 { get; set; }

    [Column("prodation_date_10", TypeName = "datetime")]
    public DateTime? ProdationDate10 { get; set; }

    [Column("end_date_10", TypeName = "datetime")]
    public DateTime? EndDate10 { get; set; }

    [Column("code_10")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Code10 { get; set; }

    [Column("item_11")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Item11 { get; set; }

    [Column("contener_11")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Contener11 { get; set; }

    [Column("qty_11", TypeName = "decimal(18, 0)")]
    public decimal? Qty11 { get; set; }

    [Column("prodation_date_11", TypeName = "datetime")]
    public DateTime? ProdationDate11 { get; set; }

    [Column("end_date_11", TypeName = "datetime")]
    public DateTime? EndDate11 { get; set; }

    [Column("code_11")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Code11 { get; set; }

    [Column("item_12")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Item12 { get; set; }

    [Column("contener_12")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Contener12 { get; set; }

    [Column("qty_12", TypeName = "decimal(18, 0)")]
    public decimal? Qty12 { get; set; }

    [Column("prodation_date_12", TypeName = "datetime")]
    public DateTime? ProdationDate12 { get; set; }

    [Column("end_date_12", TypeName = "datetime")]
    public DateTime? EndDate12 { get; set; }

    [Column("code_12")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Code12 { get; set; }

    [Column("item_13")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Item13 { get; set; }

    [Column("contener_13")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Contener13 { get; set; }

    [Column("qty_13", TypeName = "decimal(18, 0)")]
    public decimal? Qty13 { get; set; }

    [Column("prodation_date_13", TypeName = "datetime")]
    public DateTime? ProdationDate13 { get; set; }

    [Column("end_date_13", TypeName = "datetime")]
    public DateTime? EndDate13 { get; set; }

    [Column("code_13")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Code13 { get; set; }

    [Column("item_14")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Item14 { get; set; }

    [Column("contener_14")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Contener14 { get; set; }

    [Column("qty_14", TypeName = "decimal(18, 0)")]
    public decimal? Qty14 { get; set; }

    [Column("prodation_date_14", TypeName = "datetime")]
    public DateTime? ProdationDate14 { get; set; }

    [Column("end_date_14", TypeName = "datetime")]
    public DateTime? EndDate14 { get; set; }

    [Column("code_14")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Code14 { get; set; }

    [Column("item_15")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Item15 { get; set; }

    [Column("contener_15")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Contener15 { get; set; }

    [Column("qty_15", TypeName = "decimal(18, 0)")]
    public decimal? Qty15 { get; set; }

    [Column("prodation_date_15", TypeName = "datetime")]
    public DateTime? ProdationDate15 { get; set; }

    [Column("end_date_15", TypeName = "datetime")]
    public DateTime? EndDate15 { get; set; }

    [Column("code_15")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Code15 { get; set; }

    [Column("item_16")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Item16 { get; set; }

    [Column("contener_16")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Contener16 { get; set; }

    [Column("qty_16", TypeName = "decimal(18, 0)")]
    public decimal? Qty16 { get; set; }

    [Column("prodation_date_16", TypeName = "datetime")]
    public DateTime? ProdationDate16 { get; set; }

    [Column("end_date_16", TypeName = "datetime")]
    public DateTime? EndDate16 { get; set; }

    [Column("code_16")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Code16 { get; set; }

    [Column("item_17")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Item17 { get; set; }

    [Column("contener_17")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Contener17 { get; set; }

    [Column("qty_17", TypeName = "decimal(18, 0)")]
    public decimal? Qty17 { get; set; }

    [Column("prodation_date_17", TypeName = "datetime")]
    public DateTime? ProdationDate17 { get; set; }

    [Column("end_date_17", TypeName = "datetime")]
    public DateTime? EndDate17 { get; set; }

    [Column("code_17")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Code17 { get; set; }

    [Column("item_18")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Item18 { get; set; }

    [Column("contener_18")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Contener18 { get; set; }

    [Column("qty_18", TypeName = "decimal(18, 0)")]
    public decimal? Qty18 { get; set; }

    [Column("prodation_date_18", TypeName = "datetime")]
    public DateTime? ProdationDate18 { get; set; }

    [Column("end_date_18", TypeName = "datetime")]
    public DateTime? EndDate18 { get; set; }

    [Column("code_18")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Code18 { get; set; }

    [Column("invoice_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? InvoiceNo { get; set; }

    [Column("no_carton", TypeName = "decimal(18, 0)")]
    public decimal? NoCarton { get; set; }

    [Column("no_kes", TypeName = "decimal(18, 0)")]
    public decimal? NoKes { get; set; }

    [Column("waith_all", TypeName = "decimal(18, 0)")]
    public decimal? WaithAll { get; set; }

    [Column("waith_net", TypeName = "decimal(18, 0)")]
    public decimal? WaithNet { get; set; }

    [Column("source")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Source { get; set; }

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
