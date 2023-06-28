using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("sch_clb_trans_h")]
public partial class SchClbTransH
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("code")]
    [StringLength(20)]
    [Unicode(false)]
    public string Code { get; set; } = null!;

    [Column("trans_date", TypeName = "datetime")]
    public DateTime TransDate { get; set; }

    [Column("doc_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? DocNo { get; set; }

    [Column("doc_date", TypeName = "datetime")]
    public DateTime DocDate { get; set; }

    [Column("treasury_id", TypeName = "decimal(18, 0)")]
    public decimal TreasuryId { get; set; }

    [Column("row_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string RowType { get; set; } = null!;

    [Column("active")]
    [StringLength(1)]
    [Unicode(false)]
    public string Active { get; set; } = null!;

    [Column("notes")]
    [StringLength(500)]
    [Unicode(false)]
    public string Notes { get; set; } = null!;

    [Column("creation_by", TypeName = "decimal(18, 0)")]
    public decimal CreationBy { get; set; }

    [Column("creation_date", TypeName = "datetime")]
    public DateTime CreationDate { get; set; }

    [Column("modify_by", TypeName = "decimal(18, 0)")]
    public decimal ModifyBy { get; set; }

    [Column("modify_date", TypeName = "datetime")]
    public DateTime ModifyDate { get; set; }
}
