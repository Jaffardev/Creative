using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("rcv_installment_d")]
public partial class RcvInstallmentD
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("h_id", TypeName = "decimal(18, 0)")]
    public decimal? HId { get; set; }

    [Column("row_status")]
    [StringLength(1)]
    [Unicode(false)]
    public string? RowStatus { get; set; }

    [Column("trans_date", TypeName = "datetime")]
    public DateTime? TransDate { get; set; }

    [Column("doc_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? DocNo { get; set; }

    [Column("doc_date", TypeName = "datetime")]
    public DateTime? DocDate { get; set; }

    [Column("payment_id", TypeName = "decimal(18, 0)")]
    public decimal? PaymentId { get; set; }

    [Column("pay_date", TypeName = "decimal(18, 0)")]
    public decimal? PayDate { get; set; }

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

    [StringLength(1)]
    [Unicode(false)]
    public string? Posted { get; set; }

    [Column("trans_month", TypeName = "decimal(18, 0)")]
    public decimal? TransMonth { get; set; }

    [Column("trans_year", TypeName = "decimal(18, 0)")]
    public decimal? TransYear { get; set; }

    [Column("from_date", TypeName = "smalldatetime")]
    public DateTime? FromDate { get; set; }

    [Column("to_date", TypeName = "smalldatetime")]
    public DateTime? ToDate { get; set; }
}
