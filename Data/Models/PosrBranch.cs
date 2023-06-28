using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("posr_branch")]
public partial class PosrBranch
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

    [Column("tel_1")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Tel1 { get; set; }

    [Column("tel_2")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Tel2 { get; set; }

    [Column("mobile")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Mobile { get; set; }

    [Column("fax")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Fax { get; set; }

    [Column("address_1")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Address1 { get; set; }

    [Column("address_2")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Address2 { get; set; }

    [Column("web_site")]
    [StringLength(200)]
    [Unicode(false)]
    public string? WebSite { get; set; }

    [Column("email_1")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Email1 { get; set; }

    [Column("email_2")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Email2 { get; set; }

    [Column("manger")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Manger { get; set; }

    [Column("manger_tel")]
    [StringLength(15)]
    [Unicode(false)]
    public string? MangerTel { get; set; }

    [Column("default_whs_id", TypeName = "decimal(18, 0)")]
    public decimal? DefaultWhsId { get; set; }

    [Column("acc_id", TypeName = "decimal(18, 0)")]
    public decimal? AccId { get; set; }

    [Column("cost_id", TypeName = "decimal(18, 0)")]
    public decimal? CostId { get; set; }

    [Column("exp_id", TypeName = "decimal(18, 0)")]
    public decimal? ExpId { get; set; }

    [Column("analysis_id", TypeName = "decimal(18, 0)")]
    public decimal? AnalysisId { get; set; }

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

    [Column("printer_name_01")]
    [StringLength(500)]
    [Unicode(false)]
    public string? PrinterName01 { get; set; }

    [Column("printer_name_02")]
    [StringLength(500)]
    [Unicode(false)]
    public string? PrinterName02 { get; set; }

    [Column("printer_name_03")]
    [StringLength(500)]
    [Unicode(false)]
    public string? PrinterName03 { get; set; }

    [Column("printer_name_04")]
    [StringLength(500)]
    [Unicode(false)]
    public string? PrinterName04 { get; set; }

    [Column("printer_name_05")]
    [StringLength(500)]
    [Unicode(false)]
    public string? PrinterName05 { get; set; }

    [Column("printer_name_06")]
    [StringLength(500)]
    [Unicode(false)]
    public string? PrinterName06 { get; set; }

    [Column("printer_name_07")]
    [StringLength(500)]
    [Unicode(false)]
    public string? PrinterName07 { get; set; }

    [Column("printer_name_08")]
    [StringLength(500)]
    [Unicode(false)]
    public string? PrinterName08 { get; set; }

    [Column("printer_name_09")]
    [StringLength(500)]
    [Unicode(false)]
    public string? PrinterName09 { get; set; }

    [Column("printer_name_10")]
    [StringLength(500)]
    [Unicode(false)]
    public string? PrinterName10 { get; set; }

    [Column("acc_delivery_id", TypeName = "decimal(18, 0)")]
    public decimal? AccDeliveryId { get; set; }

    [Column("inv_org_id", TypeName = "decimal(18, 0)")]
    public decimal? InvOrgId { get; set; }
}
