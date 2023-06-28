using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("inv_trans_type")]
public partial class InvTransType
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

    [Column("amount")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Amount { get; set; }

    [Column("qty")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Qty { get; set; }

    [Column("trans_salse")]
    [StringLength(1)]
    [Unicode(false)]
    public string? TransSalse { get; set; }

    [Column("trans_pur")]
    [StringLength(1)]
    [Unicode(false)]
    public string? TransPur { get; set; }

    [Column("trans_inv")]
    [StringLength(1)]
    [Unicode(false)]
    public string? TransInv { get; set; }

    [Column("user_defind")]
    [StringLength(1)]
    [Unicode(false)]
    public string? UserDefind { get; set; }

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
