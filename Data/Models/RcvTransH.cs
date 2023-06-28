using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("rcv_trans_h")]
public partial class RcvTransH
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("trans_type_id", TypeName = "decimal(18, 0)")]
    public decimal? TransTypeId { get; set; }

    [Column("code")]
    [StringLength(20)]
    [Unicode(false)]
    public string Code { get; set; } = null!;

    [Column("trans_date", TypeName = "datetime")]
    public DateTime? TransDate { get; set; }

    [Column("doc_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? DocNo { get; set; }

    [Column("doc_date", TypeName = "datetime")]
    public DateTime? DocDate { get; set; }

    [Column("pay_type_id", TypeName = "decimal(18, 0)")]
    public decimal? PayTypeId { get; set; }

    [Column("bnk_trsury")]
    [StringLength(1)]
    [Unicode(false)]
    public string? BnkTrsury { get; set; }

    [Column("banck_acc_id", TypeName = "decimal(18, 0)")]
    public decimal? BanckAccId { get; set; }

    [Column("treasury_id", TypeName = "decimal(18, 0)")]
    public decimal? TreasuryId { get; set; }

    [Column("amount", TypeName = "decimal(18, 4)")]
    public decimal? Amount { get; set; }

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

    [Column("find_from_date", TypeName = "datetime")]
    public DateTime? FindFromDate { get; set; }

    [Column("find_to_date", TypeName = "datetime")]
    public DateTime? FindToDate { get; set; }

    [Column("find_doc_no")]
    [StringLength(20)]
    [Unicode(false)]
    public string? FindDocNo { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Posted { get; set; }
}
