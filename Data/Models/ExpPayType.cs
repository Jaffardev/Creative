using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("exp_pay_type")]
public partial class ExpPayType
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("h_id", TypeName = "decimal(18, 0)")]
    public decimal? HId { get; set; }

    [Column("pay_type_id", TypeName = "decimal(18, 0)")]
    public decimal? PayTypeId { get; set; }

    [Column("amount", TypeName = "decimal(18, 3)")]
    public decimal? Amount { get; set; }

    [Column("ratio", TypeName = "decimal(18, 5)")]
    public decimal? Ratio { get; set; }

    [Column("code")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("name_1")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Name1 { get; set; }

    [Column("name_2")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Name2 { get; set; }

    [Column("active")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Active { get; set; }

    [Column("notes")]
    [StringLength(255)]
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

    [Column("acc_trans_id", TypeName = "decimal(18, 0)")]
    public decimal? AccTransId { get; set; }

    [Column("posted")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Posted { get; set; }
}
