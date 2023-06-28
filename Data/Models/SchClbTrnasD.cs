using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("sch_clb_trnas_d")]
public partial class SchClbTrnasD
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

    [Column("team_id", TypeName = "decimal(18, 0)")]
    public decimal? TeamId { get; set; }

    [Column("member_id", TypeName = "decimal(18, 0)")]
    public decimal? MemberId { get; set; }

    [Column("services_id", TypeName = "decimal(18, 0)")]
    public decimal? ServicesId { get; set; }

    [Column("trans_date", TypeName = "datetime")]
    public DateTime? TransDate { get; set; }

    [Column("amount_1", TypeName = "decimal(18, 3)")]
    public decimal? Amount1 { get; set; }

    [Column("amount_2", TypeName = "decimal(18, 3)")]
    public decimal? Amount2 { get; set; }

    [Column("amount_3", TypeName = "decimal(18, 3)")]
    public decimal? Amount3 { get; set; }

    [Column("amount_4", TypeName = "decimal(18, 3)")]
    public decimal? Amount4 { get; set; }

    [Column("amount_pay_1", TypeName = "decimal(18, 4)")]
    public decimal? AmountPay1 { get; set; }

    [Column("amount_pay_2", TypeName = "decimal(18, 4)")]
    public decimal? AmountPay2 { get; set; }

    [Column("amount_pay_3", TypeName = "decimal(18, 4)")]
    public decimal? AmountPay3 { get; set; }

    [Column("exp_amount", TypeName = "decimal(18, 3)")]
    public decimal? ExpAmount { get; set; }

    [Column("paied_amount", TypeName = "decimal(18, 3)")]
    public decimal? PaiedAmount { get; set; }

    [Column("amount", TypeName = "decimal(18, 3)")]
    public decimal? Amount { get; set; }

    [Column("row_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? RowType { get; set; }

    [Column("row_status")]
    [StringLength(1)]
    [Unicode(false)]
    public string? RowStatus { get; set; }

    [Column("from_date", TypeName = "datetime")]
    public DateTime? FromDate { get; set; }

    [Column("to_date", TypeName = "datetime")]
    public DateTime? ToDate { get; set; }

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
