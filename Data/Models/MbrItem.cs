using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("mbr_items")]
public partial class MbrItem
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

    [Column("item_group")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ItemGroup { get; set; }

    [Column("unit")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Unit { get; set; }

    [Column("cost", TypeName = "decimal(18, 4)")]
    public decimal? Cost { get; set; }

    [Column("price", TypeName = "decimal(18, 4)")]
    public decimal? Price { get; set; }

    [Column("tel_comtion", TypeName = "decimal(18, 4)")]
    public decimal? TelComtion { get; set; }

    [Column("driver_comtion", TypeName = "decimal(18, 4)")]
    public decimal? DriverComtion { get; set; }

    [Column("vendor")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Vendor { get; set; }

    [Column("vendor_code")]
    [StringLength(50)]
    [Unicode(false)]
    public string? VendorCode { get; set; }

    [Column("vendor_tel_1")]
    [StringLength(15)]
    [Unicode(false)]
    public string? VendorTel1 { get; set; }

    [Column("vendor_tel_2")]
    [StringLength(15)]
    [Unicode(false)]
    public string? VendorTel2 { get; set; }

    [Column("vendor_address")]
    [StringLength(200)]
    [Unicode(false)]
    public string? VendorAddress { get; set; }

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
