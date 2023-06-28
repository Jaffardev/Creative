using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("rcon_trans_h")]
public partial class RconTransH
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

    [Column("status")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Status { get; set; }

    [Column("ref_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? RefNo { get; set; }

    [Column("rent_id", TypeName = "decimal(18, 0)")]
    public decimal? RentId { get; set; }

    [Column("trans_date", TypeName = "datetime")]
    public DateTime? TransDate { get; set; }

    [Column("from_date", TypeName = "datetime")]
    public DateTime? FromDate { get; set; }

    [Column("to_date", TypeName = "datetime")]
    public DateTime? ToDate { get; set; }

    [Column("pay_from", TypeName = "datetime")]
    public DateTime? PayFrom { get; set; }

    [Column("pay_to", TypeName = "datetime")]
    public DateTime? PayTo { get; set; }

    [Column("amount", TypeName = "decimal(18, 3)")]
    public decimal? Amount { get; set; }

    [Column("insurance_amount", TypeName = "decimal(18, 3)")]
    public decimal? InsuranceAmount { get; set; }

    [Column("electrets_amount", TypeName = "decimal(18, 3)")]
    public decimal? ElectretsAmount { get; set; }

    [Column("service_amount", TypeName = "decimal(18, 3)")]
    public decimal? ServiceAmount { get; set; }

    [Column("discount", TypeName = "decimal(18, 3)")]
    public decimal? Discount { get; set; }

    [Column("used_in")]
    [StringLength(200)]
    [Unicode(false)]
    public string? UsedIn { get; set; }

    [Column("work_type")]
    [StringLength(50)]
    [Unicode(false)]
    public string? WorkType { get; set; }

    [Column("work_in")]
    [StringLength(100)]
    [Unicode(false)]
    public string? WorkIn { get; set; }

    [Column("print_invoice")]
    [StringLength(1)]
    [Unicode(false)]
    public string? PrintInvoice { get; set; }

    [Column("doc_1")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Doc1 { get; set; }

    [Column("doc_2")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Doc2 { get; set; }

    [Column("doc_3")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Doc3 { get; set; }

    [Column("doc_4")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Doc4 { get; set; }

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

    [Column("year_no", TypeName = "decimal(18, 0)")]
    public decimal? YearNo { get; set; }

    [Column("end_date", TypeName = "datetime")]
    public DateTime? EndDate { get; set; }
}
