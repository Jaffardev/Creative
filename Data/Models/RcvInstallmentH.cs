using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("rcv_installment_h")]
public partial class RcvInstallmentH
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("code")]
    [StringLength(20)]
    [Unicode(false)]
    public string Code { get; set; } = null!;

    [Column("row_type")]
    [StringLength(50)]
    [Unicode(false)]
    public string? RowType { get; set; }

    [Column("trans_date", TypeName = "datetime")]
    public DateTime? TransDate { get; set; }

    [Column("ref_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? RefNo { get; set; }

    [Column("doc_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? DocNo { get; set; }

    [Column("doc_date", TypeName = "datetime")]
    public DateTime? DocDate { get; set; }

    [Column("cust_bank")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CustBank { get; set; }

    [Column("cust_branch")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CustBranch { get; set; }

    [Column("cust_acc_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CustAccNo { get; set; }

    [Column("from_date", TypeName = "datetime")]
    public DateTime? FromDate { get; set; }

    [Column("to_date", TypeName = "datetime")]
    public DateTime? ToDate { get; set; }

    [Column("install_no", TypeName = "decimal(18, 0)")]
    public decimal? InstallNo { get; set; }

    [Column("amount", TypeName = "decimal(18, 4)")]
    public decimal? Amount { get; set; }

    [Column("pay_to")]
    [StringLength(50)]
    [Unicode(false)]
    public string? PayTo { get; set; }

    [Column("project_id", TypeName = "decimal(18, 0)")]
    public decimal? ProjectId { get; set; }

    [Column("cust_name")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CustName { get; set; }

    [Column("cust_address")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CustAddress { get; set; }

    [Column("cust_id_no")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CustIdNo { get; set; }

    [Column("area")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Area { get; set; }

    [Column("part")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Part { get; set; }

    [Column("strate")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Strate { get; set; }

    [Column("gada")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Gada { get; set; }

    [Column("bulding")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Bulding { get; set; }

    [Column("kasema")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Kasema { get; set; }

    [Column("flower")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Flower { get; set; }

    [Column("flat")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Flat { get; set; }

    [Column("cust_tel_1")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CustTel1 { get; set; }

    [Column("cust_tel_2")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CustTel2 { get; set; }

    [Column("box_mail")]
    [StringLength(50)]
    [Unicode(false)]
    public string? BoxMail { get; set; }

    [Column("box_area")]
    [StringLength(50)]
    [Unicode(false)]
    public string? BoxArea { get; set; }

    [Column("r_b")]
    [StringLength(50)]
    [Unicode(false)]
    public string? RB { get; set; }

    [Column("acc_id", TypeName = "decimal(18, 0)")]
    public decimal? AccId { get; set; }

    [Column("cost_id", TypeName = "decimal(18, 0)")]
    public decimal? CostId { get; set; }

    [Column("exp_id", TypeName = "decimal(18, 0)")]
    public decimal? ExpId { get; set; }

    [Column("analysis_id", TypeName = "decimal(18, 0)")]
    public decimal? AnalysisId { get; set; }

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

    [Column("bank_acc_id", TypeName = "decimal(18, 0)")]
    public decimal? BankAccId { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Posted { get; set; }

    [Column("total_amount", TypeName = "decimal(18, 3)")]
    public decimal? TotalAmount { get; set; }
}
