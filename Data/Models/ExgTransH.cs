using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("exg_trans_h")]
public partial class ExgTransH
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

    [Column("active")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Active { get; set; }

    [Column("branch_id", TypeName = "decimal(18, 0)")]
    public decimal? BranchId { get; set; }

    [Column("treasury_id", TypeName = "decimal(18, 0)")]
    public decimal? TreasuryId { get; set; }

    [Column("employ_id", TypeName = "decimal(18, 0)")]
    public decimal? EmployId { get; set; }

    [Column("country_id", TypeName = "decimal(18, 0)")]
    public decimal? CountryId { get; set; }

    [Column("currency_id", TypeName = "decimal(18, 0)")]
    public decimal? CurrencyId { get; set; }

    [Column("service_id", TypeName = "decimal(18, 0)")]
    public decimal? ServiceId { get; set; }

    [Column("agent_id", TypeName = "decimal(18, 0)")]
    public decimal? AgentId { get; set; }

    [Column("agent_branch_id", TypeName = "decimal(18, 0)")]
    public decimal? AgentBranchId { get; set; }

    [Column("cust_id", TypeName = "decimal(18, 0)")]
    public decimal? CustId { get; set; }

    [Column("recipient_id", TypeName = "decimal(18, 0)")]
    public decimal? RecipientId { get; set; }

    [Column("amount", TypeName = "decimal(18, 5)")]
    public decimal? Amount { get; set; }

    [Column("exchange_rate", TypeName = "decimal(18, 5)")]
    public decimal? ExchangeRate { get; set; }

    [Column("main_amount", TypeName = "decimal(18, 5)")]
    public decimal? MainAmount { get; set; }

    [Column("commission", TypeName = "decimal(18, 5)")]
    public decimal? Commission { get; set; }

    [Column("discount", TypeName = "decimal(18, 5)")]
    public decimal? Discount { get; set; }

    [Column("pay_type_1", TypeName = "decimal(18, 0)")]
    public decimal? PayType1 { get; set; }

    [Column("pay_amount_1", TypeName = "decimal(18, 0)")]
    public decimal? PayAmount1 { get; set; }

    [Column("pay_type_2", TypeName = "decimal(18, 0)")]
    public decimal? PayType2 { get; set; }

    [Column("pay_amount_2", TypeName = "decimal(18, 0)")]
    public decimal? PayAmount2 { get; set; }

    [Column("pay_type_3", TypeName = "decimal(18, 0)")]
    public decimal? PayType3 { get; set; }

    [Column("pay_amount_3", TypeName = "decimal(18, 0)")]
    public decimal? PayAmount3 { get; set; }

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
