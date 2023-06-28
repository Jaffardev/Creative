using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("adl_pay_exp")]
public partial class AdlPayExp
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

    [Column("pay_exp")]
    [StringLength(1)]
    [Unicode(false)]
    public string? PayExp { get; set; }

    [Column("trans_date", TypeName = "datetime")]
    public DateTime? TransDate { get; set; }

    [Column("doc_date", TypeName = "datetime")]
    public DateTime? DocDate { get; set; }

    [Column("pay_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? PayType { get; set; }

    [Column("bank")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Bank { get; set; }

    [Column("cheq_no")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CheqNo { get; set; }

    [Column("costed")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Costed { get; set; }

    [Column("con_id", TypeName = "decimal(18, 0)")]
    public decimal? ConId { get; set; }

    [Column("amount", TypeName = "decimal(18, 4)")]
    public decimal? Amount { get; set; }

    [Column("descrption")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Descrption { get; set; }

    [Column("receved_by")]
    [StringLength(100)]
    [Unicode(false)]
    public string? RecevedBy { get; set; }

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
