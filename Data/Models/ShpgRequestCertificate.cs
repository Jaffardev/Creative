using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("shpg_request_certificate")]
public partial class ShpgRequestCertificate
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

    [Column("row_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? RowType { get; set; }

    [Column("item_type")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ItemType { get; set; }

    [Column("vechile_name")]
    [StringLength(100)]
    [Unicode(false)]
    public string? VechileName { get; set; }

    [Column("refer_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ReferNo { get; set; }

    [Column("owner_name")]
    [StringLength(100)]
    [Unicode(false)]
    public string? OwnerName { get; set; }

    [Column("id_no")]
    [StringLength(20)]
    [Unicode(false)]
    public string? IdNo { get; set; }

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
