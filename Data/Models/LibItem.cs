using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("lib_items")]
public partial class LibItem
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

    [Column("inv_item_id", TypeName = "decimal(18, 0)")]
    public decimal? InvItemId { get; set; }

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

    [Column("lib_unit_id", TypeName = "decimal(18, 0)")]
    public decimal? LibUnitId { get; set; }

    [Column("library_id", TypeName = "decimal(18, 0)")]
    public decimal? LibraryId { get; set; }

    [Column("location_id", TypeName = "decimal(18, 0)")]
    public decimal? LocationId { get; set; }

    [Column("cost_amount", TypeName = "decimal(18, 4)")]
    public decimal? CostAmount { get; set; }

    [Column("pur_amount", TypeName = "decimal(18, 4)")]
    public decimal? PurAmount { get; set; }

    [Column("salse_amount", TypeName = "decimal(18, 4)")]
    public decimal? SalseAmount { get; set; }

    [Column("lib_item")]
    [StringLength(1)]
    [Unicode(false)]
    public string? LibItem1 { get; set; }

    [Column("salse_item")]
    [StringLength(1)]
    [Unicode(false)]
    public string? SalseItem { get; set; }

    [Column("comp_item")]
    [StringLength(1)]
    [Unicode(false)]
    public string? CompItem { get; set; }

    [Column("expier_date")]
    [StringLength(1)]
    [Unicode(false)]
    public string? ExpierDate { get; set; }

    [Column("day_no")]
    public int? DayNo { get; set; }

    [Column("allow_external")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AllowExternal { get; set; }

    [Column("plan_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? PlanType { get; set; }

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

    [Column("authers_1")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Authers1 { get; set; }

    [Column("authers_2")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Authers2 { get; set; }

    [Column("publisher")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Publisher { get; set; }

    [Column("publisher_date", TypeName = "datetime")]
    public DateTime? PublisherDate { get; set; }

    [Column("ref_no")]
    [StringLength(100)]
    [Unicode(false)]
    public string? RefNo { get; set; }

    [Column("pages_no")]
    public int? PagesNo { get; set; }

    [Column("folder")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Folder { get; set; }

    [Column("folder_no")]
    [StringLength(100)]
    [Unicode(false)]
    public string? FolderNo { get; set; }

    [Column("translator")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Translator { get; set; }

    [Column("classification_no")]
    [StringLength(200)]
    [Unicode(false)]
    public string? ClassificationNo { get; set; }

    [Column("data_1")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Data1 { get; set; }

    [Column("data_2")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Data2 { get; set; }

    [Column("data_3")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Data3 { get; set; }

    [Column("data_4")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Data4 { get; set; }

    [Column("data_5")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Data5 { get; set; }

    [Column("publisher_place")]
    [StringLength(200)]
    [Unicode(false)]
    public string? PublisherPlace { get; set; }

    [Column("painter")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Painter { get; set; }

    [Column("introducer")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Introducer { get; set; }

    [Column("id_found", TypeName = "decimal(18, 0)")]
    public decimal? IdFound { get; set; }

    [Column("Classification_id", TypeName = "decimal(18, 0)")]
    public decimal? ClassificationId { get; set; }

    [Column("Classification_id_scnd", TypeName = "decimal(18, 0)")]
    public decimal? ClassificationIdScnd { get; set; }

    [Column("Classification_id_thrd", TypeName = "decimal(18, 0)")]
    public decimal? ClassificationIdThrd { get; set; }

    [Column("Classification_frth_code")]
    [StringLength(20)]
    [Unicode(false)]
    public string? ClassificationFrthCode { get; set; }

    [Column("Classification_frth_name")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ClassificationFrthName { get; set; }

    [Column("item_url")]
    [StringLength(500)]
    [Unicode(false)]
    public string? ItemUrl { get; set; }
}
