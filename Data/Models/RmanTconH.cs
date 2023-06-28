using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("rman_tcon_h")]
public partial class RmanTconH
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

    [Column("trans_date", TypeName = "datetime")]
    public DateTime? TransDate { get; set; }

    [Column("doc_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? DocNo { get; set; }

    [Column("doc_date", TypeName = "datetime")]
    public DateTime? DocDate { get; set; }

    [Column("order_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? OrderType { get; set; }

    [Column("comp_id", TypeName = "decimal(18, 0)")]
    public decimal? CompId { get; set; }

    [Column("contact_person")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ContactPerson { get; set; }

    [Column("contact_tel_1")]
    [StringLength(20)]
    [Unicode(false)]
    public string? ContactTel1 { get; set; }

    [Column("contact_tel_2")]
    [StringLength(20)]
    [Unicode(false)]
    public string? ContactTel2 { get; set; }

    [Column("branch_id", TypeName = "decimal(18, 0)")]
    public decimal? BranchId { get; set; }

    [Column("deprt_id", TypeName = "decimal(18, 0)")]
    public decimal? DeprtId { get; set; }

    [Column("emp_id", TypeName = "decimal(18, 0)")]
    public decimal? EmpId { get; set; }

    [Column("portfolio_id", TypeName = "decimal(18, 0)")]
    public decimal? PortfolioId { get; set; }

    [Column("real_id", TypeName = "decimal(18, 0)")]
    public decimal? RealId { get; set; }

    [Column("unit_id", TypeName = "decimal(18, 0)")]
    public decimal? UnitId { get; set; }

    [Column("from_date", TypeName = "datetime")]
    public DateTime? FromDate { get; set; }

    [Column("to_date", TypeName = "datetime")]
    public DateTime? ToDate { get; set; }

    [Column("amount", TypeName = "decimal(18, 3)")]
    public decimal? Amount { get; set; }

    [Column("discount", TypeName = "decimal(18, 4)")]
    public decimal? Discount { get; set; }

    [Column("currency_id", TypeName = "decimal(18, 0)")]
    public decimal? CurrencyId { get; set; }

    [Column("exchange_rate", TypeName = "decimal(18, 5)")]
    public decimal? ExchangeRate { get; set; }

    [Column("amount_main", TypeName = "decimal(18, 3)")]
    public decimal? AmountMain { get; set; }

    [Column("pay_from", TypeName = "datetime")]
    public DateTime? PayFrom { get; set; }

    [Column("pay_to", TypeName = "datetime")]
    public DateTime? PayTo { get; set; }

    [Column("pay_no", TypeName = "decimal(18, 0)")]
    public decimal? PayNo { get; set; }

    [Column("terms_1")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Terms1 { get; set; }

    [Column("terms_2")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Terms2 { get; set; }

    [Column("terms_3")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Terms3 { get; set; }

    [Column("terms_4")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Terms4 { get; set; }

    [Column("terms_5")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Terms5 { get; set; }

    [Column("photo_1")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Photo1 { get; set; }

    [Column("photo_2")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Photo2 { get; set; }

    [Column("status")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Status { get; set; }

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
}
