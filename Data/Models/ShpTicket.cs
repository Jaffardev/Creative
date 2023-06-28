using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("shp_ticket")]
public partial class ShpTicket
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

    [Column("treasury_id", TypeName = "decimal(18, 0)")]
    public decimal? TreasuryId { get; set; }

    [Column("trans_date", TypeName = "datetime")]
    public DateTime? TransDate { get; set; }

    [Column("con_id", TypeName = "decimal(18, 0)")]
    public decimal? ConId { get; set; }

    [Column("cust_id", TypeName = "decimal(18, 0)")]
    public decimal? CustId { get; set; }

    [Column("cash_cheq")]
    [StringLength(1)]
    [Unicode(false)]
    public string? CashCheq { get; set; }

    [Column("being_for")]
    [StringLength(500)]
    [Unicode(false)]
    public string? BeingFor { get; set; }

    [Column("emp_id", TypeName = "decimal(18, 0)")]
    public decimal? EmpId { get; set; }

    [Column("amount", TypeName = "decimal(18, 3)")]
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

    [Column("ticket_amount", TypeName = "decimal(18, 3)")]
    public decimal? TicketAmount { get; set; }

    [Column("from_ticket", TypeName = "decimal(18, 0)")]
    public decimal? FromTicket { get; set; }

    [Column("to_ticket", TypeName = "decimal(18, 0)")]
    public decimal? ToTicket { get; set; }

    [Column("pay_cash", TypeName = "decimal(18, 3)")]
    public decimal? PayCash { get; set; }

    [Column("pay_key", TypeName = "decimal(18, 3)")]
    public decimal? PayKey { get; set; }

    [Column("pay_visa", TypeName = "decimal(18, 3)")]
    public decimal? PayVisa { get; set; }

    [Column("pay_master", TypeName = "decimal(18, 3)")]
    public decimal? PayMaster { get; set; }

    [Column("pay_atm", TypeName = "decimal(18, 3)")]
    public decimal? PayAtm { get; set; }

    [Column("pay_other", TypeName = "decimal(18, 3)")]
    public decimal? PayOther { get; set; }

    [Column("total_pay", TypeName = "decimal(18, 3)")]
    public decimal? TotalPay { get; set; }

    [Column("ticket_amount_1", TypeName = "decimal(18, 3)")]
    public decimal? TicketAmount1 { get; set; }

    [Column("from_ticket_1", TypeName = "decimal(18, 0)")]
    public decimal? FromTicket1 { get; set; }

    [Column("to_ticket_1", TypeName = "decimal(18, 0)")]
    public decimal? ToTicket1 { get; set; }

    [Column("pay_cash_1", TypeName = "decimal(18, 3)")]
    public decimal? PayCash1 { get; set; }

    [Column("pay_key_1", TypeName = "decimal(18, 3)")]
    public decimal? PayKey1 { get; set; }

    [Column("pay_visa_1", TypeName = "decimal(18, 3)")]
    public decimal? PayVisa1 { get; set; }

    [Column("pay_master_1", TypeName = "decimal(18, 3)")]
    public decimal? PayMaster1 { get; set; }

    [Column("pay_atm_1", TypeName = "decimal(18, 3)")]
    public decimal? PayAtm1 { get; set; }

    [Column("pay_other_1", TypeName = "decimal(18, 3)")]
    public decimal? PayOther1 { get; set; }

    [Column("total_pay_1", TypeName = "decimal(18, 3)")]
    public decimal? TotalPay1 { get; set; }

    [Column("ticket_amount_2", TypeName = "decimal(18, 3)")]
    public decimal? TicketAmount2 { get; set; }

    [Column("from_ticket_2", TypeName = "decimal(18, 0)")]
    public decimal? FromTicket2 { get; set; }

    [Column("to_ticket_2", TypeName = "decimal(18, 0)")]
    public decimal? ToTicket2 { get; set; }

    [Column("pay_cash_2", TypeName = "decimal(18, 3)")]
    public decimal? PayCash2 { get; set; }

    [Column("pay_key_2", TypeName = "decimal(18, 3)")]
    public decimal? PayKey2 { get; set; }

    [Column("pay_visa_2", TypeName = "decimal(18, 3)")]
    public decimal? PayVisa2 { get; set; }

    [Column("pay_master_2", TypeName = "decimal(18, 3)")]
    public decimal? PayMaster2 { get; set; }

    [Column("pay_atm_2", TypeName = "decimal(18, 3)")]
    public decimal? PayAtm2 { get; set; }

    [Column("pay_other_2", TypeName = "decimal(18, 3)")]
    public decimal? PayOther2 { get; set; }

    [Column("total_pay_2", TypeName = "decimal(18, 3)")]
    public decimal? TotalPay2 { get; set; }

    [Column("ticket_amount_3", TypeName = "decimal(18, 3)")]
    public decimal? TicketAmount3 { get; set; }

    [Column("from_ticket_3", TypeName = "decimal(18, 0)")]
    public decimal? FromTicket3 { get; set; }

    [Column("to_ticket_3", TypeName = "decimal(18, 0)")]
    public decimal? ToTicket3 { get; set; }

    [Column("pay_cash_3", TypeName = "decimal(18, 3)")]
    public decimal? PayCash3 { get; set; }

    [Column("pay_key_3", TypeName = "decimal(18, 3)")]
    public decimal? PayKey3 { get; set; }

    [Column("pay_visa_3", TypeName = "decimal(18, 3)")]
    public decimal? PayVisa3 { get; set; }

    [Column("pay_master_3", TypeName = "decimal(18, 3)")]
    public decimal? PayMaster3 { get; set; }

    [Column("pay_atm_3", TypeName = "decimal(18, 3)")]
    public decimal? PayAtm3 { get; set; }

    [Column("pay_other_3", TypeName = "decimal(18, 3)")]
    public decimal? PayOther3 { get; set; }

    [Column("total_pay_3", TypeName = "decimal(18, 3)")]
    public decimal? TotalPay3 { get; set; }

    [Column("ticket_amount_4", TypeName = "decimal(18, 3)")]
    public decimal? TicketAmount4 { get; set; }

    [Column("from_ticket_4", TypeName = "decimal(18, 0)")]
    public decimal? FromTicket4 { get; set; }

    [Column("to_ticket_4", TypeName = "decimal(18, 0)")]
    public decimal? ToTicket4 { get; set; }

    [Column("pay_cash_4", TypeName = "decimal(18, 3)")]
    public decimal? PayCash4 { get; set; }

    [Column("pay_key_4", TypeName = "decimal(18, 3)")]
    public decimal? PayKey4 { get; set; }

    [Column("pay_visa_4", TypeName = "decimal(18, 3)")]
    public decimal? PayVisa4 { get; set; }

    [Column("pay_master_4", TypeName = "decimal(18, 3)")]
    public decimal? PayMaster4 { get; set; }

    [Column("pay_atm_4", TypeName = "decimal(18, 3)")]
    public decimal? PayAtm4 { get; set; }

    [Column("pay_other_4", TypeName = "decimal(18, 3)")]
    public decimal? PayOther4 { get; set; }

    [Column("total_pay_4", TypeName = "decimal(18, 3)")]
    public decimal? TotalPay4 { get; set; }

    [Column("ticket_amount_5", TypeName = "decimal(18, 3)")]
    public decimal? TicketAmount5 { get; set; }

    [Column("from_ticket_5", TypeName = "decimal(18, 0)")]
    public decimal? FromTicket5 { get; set; }

    [Column("to_ticket_5", TypeName = "decimal(18, 0)")]
    public decimal? ToTicket5 { get; set; }

    [Column("pay_cash_5", TypeName = "decimal(18, 3)")]
    public decimal? PayCash5 { get; set; }

    [Column("pay_key_5", TypeName = "decimal(18, 3)")]
    public decimal? PayKey5 { get; set; }

    [Column("pay_visa_5", TypeName = "decimal(18, 3)")]
    public decimal? PayVisa5 { get; set; }

    [Column("pay_master_5", TypeName = "decimal(18, 3)")]
    public decimal? PayMaster5 { get; set; }

    [Column("pay_atm_5", TypeName = "decimal(18, 3)")]
    public decimal? PayAtm5 { get; set; }

    [Column("pay_other_5", TypeName = "decimal(18, 3)")]
    public decimal? PayOther5 { get; set; }

    [Column("total_pay_5", TypeName = "decimal(18, 3)")]
    public decimal? TotalPay5 { get; set; }
}
