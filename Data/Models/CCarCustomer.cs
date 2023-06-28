using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("c_car_customer")]
public partial class CCarCustomer
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

    [Column("nationality")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Nationality { get; set; }

    [Column("id_no")]
    [StringLength(12)]
    [Unicode(false)]
    public string? IdNo { get; set; }

    [Column("passport_no")]
    [StringLength(20)]
    [Unicode(false)]
    public string? PassportNo { get; set; }

    [Column("address_work")]
    [StringLength(100)]
    [Unicode(false)]
    public string? AddressWork { get; set; }

    [Column("address_home")]
    [StringLength(100)]
    [Unicode(false)]
    public string? AddressHome { get; set; }

    [Column("tel_1")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Tel1 { get; set; }

    [Column("tel_2")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Tel2 { get; set; }

    [Column("tel_3")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Tel3 { get; set; }

    [Column("tel_4")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Tel4 { get; set; }

    [Column("id_licence_no")]
    [StringLength(20)]
    [Unicode(false)]
    public string? IdLicenceNo { get; set; }

    [Column("licence_issue", TypeName = "datetime")]
    public DateTime? LicenceIssue { get; set; }

    [Column("licence_expiry", TypeName = "datetime")]
    public DateTime? LicenceExpiry { get; set; }

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
