﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("acc_trans_d")]
public partial class AccTransD
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("code")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("h_id", TypeName = "decimal(18, 0)")]
    public decimal? HId { get; set; }

    [Column("acc_id", TypeName = "decimal(18, 0)")]
    public decimal? AccId { get; set; }

    [Column("cost_id", TypeName = "decimal(18, 0)")]
    public decimal? CostId { get; set; }

    [Column("exp_id", TypeName = "decimal(18, 0)")]
    public decimal? ExpId { get; set; }

    [Column("analysis_id", TypeName = "decimal(18, 0)")]
    public decimal? AnalysisId { get; set; }

    [Column("trans_date", TypeName = "datetime")]
    public DateTime? TransDate { get; set; }

    [Column("doc_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? DocNo { get; set; }

    [Column("doc_date", TypeName = "datetime")]
    public DateTime? DocDate { get; set; }

    [Column("journal_id", TypeName = "decimal(18, 0)")]
    public decimal? JournalId { get; set; }

    [Column("currency_id", TypeName = "decimal(18, 0)")]
    public decimal? CurrencyId { get; set; }

    [Column("exchange_rate", TypeName = "decimal(18, 5)")]
    public decimal? ExchangeRate { get; set; }

    [Column("credit", TypeName = "decimal(18, 4)")]
    public decimal? Credit { get; set; }

    [Column("debit", TypeName = "decimal(18, 4)")]
    public decimal? Debit { get; set; }

    [Column("description")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Description { get; set; }

    [Column("posted")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Posted { get; set; }

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

    [Column("notes_1")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes1 { get; set; }

    [Column("notes_2")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes2 { get; set; }

    [Column("aproved")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Aproved { get; set; }
}
