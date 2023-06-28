using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("cst_tel")]
public partial class CstTel
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

    [Column("id_no")]
    [StringLength(15)]
    [Unicode(false)]
    public string? IdNo { get; set; }

    [Column("address_1")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Address1 { get; set; }

    [Column("address_2")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Address2 { get; set; }

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

    [Column("mobile")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Mobile { get; set; }

    [Column("mobile_2")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Mobile2 { get; set; }

    [Column("tel_w_1")]
    [StringLength(15)]
    [Unicode(false)]
    public string? TelW1 { get; set; }

    [Column("tel_w_2")]
    [StringLength(15)]
    [Unicode(false)]
    public string? TelW2 { get; set; }

    [Column("tel_w_ext")]
    [StringLength(10)]
    [Unicode(false)]
    public string? TelWExt { get; set; }

    [Column("email_1")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Email1 { get; set; }

    [Column("email_2")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Email2 { get; set; }

    [Column("web_sit")]
    [StringLength(200)]
    [Unicode(false)]
    public string? WebSit { get; set; }

    [Column("job")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Job { get; set; }

    [Column("org")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Org { get; set; }

    [Column("depar")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Depar { get; set; }

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
