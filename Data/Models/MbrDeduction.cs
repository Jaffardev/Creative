using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Keyless]
[Table("mbr_deduction")]
public partial class MbrDeduction
{
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

    [Column("doc_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? DocNo { get; set; }

    [Column("doc_date", TypeName = "datetime")]
    public DateTime? DocDate { get; set; }

    [Column("ref_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? RefNo { get; set; }

    [Column("bank_id", TypeName = "decimal(18, 0)")]
    public decimal? BankId { get; set; }

    [Column("bank_branch_id", TypeName = "decimal(18, 0)")]
    public decimal? BankBranchId { get; set; }

    [Column("banck_acc_id", TypeName = "decimal(18, 0)")]
    public decimal? BanckAccId { get; set; }

    [Column("amount", TypeName = "decimal(18, 0)")]
    public decimal? Amount { get; set; }

    [Column("pay_count")]
    public int? PayCount { get; set; }

    [Column("from_date", TypeName = "smalldatetime")]
    public DateTime? FromDate { get; set; }

    [Column("to_date", TypeName = "smalldatetime")]
    public DateTime? ToDate { get; set; }

    [Column("pay_to")]
    [StringLength(100)]
    [Unicode(false)]
    public string? PayTo { get; set; }

    [Column("project_id", TypeName = "decimal(18, 0)")]
    public decimal? ProjectId { get; set; }

    [Column("cust_name")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CustName { get; set; }

    [Column("cust_id_no")]
    [StringLength(12)]
    [Unicode(false)]
    public string? CustIdNo { get; set; }

    [Column("address")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Address { get; set; }

    [Column("area")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Area { get; set; }

    [Column("street")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Street { get; set; }

    [Column("gada")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Gada { get; set; }

    [Column("kasema")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Kasema { get; set; }

    [Column("flow")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Flow { get; set; }

    [Column("flat")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Flat { get; set; }

    [Column("tel_1")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Tel1 { get; set; }

    [Column("tel_2")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Tel2 { get; set; }

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
