using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("inv_items")]
public partial class InvItem
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

    [Column("bar_code")]
    [StringLength(50)]
    [Unicode(false)]
    public string? BarCode { get; set; }

    [Column("vendor_id_1", TypeName = "decimal(18, 0)")]
    public decimal? VendorId1 { get; set; }

    [Column("vendor_id_2", TypeName = "decimal(18, 0)")]
    public decimal? VendorId2 { get; set; }

    [Column("ven_code_1")]
    [StringLength(50)]
    [Unicode(false)]
    public string? VenCode1 { get; set; }

    [Column("ven_code_2")]
    [StringLength(50)]
    [Unicode(false)]
    public string? VenCode2 { get; set; }

    [Column("group_id", TypeName = "decimal(18, 0)")]
    public decimal? GroupId { get; set; }

    [Column("class_id", TypeName = "decimal(18, 0)")]
    public decimal? ClassId { get; set; }

    [Column("type_id", TypeName = "decimal(18, 0)")]
    public decimal? TypeId { get; set; }

    [Column("cost_id", TypeName = "decimal(18, 0)")]
    public decimal? CostId { get; set; }

    [Column("exp_id", TypeName = "decimal(18, 0)")]
    public decimal? ExpId { get; set; }

    [Column("cost_amount", TypeName = "decimal(18, 4)")]
    public decimal? CostAmount { get; set; }

    [Column("pur_amount", TypeName = "decimal(18, 4)")]
    public decimal? PurAmount { get; set; }

    [Column("salse_amount", TypeName = "decimal(18, 4)")]
    public decimal? SalseAmount { get; set; }

    [Column("inv_unit_id", TypeName = "decimal(18, 0)")]
    public decimal? InvUnitId { get; set; }

    [Column("inv_item")]
    [StringLength(1)]
    [Unicode(false)]
    public string? InvItem1 { get; set; }

    [Column("salse_item")]
    [StringLength(1)]
    [Unicode(false)]
    public string? SalseItem { get; set; }

    [Column("comp_item")]
    [StringLength(1)]
    [Unicode(false)]
    public string? CompItem { get; set; }

    [Column("lot_control")]
    [StringLength(1)]
    [Unicode(false)]
    public string? LotControl { get; set; }

    [Column("contener_controll")]
    [StringLength(1)]
    [Unicode(false)]
    public string? ContenerControll { get; set; }

    [Column("expier_date")]
    [StringLength(1)]
    [Unicode(false)]
    public string? ExpierDate { get; set; }

    [Column("plan_item")]
    [StringLength(1)]
    [Unicode(false)]
    public string? PlanItem { get; set; }

    [Column("plan_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? PlanType { get; set; }

    [Column("min_qty", TypeName = "decimal(18, 4)")]
    public decimal? MinQty { get; set; }

    [Column("max_qty", TypeName = "decimal(18, 4)")]
    public decimal? MaxQty { get; set; }

    [Column("req_qty", TypeName = "decimal(18, 4)")]
    public decimal? ReqQty { get; set; }

    [Column("pariod_day")]
    public int? PariodDay { get; set; }

    [Column("pur_qty", TypeName = "decimal(18, 4)")]
    public decimal? PurQty { get; set; }

    [Column("mrp_balance", TypeName = "decimal(18, 4)")]
    public decimal? MrpBalance { get; set; }

    [Column("mrp_onway", TypeName = "decimal(18, 4)")]
    public decimal? MrpOnway { get; set; }

    [Column("mrp_open_order", TypeName = "decimal(18, 4)")]
    public decimal? MrpOpenOrder { get; set; }

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

    [Column("acc_inv_id", TypeName = "decimal(18, 0)")]
    public decimal? AccInvId { get; set; }

    [Column("acc_pur_id", TypeName = "decimal(18, 0)")]
    public decimal? AccPurId { get; set; }

    [Column("acc_sal_id", TypeName = "decimal(18, 0)")]
    public decimal? AccSalId { get; set; }

    [Column("acc_sal_cost_id", TypeName = "decimal(18, 0)")]
    public decimal? AccSalCostId { get; set; }

    [Column("acc_sfc_id", TypeName = "decimal(18, 0)")]
    public decimal? AccSfcId { get; set; }

    [Column("acc_sfc_cost_id", TypeName = "decimal(18, 0)")]
    public decimal? AccSfcCostId { get; set; }

    [Column("analysis_id", TypeName = "decimal(18, 0)")]
    public decimal? AnalysisId { get; set; }

    [Column("discount_acc_id", TypeName = "decimal(18, 0)")]
    public decimal? DiscountAccId { get; set; }

    [Column("sal_unit_id", TypeName = "decimal(18, 0)")]
    public decimal? SalUnitId { get; set; }

    [Column("pur_unit_id", TypeName = "decimal(18, 0)")]
    public decimal? PurUnitId { get; set; }

    [Column("Manufacture_item")]
    [StringLength(1)]
    [Unicode(false)]
    public string? ManufactureItem { get; set; }

    [Column("item_sfc_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? ItemSfcType { get; set; }

    [Column("item_Matrix")]
    [StringLength(1)]
    [Unicode(false)]
    public string? ItemMatrix { get; set; }

    [Column("matrix_id", TypeName = "decimal(18, 0)")]
    public decimal? MatrixId { get; set; }

    [Column("cat_matrix_id_1", TypeName = "decimal(18, 0)")]
    public decimal? CatMatrixId1 { get; set; }

    [Column("cat_matrix_id_2", TypeName = "decimal(18, 0)")]
    public decimal? CatMatrixId2 { get; set; }

    [Column("sfc_bom_id", TypeName = "decimal(18, 0)")]
    public decimal? SfcBomId { get; set; }

    [Column("sfc_method_id", TypeName = "decimal(18, 0)")]
    public decimal? SfcMethodId { get; set; }

    [Column("pur_item")]
    [StringLength(1)]
    [Unicode(false)]
    public string? PurItem { get; set; }

    [Column("service_item")]
    [StringLength(1)]
    [Unicode(false)]
    public string? ServiceItem { get; set; }

    [Column("under_tax")]
    [StringLength(1)]
    [Unicode(false)]
    public string? UnderTax { get; set; }

    [Column("accept_exemption")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AcceptExemption { get; set; }

    [Column("tax_value", TypeName = "decimal(18, 4)")]
    public decimal? TaxValue { get; set; }

    [Column("h_id", TypeName = "decimal(18, 0)")]
    public decimal? HId { get; set; }

    [Column("photo_path")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? PhotoPath { get; set; }

    [Column("default_whs_id", TypeName = "decimal(18, 0)")]
    public decimal? DefaultWhsId { get; set; }

    [Column("color_red")]
    public int? ColorRed { get; set; }

    [Column("color_green")]
    public int? ColorGreen { get; set; }

    [Column("color_blue")]
    public int? ColorBlue { get; set; }
}
