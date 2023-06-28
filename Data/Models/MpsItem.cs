using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("mps_item")]
public partial class MpsItem
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
    public string? InvItem { get; set; }

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
